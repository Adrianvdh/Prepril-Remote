using PpRStandardLib.Controls;
using PpRStandardLib.Controls;
namespace DDOS_Client
{
    partial class DDOSTaskListView
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "149901-08ZA1135",
            "New Stub",
            "New Group",
            "25000",
            "Infinite"}, -1);
            this.listView1 = new FullListView();
            this.ConnectionIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GroupColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BytesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PacketsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.StubDDOSTaskPropertiesMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.RemoveStubMenuItem = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ConnectionIDColumn,
            this.NameColumn,
            this.GroupColumn,
            this.BytesColumn,
            this.PacketsColumn});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.ExplorerTheme = false;
            this.listView1.ExplorerThemeMultiSelect = false;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.listView1.FullRowSelect = true;
            this.listView1.ItemContextMenuStrip = false;
            listViewItem1.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.LockColumnSize = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(485, 278);
            this.listView1.TabIndex = 1;
            this.listView1.TileSize = new System.Drawing.Size(320, 54);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ConnectionIDColumn
            // 
            this.ConnectionIDColumn.Text = "Connection ID";
            this.ConnectionIDColumn.Width = 119;
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 97;
            // 
            // GroupColumn
            // 
            this.GroupColumn.Text = "Group";
            this.GroupColumn.Width = 147;
            // 
            // BytesColumn
            // 
            this.BytesColumn.Text = "Bytes";
            this.BytesColumn.Width = 58;
            // 
            // PacketsColumn
            // 
            this.PacketsColumn.Text = "Packets";
            this.PacketsColumn.Width = 58;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.StubDDOSTaskPropertiesMenuItem,
            this.menuItem12,
            this.menuItem3,
            this.menuItem7,
            this.menuItem11,
            this.RemoveStubMenuItem});
            // 
            // StubDDOSTaskPropertiesMenuItem
            // 
            this.StubDDOSTaskPropertiesMenuItem.Index = 0;
            this.StubDDOSTaskPropertiesMenuItem.Text = "Task Properties";
            this.StubDDOSTaskPropertiesMenuItem.Click += new System.EventHandler(this.StubDDOSTaskPropertiesMenuItem_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 1;
            this.menuItem12.Text = "-";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4,
            this.menuItem5,
            this.menuItem6});
            this.menuItem3.Text = "Move";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.Text = "(Tab1)";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.Text = "(Tab1)";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 2;
            this.menuItem6.Text = "(Tab1)";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 3;
            this.menuItem7.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem8,
            this.menuItem9,
            this.menuItem10});
            this.menuItem7.Text = "Copy";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 0;
            this.menuItem8.Text = "(Tab1)";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 1;
            this.menuItem9.Text = "(Tab1)";
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 2;
            this.menuItem10.Text = "(Tab1)";
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 4;
            this.menuItem11.Text = "-";
            // 
            // RemoveStubMenuItem
            // 
            this.RemoveStubMenuItem.Index = 5;
            this.RemoveStubMenuItem.Text = "Remove";
            this.RemoveStubMenuItem.Click += new System.EventHandler(this.RemoveStubMenuItem_Click);
            // 
            // DDOSTaskListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Name = "DDOSTaskListView";
            this.Size = new System.Drawing.Size(485, 278);
            this.Load += new System.EventHandler(this.ServicesListView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FullListView listView1;
        private System.Windows.Forms.ColumnHeader ConnectionIDColumn;
        private System.Windows.Forms.ColumnHeader GroupColumn;
        private System.Windows.Forms.ColumnHeader BytesColumn;
        private System.Windows.Forms.ColumnHeader PacketsColumn;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem StubDDOSTaskPropertiesMenuItem;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem RemoveStubMenuItem;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.ColumnHeader NameColumn;
    }
}
