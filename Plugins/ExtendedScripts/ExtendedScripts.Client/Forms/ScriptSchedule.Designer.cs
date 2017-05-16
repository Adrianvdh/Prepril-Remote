using PpRStandardLib.Controls;
namespace ExtendedScripts_Client
{
    partial class ScriptSchedule
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
            "Dropbox Backup.bat",
            "2014/06/01 11:00:00 PM",
            "Successful",
            "2014/06/02 11:00:00 PM",
            "Ready"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Test.bat",
            "Unknown",
            "Unknown",
            "2014/06/02 06:30:00 PM",
            "Disabled"}, -1);
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OneTimeRadioButton = new System.Windows.Forms.RadioButton();
            this.UserLogOnRadioButton = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.WeeklyRadioButton = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.DisabledRadioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DailyRadioButton = new System.Windows.Forms.RadioButton();
            this.ScheduleContext = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.EnableScheduleCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ScheduleListView = new PpRStandardLib.Controls.FullListView();
            this.ScriptColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastRunColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RunResultColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NextRunColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.projectPanel1 = new PpRStandardLib.Controls.ProjectPanel();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(0, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(577, 2);
            this.label3.TabIndex = 34;
            this.label3.Text = "label3";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button2.Location = new System.Drawing.Point(495, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 23);
            this.dateTimePicker1.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 53;
            this.label1.Text = "Start Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(130, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 54;
            this.label2.Text = "Recur Every:";
            this.label2.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.OneTimeRadioButton);
            this.groupBox1.Controls.Add(this.UserLogOnRadioButton);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.WeeklyRadioButton);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.DisabledRadioButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.DailyRadioButton);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.Location = new System.Drawing.Point(6, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 111);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Events";
            // 
            // OneTimeRadioButton
            // 
            this.OneTimeRadioButton.AutoSize = true;
            this.OneTimeRadioButton.Location = new System.Drawing.Point(129, 19);
            this.OneTimeRadioButton.Name = "OneTimeRadioButton";
            this.OneTimeRadioButton.Size = new System.Drawing.Size(77, 19);
            this.OneTimeRadioButton.TabIndex = 62;
            this.OneTimeRadioButton.TabStop = true;
            this.OneTimeRadioButton.Text = "One Time";
            this.OneTimeRadioButton.UseVisualStyleBackColor = true;
            this.OneTimeRadioButton.CheckedChanged += new System.EventHandler(this.OneTimeRadioButton_CheckedChanged);
            // 
            // UserLogOnRadioButton
            // 
            this.UserLogOnRadioButton.AutoSize = true;
            this.UserLogOnRadioButton.Location = new System.Drawing.Point(212, 19);
            this.UserLogOnRadioButton.Name = "UserLogOnRadioButton";
            this.UserLogOnRadioButton.Size = new System.Drawing.Size(104, 19);
            this.UserLogOnRadioButton.TabIndex = 61;
            this.UserLogOnRadioButton.TabStop = true;
            this.UserLogOnRadioButton.Text = "When I Log On";
            this.UserLogOnRadioButton.UseVisualStyleBackColor = true;
            this.UserLogOnRadioButton.CheckedChanged += new System.EventHandler(this.UserLogOnRadioButton_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.checkBox4);
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Controls.Add(this.checkBox2);
            this.flowLayoutPanel1.Controls.Add(this.checkBox3);
            this.flowLayoutPanel1.Controls.Add(this.checkBox5);
            this.flowLayoutPanel1.Controls.Add(this.checkBox6);
            this.flowLayoutPanel1.Controls.Add(this.checkBox7);
            this.flowLayoutPanel1.Enabled = false;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 84);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(556, 25);
            this.flowLayoutPanel1.TabIndex = 60;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(3, 3);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(65, 19);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Sunday";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(74, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 19);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Monday";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(150, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(70, 19);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Tuesday";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(226, 3);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(87, 19);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Wednesday";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(319, 3);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(75, 19);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Text = "Thursday";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(400, 3);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(58, 19);
            this.checkBox6.TabIndex = 7;
            this.checkBox6.Text = "Friday";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(464, 3);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(72, 19);
            this.checkBox7.TabIndex = 8;
            this.checkBox7.Text = "Saturday";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // WeeklyRadioButton
            // 
            this.WeeklyRadioButton.AutoSize = true;
            this.WeeklyRadioButton.Location = new System.Drawing.Point(63, 19);
            this.WeeklyRadioButton.Name = "WeeklyRadioButton";
            this.WeeklyRadioButton.Size = new System.Drawing.Size(63, 19);
            this.WeeklyRadioButton.TabIndex = 59;
            this.WeeklyRadioButton.TabStop = true;
            this.WeeklyRadioButton.Text = "Weekly";
            this.WeeklyRadioButton.UseVisualStyleBackColor = true;
            this.WeeklyRadioButton.CheckedChanged += new System.EventHandler(this.WeeklyRadioButton_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(484, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 58;
            this.button3.Text = "Run Now";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // DisabledRadioButton
            // 
            this.DisabledRadioButton.AutoSize = true;
            this.DisabledRadioButton.Location = new System.Drawing.Point(322, 19);
            this.DisabledRadioButton.Name = "DisabledRadioButton";
            this.DisabledRadioButton.Size = new System.Drawing.Size(70, 19);
            this.DisabledRadioButton.TabIndex = 57;
            this.DisabledRadioButton.Text = "Disabled";
            this.DisabledRadioButton.UseVisualStyleBackColor = true;
            this.DisabledRadioButton.CheckedChanged += new System.EventHandler(this.DisabledRadioButton_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(189, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 56;
            this.label5.Text = "Week(s) On:";
            this.label5.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(133, 61);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 23);
            this.textBox1.TabIndex = 55;
            this.textBox1.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(553, 2);
            this.label4.TabIndex = 54;
            this.label4.Text = "label4";
            // 
            // DailyRadioButton
            // 
            this.DailyRadioButton.AutoSize = true;
            this.DailyRadioButton.Checked = true;
            this.DailyRadioButton.Location = new System.Drawing.Point(6, 19);
            this.DailyRadioButton.Name = "DailyRadioButton";
            this.DailyRadioButton.Size = new System.Drawing.Size(51, 19);
            this.DailyRadioButton.TabIndex = 0;
            this.DailyRadioButton.TabStop = true;
            this.DailyRadioButton.Text = "Daily";
            this.DailyRadioButton.UseVisualStyleBackColor = true;
            this.DailyRadioButton.CheckedChanged += new System.EventHandler(this.DailyRadioButton_CheckedChanged);
            // 
            // ScheduleContext
            // 
            this.ScheduleContext.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem3,
            this.menuItem2});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Remove Selected";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "-";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.Text = "Select All";
            // 
            // EnableScheduleCheckBox
            // 
            this.EnableScheduleCheckBox.AutoSize = true;
            this.EnableScheduleCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EnableScheduleCheckBox.Location = new System.Drawing.Point(6, 39);
            this.EnableScheduleCheckBox.Name = "EnableScheduleCheckBox";
            this.EnableScheduleCheckBox.Size = new System.Drawing.Size(150, 19);
            this.EnableScheduleCheckBox.TabIndex = 57;
            this.EnableScheduleCheckBox.Text = "Enable Schedule Scripts";
            this.EnableScheduleCheckBox.UseVisualStyleBackColor = true;
            this.EnableScheduleCheckBox.CheckedChanged += new System.EventHandler(this.EnableScheduleCheckBox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.Location = new System.Drawing.Point(414, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ScheduleListView
            // 
            this.ScheduleListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScheduleListView.CheckBoxes = true;
            this.ScheduleListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ScriptColumn,
            this.LastRunColumn,
            this.RunResultColumn,
            this.NextRunColumn,
            this.StatusColumn});
            this.ScheduleListView.Enabled = false;
            this.ScheduleListView.ExplorerTheme = true;
            this.ScheduleListView.ExplorerThemeMultiSelect = true;
            this.ScheduleListView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ScheduleListView.FullRowSelect = true;
            this.ScheduleListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ScheduleListView.ItemContextMenuStrip = true;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            this.ScheduleListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.ScheduleListView.Location = new System.Drawing.Point(6, 60);
            this.ScheduleListView.LockColumnSize = true;
            this.ScheduleListView.MultiSelect = false;
            this.ScheduleListView.Name = "ScheduleListView";
            this.ScheduleListView.Size = new System.Drawing.Size(565, 173);
            this.ScheduleListView.TabIndex = 62;
            this.ScheduleListView.UseCompatibleStateImageBehavior = false;
            this.ScheduleListView.View = System.Windows.Forms.View.Details;
            this.ScheduleListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ScheduleListView_ColumnWidthChanging);
            this.ScheduleListView.SelectedIndexChanged += new System.EventHandler(this.ScheduleListView_SelectedIndexChanged);
            // 
            // ScriptColumn
            // 
            this.ScriptColumn.Text = "Script";
            this.ScriptColumn.Width = 147;
            // 
            // LastRunColumn
            // 
            this.LastRunColumn.Text = "Last Run";
            this.LastRunColumn.Width = 139;
            // 
            // RunResultColumn
            // 
            this.RunResultColumn.Text = "Run Result";
            this.RunResultColumn.Width = 72;
            // 
            // NextRunColumn
            // 
            this.NextRunColumn.Text = "Next Run";
            this.NextRunColumn.Width = 139;
            // 
            // StatusColumn
            // 
            this.StatusColumn.Text = "Status";
            this.StatusColumn.Width = 64;
            // 
            // projectPanel1
            // 
            this.projectPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectPanel1.Enabled = false;
            this.projectPanel1.Location = new System.Drawing.Point(0, 0);
            this.projectPanel1.MinimumSize = new System.Drawing.Size(300, 36);
            this.projectPanel1.Name = "projectPanel1";
            this.projectPanel1.Size = new System.Drawing.Size(576, 37);
            this.projectPanel1.TabIndex = 61;
            // 
            // ScriptSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 385);
            this.Controls.Add(this.ScheduleListView);
            this.Controls.Add(this.projectPanel1);
            this.Controls.Add(this.EnableScheduleCheckBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(426, 320);
            this.Name = "ScriptSchedule";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Server Script Schedule";
            this.Load += new System.EventHandler(this.ScriptSchedule_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton DailyRadioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenu ScheduleContext;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.RadioButton DisabledRadioButton;
        private System.Windows.Forms.CheckBox EnableScheduleCheckBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private ProjectPanel projectPanel1;
        private FullListView ScheduleListView;
        private System.Windows.Forms.ColumnHeader ScriptColumn;
        private System.Windows.Forms.ColumnHeader LastRunColumn;
        private System.Windows.Forms.ColumnHeader RunResultColumn;
        private System.Windows.Forms.ColumnHeader NextRunColumn;
        private System.Windows.Forms.ColumnHeader StatusColumn;
        private System.Windows.Forms.RadioButton WeeklyRadioButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton UserLogOnRadioButton;
        private System.Windows.Forms.RadioButton OneTimeRadioButton;
    }
}