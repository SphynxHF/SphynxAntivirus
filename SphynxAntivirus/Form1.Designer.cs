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
            trayMenu.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 36);
            label1.Name = "label1";
            label1.Size = new Size(157, 32);
            label1.TabIndex = 0;
            label1.Text = "Select Folder:";
            // 
            // textBoxFolder
            // 
            textBoxFolder.Location = new Point(186, 33);
            textBoxFolder.Name = "textBoxFolder";
            textBoxFolder.ReadOnly = true;
            textBoxFolder.Size = new Size(471, 39);
            textBoxFolder.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(676, 36);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(150, 46);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnScan
            // 
            btnScan.Location = new Point(832, 33);
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
            listBoxResults.Location = new Point(165, 114);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(533, 164);
            listBoxResults.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 329);
            label2.Name = "label2";
            label2.Size = new Size(201, 32);
            label2.TabIndex = 5;
            label2.Text = "Quarantined Files";
            // 
            // listBoxQuarantine
            // 
            listBoxQuarantine.FormattingEnabled = true;
            listBoxQuarantine.Location = new Point(49, 375);
            listBoxQuarantine.Name = "listBoxQuarantine";
            listBoxQuarantine.Size = new Size(686, 164);
            listBoxQuarantine.TabIndex = 6;
            // 
            // btnLoadQuarantine
            // 
            btnLoadQuarantine.Location = new Point(752, 375);
            btnLoadQuarantine.Name = "btnLoadQuarantine";
            btnLoadQuarantine.Size = new Size(150, 46);
            btnLoadQuarantine.TabIndex = 7;
            btnLoadQuarantine.Text = "Load Quarantine";
            btnLoadQuarantine.UseVisualStyleBackColor = true;
            btnLoadQuarantine.Click += btnLoadQuarantine_Click;
            // 
            // btnRestore
            // 
            btnRestore.Location = new Point(752, 427);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(150, 46);
            btnRestore.TabIndex = 8;
            btnRestore.Text = "Restore File";
            btnRestore.UseVisualStyleBackColor = true;
            btnRestore.Click += btnRestore_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(752, 479);
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
            label3.Location = new Point(23, 619);
            label3.Name = "label3";
            label3.Size = new Size(237, 32);
            label3.TabIndex = 10;
            label3.Text = "Real-Time Protection";
            // 
            // btnToggleRTP
            // 
            btnToggleRTP.Location = new Point(83, 671);
            btnToggleRTP.Name = "btnToggleRTP";
            btnToggleRTP.Size = new Size(150, 46);
            btnToggleRTP.TabIndex = 11;
            btnToggleRTP.Text = "Start Protection";
            btnToggleRTP.UseVisualStyleBackColor = true;
            // 
            // lblRTPStatus
            // 
            lblRTPStatus.AutoSize = true;
            lblRTPStatus.Location = new Point(39, 746);
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
            btnViewLogs.Location = new Point(21, 985);
            btnViewLogs.Name = "btnViewLogs";
            btnViewLogs.Size = new Size(150, 46);
            btnViewLogs.TabIndex = 13;
            btnViewLogs.Text = "View Logs";
            btnViewLogs.UseVisualStyleBackColor = true;
            btnViewLogs.Click += btnViewLogs_Click;
            // 
            // btnClearLogs
            // 
            btnClearLogs.Location = new Point(197, 985);
            btnClearLogs.Name = "btnClearLogs";
            btnClearLogs.Size = new Size(150, 46);
            btnClearLogs.TabIndex = 14;
            btnClearLogs.Text = "Clear Logs";
            btnClearLogs.UseVisualStyleBackColor = true;
            btnClearLogs.Click += btnClearLogs_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1700, 1059);
            Controls.Add(btnClearLogs);
            Controls.Add(btnViewLogs);
            Controls.Add(lblRTPStatus);
            Controls.Add(btnToggleRTP);
            Controls.Add(label3);
            Controls.Add(btnDelete);
            Controls.Add(btnRestore);
            Controls.Add(btnLoadQuarantine);
            Controls.Add(listBoxQuarantine);
            Controls.Add(label2);
            Controls.Add(listBoxResults);
            Controls.Add(btnScan);
            Controls.Add(btnBrowse);
            Controls.Add(textBoxFolder);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            trayMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
    }
}
