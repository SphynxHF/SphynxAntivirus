namespace SphynxAntivirus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBoxFolder = new TextBox();
            btnBrowse = new Button();
            btnScan = new Button();
            listBoxResults = new ListBox();
            label2 = new Label();
            listBoxQuarantine = new ListBox();
            btnLoadQuarantine = new Button();
            btnRestore = new Button();
            btnDelete = new Button();
            label3 = new Label();
            btnToggleRTP = new Button();
            lblRTPStatus = new Label();
            trayIcon = new NotifyIcon(components);
            trayMenu = new ContextMenuStrip(components);
            menuShowApp_Click = new ToolStripMenuItem();
            menuStart_Click = new ToolStripMenuItem();
            menuStop_Click = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            menuExit_Click = new ToolStripMenuItem();
            btnViewLogs = new Button();
            btnClearLogs = new Button();
            btnUpdateSigs = new Button();
            lblSignatureVersion = new Label();
            tabControl1 = new TabControl();
            ScannerTab = new TabPage();
            SettingsTab = new TabPage();
            btnResetDefaults = new Button();
            btnSaveSettings = new Button();
            chkEnableLogging = new CheckBox();
            chkLaunchMinimized = new CheckBox();
            chkBalloonAlerts = new CheckBox();
            label4 = new Label();
            numUpdateInterval = new NumericUpDown();
            chkEnableRTP = new CheckBox();
            groupBox1 = new GroupBox();
            radioQuickScan = new RadioButton();
            radioFullScan = new RadioButton();
            trayMenu.SuspendLayout();
            tabControl1.SuspendLayout();
            ScannerTab.SuspendLayout();
            SettingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpdateInterval).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 51);
            label1.Name = "label1";
            label1.Size = new Size(157, 32);
            label1.TabIndex = 0;
            label1.Text = "Select Folder:";
            // 
            // textBoxFolder
            // 
            textBoxFolder.Location = new Point(197, 48);
            textBoxFolder.Name = "textBoxFolder";
            textBoxFolder.ReadOnly = true;
            textBoxFolder.Size = new Size(471, 39);
            textBoxFolder.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(687, 51);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(150, 46);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnScan
            // 
            btnScan.Location = new Point(843, 48);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(150, 46);
            btnScan.TabIndex = 3;
            btnScan.Text = "Scan";
            btnScan.UseVisualStyleBackColor = true;
            btnScan.Click += btnScan_Click;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(176, 129);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(533, 164);
            listBoxResults.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 344);
            label2.Name = "label2";
            label2.Size = new Size(201, 32);
            label2.TabIndex = 5;
            label2.Text = "Quarantined Files";
            // 
            // listBoxQuarantine
            // 
            listBoxQuarantine.FormattingEnabled = true;
            listBoxQuarantine.Location = new Point(60, 390);
            listBoxQuarantine.Name = "listBoxQuarantine";
            listBoxQuarantine.Size = new Size(686, 164);
            listBoxQuarantine.TabIndex = 6;
            // 
            // btnLoadQuarantine
            // 
            btnLoadQuarantine.Location = new Point(763, 390);
            btnLoadQuarantine.Name = "btnLoadQuarantine";
            btnLoadQuarantine.Size = new Size(150, 46);
            btnLoadQuarantine.TabIndex = 7;
            btnLoadQuarantine.Text = "Load Quarantine";
            btnLoadQuarantine.UseVisualStyleBackColor = true;
            btnLoadQuarantine.Click += btnLoadQuarantine_Click;
            // 
            // btnRestore
            // 
            btnRestore.Location = new Point(763, 442);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(150, 46);
            btnRestore.TabIndex = 8;
            btnRestore.Text = "Restore File";
            btnRestore.UseVisualStyleBackColor = true;
            btnRestore.Click += btnRestore_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(763, 494);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete File";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 634);
            label3.Name = "label3";
            label3.Size = new Size(237, 32);
            label3.TabIndex = 10;
            label3.Text = "Real-Time Protection";
            // 
            // btnToggleRTP
            // 
            btnToggleRTP.Location = new Point(94, 686);
            btnToggleRTP.Name = "btnToggleRTP";
            btnToggleRTP.Size = new Size(150, 46);
            btnToggleRTP.TabIndex = 11;
            btnToggleRTP.Text = "Start Protection";
            btnToggleRTP.UseVisualStyleBackColor = true;
            // 
            // lblRTPStatus
            // 
            lblRTPStatus.AutoSize = true;
            lblRTPStatus.Location = new Point(50, 761);
            lblRTPStatus.Name = "lblRTPStatus";
            lblRTPStatus.Size = new Size(132, 32);
            lblRTPStatus.TabIndex = 12;
            lblRTPStatus.Text = "Status: OFF";
            // 
            // trayIcon
            // 
            trayIcon.ContextMenuStrip = trayMenu;
            trayIcon.Icon = (Icon)resources.GetObject("trayIcon.Icon");
            trayIcon.Text = "Sphynx Antivirus";
            trayIcon.MouseDoubleClick += trayIcon_MouseDoubleClick;
            // 
            // trayMenu
            // 
            trayMenu.ImageScalingSize = new Size(32, 32);
            trayMenu.Items.AddRange(new ToolStripItem[] { menuShowApp_Click, menuStart_Click, menuStop_Click, toolStripSeparator1, menuExit_Click });
            trayMenu.Name = "trayMenu";
            trayMenu.Size = new Size(253, 162);
            // 
            // menuShowApp_Click
            // 
            menuShowApp_Click.Name = "menuShowApp_Click";
            menuShowApp_Click.Size = new Size(252, 38);
            menuShowApp_Click.Text = "Show App";
            menuShowApp_Click.Click += menuShowApp_Click_Click;
            // 
            // menuStart_Click
            // 
            menuStart_Click.Name = "menuStart_Click";
            menuStart_Click.Size = new Size(252, 38);
            menuStart_Click.Text = "Start Protection";
            menuStart_Click.Click += menuStart_Click_Click;
            // 
            // menuStop_Click
            // 
            menuStop_Click.Name = "menuStop_Click";
            menuStop_Click.Size = new Size(252, 38);
            menuStop_Click.Text = "Stop Protection";
            menuStop_Click.Click += menuStop_Click_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(249, 6);
            // 
            // menuExit_Click
            // 
            menuExit_Click.Name = "menuExit_Click";
            menuExit_Click.Size = new Size(252, 38);
            menuExit_Click.Text = "Exit";
            menuExit_Click.Click += menuExit_Click_Click;
            // 
            // btnViewLogs
            // 
            btnViewLogs.Location = new Point(32, 1000);
            btnViewLogs.Name = "btnViewLogs";
            btnViewLogs.Size = new Size(150, 46);
            btnViewLogs.TabIndex = 13;
            btnViewLogs.Text = "View Logs";
            btnViewLogs.UseVisualStyleBackColor = true;
            btnViewLogs.Click += btnViewLogs_Click;
            // 
            // btnClearLogs
            // 
            btnClearLogs.Location = new Point(208, 1000);
            btnClearLogs.Name = "btnClearLogs";
            btnClearLogs.Size = new Size(150, 46);
            btnClearLogs.TabIndex = 14;
            btnClearLogs.Text = "Clear Logs";
            btnClearLogs.UseVisualStyleBackColor = true;
            btnClearLogs.Click += btnClearLogs_Click;
            // 
            // btnUpdateSigs
            // 
            btnUpdateSigs.Location = new Point(379, 1000);
            btnUpdateSigs.Name = "btnUpdateSigs";
            btnUpdateSigs.Size = new Size(242, 46);
            btnUpdateSigs.TabIndex = 15;
            btnUpdateSigs.Text = "Update Signatures";
            btnUpdateSigs.UseVisualStyleBackColor = true;
            btnUpdateSigs.Click += btnUpdateSigs_Click;
            // 
            // lblSignatureVersion
            // 
            lblSignatureVersion.AutoSize = true;
            lblSignatureVersion.Location = new Point(655, 1007);
            lblSignatureVersion.Name = "lblSignatureVersion";
            lblSignatureVersion.Size = new Size(314, 32);
            lblSignatureVersion.TabIndex = 16;
            lblSignatureVersion.Text = "Signature Version: Unknown";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ScannerTab);
            tabControl1.Controls.Add(SettingsTab);
            tabControl1.Location = new Point(12, -6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1686, 1053);
            tabControl1.TabIndex = 17;
            // 
            // ScannerTab
            // 
            ScannerTab.Controls.Add(groupBox1);
            ScannerTab.Controls.Add(label1);
            ScannerTab.Controls.Add(textBoxFolder);
            ScannerTab.Controls.Add(lblSignatureVersion);
            ScannerTab.Controls.Add(btnBrowse);
            ScannerTab.Controls.Add(btnUpdateSigs);
            ScannerTab.Controls.Add(btnScan);
            ScannerTab.Controls.Add(btnClearLogs);
            ScannerTab.Controls.Add(listBoxResults);
            ScannerTab.Controls.Add(btnViewLogs);
            ScannerTab.Controls.Add(label2);
            ScannerTab.Controls.Add(lblRTPStatus);
            ScannerTab.Controls.Add(listBoxQuarantine);
            ScannerTab.Controls.Add(btnToggleRTP);
            ScannerTab.Controls.Add(btnLoadQuarantine);
            ScannerTab.Controls.Add(label3);
            ScannerTab.Controls.Add(btnRestore);
            ScannerTab.Controls.Add(btnDelete);
            ScannerTab.Location = new Point(8, 46);
            ScannerTab.Name = "ScannerTab";
            ScannerTab.Padding = new Padding(3);
            ScannerTab.Size = new Size(1670, 999);
            ScannerTab.TabIndex = 0;
            ScannerTab.Text = "Scanner";
            ScannerTab.UseVisualStyleBackColor = true;
            // 
            // SettingsTab
            // 
            SettingsTab.Controls.Add(btnResetDefaults);
            SettingsTab.Controls.Add(btnSaveSettings);
            SettingsTab.Controls.Add(chkEnableLogging);
            SettingsTab.Controls.Add(chkLaunchMinimized);
            SettingsTab.Controls.Add(chkBalloonAlerts);
            SettingsTab.Controls.Add(label4);
            SettingsTab.Controls.Add(numUpdateInterval);
            SettingsTab.Controls.Add(chkEnableRTP);
            SettingsTab.Location = new Point(8, 46);
            SettingsTab.Name = "SettingsTab";
            SettingsTab.Padding = new Padding(3);
            SettingsTab.Size = new Size(1670, 999);
            SettingsTab.TabIndex = 1;
            SettingsTab.Text = "Settings";
            SettingsTab.UseVisualStyleBackColor = true;
            // 
            // btnResetDefaults
            // 
            btnResetDefaults.Location = new Point(294, 912);
            btnResetDefaults.Name = "btnResetDefaults";
            btnResetDefaults.Size = new Size(239, 46);
            btnResetDefaults.TabIndex = 7;
            btnResetDefaults.Text = "Reset Settings";
            btnResetDefaults.UseVisualStyleBackColor = true;
            btnResetDefaults.Click += btnResetDefaults_Click;
            // 
            // btnSaveSettings
            // 
            btnSaveSettings.Location = new Point(28, 912);
            btnSaveSettings.Name = "btnSaveSettings";
            btnSaveSettings.Size = new Size(242, 46);
            btnSaveSettings.TabIndex = 6;
            btnSaveSettings.Text = "Save Settings";
            btnSaveSettings.UseVisualStyleBackColor = true;
            btnSaveSettings.Click += btnSaveSettings_Click;
            // 
            // chkEnableLogging
            // 
            chkEnableLogging.AutoSize = true;
            chkEnableLogging.Location = new Point(28, 334);
            chkEnableLogging.Name = "chkEnableLogging";
            chkEnableLogging.Size = new Size(211, 36);
            chkEnableLogging.TabIndex = 5;
            chkEnableLogging.Text = "Enable Logging";
            chkEnableLogging.UseVisualStyleBackColor = true;
            // 
            // chkLaunchMinimized
            // 
            chkLaunchMinimized.AutoSize = true;
            chkLaunchMinimized.Location = new Point(28, 264);
            chkLaunchMinimized.Name = "chkLaunchMinimized";
            chkLaunchMinimized.Size = new Size(242, 36);
            chkLaunchMinimized.TabIndex = 4;
            chkLaunchMinimized.Text = "Launch Minimized";
            chkLaunchMinimized.UseVisualStyleBackColor = true;
            // 
            // chkBalloonAlerts
            // 
            chkBalloonAlerts.AutoSize = true;
            chkBalloonAlerts.Location = new Point(28, 196);
            chkBalloonAlerts.Name = "chkBalloonAlerts";
            chkBalloonAlerts.Size = new Size(258, 36);
            chkBalloonAlerts.TabIndex = 3;
            chkBalloonAlerts.Text = "Show Balloon Alerts";
            chkBalloonAlerts.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 121);
            label4.Name = "label4";
            label4.Size = new Size(230, 32);
            label4.TabIndex = 2;
            label4.Text = "Update Interval (hrs)";
            // 
            // numUpdateInterval
            // 
            numUpdateInterval.Location = new Point(262, 121);
            numUpdateInterval.Name = "numUpdateInterval";
            numUpdateInterval.Size = new Size(143, 39);
            numUpdateInterval.TabIndex = 1;
            // 
            // chkEnableRTP
            // 
            chkEnableRTP.AutoSize = true;
            chkEnableRTP.Location = new Point(26, 45);
            chkEnableRTP.Name = "chkEnableRTP";
            chkEnableRTP.Size = new Size(347, 36);
            chkEnableRTP.TabIndex = 0;
            chkEnableRTP.Text = "Enable Real-Time Protection";
            chkEnableRTP.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioFullScan);
            groupBox1.Controls.Add(radioQuickScan);
            groupBox1.Location = new Point(513, 650);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(238, 156);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Scan Mode";
            // 
            // radioQuickScan
            // 
            radioQuickScan.AutoSize = true;
            radioQuickScan.Location = new Point(21, 35);
            radioQuickScan.Name = "radioQuickScan";
            radioQuickScan.Size = new Size(163, 36);
            radioQuickScan.TabIndex = 0;
            radioQuickScan.TabStop = true;
            radioQuickScan.Text = "Quick Scan";
            radioQuickScan.UseVisualStyleBackColor = true;
            // 
            // radioFullScan
            // 
            radioFullScan.AutoSize = true;
            radioFullScan.Location = new Point(21, 77);
            radioFullScan.Name = "radioFullScan";
            radioFullScan.Size = new Size(140, 36);
            radioFullScan.TabIndex = 1;
            radioFullScan.TabStop = true;
            radioFullScan.Text = "Full Scan";
            radioFullScan.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1700, 1059);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            trayMenu.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ScannerTab.ResumeLayout(false);
            ScannerTab.PerformLayout();
            SettingsTab.ResumeLayout(false);
            SettingsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUpdateInterval).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBoxFolder;
        private Button btnBrowse;
        private Button btnScan;
        private ListBox listBoxResults;
        private Label label2;
        private ListBox listBoxQuarantine;
        private Button btnLoadQuarantine;
        private Button btnRestore;
        private Button btnDelete;
        private Label label3;
        private Button btnToggleRTP;
        private Label lblRTPStatus;
        private NotifyIcon trayIcon;
        private ContextMenuStrip trayMenu;
        private ToolStripMenuItem menuShowApp_Click;
        private ToolStripMenuItem menuStart_Click;
        private ToolStripMenuItem menuStop_Click;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem menuExit_Click;
        private Button btnViewLogs;
        private Button btnClearLogs;
        private Button btnUpdateSigs;
        private Label lblSignatureVersion;
        private TabControl tabControl1;
        private TabPage ScannerTab;
        private TabPage SettingsTab;
        private NumericUpDown numUpdateInterval;
        private CheckBox chkEnableRTP;
        private Button btnSaveSettings;
        private CheckBox chkEnableLogging;
        private CheckBox chkLaunchMinimized;
        private CheckBox chkBalloonAlerts;
        private Label label4;
        private Button btnResetDefaults;
        private GroupBox groupBox1;
        private RadioButton radioQuickScan;
        private RadioButton radioFullScan;
    }
}
