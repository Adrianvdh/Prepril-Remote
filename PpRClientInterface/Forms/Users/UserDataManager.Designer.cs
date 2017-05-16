using PpRStandardLib.Controls;
namespace PpRClientInterface.Forms
{
    partial class UserDataBackup
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
            "",
            "2014/06/03 11:00:00 PM",
            "758 KB"}, -1);
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.userDataFields1 = new PpRStandardLib.Controls.UserDataFields();
            this.BackupRecordsListView = new PpRStandardLib.Controls.FullListView();
            this.BackupRecordColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BackupDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeColumn1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button3.Location = new System.Drawing.Point(192, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 23);
            this.button3.TabIndex = 58;
            this.button3.Text = "Create Full Backup";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.Location = new System.Drawing.Point(311, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "Restore Selected";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button2.Location = new System.Drawing.Point(6, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 60;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // userDataFields1
            // 
            this.userDataFields1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userDataFields1.Location = new System.Drawing.Point(418, 6);
            this.userDataFields1.Name = "userDataFields1";
            this.userDataFields1.Size = new System.Drawing.Size(256, 270);
            this.userDataFields1.TabIndex = 66;
            // 
            // BackupRecordsListView
            // 
            this.BackupRecordsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BackupRecordColumn,
            this.BackupDateColumn,
            this.SizeColumn1});
            this.BackupRecordsListView.ExplorerTheme = true;
            this.BackupRecordsListView.ExplorerThemeMultiSelect = true;
            this.BackupRecordsListView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BackupRecordsListView.FullRowSelect = true;
            this.BackupRecordsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.BackupRecordsListView.ItemContextMenuStrip = true;
            this.BackupRecordsListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.BackupRecordsListView.Location = new System.Drawing.Point(6, 6);
            this.BackupRecordsListView.LockColumnSize = true;
            this.BackupRecordsListView.MultiSelect = false;
            this.BackupRecordsListView.Name = "BackupRecordsListView";
            this.BackupRecordsListView.Size = new System.Drawing.Size(406, 241);
            this.BackupRecordsListView.TabIndex = 67;
            this.BackupRecordsListView.UseCompatibleStateImageBehavior = false;
            this.BackupRecordsListView.View = System.Windows.Forms.View.Details;
            this.BackupRecordsListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.BackupRecordsListView_ColumnWidthChanging);
            // 
            // BackupRecordColumn
            // 
            this.BackupRecordColumn.Text = "Backup Record";
            this.BackupRecordColumn.Width = 203;
            // 
            // BackupDateColumn
            // 
            this.BackupDateColumn.Text = "Backup Date";
            this.BackupDateColumn.Width = 139;
            // 
            // SizeColumn1
            // 
            this.SizeColumn1.Text = "Size";
            // 
            // UserDataBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 312);
            this.Controls.Add(this.BackupRecordsListView);
            this.Controls.Add(this.userDataFields1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserDataBackup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Data Backup And Restore";
            this.Load += new System.EventHandler(this.UserDataBackup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private UserDataFields userDataFields1;
        private FullListView BackupRecordsListView;
        private System.Windows.Forms.ColumnHeader BackupRecordColumn;
        private System.Windows.Forms.ColumnHeader BackupDateColumn;
        private System.Windows.Forms.ColumnHeader SizeColumn1;
    }
}