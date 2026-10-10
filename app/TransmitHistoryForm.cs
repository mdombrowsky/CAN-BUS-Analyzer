using System;
using System.Drawing;
using System.Windows.Forms;

namespace CAN_BUS_Analyzer_App
{
    public partial class TransmitHistoryForm : Form
    {
        public DataGridView HistoryGrid { get; }

        public TransmitHistoryForm()
        {
            Text = "CAN Transmit History";
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(800, 400);
            MinimumSize = new Size(600, 300);

            HistoryGrid = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White
            };

            HistoryGrid.Columns.Add("Time", "Time");
            HistoryGrid.Columns.Add("CANID", "CAN ID");
            HistoryGrid.Columns.Add("DLC", "DLC");
            HistoryGrid.Columns.Add("Data", "Data");

            Controls.Add(HistoryGrid);
        }

        public void AddFrame(string time, string id, int dlc, string data)
        {
            HistoryGrid.Rows.Add(time, id, dlc, data);

            if (HistoryGrid.Rows.Count > 5000)
                HistoryGrid.Rows.RemoveAt(0);

            if (HistoryGrid.Rows.Count > 0)
                HistoryGrid.FirstDisplayedScrollingRowIndex = HistoryGrid.Rows.Count - 1;
        }
    }
}