using PreprilRemoteClient.Controls;
namespace MSReader_Client
{
    partial class MSReader
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Hello, this is a test message",
            "2014/03/13 10:05:57 PM"}, -1);
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.menuItem18 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem19 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.VoiceListContext = new System.Windows.Forms.ContextMenu();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.projectPanel1 = new ProjectPanel();
            this.MSReaderListView = new FullListView();
            this.MessageColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button3.Location = new System.Drawing.Point(462, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "+/Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Enabled = false;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button6.Location = new System.Drawing.Point(462, 104);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Speak";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button5.Location = new System.Drawing.Point(462, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Remove";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem10,
            this.menuItem7});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem17,
            this.menuItem18,
            this.menuItem2,
            this.menuItem3,
            this.menuItem4,
            this.menuItem6});
            this.menuItem1.Text = "File";
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 0;
            this.menuItem17.Text = "Open Text File";
            // 
            // menuItem18
            // 
            this.menuItem18.Index = 1;
            this.menuItem18.Text = "-";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.Text = "Export Project";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 3;
            this.menuItem3.Text = "Import Project";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 4;
            this.menuItem4.Text = "-";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 5;
            this.menuItem6.Text = "Exit";
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 1;
            this.menuItem10.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem11,
            this.menuItem19});
            this.menuItem10.Text = "Mode";
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 0;
            this.menuItem11.RadioCheck = true;
            this.menuItem11.Text = "Save";
            // 
            // menuItem19
            // 
            this.menuItem19.Checked = true;
            this.menuItem19.Index = 1;
            this.menuItem19.RadioCheck = true;
            this.menuItem19.Text = "Load";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 2;
            this.menuItem7.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem8,
            this.menuItem9});
            this.menuItem7.Text = "Saved";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 0;
            this.menuItem8.Text = "Delete Save";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 1;
            this.menuItem9.Text = "Delete All";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox2.Location = new System.Drawing.Point(5, 233);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(451, 23);
            this.textBox2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(5, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(532, 2);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button2.Location = new System.Drawing.Point(462, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.Location = new System.Drawing.Point(381, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Enabled = false;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button7.Location = new System.Drawing.Point(462, 71);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 4;
            this.button7.Text = "Edit";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(462, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 2);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // VoiceListContext
            // 
            this.VoiceListContext.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem5,
            this.menuItem13,
            this.menuItem12,
            this.menuItem14,
            this.menuItem16,
            this.menuItem15});
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 0;
            this.menuItem5.Text = "Copy Message";
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 1;
            this.menuItem13.Text = "-";
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 2;
            this.menuItem12.Text = "Remove";
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 3;
            this.menuItem14.Text = "Edit";
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 4;
            this.menuItem16.Text = "-";
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 5;
            this.menuItem15.Text = "Speak";
            // 
            // projectPanel1
            // 
            this.projectPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectPanel1.Location = new System.Drawing.Point(0, 0);
            this.projectPanel1.MinimumSize = new System.Drawing.Size(400, 37);
            this.projectPanel1.Name = "projectPanel1";
            this.projectPanel1.Size = new System.Drawing.Size(542, 37);
            this.projectPanel1.TabIndex = 34;
            // 
            // MSReaderListView
            // 
            this.MSReaderListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MSReaderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MessageColumn,
            this.AddedColumn});
            this.MSReaderListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.MSReaderListView.ExplorerTheme = false;
            this.MSReaderListView.ExplorerThemeMultiSelect = false;
            this.MSReaderListView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MSReaderListView.FullRowSelect = true;
            this.MSReaderListView.ItemContextMenuStrip = false;
            listViewItem1.StateImageIndex = 0;
            this.MSReaderListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.MSReaderListView.LabelEdit = true;
            this.MSReaderListView.Location = new System.Drawing.Point(5, 43);
            this.MSReaderListView.LockColumnSize = false;
            this.MSReaderListView.MultiSelect = false;
            this.MSReaderListView.Name = "MSReaderListView";
            this.MSReaderListView.ShowItemToolTips = true;
            this.MSReaderListView.Size = new System.Drawing.Size(451, 186);
            this.MSReaderListView.TabIndex = 35;
            this.MSReaderListView.TileSize = new System.Drawing.Size(320, 54);
            this.MSReaderListView.UseCompatibleStateImageBehavior = false;
            this.MSReaderListView.View = System.Windows.Forms.View.Details;
            this.MSReaderListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.VoiceListView_ColumnWidthChanging);
            this.MSReaderListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MSReaderListView_MouseUp);
            // 
            // MessageColumn
            // 
            this.MessageColumn.Text = "Message";
            this.MessageColumn.Width = 307;
            // 
            // AddedColumn
            // 
            this.AddedColumn.Text = "Added";
            this.AddedColumn.Width = 140;
            // 
            // MSReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 295);
            this.Controls.Add(this.MSReaderListView);
            this.Controls.Add(this.projectPanel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 333);
            this.Name = "MSReader";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MS Reader (Connection ID : 149901-08ZA1135)";
            this.Load += new System.EventHandler(this.Stubspeak_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenu VoiceListContext;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem13;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.MenuItem menuItem14;
        private System.Windows.Forms.MenuItem menuItem16;
        private System.Windows.Forms.MenuItem menuItem15;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem17;
        private System.Windows.Forms.MenuItem menuItem18;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem menuItem19;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem9;
        private ProjectPanel projectPanel1;
        private FullListView MSReaderListView;
        private System.Windows.Forms.ColumnHeader MessageColumn;
        private System.Windows.Forms.ColumnHeader AddedColumn;


    }
}