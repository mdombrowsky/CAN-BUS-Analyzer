
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace CAN_BUS_Analyzer_App
{
    public partial class Form1 : Form
    {
        private SerialPort? serialPort;
        private TransmitHistoryForm? transmitHistoryForm;

        public Form1()
        {
            InitializeComponent();
            InitializeCanAnalyzer();
            InitializeHistoryMenu();
        }

        private void InitializeCanAnalyzer()
        {
            Text = "CAN Bus Analyzer";
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(900, 550);

            RefreshComPorts();
        }

        private void InitializeHistoryMenu()
        {
            foreach (ToolStripItem item in menuStripMain.Items)
            {
                if (item is ToolStripMenuItem menu && menu.Text == "View")
                {
                    menu.DropDownItems.Add(new ToolStripSeparator());
                    var historyItem = new ToolStripMenuItem("Transmit History");
                    historyItem.Click += (sender, e) => ShowTransmitHistory();
                    menu.DropDownItems.Add(historyItem);
                    break;
                }
            }
        }

        private void ShowTransmitHistory()
        {
            if (transmitHistoryForm == null || transmitHistoryForm.IsDisposed)
            {
                transmitHistoryForm = new TransmitHistoryForm();
            }

            if (!transmitHistoryForm.Visible)
                transmitHistoryForm.Show(this);
            else
                transmitHistoryForm.Activate();
        }

        private void LogTransmittedFrame(uint canId, int length, string data)
        {
            if (transmitHistoryForm == null || transmitHistoryForm.IsDisposed)
            {
                transmitHistoryForm = new TransmitHistoryForm();
            }

            string timestamp = DateTime.Now.ToString("HH:mm:ss.fff");
            transmitHistoryForm.AddFrame(timestamp, $"0x{canId:X3}", length, data);
        }

        private void RefreshComPorts()
        {
            string? previousPort = comboPort.SelectedItem?.ToString();

            comboPort.Items.Clear();
            comboPort.Items.AddRange(SerialPort.GetPortNames());

            if (previousPort != null && comboPort.Items.Contains(previousPort))
            {
                comboPort.SelectedItem = previousPort;
            }
            else if (comboPort.Items.Count > 0)
            {
                comboPort.SelectedIndex = 0;
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshComPorts();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                Disconnect();
                return;
            }

            if (comboPort.SelectedItem == null)
            {
                MessageBox.Show("Please select a COM port.", "CAN Analyzer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                serialPort = new SerialPort
                {
                    PortName = comboPort.SelectedItem.ToString()!,
                    BaudRate = 115200,
                    DataBits = 8,
                    Parity = Parity.None,
                    StopBits = StopBits.One,
                    Encoding = Encoding.ASCII,
                    NewLine = "\n"
                };

                serialPort.DataReceived += SerialPort_DataReceived;
                serialPort.Open();
                buttonConnect.Text = "Disconnect";
                labelStatus.Text = "● Connected";
                labelStatus.ForeColor = Color.Green;
                comboPort.Enabled = false;
            }
            catch (Exception ex)
            {
                if (serialPort != null)
                {
                    try
                    {
                        serialPort.Dispose();
                    }
                    catch
                    {
                        // Ignore cleanup errors.
                    }

                    serialPort = null;
                }
                MessageBox.Show( $"Unable to open serial port.\n\n{ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Disconnect()
        {
            try
            {
                if (serialPort != null)
                {
                    serialPort.DataReceived -= SerialPort_DataReceived;

                    if (serialPort.IsOpen)
                        serialPort.Close();

                    serialPort.Dispose();
                    serialPort = null;
                }
            }
            catch
            {
                // Ignore disconnect errors.
            }

            buttonConnect.Text = "Connect";
            labelStatus.Text = "● Disconnected";
            labelStatus.ForeColor = Color.DarkRed;
            comboPort.Enabled = true;
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort? port = serialPort;

                if (port == null || !port.IsOpen)
                    return;

                string line = port.ReadLine().Trim();

                if (string.IsNullOrWhiteSpace(line))
                    return;

                if (IsDisposed || !IsHandleCreated)
                    return;

                BeginInvoke((MethodInvoker)(() =>
                {
                    ProcessCanMessage(line);
                }));
            }
            catch
            {
                // The port may have been disconnected.
            }
        }

        private void ProcessCanMessage(string line)
        {
            // Expected format:
            // RX ID=0x123 LEN=8 DATA=11 22 33 44 55 66 77 88

            if (!line.StartsWith("RX ID=", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            try
            {
                int idStart = line.IndexOf("0x", StringComparison.OrdinalIgnoreCase);

                if (idStart < 0)
                    return;

                int idEnd = line.IndexOf(' ', idStart);

                if (idEnd < 0)
                    return;

                string idText = line.Substring(idStart + 2, idEnd - idStart - 2);
                uint id = Convert.ToUInt32(idText, 16);
                int lenStart = line.IndexOf("LEN=", StringComparison.OrdinalIgnoreCase);

                if (lenStart < 0)
                    return;

                lenStart += 4;
                int lenEnd = line.IndexOf(' ', lenStart);

                if (lenEnd < 0)
                    lenEnd = line.Length;

                string lenText = line.Substring(lenStart, lenEnd - lenStart);

                if (!int.TryParse(lenText, out int length) || length < 0 || length > 8)
                {
                    return;
                }

                int dataStart = line.IndexOf("DATA=", StringComparison.OrdinalIgnoreCase);

                if (dataStart < 0)
                    return;

                dataStart += 5;
                string dataText = line.Substring(dataStart).Trim();
                AddCanFrame(id, length, dataText);
            }
            catch
            {
                // Ignore malformed CAN messages.
            }
        }

        private void AddCanFrame(uint id, int length, string data)
        {
            string timestamp = DateTime.Now.ToString("HH:mm:ss.fff");
            int rowIndex = dataGridFrames.Rows.Add();
            DataGridViewRow row = dataGridFrames.Rows[rowIndex];

            row.Cells["ColumnTime"].Value = timestamp;
            row.Cells["ColumnId"].Value = $"0x{id:X3}";
            row.Cells["ColumnDlc"].Value = length;
            row.Cells["ColumnData"].Value = data;

            if (dataGridFrames.Rows.Count > 5000)
                dataGridFrames.Rows.RemoveAt(0);

            labelFrameCount.Text = $"Frames: {dataGridFrames.Rows.Count:N0}";

            if (dataGridFrames.Rows.Count > 0)
            {
                dataGridFrames.FirstDisplayedScrollingRowIndex = dataGridFrames.Rows.Count - 1;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataGridFrames.Rows.Clear();
            labelFrameCount.Text = "Frames: 0";
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (serialPort == null || !serialPort.IsOpen)
            {
                MessageBox.Show("Connect to the CAN interface first.", "CAN Analyzer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string id = textBoxTxId.Text.Trim();
                string dlc = textBoxTxDlc.Text.Trim();
                string data = textBoxTxData.Text.Trim();

                if (string.IsNullOrWhiteSpace(id))
                    throw new Exception("CAN ID is required.");

                if (string.IsNullOrWhiteSpace(dlc))
                    throw new Exception("DLC is required.");

                if (!int.TryParse(dlc, out int length) || length < 0 || length > 8)
                {
                    throw new Exception("DLC must be between 0 and 8.");
                }

                id = id.Replace("0x", "", StringComparison.OrdinalIgnoreCase);

                if (!uint.TryParse(id, System.Globalization.NumberStyles.HexNumber, null, out uint canId))
                {
                    throw new Exception("Invalid CAN ID.");
                }

                if (canId > 0x7FF)
                {
                    throw new Exception("CAN ID must be between 000 and 7FF.");
                }

                string[] bytes = data.Split(new[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);

                if (bytes.Length != length)
                {
                    throw new Exception($"DLC is {length}, but {bytes.Length} data bytes were entered.");
                }

                List<string> hexBytes = new();

                foreach (string b in bytes)
                {
                    if (!byte.TryParse(b, System.Globalization.NumberStyles.HexNumber, null, out byte value))
                    {
                        throw new Exception($"Invalid data byte: {b}");
                    }

                    hexBytes.Add(value.ToString("X2"));
                }

                string command = $"TX,{canId:X},{length},{string.Join(",", hexBytes)}";
                serialPort.WriteLine(command);
                string txData = string.Join(" ", hexBytes);
                LogTransmittedFrame(canId, length, txData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Send CAN Frame", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (transmitHistoryForm != null && !transmitHistoryForm.IsDisposed)
            {
                transmitHistoryForm.Close();
            }

            Disconnect();
            base.OnFormClosing(e);
        }
    }
}
