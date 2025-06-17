
using System;
using System.IO;
using System.Windows.Forms;

namespace SphynxAntivirus
{
    public partial class Form1 : Form
    {
        private FileSystemWatcher watcher;
        private bool isRTPActive = false;

        public Form1()
        {
            InitializeComponent();
            SignatureUpdater.UpdateSignatures(); // silent fetch on launch
            Logger.Log("UPDATED: Updated Virus Signatures");
            trayIcon.Visible = false;
            trayIcon.MouseDoubleClick += trayIcon_MouseDoubleClick;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxFolder.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();

            string folder = textBoxFolder.Text;
            if (string.IsNullOrEmpty(folder) || !Directory.Exists(folder))
            {
                MessageBox.Show("Please select a valid folder.");
                return;
            }

            string quarantinePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Quarantine");
            var signatures = Scanner.LoadSignatures("signatures.txt");
            var results = Scanner.ScanFolder(folder, signatures, quarantinePath);

            foreach (var result in results)
            {
                listBoxResults.Items.Add(result);
            }

            MessageBox.Show("Scan complete. Threats have been quarantined.");
        }

        private void btnLoadQuarantine_Click(object sender, EventArgs e)
        {
            listBoxQuarantine.Items.Clear();
            string quarantinePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Quarantine");

            if (!Directory.Exists(quarantinePath))
            {
                MessageBox.Show("No quarantine folder found.");
                return;
            }

            var files = Directory.GetFiles(quarantinePath);
            foreach (var file in files)
            {
                listBoxQuarantine.Items.Add(file);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (listBoxQuarantine.SelectedItem == null)
            {
                MessageBox.Show("Select a file to restore.");
                return;
            }

            string filePath = listBoxQuarantine.SelectedItem.ToString();
            string originalName = filePath.Substring(filePath.IndexOf('_') + 1);
            string restorePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Restored");

            try
            {
                if (!Directory.Exists(restorePath))
                    Directory.CreateDirectory(restorePath);

                File.Move(filePath, Path.Combine(restorePath, originalName));
                listBoxQuarantine.Items.Remove(filePath);
                MessageBox.Show("File restored to 'Restored' folder.");
                Logger.Log($"Restored from quarantine: {filePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to restore: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxQuarantine.SelectedItem == null)
            {
                MessageBox.Show("Select a file to delete.");
                return;
            }

            string filePath = listBoxQuarantine.SelectedItem.ToString();

            try
            {
                File.Delete(filePath);
                listBoxQuarantine.Items.Remove(filePath);
                MessageBox.Show("File deleted permanently.");
                Logger.Log($"Deleted from quarantine: {filePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete: " + ex.Message);
            }
        }

        private void StartRealTimeProtection(string folderToWatch)
        {
            if (!Directory.Exists(folderToWatch))
            {
                MessageBox.Show("Selected folder does not exist.");
                return;
            }

            watcher = new FileSystemWatcher(folderToWatch)
            {
                IncludeSubdirectories = true,
                NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite
            };

            watcher.Created += OnFileChanged;
            watcher.Changed += OnFileChanged;

            watcher.EnableRaisingEvents = true;

            lblRTPStatus.Text = "Status: ON";
            btnToggleRTP.Text = "Stop Protection";
            isRTPActive = true;
        }

        private void StopRealTimeProtection()
        {
            if (watcher != null)
            {
                watcher.EnableRaisingEvents = false;
                watcher.Dispose();
                watcher = null;
            }

            lblRTPStatus.Text = "Status: OFF";
            btnToggleRTP.Text = "Start Protection";
            isRTPActive = false;
        }

        private void OnFileChanged(object sender, FileSystemEventArgs e)
        {
            try
            {
                if (!File.Exists(e.FullPath)) return;

                var signatures = Scanner.LoadSignatures("signatures.txt");
                string quarantinePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Quarantine");

                string hash = Scanner.ComputeSHA256(e.FullPath);

                Logger.Log($"[RTP] File created or modified: {e.FullPath}");

                if (signatures.Contains(hash))
                {
                    Logger.Log($"[RTP] Quarantined: {e.FullPath}");
                    Scanner.QuarantineFile(e.FullPath, quarantinePath);
                    this.Invoke((MethodInvoker)(() =>
                    {
                        listBoxResults.Items.Add($"[RTP] Quarantined: {Path.GetFileName(e.FullPath)}");

                        trayIcon.BalloonTipTitle = "Threat Detected!";
                        trayIcon.BalloonTipText = $"{Path.GetFileName(e.FullPath)} has been quarantined.";
                        trayIcon.BalloonTipIcon = ToolTipIcon.Warning;
                        trayIcon.ShowBalloonTip(2000);
                    }));
                }
                else
                {
                    this.Invoke((MethodInvoker)(() =>
                    {
                        listBoxResults.Items.Add($"[RTP] Safe: {Path.GetFileName(e.FullPath)}");
                    }));
                }
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    listBoxResults.Items.Add($"[RTP] Error: {ex.Message}");
                }));
            }
        }

        private void btnToggleRTP_Click(object sender, EventArgs e)
        {
            string folder = textBoxFolder.Text;
            if (string.IsNullOrEmpty(folder) || !Directory.Exists(folder))
            {
                MessageBox.Show("Please select a valid folder to watch.");
                return;
            }

            if (!isRTPActive)
                StartRealTimeProtection(folder);
            else
                StopRealTimeProtection();
        }

        private void menuShowApp_Click_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void menuStart_Click_Click(object sender, EventArgs e)
        {
            if (!isRTPActive)
                StartRealTimeProtection(textBoxFolder.Text);
        }

        private void menuStop_Click_Click(object sender, EventArgs e)
        {
            if (isRTPActive)
                StopRealTimeProtection();
        }

        private void menuExit_Click_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                trayIcon.Visible = true;
                trayIcon.ShowBalloonTip(1000, "Sphynx Antivirus", "Running in background...", ToolTipIcon.Info);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            trayIcon.Dispose();
            base.OnFormClosing(e);
        }

        private void btnViewLogs_Click(object sender, EventArgs e)
        {
            var logs = Logger.GetLogEntries();
            if (logs.Length == 0)
            {
                MessageBox.Show("No logs found.");
                return;
            }

            Form logForm = new Form()
            {
                Text = "Log Viewer",
                Width = 600,
                Height = 400
            };

            TextBox logBox = new TextBox()
            {
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Both,
                Dock = DockStyle.Fill,
                Text = string.Join(Environment.NewLine, logs)
            };

            logForm.Controls.Add(logBox);
            logForm.Show();
        }

        private void btnClearLogs_Click(object sender, EventArgs e)
        {
            Logger.ClearLogs();
        }

        private void btnUpdateSigs_Click(object sender, EventArgs e)
        {
            bool success = SignatureUpdater.UpdateSignatures();
            if (success)
                MessageBox.Show("Signatures updated successfully.");
            else
                MessageBox.Show("Failed to update signatures. Check log.");
        }
    }
}
