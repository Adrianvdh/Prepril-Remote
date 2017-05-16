namespace Configuration.Controls
{
    partial class Users
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("Adrian");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Branson");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("Add Stubs");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("Built-In Server Mode");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("Server Settings");
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("User Chat");
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("Advertiser");
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem("Browser History Viewer");
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem("CdRom Ejector");
            System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem("Client Installers Release Updates");
            System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem("Computer+");
            System.Windows.Forms.ListViewItem listViewItem25 = new System.Windows.Forms.ListViewItem("Keyboard Controller");
            System.Windows.Forms.ListViewItem listViewItem26 = new System.Windows.Forms.ListViewItem("Mouse Controller");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UsersListView = new PpRStandardLib.Controls.FullListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.GeneralTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.FeaturesTab = new System.Windows.Forms.TabPage();
            this.FeaturesListView = new PpRStandardLib.Controls.FullListView();
            this.FeatureNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PluginsTab = new System.Windows.Forms.TabPage();
            this.PluginsListView = new PpRStandardLib.Controls.FullListView();
            this.PluginNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CommentTab = new System.Windows.Forms.TabPage();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.GeneralTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.FeaturesTab.SuspendLayout();
            this.PluginsTab.SuspendLayout();
            this.CommentTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UsersListView);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(-1, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 367);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Accounts";
            // 
            // UsersListView
            // 
            this.UsersListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.UsersListView.ExplorerTheme = false;
            this.UsersListView.ExplorerThemeMultiSelect = false;
            this.UsersListView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UsersListView.FullRowSelect = true;
            this.UsersListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.UsersListView.ItemContextMenuStrip = false;
            this.UsersListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem14,
            listViewItem15});
            this.UsersListView.LabelEdit = true;
            this.UsersListView.Location = new System.Drawing.Point(6, 19);
            this.UsersListView.LockColumnSize = false;
            this.UsersListView.MultiSelect = false;
            this.UsersListView.Name = "UsersListView";
            this.UsersListView.Size = new System.Drawing.Size(156, 284);
            this.UsersListView.TabIndex = 1;
            this.UsersListView.UseCompatibleStateImageBehavior = false;
            this.UsersListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 152;
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button8.Location = new System.Drawing.Point(87, 338);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 5;
            this.button8.Text = "Duplicate";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button7.Location = new System.Drawing.Point(6, 338);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 4;
            this.button7.Text = "Rename";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(87, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(6, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.GeneralTab);
            this.tabControl1.Controls.Add(this.FeaturesTab);
            this.tabControl1.Controls.Add(this.PluginsTab);
            this.tabControl1.Controls.Add(this.CommentTab);
            this.tabControl1.Location = new System.Drawing.Point(174, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(292, 363);
            this.tabControl1.TabIndex = 18;
            // 
            // GeneralTab
            // 
            this.GeneralTab.Controls.Add(this.groupBox2);
            this.GeneralTab.Controls.Add(this.checkBox1);
            this.GeneralTab.Controls.Add(this.label1);
            this.GeneralTab.Controls.Add(this.textBox6);
            this.GeneralTab.Controls.Add(this.groupBox3);
            this.GeneralTab.Location = new System.Drawing.Point(4, 22);
            this.GeneralTab.Name = "GeneralTab";
            this.GeneralTab.Size = new System.Drawing.Size(284, 337);
            this.GeneralTab.TabIndex = 1;
            this.GeneralTab.Text = "General";
            this.GeneralTab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Location = new System.Drawing.Point(6, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 87);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Access";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(6, 65);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(74, 17);
            this.checkBox5.TabIndex = 8;
            this.checkBox5.Text = "All Plugins";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 42);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(75, 17);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "All Presets";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 19);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(81, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "All Features";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 218);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(181, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Allow user to use server as Proxy";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Description:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(12, 193);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(258, 20);
            this.textBox6.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 168);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account Settings";
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Location = new System.Drawing.Point(6, 136);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(258, 20);
            this.textBox7.TabIndex = 8;
            this.textBox7.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Comfirm:";
            // 
            // textBox8
            // 
            this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox8.Location = new System.Drawing.Point(6, 97);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(258, 20);
            this.textBox8.TabIndex = 6;
            this.textBox8.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Password:";
            // 
            // textBox9
            // 
            this.textBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox9.Location = new System.Drawing.Point(6, 55);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(258, 20);
            this.textBox9.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Username:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(102, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Enable Account";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // FeaturesTab
            // 
            this.FeaturesTab.Controls.Add(this.FeaturesListView);
            this.FeaturesTab.Location = new System.Drawing.Point(4, 22);
            this.FeaturesTab.Name = "FeaturesTab";
            this.FeaturesTab.Size = new System.Drawing.Size(284, 337);
            this.FeaturesTab.TabIndex = 2;
            this.FeaturesTab.Text = "Features";
            this.FeaturesTab.UseVisualStyleBackColor = true;
            // 
            // FeaturesListView
            // 
            this.FeaturesListView.CheckBoxes = true;
            this.FeaturesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FeatureNameColumn});
            this.FeaturesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FeaturesListView.ExplorerTheme = false;
            this.FeaturesListView.ExplorerThemeMultiSelect = false;
            this.FeaturesListView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FeaturesListView.FullRowSelect = true;
            this.FeaturesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.FeaturesListView.ItemContextMenuStrip = false;
            listViewItem16.StateImageIndex = 0;
            listViewItem17.StateImageIndex = 0;
            listViewItem18.StateImageIndex = 0;
            listViewItem19.StateImageIndex = 0;
            this.FeaturesListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19});
            this.FeaturesListView.Location = new System.Drawing.Point(0, 0);
            this.FeaturesListView.LockColumnSize = false;
            this.FeaturesListView.MultiSelect = false;
            this.FeaturesListView.Name = "FeaturesListView";
            this.FeaturesListView.Size = new System.Drawing.Size(284, 337);
            this.FeaturesListView.TabIndex = 1;
            this.FeaturesListView.UseCompatibleStateImageBehavior = false;
            this.FeaturesListView.View = System.Windows.Forms.View.Details;
            // 
            // FeatureNameColumn
            // 
            this.FeatureNameColumn.Text = "Feature Name";
            this.FeatureNameColumn.Width = 280;
            // 
            // PluginsTab
            // 
            this.PluginsTab.Controls.Add(this.PluginsListView);
            this.PluginsTab.Location = new System.Drawing.Point(4, 22);
            this.PluginsTab.Name = "PluginsTab";
            this.PluginsTab.Size = new System.Drawing.Size(284, 337);
            this.PluginsTab.TabIndex = 4;
            this.PluginsTab.Text = "Plugins";
            this.PluginsTab.UseVisualStyleBackColor = true;
            // 
            // PluginsListView
            // 
            this.PluginsListView.CheckBoxes = true;
            this.PluginsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PluginNameColumn});
            this.PluginsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PluginsListView.ExplorerTheme = false;
            this.PluginsListView.ExplorerThemeMultiSelect = false;
            this.PluginsListView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PluginsListView.FullRowSelect = true;
            this.PluginsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.PluginsListView.ItemContextMenuStrip = false;
            listViewItem20.StateImageIndex = 0;
            listViewItem21.StateImageIndex = 0;
            listViewItem22.StateImageIndex = 0;
            listViewItem23.StateImageIndex = 0;
            listViewItem24.StateImageIndex = 0;
            listViewItem25.StateImageIndex = 0;
            listViewItem26.StateImageIndex = 0;
            this.PluginsListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem20,
            listViewItem21,
            listViewItem22,
            listViewItem23,
            listViewItem24,
            listViewItem25,
            listViewItem26});
            this.PluginsListView.Location = new System.Drawing.Point(0, 0);
            this.PluginsListView.LockColumnSize = false;
            this.PluginsListView.MultiSelect = false;
            this.PluginsListView.Name = "PluginsListView";
            this.PluginsListView.Size = new System.Drawing.Size(284, 337);
            this.PluginsListView.TabIndex = 1;
            this.PluginsListView.UseCompatibleStateImageBehavior = false;
            this.PluginsListView.View = System.Windows.Forms.View.Details;
            // 
            // PluginNameColumn
            // 
            this.PluginNameColumn.Text = "Plugin Name";
            this.PluginNameColumn.Width = 280;
            // 
            // CommentTab
            // 
            this.CommentTab.Controls.Add(this.textBox10);
            this.CommentTab.Location = new System.Drawing.Point(4, 22);
            this.CommentTab.Name = "CommentTab";
            this.CommentTab.Padding = new System.Windows.Forms.Padding(3);
            this.CommentTab.Size = new System.Drawing.Size(284, 337);
            this.CommentTab.TabIndex = 5;
            this.CommentTab.Text = "Comment";
            this.CommentTab.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            this.textBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox10.Location = new System.Drawing.Point(3, 3);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(278, 331);
            this.textBox10.TabIndex = 1;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Users";
            this.Size = new System.Drawing.Size(545, 433);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.GeneralTab.ResumeLayout(false);
            this.GeneralTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.FeaturesTab.ResumeLayout(false);
            this.PluginsTab.ResumeLayout(false);
            this.CommentTab.ResumeLayout(false);
            this.CommentTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private PpRStandardLib.Controls.FullListView UsersListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage GeneralTab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TabPage FeaturesTab;
        private PpRStandardLib.Controls.FullListView FeaturesListView;
        private System.Windows.Forms.ColumnHeader FeatureNameColumn;
        private System.Windows.Forms.TabPage PluginsTab;
        private PpRStandardLib.Controls.FullListView PluginsListView;
        private System.Windows.Forms.ColumnHeader PluginNameColumn;
        private System.Windows.Forms.TabPage CommentTab;
        private System.Windows.Forms.TextBox textBox10;
    }
}
