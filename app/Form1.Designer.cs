namespace CAN_BUS_Analyzer_App
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private MenuStrip menuStripMain;

        private Panel panelTop;
        private Label labelPort;
        private ComboBox comboPort;
        private Button buttonRefresh;
        private Button buttonConnect;
        private Label labelStatus;

        private Panel panelBottom;
        private Label labelTx;
        private Label labelTxId;
        private TextBox textBoxTxId;
        private Label labelTxDlc;
        private TextBox textBoxTxDlc;
        private Label labelTxData;
        private TextBox textBoxTxData;
        private Button buttonSend;

        private Panel panelFrameStatus;
        private Label labelFrameCount;
        private Button buttonClear;

        private DataGridView dataGridFrames;
        private DataGridViewTextBoxColumn ColumnTime;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnDlc;
        private DataGridViewTextBoxColumn ColumnData;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStripMain = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            recentFilesToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            cANIDFormatToolStripMenuItem = new ToolStripMenuItem();
            hexadecimalToolStripMenuItem = new ToolStripMenuItem();
            decimalToolStripMenuItem = new ToolStripMenuItem();
            dataByteFormatToolStripMenuItem = new ToolStripMenuItem();
            hexadecimalToolStripMenuItem1 = new ToolStripMenuItem();
            decimalToolStripMenuItem1 = new ToolStripMenuItem();
            aSCIIToolStripMenuItem = new ToolStripMenuItem();
            dataLengthDisplayToolStripMenuItem = new ToolStripMenuItem();
            showDataLengthToolStripMenuItem = new ToolStripMenuItem();
            showDataLengthCodeDLCToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            languageToolStripMenuItem = new ToolStripMenuItem();
            automaticToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            englishToolStripMenuItem = new ToolStripMenuItem();
            styleToolStripMenuItem = new ToolStripMenuItem();
            darkToolStripMenuItem = new ToolStripMenuItem();
            windowsToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            cANToolStripMenuItem = new ToolStripMenuItem();
            connectToolStripMenuItem = new ToolStripMenuItem();
            disconnectToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            clearAllToolStripMenuItem = new ToolStripMenuItem();
            transmitToolStripMenuItem = new ToolStripMenuItem();
            newMessageToolStripMenuItem = new ToolStripMenuItem();
            editMessageToolStripMenuItem = new ToolStripMenuItem();
            sendToolStripMenuItem = new ToolStripMenuItem();
            pauseResumeToolStripMenuItem = new ToolStripMenuItem();
            viewMenu = new ToolStripMenuItem();
            receiveTransmitToolStripMenuItem = new ToolStripMenuItem();
            traceToolStripMenuItem1 = new ToolStripMenuItem();
            uSBToolStripMenuItem = new ToolStripMenuItem();
            traceToolStripMenuItem = new ToolStripMenuItem();
            startToolStripMenuItem = new ToolStripMenuItem();
            pauseToolStripMenuItem = new ToolStripMenuItem();
            stopToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            bufferSizeToolStripMenuItem = new ToolStripMenuItem();
            linearBufferToolStripMenuItem = new ToolStripMenuItem();
            ringBufferToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            logDataDToolStripMenuItem = new ToolStripMenuItem();
            logPTRToolStripMenuItem = new ToolStripMenuItem();
            logStatusChangesToolStripMenuItem = new ToolStripMenuItem();
            logErrorFramesToolStripMenuItem = new ToolStripMenuItem();
            logErrorCounterChangesToolStripMenuItem = new ToolStripMenuItem();
            logEventsToolStripMenuItem = new ToolStripMenuItem();
            windowsToolStripMenuItem = new ToolStripMenuItem();
            stayOnTopToolStripMenuItem = new ToolStripMenuItem();
            makeFloatingToolStripMenuItem = new ToolStripMenuItem();
            helpMenu = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            fileFormatSpecificationsForCANTraceFilesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            deviceDriverVersionToolStripMenuItem = new ToolStripMenuItem();
            licenceToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            panelTop = new Panel();
            labelPort = new Label();
            comboPort = new ComboBox();
            buttonRefresh = new Button();
            buttonConnect = new Button();
            labelStatus = new Label();
            dataGridFrames = new DataGridView();
            ColumnTime = new DataGridViewTextBoxColumn();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnDlc = new DataGridViewTextBoxColumn();
            ColumnData = new DataGridViewTextBoxColumn();
            panelFrameStatus = new Panel();
            labelFrameCount = new Label();
            buttonClear = new Button();
            panelBottom = new Panel();
            labelTx = new Label();
            labelTxId = new Label();
            textBoxTxId = new TextBox();
            labelTxDlc = new Label();
            textBoxTxDlc = new TextBox();
            labelTxData = new Label();
            textBoxTxData = new TextBox();
            buttonSend = new Button();
            menuStripMain.SuspendLayout();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridFrames).BeginInit();
            panelFrameStatus.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.Items.AddRange(new ToolStripItem[] { fileMenu, cANToolStripMenuItem, editToolStripMenuItem, transmitToolStripMenuItem, viewMenu, traceToolStripMenuItem, windowsToolStripMenuItem, helpMenu });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(900, 24);
            menuStripMain.TabIndex = 0;
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, recentFilesToolStripMenuItem, saveToolStripMenuItem1, toolStripSeparator3, settingsToolStripMenuItem, toolStripSeparator4, exitToolStripMenuItem });
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(37, 20);
            fileMenu.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(136, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // recentFilesToolStripMenuItem
            // 
            recentFilesToolStripMenuItem.Name = "recentFilesToolStripMenuItem";
            recentFilesToolStripMenuItem.Size = new Size(136, 22);
            recentFilesToolStripMenuItem.Text = "Recent Files";
            // 
            // saveToolStripMenuItem1
            // 
            saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            saveToolStripMenuItem1.Size = new Size(136, 22);
            saveToolStripMenuItem1.Text = "Save";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(133, 6);
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cANIDFormatToolStripMenuItem, dataByteFormatToolStripMenuItem, dataLengthDisplayToolStripMenuItem, toolStripSeparator5, languageToolStripMenuItem, styleToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(136, 22);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // cANIDFormatToolStripMenuItem
            // 
            cANIDFormatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hexadecimalToolStripMenuItem, decimalToolStripMenuItem });
            cANIDFormatToolStripMenuItem.Name = "cANIDFormatToolStripMenuItem";
            cANIDFormatToolStripMenuItem.Size = new Size(179, 22);
            cANIDFormatToolStripMenuItem.Text = "CAN ID Format";
            // 
            // hexadecimalToolStripMenuItem
            // 
            hexadecimalToolStripMenuItem.Name = "hexadecimalToolStripMenuItem";
            hexadecimalToolStripMenuItem.Size = new Size(143, 22);
            hexadecimalToolStripMenuItem.Text = "Hexadecimal";
            // 
            // decimalToolStripMenuItem
            // 
            decimalToolStripMenuItem.Name = "decimalToolStripMenuItem";
            decimalToolStripMenuItem.Size = new Size(143, 22);
            decimalToolStripMenuItem.Text = "Decimal";
            // 
            // dataByteFormatToolStripMenuItem
            // 
            dataByteFormatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hexadecimalToolStripMenuItem1, decimalToolStripMenuItem1, aSCIIToolStripMenuItem });
            dataByteFormatToolStripMenuItem.Name = "dataByteFormatToolStripMenuItem";
            dataByteFormatToolStripMenuItem.Size = new Size(179, 22);
            dataByteFormatToolStripMenuItem.Text = "Data Byte Format";
            // 
            // hexadecimalToolStripMenuItem1
            // 
            hexadecimalToolStripMenuItem1.Name = "hexadecimalToolStripMenuItem1";
            hexadecimalToolStripMenuItem1.Size = new Size(143, 22);
            hexadecimalToolStripMenuItem1.Text = "Hexadecimal";
            // 
            // decimalToolStripMenuItem1
            // 
            decimalToolStripMenuItem1.Name = "decimalToolStripMenuItem1";
            decimalToolStripMenuItem1.Size = new Size(143, 22);
            decimalToolStripMenuItem1.Text = "Decimal";
            // 
            // aSCIIToolStripMenuItem
            // 
            aSCIIToolStripMenuItem.Name = "aSCIIToolStripMenuItem";
            aSCIIToolStripMenuItem.Size = new Size(143, 22);
            aSCIIToolStripMenuItem.Text = "ASCII";
            // 
            // dataLengthDisplayToolStripMenuItem
            // 
            dataLengthDisplayToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showDataLengthToolStripMenuItem, showDataLengthCodeDLCToolStripMenuItem });
            dataLengthDisplayToolStripMenuItem.Name = "dataLengthDisplayToolStripMenuItem";
            dataLengthDisplayToolStripMenuItem.Size = new Size(179, 22);
            dataLengthDisplayToolStripMenuItem.Text = "Data Length Display";
            // 
            // showDataLengthToolStripMenuItem
            // 
            showDataLengthToolStripMenuItem.Name = "showDataLengthToolStripMenuItem";
            showDataLengthToolStripMenuItem.Size = new Size(234, 22);
            showDataLengthToolStripMenuItem.Text = "Show Data Length";
            // 
            // showDataLengthCodeDLCToolStripMenuItem
            // 
            showDataLengthCodeDLCToolStripMenuItem.Name = "showDataLengthCodeDLCToolStripMenuItem";
            showDataLengthCodeDLCToolStripMenuItem.Size = new Size(234, 22);
            showDataLengthCodeDLCToolStripMenuItem.Text = "Show Data Length Code (DLC)";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(176, 6);
            // 
            // languageToolStripMenuItem
            // 
            languageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { automaticToolStripMenuItem, toolStripSeparator6, englishToolStripMenuItem });
            languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            languageToolStripMenuItem.Size = new Size(179, 22);
            languageToolStripMenuItem.Text = "Language";
            // 
            // automaticToolStripMenuItem
            // 
            automaticToolStripMenuItem.Name = "automaticToolStripMenuItem";
            automaticToolStripMenuItem.Size = new Size(130, 22);
            automaticToolStripMenuItem.Text = "Automatic";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(127, 6);
            // 
            // englishToolStripMenuItem
            // 
            englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            englishToolStripMenuItem.Size = new Size(130, 22);
            englishToolStripMenuItem.Text = "English";
            // 
            // styleToolStripMenuItem
            // 
            styleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { darkToolStripMenuItem, windowsToolStripMenuItem1 });
            styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            styleToolStripMenuItem.Size = new Size(179, 22);
            styleToolStripMenuItem.Text = "Style";
            // 
            // darkToolStripMenuItem
            // 
            darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            darkToolStripMenuItem.Size = new Size(123, 22);
            darkToolStripMenuItem.Text = "Dark";
            // 
            // windowsToolStripMenuItem1
            // 
            windowsToolStripMenuItem1.Name = "windowsToolStripMenuItem1";
            windowsToolStripMenuItem1.Size = new Size(123, 22);
            windowsToolStripMenuItem1.Text = "Windows";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(133, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(136, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // cANToolStripMenuItem
            // 
            cANToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { connectToolStripMenuItem, disconnectToolStripMenuItem, resetToolStripMenuItem });
            cANToolStripMenuItem.Name = "cANToolStripMenuItem";
            cANToolStripMenuItem.Size = new Size(44, 20);
            cANToolStripMenuItem.Text = "CAN";
            // 
            // connectToolStripMenuItem
            // 
            connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            connectToolStripMenuItem.Size = new Size(133, 22);
            connectToolStripMenuItem.Text = "Connect";
            // 
            // disconnectToolStripMenuItem
            // 
            disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            disconnectToolStripMenuItem.Size = new Size(133, 22);
            disconnectToolStripMenuItem.Text = "Disconnect";
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(133, 22);
            resetToolStripMenuItem.Text = "Reset";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, deleteToolStripMenuItem, selectAllToolStripMenuItem, clearAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(122, 22);
            cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(122, 22);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(122, 22);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(122, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(122, 22);
            selectAllToolStripMenuItem.Text = "Select All";
            // 
            // clearAllToolStripMenuItem
            // 
            clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            clearAllToolStripMenuItem.Size = new Size(122, 22);
            clearAllToolStripMenuItem.Text = "Clear All";
            // 
            // transmitToolStripMenuItem
            // 
            transmitToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newMessageToolStripMenuItem, editMessageToolStripMenuItem, sendToolStripMenuItem, pauseResumeToolStripMenuItem });
            transmitToolStripMenuItem.Name = "transmitToolStripMenuItem";
            transmitToolStripMenuItem.Size = new Size(64, 20);
            transmitToolStripMenuItem.Text = "Transmit";
            // 
            // newMessageToolStripMenuItem
            // 
            newMessageToolStripMenuItem.Name = "newMessageToolStripMenuItem";
            newMessageToolStripMenuItem.Size = new Size(158, 22);
            newMessageToolStripMenuItem.Text = "New Message";
            // 
            // editMessageToolStripMenuItem
            // 
            editMessageToolStripMenuItem.Name = "editMessageToolStripMenuItem";
            editMessageToolStripMenuItem.Size = new Size(158, 22);
            editMessageToolStripMenuItem.Text = "Edit Message";
            // 
            // sendToolStripMenuItem
            // 
            sendToolStripMenuItem.Name = "sendToolStripMenuItem";
            sendToolStripMenuItem.Size = new Size(158, 22);
            sendToolStripMenuItem.Text = "Send";
            // 
            // pauseResumeToolStripMenuItem
            // 
            pauseResumeToolStripMenuItem.Name = "pauseResumeToolStripMenuItem";
            pauseResumeToolStripMenuItem.Size = new Size(158, 22);
            pauseResumeToolStripMenuItem.Text = "Pause / Resume";
            // 
            // viewMenu
            // 
            viewMenu.DropDownItems.AddRange(new ToolStripItem[] { receiveTransmitToolStripMenuItem, traceToolStripMenuItem1, uSBToolStripMenuItem });
            viewMenu.Name = "viewMenu";
            viewMenu.Size = new Size(44, 20);
            viewMenu.Text = "View";
            // 
            // receiveTransmitToolStripMenuItem
            // 
            receiveTransmitToolStripMenuItem.Name = "receiveTransmitToolStripMenuItem";
            receiveTransmitToolStripMenuItem.Size = new Size(170, 22);
            receiveTransmitToolStripMenuItem.Text = "Receive / Transmit";
            // 
            // traceToolStripMenuItem1
            // 
            traceToolStripMenuItem1.Name = "traceToolStripMenuItem1";
            traceToolStripMenuItem1.Size = new Size(170, 22);
            traceToolStripMenuItem1.Text = "Trace";
            // 
            // uSBToolStripMenuItem
            // 
            uSBToolStripMenuItem.Name = "uSBToolStripMenuItem";
            uSBToolStripMenuItem.Size = new Size(170, 22);
            uSBToolStripMenuItem.Text = "USB";
            // 
            // traceToolStripMenuItem
            // 
            traceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { startToolStripMenuItem, pauseToolStripMenuItem, stopToolStripMenuItem, saveToolStripMenuItem, toolStripSeparator1, bufferSizeToolStripMenuItem, linearBufferToolStripMenuItem, ringBufferToolStripMenuItem, toolStripSeparator2, logDataDToolStripMenuItem, logPTRToolStripMenuItem, logStatusChangesToolStripMenuItem, logErrorFramesToolStripMenuItem, logErrorCounterChangesToolStripMenuItem, logEventsToolStripMenuItem });
            traceToolStripMenuItem.Name = "traceToolStripMenuItem";
            traceToolStripMenuItem.Size = new Size(46, 20);
            traceToolStripMenuItem.Text = "Trace";
            // 
            // startToolStripMenuItem
            // 
            startToolStripMenuItem.Name = "startToolStripMenuItem";
            startToolStripMenuItem.Size = new Size(217, 22);
            startToolStripMenuItem.Text = "Start";
            // 
            // pauseToolStripMenuItem
            // 
            pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            pauseToolStripMenuItem.Size = new Size(217, 22);
            pauseToolStripMenuItem.Text = "Pause";
            // 
            // stopToolStripMenuItem
            // 
            stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            stopToolStripMenuItem.Size = new Size(217, 22);
            stopToolStripMenuItem.Text = "Stop";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(217, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(214, 6);
            // 
            // bufferSizeToolStripMenuItem
            // 
            bufferSizeToolStripMenuItem.Name = "bufferSizeToolStripMenuItem";
            bufferSizeToolStripMenuItem.Size = new Size(217, 22);
            bufferSizeToolStripMenuItem.Text = "Buffer Size";
            // 
            // linearBufferToolStripMenuItem
            // 
            linearBufferToolStripMenuItem.Name = "linearBufferToolStripMenuItem";
            linearBufferToolStripMenuItem.Size = new Size(217, 22);
            linearBufferToolStripMenuItem.Text = "Linear Buffer";
            // 
            // ringBufferToolStripMenuItem
            // 
            ringBufferToolStripMenuItem.Name = "ringBufferToolStripMenuItem";
            ringBufferToolStripMenuItem.Size = new Size(217, 22);
            ringBufferToolStripMenuItem.Text = "Ring Buffer";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(214, 6);
            // 
            // logDataDToolStripMenuItem
            // 
            logDataDToolStripMenuItem.Checked = true;
            logDataDToolStripMenuItem.CheckState = CheckState.Checked;
            logDataDToolStripMenuItem.Name = "logDataDToolStripMenuItem";
            logDataDToolStripMenuItem.Size = new Size(217, 22);
            logDataDToolStripMenuItem.Text = "Log Data Frames";
            // 
            // logPTRToolStripMenuItem
            // 
            logPTRToolStripMenuItem.Checked = true;
            logPTRToolStripMenuItem.CheckState = CheckState.Checked;
            logPTRToolStripMenuItem.Name = "logPTRToolStripMenuItem";
            logPTRToolStripMenuItem.Size = new Size(217, 22);
            logPTRToolStripMenuItem.Text = "Log PTR";
            // 
            // logStatusChangesToolStripMenuItem
            // 
            logStatusChangesToolStripMenuItem.Checked = true;
            logStatusChangesToolStripMenuItem.CheckState = CheckState.Checked;
            logStatusChangesToolStripMenuItem.Name = "logStatusChangesToolStripMenuItem";
            logStatusChangesToolStripMenuItem.Size = new Size(217, 22);
            logStatusChangesToolStripMenuItem.Text = "Log Status Changes";
            // 
            // logErrorFramesToolStripMenuItem
            // 
            logErrorFramesToolStripMenuItem.Checked = true;
            logErrorFramesToolStripMenuItem.CheckState = CheckState.Checked;
            logErrorFramesToolStripMenuItem.Name = "logErrorFramesToolStripMenuItem";
            logErrorFramesToolStripMenuItem.Size = new Size(217, 22);
            logErrorFramesToolStripMenuItem.Text = "Log Error Frames";
            // 
            // logErrorCounterChangesToolStripMenuItem
            // 
            logErrorCounterChangesToolStripMenuItem.Checked = true;
            logErrorCounterChangesToolStripMenuItem.CheckState = CheckState.Checked;
            logErrorCounterChangesToolStripMenuItem.Name = "logErrorCounterChangesToolStripMenuItem";
            logErrorCounterChangesToolStripMenuItem.Size = new Size(217, 22);
            logErrorCounterChangesToolStripMenuItem.Text = "Log Error Counter Changes";
            // 
            // logEventsToolStripMenuItem
            // 
            logEventsToolStripMenuItem.Checked = true;
            logEventsToolStripMenuItem.CheckState = CheckState.Checked;
            logEventsToolStripMenuItem.Name = "logEventsToolStripMenuItem";
            logEventsToolStripMenuItem.Size = new Size(217, 22);
            logEventsToolStripMenuItem.Text = "Log Events";
            // 
            // windowsToolStripMenuItem
            // 
            windowsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stayOnTopToolStripMenuItem, makeFloatingToolStripMenuItem });
            windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            windowsToolStripMenuItem.Size = new Size(63, 20);
            windowsToolStripMenuItem.Text = "Window";
            // 
            // stayOnTopToolStripMenuItem
            // 
            stayOnTopToolStripMenuItem.Name = "stayOnTopToolStripMenuItem";
            stayOnTopToolStripMenuItem.Size = new Size(149, 22);
            stayOnTopToolStripMenuItem.Text = "Stay on Top";
            // 
            // makeFloatingToolStripMenuItem
            // 
            makeFloatingToolStripMenuItem.Name = "makeFloatingToolStripMenuItem";
            makeFloatingToolStripMenuItem.Size = new Size(149, 22);
            makeFloatingToolStripMenuItem.Text = "Make Floating";
            // 
            // helpMenu
            // 
            helpMenu.DropDownItems.AddRange(new ToolStripItem[] { helpToolStripMenuItem, fileFormatSpecificationsForCANTraceFilesToolStripMenuItem, toolStripSeparator7, deviceDriverVersionToolStripMenuItem, licenceToolStripMenuItem, aboutToolStripMenuItem });
            helpMenu.Name = "helpMenu";
            helpMenu.Size = new Size(44, 20);
            helpMenu.Text = "Help";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(311, 22);
            helpToolStripMenuItem.Text = "Help";
            // 
            // fileFormatSpecificationsForCANTraceFilesToolStripMenuItem
            // 
            fileFormatSpecificationsForCANTraceFilesToolStripMenuItem.Name = "fileFormatSpecificationsForCANTraceFilesToolStripMenuItem";
            fileFormatSpecificationsForCANTraceFilesToolStripMenuItem.Size = new Size(311, 22);
            fileFormatSpecificationsForCANTraceFilesToolStripMenuItem.Text = "File Format Specifications for CAN Trace Files";
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(308, 6);
            // 
            // deviceDriverVersionToolStripMenuItem
            // 
            deviceDriverVersionToolStripMenuItem.Name = "deviceDriverVersionToolStripMenuItem";
            deviceDriverVersionToolStripMenuItem.Size = new Size(311, 22);
            deviceDriverVersionToolStripMenuItem.Text = "Device Driver Version";
            // 
            // licenceToolStripMenuItem
            // 
            licenceToolStripMenuItem.Name = "licenceToolStripMenuItem";
            licenceToolStripMenuItem.Size = new Size(311, 22);
            licenceToolStripMenuItem.Text = "Licence";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(311, 22);
            aboutToolStripMenuItem.Text = "About";
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(240, 240, 240);
            panelTop.Controls.Add(labelPort);
            panelTop.Controls.Add(comboPort);
            panelTop.Controls.Add(buttonRefresh);
            panelTop.Controls.Add(buttonConnect);
            panelTop.Controls.Add(labelStatus);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 24);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(900, 55);
            panelTop.TabIndex = 1;
            // 
            // labelPort
            // 
            labelPort.AutoSize = true;
            labelPort.Location = new Point(12, 17);
            labelPort.Name = "labelPort";
            labelPort.Size = new Size(63, 15);
            labelPort.TabIndex = 0;
            labelPort.Text = "COM Port:";
            // 
            // comboPort
            // 
            comboPort.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPort.Location = new Point(82, 13);
            comboPort.Name = "comboPort";
            comboPort.Size = new Size(100, 23);
            comboPort.TabIndex = 1;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(188, 12);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(75, 27);
            buttonRefresh.TabIndex = 2;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(270, 12);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(95, 27);
            buttonConnect.TabIndex = 3;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.ForeColor = Color.DarkRed;
            labelStatus.Location = new Point(385, 17);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(89, 15);
            labelStatus.TabIndex = 4;
            labelStatus.Text = "● Disconnected";
            // 
            // dataGridFrames
            // 
            dataGridFrames.AllowUserToAddRows = false;
            dataGridFrames.AllowUserToDeleteRows = false;
            dataGridFrames.AllowUserToResizeRows = false;
            dataGridFrames.BackgroundColor = Color.White;
            dataGridFrames.BorderStyle = BorderStyle.None;
            dataGridFrames.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridFrames.ColumnHeadersHeight = 32;
            dataGridFrames.Columns.AddRange(new DataGridViewColumn[] { ColumnTime, ColumnId, ColumnDlc, ColumnData });
            dataGridFrames.Dock = DockStyle.Fill;
            dataGridFrames.EnableHeadersVisualStyles = false;
            dataGridFrames.Location = new Point(0, 79);
            dataGridFrames.Name = "dataGridFrames";
            dataGridFrames.RowHeadersVisible = false;
            dataGridFrames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridFrames.Size = new Size(900, 393);
            dataGridFrames.TabIndex = 2;
            // 
            // ColumnTime
            // 
            ColumnTime.HeaderText = "Time";
            ColumnTime.Name = "ColumnTime";
            ColumnTime.Width = 110;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "CAN ID";
            ColumnId.Name = "ColumnId";
            ColumnId.Width = 110;
            // 
            // ColumnDlc
            // 
            ColumnDlc.HeaderText = "DLC";
            ColumnDlc.Name = "ColumnDlc";
            ColumnDlc.Width = 60;
            // 
            // ColumnData
            // 
            ColumnData.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnData.HeaderText = "Data";
            ColumnData.Name = "ColumnData";
            // 
            // panelFrameStatus
            // 
            panelFrameStatus.BackColor = Color.FromArgb(245, 245, 245);
            panelFrameStatus.Controls.Add(labelFrameCount);
            panelFrameStatus.Controls.Add(buttonClear);
            panelFrameStatus.Dock = DockStyle.Bottom;
            panelFrameStatus.Location = new Point(0, 472);
            panelFrameStatus.Name = "panelFrameStatus";
            panelFrameStatus.Padding = new Padding(10, 5, 10, 5);
            panelFrameStatus.Size = new Size(900, 38);
            panelFrameStatus.TabIndex = 3;
            // 
            // labelFrameCount
            // 
            labelFrameCount.AutoSize = true;
            labelFrameCount.Location = new Point(20, 15);
            labelFrameCount.Name = "labelFrameCount";
            labelFrameCount.Size = new Size(57, 15);
            labelFrameCount.TabIndex = 0;
            labelFrameCount.Text = "Frames: 0";
            // 
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClear.Location = new Point(800, 5);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(80, 28);
            buttonClear.TabIndex = 1;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.FromArgb(235, 235, 235);
            panelBottom.Controls.Add(labelTx);
            panelBottom.Controls.Add(labelTxId);
            panelBottom.Controls.Add(textBoxTxId);
            panelBottom.Controls.Add(labelTxDlc);
            panelBottom.Controls.Add(textBoxTxDlc);
            panelBottom.Controls.Add(labelTxData);
            panelBottom.Controls.Add(textBoxTxData);
            panelBottom.Controls.Add(buttonSend);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 510);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(10);
            panelBottom.Size = new Size(900, 90);
            panelBottom.TabIndex = 4;
            // 
            // labelTx
            // 
            labelTx.AutoSize = true;
            labelTx.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTx.Location = new Point(20, 20);
            labelTx.Name = "labelTx";
            labelTx.Size = new Size(68, 15);
            labelTx.TabIndex = 0;
            labelTx.Text = "TRANSMIT";
            // 
            // labelTxId
            // 
            labelTxId.AutoSize = true;
            labelTxId.Location = new Point(10, 47);
            labelTxId.Name = "labelTxId";
            labelTxId.Size = new Size(21, 15);
            labelTxId.TabIndex = 1;
            labelTxId.Text = "ID:";
            // 
            // textBoxTxId
            // 
            textBoxTxId.Location = new Point(35, 43);
            textBoxTxId.Name = "textBoxTxId";
            textBoxTxId.Size = new Size(80, 23);
            textBoxTxId.TabIndex = 0;
            textBoxTxId.Text = "123";
            // 
            // labelTxDlc
            // 
            labelTxDlc.AutoSize = true;
            labelTxDlc.Location = new Point(130, 47);
            labelTxDlc.Name = "labelTxDlc";
            labelTxDlc.Size = new Size(32, 15);
            labelTxDlc.TabIndex = 2;
            labelTxDlc.Text = "DLC:";
            // 
            // textBoxTxDlc
            // 
            textBoxTxDlc.Location = new Point(165, 43);
            textBoxTxDlc.Name = "textBoxTxDlc";
            textBoxTxDlc.Size = new Size(40, 23);
            textBoxTxDlc.TabIndex = 1;
            textBoxTxDlc.Text = "8";
            // 
            // labelTxData
            // 
            labelTxData.AutoSize = true;
            labelTxData.Location = new Point(220, 47);
            labelTxData.Name = "labelTxData";
            labelTxData.Size = new Size(34, 15);
            labelTxData.TabIndex = 3;
            labelTxData.Text = "Data:";
            // 
            // textBoxTxData
            // 
            textBoxTxData.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            textBoxTxData.Font = new Font("Consolas", 9F);
            textBoxTxData.Location = new Point(260, 43);
            textBoxTxData.Name = "textBoxTxData";
            textBoxTxData.Size = new Size(500, 23);
            textBoxTxData.TabIndex = 2;
            textBoxTxData.Text = "11 22 33 44 55 66 77 88";
            // 
            // buttonSend
            // 
            buttonSend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSend.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSend.Location = new Point(790, 40);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(90, 30);
            buttonSend.TabIndex = 3;
            buttonSend.Text = "SEND";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(dataGridFrames);
            Controls.Add(panelFrameStatus);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Controls.Add(menuStripMain);
            MainMenuStrip = menuStripMain;
            MinimumSize = new Size(900, 550);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CAN Bus Analyzer";
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridFrames).EndInit();
            panelFrameStatus.ResumeLayout(false);
            panelFrameStatus.PerformLayout();
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem cANToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem transmitToolStripMenuItem;
        private ToolStripMenuItem viewMenu;
        private ToolStripMenuItem traceToolStripMenuItem;
        private ToolStripMenuItem helpMenu;
        private ToolStripMenuItem startToolStripMenuItem;
        private ToolStripMenuItem pauseToolStripMenuItem;
        private ToolStripMenuItem stopToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem bufferSizeToolStripMenuItem;
        private ToolStripMenuItem linearBufferToolStripMenuItem;
        private ToolStripMenuItem ringBufferToolStripMenuItem;
        private ToolStripMenuItem windowsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem logDataDToolStripMenuItem;
        private ToolStripMenuItem logPTRToolStripMenuItem;
        private ToolStripMenuItem logStatusChangesToolStripMenuItem;
        private ToolStripMenuItem logErrorFramesToolStripMenuItem;
        private ToolStripMenuItem logErrorCounterChangesToolStripMenuItem;
        private ToolStripMenuItem logEventsToolStripMenuItem;
        private ToolStripMenuItem stayOnTopToolStripMenuItem;
        private ToolStripMenuItem makeFloatingToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem recentFilesToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem connectToolStripMenuItem;
        private ToolStripMenuItem disconnectToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem clearAllToolStripMenuItem;
        private ToolStripMenuItem newMessageToolStripMenuItem;
        private ToolStripMenuItem editMessageToolStripMenuItem;
        private ToolStripMenuItem sendToolStripMenuItem;
        private ToolStripMenuItem pauseResumeToolStripMenuItem;
        private ToolStripMenuItem receiveTransmitToolStripMenuItem;
        private ToolStripMenuItem traceToolStripMenuItem1;
        private ToolStripMenuItem uSBToolStripMenuItem;
        private ToolStripMenuItem cANIDFormatToolStripMenuItem;
        private ToolStripMenuItem hexadecimalToolStripMenuItem;
        private ToolStripMenuItem decimalToolStripMenuItem;
        private ToolStripMenuItem dataByteFormatToolStripMenuItem;
        private ToolStripMenuItem hexadecimalToolStripMenuItem1;
        private ToolStripMenuItem decimalToolStripMenuItem1;
        private ToolStripMenuItem aSCIIToolStripMenuItem;
        private ToolStripMenuItem dataLengthDisplayToolStripMenuItem;
        private ToolStripMenuItem showDataLengthToolStripMenuItem;
        private ToolStripMenuItem showDataLengthCodeDLCToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem languageToolStripMenuItem;
        private ToolStripMenuItem automaticToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem englishToolStripMenuItem;
        private ToolStripMenuItem styleToolStripMenuItem;
        private ToolStripMenuItem darkToolStripMenuItem;
        private ToolStripMenuItem windowsToolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem fileFormatSpecificationsForCANTraceFilesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem deviceDriverVersionToolStripMenuItem;
        private ToolStripMenuItem licenceToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}
