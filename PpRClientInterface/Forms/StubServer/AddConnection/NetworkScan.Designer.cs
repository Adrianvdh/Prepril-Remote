namespace PpRClientInterface.Forms
{
    partial class NetworkScan
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Andrea-PC",
            "192.168.1.9",
            "1135",
            "1c:65:9d:c6:1f:e7",
            "Yes"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Drenie-PC",
            "192.168.1.12",
            "1135",
            "1c:65:9d:c6:20:f5",
            "Yes"}, -1);
            this.NetworkDevicesListView = new PpRStandardLib.Controls.FullListView();
            this.DeviceNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IPAddressColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PortColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MACAddressColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.StatusBarPanel = new System.Windows.Forms.StatusBarPanel();
            this.DevicesBarPanel = new System.Windows.Forms.StatusBarPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.GroupComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevicesBarPanel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NetworkDevicesListView
            // 
            this.NetworkDevicesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NetworkDevicesListView.CheckBoxes = true;
            this.NetworkDevicesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DeviceNameColumn,
            this.IPAddressColumn,
            this.PortColumn,
            this.MACAddressColumn,
            this.columnHeader2});
            this.NetworkDevicesListView.ExplorerTheme = false;
            this.NetworkDevicesListView.ExplorerThemeMultiSelect = false;
            this.NetworkDevicesListView.FullRowSelect = true;
            this.NetworkDevicesListView.ItemContextMenuStrip = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            this.NetworkDevicesListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.NetworkDevicesListView.Location = new System.Drawing.Point(258, 7);
            this.NetworkDevicesListView.LockColumnSize = false;
            this.NetworkDevicesListView.MultiSelect = false;
            this.NetworkDevicesListView.Name = "NetworkDevicesListView";
            this.NetworkDevicesListView.Size = new System.Drawing.Size(465, 290);
            this.NetworkDevicesListView.TabIndex = 74;
            this.NetworkDevicesListView.UseCompatibleStateImageBehavior = false;
            this.NetworkDevicesListView.View = System.Windows.Forms.View.Details;
            // 
            // DeviceNameColumn
            // 
            this.DeviceNameColumn.Text = "Device Name";
            this.DeviceNameColumn.Width = 143;
            // 
            // IPAddressColumn
            // 
            this.IPAddressColumn.Text = "IP Address";
            this.IPAddressColumn.Width = 86;
            // 
            // PortColumn
            // 
            this.PortColumn.Text = "Port";
            this.PortColumn.Width = 45;
            // 
            // MACAddressColumn
            // 
            this.MACAddressColumn.Text = "MAC Address";
            this.MACAddressColumn.Width = 114;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Password";
            this.columnHeader2.Width = 63;
            // 
            // statusBar1
            // 
            this.statusBar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusBar1.Location = new System.Drawing.Point(0, 304);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.StatusBarPanel,
            this.DevicesBarPanel});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(729, 22);
            this.statusBar1.SizingGrip = false;
            this.statusBar1.TabIndex = 73;
            this.statusBar1.Text = "statusBar1";
            // 
            // StatusBarPanel
            // 
            this.StatusBarPanel.Name = "StatusBarPanel";
            this.StatusBarPanel.Text = "Ready";
            this.StatusBarPanel.Width = 220;
            // 
            // DevicesBarPanel
            // 
            this.DevicesBarPanel.Name = "DevicesBarPanel";
            this.DevicesBarPanel.Text = "Devices Found: 2";
            this.DevicesBarPanel.Width = 115;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.Location = new System.Drawing.Point(6, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 2);
            this.label9.TabIndex = 72;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.Location = new System.Drawing.Point(76, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 15);
            this.label8.TabIndex = 69;
            this.label8.Text = "0%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 68;
            this.label7.Text = "Adapter:";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "All Adapters",
            "192.168.1.x"});
            this.comboBox2.Location = new System.Drawing.Point(64, 16);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(93, 23);
            this.comboBox2.TabIndex = 67;
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(6, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 66;
            this.label6.Text = "Percentage:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 96);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(233, 18);
            this.progressBar1.TabIndex = 65;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button3.Location = new System.Drawing.Point(119, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 64;
            this.button3.Text = "Scan Local Network";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // menuItem2
            // 
            this.menuItem2.Enabled = false;
            this.menuItem2.Index = 2;
            this.menuItem2.Text = "Check All";
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem3,
            this.menuItem2});
            // 
            // menuItem1
            // 
            this.menuItem1.Enabled = false;
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Remove Checked";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBox2.Location = new System.Drawing.Point(6, 74);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(140, 19);
            this.checkBox2.TabIndex = 57;
            this.checkBox2.Text = "Automatically update";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBox1.Location = new System.Drawing.Point(6, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 19);
            this.checkBox1.TabIndex = 56;
            this.checkBox1.Text = "Add as favorite";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // GroupComboBox
            // 
            this.GroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupComboBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GroupComboBox.FormattingEnabled = true;
            this.GroupComboBox.Items.AddRange(new object[] {
            "None"});
            this.GroupComboBox.Location = new System.Drawing.Point(6, 22);
            this.GroupComboBox.Name = "GroupComboBox";
            this.GroupComboBox.Size = new System.Drawing.Size(203, 23);
            this.GroupComboBox.TabIndex = 60;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button2.Location = new System.Drawing.Point(177, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 63;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.Location = new System.Drawing.Point(96, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 62;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(7, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 151);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.GroupComboBox);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Location = new System.Drawing.Point(7, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 98);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 73;
            this.label1.Text = "Port:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(64, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(93, 23);
            this.comboBox1.TabIndex = 74;
            // 
            // NetworkScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 326);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NetworkDevicesListView);
            this.Controls.Add(this.statusBar1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NetworkScan";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New [Network Scan] (LAN)";
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevicesBarPanel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PpRStandardLib.Controls.FullListView NetworkDevicesListView;
        private System.Windows.Forms.ColumnHeader DeviceNameColumn;
        private System.Windows.Forms.ColumnHeader IPAddressColumn;
        private System.Windows.Forms.ColumnHeader PortColumn;
        private System.Windows.Forms.ColumnHeader MACAddressColumn;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel StatusBarPanel;
        private System.Windows.Forms.StatusBarPanel DevicesBarPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox GroupComboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;

    }
}