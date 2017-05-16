using PpRStandardLib.Controls;
namespace NetworkFunctions_Client
{
    partial class NetworkFunctions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.NetworkSharesTab = new System.Windows.Forms.TabPage();
            this.fullListView1 = new PpRStandardLib.Controls.FullListView();
            this.Socks5ServerTab = new System.Windows.Forms.TabPage();
            this.LANScanTab = new System.Windows.Forms.TabPage();
            this.NetGatewayTab = new System.Windows.Forms.TabPage();
            this.IPScannerTab = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.NetworkSharesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.NetworkSharesTab);
            this.tabControl.Controls.Add(this.Socks5ServerTab);
            this.tabControl.Controls.Add(this.LANScanTab);
            this.tabControl.Controls.Add(this.NetGatewayTab);
            this.tabControl.Controls.Add(this.IPScannerTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabControl.ItemSize = new System.Drawing.Size(102, 20);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(718, 470);
            this.tabControl.TabIndex = 2;
            this.tabControl.TabStop = false;
            // 
            // NetworkSharesTab
            // 
            this.NetworkSharesTab.Controls.Add(this.fullListView1);
            this.NetworkSharesTab.Location = new System.Drawing.Point(4, 24);
            this.NetworkSharesTab.Name = "NetworkSharesTab";
            this.NetworkSharesTab.Size = new System.Drawing.Size(710, 442);
            this.NetworkSharesTab.TabIndex = 1;
            this.NetworkSharesTab.Text = "Network Shares";
            this.NetworkSharesTab.UseVisualStyleBackColor = true;
            // 
            // fullListView1
            // 
            this.fullListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullListView1.ExplorerTheme = false;
            this.fullListView1.ExplorerThemeMultiSelect = false;
            this.fullListView1.FullRowSelect = true;
            this.fullListView1.ItemContextMenuStrip = false;
            this.fullListView1.Location = new System.Drawing.Point(0, 0);
            this.fullListView1.LockColumnSize = false;
            this.fullListView1.Name = "fullListView1";
            this.fullListView1.Size = new System.Drawing.Size(710, 442);
            this.fullListView1.TabIndex = 0;
            this.fullListView1.UseCompatibleStateImageBehavior = false;
            this.fullListView1.View = System.Windows.Forms.View.Details;
            // 
            // Socks5ServerTab
            // 
            this.Socks5ServerTab.Location = new System.Drawing.Point(4, 24);
            this.Socks5ServerTab.Name = "Socks5ServerTab";
            this.Socks5ServerTab.Size = new System.Drawing.Size(710, 442);
            this.Socks5ServerTab.TabIndex = 2;
            this.Socks5ServerTab.Text = "Socks5 Server";
            this.Socks5ServerTab.UseVisualStyleBackColor = true;
            // 
            // LANScanTab
            // 
            this.LANScanTab.Location = new System.Drawing.Point(4, 24);
            this.LANScanTab.Name = "LANScanTab";
            this.LANScanTab.Size = new System.Drawing.Size(710, 442);
            this.LANScanTab.TabIndex = 3;
            this.LANScanTab.Text = "LAN Scan";
            this.LANScanTab.UseVisualStyleBackColor = true;
            // 
            // NetGatewayTab
            // 
            this.NetGatewayTab.Location = new System.Drawing.Point(4, 24);
            this.NetGatewayTab.Name = "NetGatewayTab";
            this.NetGatewayTab.Size = new System.Drawing.Size(710, 442);
            this.NetGatewayTab.TabIndex = 4;
            this.NetGatewayTab.Text = "Net Gateway";
            this.NetGatewayTab.UseVisualStyleBackColor = true;
            // 
            // IPScannerTab
            // 
            this.IPScannerTab.Location = new System.Drawing.Point(4, 24);
            this.IPScannerTab.Name = "IPScannerTab";
            this.IPScannerTab.Size = new System.Drawing.Size(710, 442);
            this.IPScannerTab.TabIndex = 5;
            this.IPScannerTab.Text = "IP Scanner";
            this.IPScannerTab.UseVisualStyleBackColor = true;
            // 
            // NetworkFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 470);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "NetworkFunctions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Functions";
            this.Load += new System.EventHandler(this.NetworkFunctions_Load);
            this.tabControl.ResumeLayout(false);
            this.NetworkSharesTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage NetworkSharesTab;
        private System.Windows.Forms.TabPage Socks5ServerTab;
        private System.Windows.Forms.TabPage LANScanTab;
        private System.Windows.Forms.TabPage NetGatewayTab;
        private System.Windows.Forms.TabPage IPScannerTab;
        private FullListView fullListView1;
    }
}