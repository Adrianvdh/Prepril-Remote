using PpRStandardLib.Controls;
namespace PpRServerInterface.Forms
{
    partial class StubsProperties
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "DDOS",
            "116",
            "Running",
            "00:09:31",
            "Adrian",
            "04:57:51 PM"}, "Application.ico");
            this.label9 = new System.Windows.Forms.Label();
            this.EnvironmentTab = new System.Windows.Forms.TabPage();
            this.FullListView1 = new PpRStandardLib.Controls.FullListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.PermissionsTab = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.GeneralTab = new System.Windows.Forms.TabPage();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.StatisticsTab = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TasksTab = new System.Windows.Forms.TabPage();
            this.TsksLstVw = new PpRStandardLib.Controls.FullListView();
            this.columnHeader170 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader171 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DurationColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader172 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader173 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BuildTypeTab = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.EnvironmentTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.GeneralTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.StatisticsTab.SuspendLayout();
            this.TasksTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(6, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 15);
            this.label9.TabIndex = 179;
            this.label9.Text = "Connection ID:";
            // 
            // EnvironmentTab
            // 
            this.EnvironmentTab.Controls.Add(this.FullListView1);
            this.EnvironmentTab.Controls.Add(this.groupBox1);
            this.EnvironmentTab.Location = new System.Drawing.Point(4, 24);
            this.EnvironmentTab.Name = "EnvironmentTab";
            this.EnvironmentTab.Size = new System.Drawing.Size(483, 432);
            this.EnvironmentTab.TabIndex = 1;
            this.EnvironmentTab.Text = "Environment";
            this.EnvironmentTab.UseVisualStyleBackColor = true;
            // 
            // FullListView1
            // 
            this.FullListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.FullListView1.ExplorerTheme = false;
            this.FullListView1.ExplorerThemeMultiSelect = false;
            this.FullListView1.FullRowSelect = true;
            this.FullListView1.ItemContextMenuStrip = false;
            this.FullListView1.Location = new System.Drawing.Point(15, 233);
            this.FullListView1.LockColumnSize = false;
            this.FullListView1.Name = "FullListView1";
            this.FullListView1.Size = new System.Drawing.Size(416, 132);
            this.FullListView1.TabIndex = 190;
            this.FullListView1.UseCompatibleStateImageBehavior = false;
            this.FullListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 193;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 204;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Location = new System.Drawing.Point(6, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 209);
            this.groupBox1.TabIndex = 189;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.Window;
            this.label21.Location = new System.Drawing.Point(6, 123);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 15);
            this.label21.TabIndex = 175;
            this.label21.Text = "Password:";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(101, 161);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(321, 15);
            this.textBox4.TabIndex = 188;
            this.textBox4.Text = "x";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.BackColor = System.Drawing.SystemColors.Window;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label15.Location = new System.Drawing.Point(9, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(355, 2);
            this.label15.TabIndex = 176;
            this.label15.Text = "label15";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(6, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 15);
            this.label13.TabIndex = 181;
            this.label13.Text = "Version:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.Window;
            this.label23.Location = new System.Drawing.Point(6, 104);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 15);
            this.label23.TabIndex = 174;
            this.label23.Text = "Username:";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.BackColor = System.Drawing.SystemColors.Window;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(101, 142);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(321, 15);
            this.textBox5.TabIndex = 184;
            this.textBox5.Text = "x";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.Window;
            this.label17.Location = new System.Drawing.Point(6, 142);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 15);
            this.label17.TabIndex = 177;
            this.label17.Text = "Running OS:";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.BackColor = System.Drawing.SystemColors.Window;
            this.label14.Location = new System.Drawing.Point(98, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(324, 15);
            this.label14.TabIndex = 187;
            this.label14.Text = "x";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(98, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(324, 15);
            this.label11.TabIndex = 185;
            this.label11.Text = "x";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.BackColor = System.Drawing.SystemColors.Window;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(101, 123);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(321, 15);
            this.textBox6.TabIndex = 183;
            this.textBox6.Text = "x";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.Window;
            this.label19.Location = new System.Drawing.Point(6, 161);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 15);
            this.label19.TabIndex = 178;
            this.label19.Text = "EPID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(6, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 15);
            this.label10.TabIndex = 180;
            this.label10.Text = "IP Address:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(98, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(324, 15);
            this.label12.TabIndex = 186;
            this.label12.Text = "x";
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.BackColor = System.Drawing.SystemColors.Window;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(101, 104);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(321, 15);
            this.textBox7.TabIndex = 182;
            this.textBox7.Text = "x";
            // 
            // PermissionsTab
            // 
            this.PermissionsTab.Location = new System.Drawing.Point(4, 24);
            this.PermissionsTab.Name = "PermissionsTab";
            this.PermissionsTab.Size = new System.Drawing.Size(483, 432);
            this.PermissionsTab.TabIndex = 3;
            this.PermissionsTab.Text = "Permissions";
            this.PermissionsTab.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ping refresh rate:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.GeneralTab);
            this.tabControl1.Controls.Add(this.StatisticsTab);
            this.tabControl1.Controls.Add(this.TasksTab);
            this.tabControl1.Controls.Add(this.EnvironmentTab);
            this.tabControl1.Controls.Add(this.PermissionsTab);
            this.tabControl1.Controls.Add(this.BuildTypeTab);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabControl1.ItemSize = new System.Drawing.Size(49, 20);
            this.tabControl1.Location = new System.Drawing.Point(6, 6);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(9, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(491, 460);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 12;
            // 
            // GeneralTab
            // 
            this.GeneralTab.Controls.Add(this.domainUpDown1);
            this.GeneralTab.Controls.Add(this.label7);
            this.GeneralTab.Controls.Add(this.label8);
            this.GeneralTab.Controls.Add(this.groupBox2);
            this.GeneralTab.Location = new System.Drawing.Point(4, 24);
            this.GeneralTab.Name = "GeneralTab";
            this.GeneralTab.Size = new System.Drawing.Size(483, 432);
            this.GeneralTab.TabIndex = 0;
            this.GeneralTab.Text = "General";
            this.GeneralTab.UseVisualStyleBackColor = true;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(26, 176);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 23);
            this.domainUpDown1.TabIndex = 10;
            this.domainUpDown1.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "seconds";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(6, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 104);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(7, 37);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(226, 23);
            this.textBox3.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 15);
            this.label16.TabIndex = 6;
            this.label16.Text = "Name:";
            // 
            // StatisticsTab
            // 
            this.StatisticsTab.Controls.Add(this.groupBox3);
            this.StatisticsTab.Location = new System.Drawing.Point(4, 24);
            this.StatisticsTab.Name = "StatisticsTab";
            this.StatisticsTab.Size = new System.Drawing.Size(483, 432);
            this.StatisticsTab.TabIndex = 4;
            this.StatisticsTab.Text = "Statistics";
            this.StatisticsTab.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(6, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(189, 189);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // TasksTab
            // 
            this.TasksTab.Controls.Add(this.TsksLstVw);
            this.TasksTab.Location = new System.Drawing.Point(4, 24);
            this.TasksTab.Name = "TasksTab";
            this.TasksTab.Size = new System.Drawing.Size(483, 432);
            this.TasksTab.TabIndex = 6;
            this.TasksTab.Text = "Tasks";
            this.TasksTab.UseVisualStyleBackColor = true;
            // 
            // TsksLstVw
            // 
            this.TsksLstVw.AllowColumnReorder = true;
            this.TsksLstVw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TsksLstVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader170,
            this.PIDColumn,
            this.columnHeader171,
            this.DurationColumn,
            this.columnHeader172,
            this.columnHeader173});
            this.TsksLstVw.ExplorerTheme = false;
            this.TsksLstVw.ExplorerThemeMultiSelect = false;
            this.TsksLstVw.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TsksLstVw.FullRowSelect = true;
            this.TsksLstVw.ItemContextMenuStrip = false;
            listViewItem3.StateImageIndex = 0;
            this.TsksLstVw.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.TsksLstVw.Location = new System.Drawing.Point(2, 3);
            this.TsksLstVw.LockColumnSize = false;
            this.TsksLstVw.Name = "TsksLstVw";
            this.TsksLstVw.Size = new System.Drawing.Size(477, 426);
            this.TsksLstVw.TabIndex = 7;
            this.TsksLstVw.UseCompatibleStateImageBehavior = false;
            this.TsksLstVw.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader170
            // 
            this.columnHeader170.Text = "Name";
            this.columnHeader170.Width = 115;
            // 
            // PIDColumn
            // 
            this.PIDColumn.Text = "PID";
            this.PIDColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PIDColumn.Width = 44;
            // 
            // columnHeader171
            // 
            this.columnHeader171.Text = "Status";
            this.columnHeader171.Width = 82;
            // 
            // DurationColumn
            // 
            this.DurationColumn.Text = "Duration";
            // 
            // columnHeader172
            // 
            this.columnHeader172.DisplayIndex = 5;
            this.columnHeader172.Text = "Owner";
            this.columnHeader172.Width = 86;
            // 
            // columnHeader173
            // 
            this.columnHeader173.DisplayIndex = 4;
            this.columnHeader173.Text = "Added";
            this.columnHeader173.Width = 80;
            // 
            // BuildTypeTab
            // 
            this.BuildTypeTab.Location = new System.Drawing.Point(4, 24);
            this.BuildTypeTab.Name = "BuildTypeTab";
            this.BuildTypeTab.Size = new System.Drawing.Size(483, 432);
            this.BuildTypeTab.TabIndex = 5;
            this.BuildTypeTab.Text = "Build Type";
            this.BuildTypeTab.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button2.Location = new System.Drawing.Point(421, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3,
            this.menuItem4,
            this.menuItem5,
            this.menuItem6,
            this.menuItem7,
            this.menuItem8});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Terminate";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "Suspend";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "Resume";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 3;
            this.menuItem4.Text = "-";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 4;
            this.menuItem5.Text = "Properties";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 5;
            this.menuItem6.Text = "-";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 6;
            this.menuItem7.Text = "Copy (Column)";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 7;
            this.menuItem8.Text = "Copy";
            // 
            // StubsProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 499);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StubsProperties";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "(Connection ID : 149901-08ZA1135) Properties";
            this.Load += new System.EventHandler(this.StubsProperties_Load);
            this.EnvironmentTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.GeneralTab.ResumeLayout(false);
            this.GeneralTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.StatisticsTab.ResumeLayout(false);
            this.TasksTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage EnvironmentTab;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TabPage PermissionsTab;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage GeneralTab;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage StatisticsTab;
        private System.Windows.Forms.TabPage BuildTypeTab;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private PpRStandardLib.Controls.FullListView FullListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TabPage TasksTab;
        private FullListView TsksLstVw;
        private System.Windows.Forms.ColumnHeader columnHeader170;
        private System.Windows.Forms.ColumnHeader PIDColumn;
        private System.Windows.Forms.ColumnHeader columnHeader171;
        private System.Windows.Forms.ColumnHeader DurationColumn;
        private System.Windows.Forms.ColumnHeader columnHeader172;
        private System.Windows.Forms.ColumnHeader columnHeader173;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;

    }
}