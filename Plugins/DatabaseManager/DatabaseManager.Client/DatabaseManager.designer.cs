using PpRStandardLib.Controls;
namespace DatabaseManager_Client
{
    partial class DatabaseManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseManager));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Client Installers");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Plugin Releases");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Project Controller");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Releases", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Server");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Stub Servers");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Users");
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Advertiser",
            "Advertiser.xml",
            "1 KB",
            "2014/05/17 ‏‎06:35:58 PM",
            "2014/06/04 ‏‎02:29:19 PM"}, "Text File.ico");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "BrowserHistoryViewer",
            "BrowserHistoryViewer.xml",
            "844 bytes",
            "2014/05/23 ‏‎07:26:51 PM",
            "2014/06/04 ‏02:30:19 PM"}, "Text File.ico");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "CdRomEjector",
            "CdRomEjector.xml",
            "1.10 KB",
            "2014/05/04 ‏‎04:47:47 PM",
            "2014/06/04 ‏‎02:31:14 PM"}, "Text File.ico");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "ClientInstallersReleaseUpdates",
            "ClientInstallersReleaseUpdates.xml",
            "642 bytes",
            "2014/05/04 ‏‎04:47:47 PM",
            "2014/06/04 ‏‎02:32:04 PM"}, "Text File.ico");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Computer+",
            "Computer+.xml",
            "791 bytes",
            "2014/05/24 ‏‎03:15:46 PM",
            "2014/06/04 ‏‎02:32:50 PM"}, "Text File.ico");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "vtExtender",
            "vtExtender.xml",
            "340 bytes",
            "2014/06/03 ‏‎11:38:34 PM",
            "2014/06/05 ‏‎10:44:54 PM"}, "Text File.ico");
            this.MainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem23 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.EditMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem26 = new System.Windows.Forms.MenuItem();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.sDbListContext = new System.Windows.Forms.ContextMenu();
            this.menuItem19 = new System.Windows.Forms.MenuItem();
            this.menuItem18 = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.menuItem20 = new System.Windows.Forms.MenuItem();
            this.menuItem21 = new System.Windows.Forms.MenuItem();
            this.menuItem22 = new System.Windows.Forms.MenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.sDbTreeView = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.sDbListView = new PpRStandardLib.Controls.FullListView();
            this.sDbNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sDbFileNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sDbSizeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sDbDateCreatedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sDbLastModifiedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem10,
            this.menuItem2,
            this.menuItem26});
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 0;
            this.menuItem10.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem9,
            this.menuItem23,
            this.menuItem13,
            this.menuItem16});
            this.menuItem10.Text = "File";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 0;
            this.menuItem9.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem11,
            this.menuItem12});
            this.menuItem9.Text = "Export";
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 0;
            this.menuItem11.Text = "Single File";
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 1;
            this.menuItem12.Text = "All -> ZIP";
            // 
            // menuItem23
            // 
            this.menuItem23.Index = 1;
            this.menuItem23.Text = "Import";
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 2;
            this.menuItem13.Text = "-";
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 3;
            this.menuItem16.Text = "Exit";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4,
            this.menuItem5,
            this.menuItem7,
            this.EditMenuItem});
            this.menuItem2.Text = "Database";
            // 
            // menuItem4
            // 
            this.menuItem4.Enabled = false;
            this.menuItem4.Index = 0;
            this.menuItem4.Text = "Delete";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.Text = "-";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 2;
            this.menuItem7.Text = "Rename";
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.Index = 3;
            this.EditMenuItem.Text = "Edit";
            this.EditMenuItem.Click += new System.EventHandler(this.EditMenuItem_Click);
            // 
            // menuItem26
            // 
            this.menuItem26.Index = 2;
            this.menuItem26.Text = "Tools";
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 474);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(880, 22);
            this.statusBar1.TabIndex = 1;
            this.statusBar1.Text = "statusBar1";
            // 
            // sDbListContext
            // 
            this.sDbListContext.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem19,
            this.menuItem18,
            this.menuItem17,
            this.menuItem20,
            this.menuItem21,
            this.menuItem22});
            // 
            // menuItem19
            // 
            this.menuItem19.Enabled = false;
            this.menuItem19.Index = 0;
            this.menuItem19.Text = "Edit";
            // 
            // menuItem18
            // 
            this.menuItem18.Index = 1;
            this.menuItem18.Text = "-";
            // 
            // menuItem17
            // 
            this.menuItem17.Enabled = false;
            this.menuItem17.Index = 2;
            this.menuItem17.Text = "Delete";
            // 
            // menuItem20
            // 
            this.menuItem20.Index = 3;
            this.menuItem20.Text = "-";
            // 
            // menuItem21
            // 
            this.menuItem21.Enabled = false;
            this.menuItem21.Index = 4;
            this.menuItem21.Text = "Export";
            // 
            // menuItem22
            // 
            this.menuItem22.Enabled = false;
            this.menuItem22.Index = 5;
            this.menuItem22.Text = "Import";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Folder.ico");
            this.imageList1.Images.SetKeyName(1, "Database.ico");
            this.imageList1.Images.SetKeyName(2, "Text File.ico");
            // 
            // sDbTreeView
            // 
            this.sDbTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.sDbTreeView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sDbTreeView.HideSelection = false;
            this.sDbTreeView.ImageIndex = 0;
            this.sDbTreeView.ImageList = this.imageList1;
            this.sDbTreeView.Location = new System.Drawing.Point(0, 0);
            this.sDbTreeView.Name = "sDbTreeView";
            treeNode1.Name = "Node3";
            treeNode1.Text = "Client Installers";
            treeNode2.Name = "Node10";
            treeNode2.Text = "Plugin Releases";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Project Controller";
            treeNode4.Name = "Node2";
            treeNode4.Text = "Releases";
            treeNode5.Name = "Node19";
            treeNode5.Text = "Server";
            treeNode6.Name = "Node20";
            treeNode6.Text = "Stub Servers";
            treeNode7.Name = "Node22";
            treeNode7.Text = "Users";
            this.sDbTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            this.sDbTreeView.SelectedImageIndex = 0;
            this.sDbTreeView.Size = new System.Drawing.Size(216, 474);
            this.sDbTreeView.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.splitter1.Location = new System.Drawing.Point(216, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 474);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // sDbListView
            // 
            this.sDbListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sDbNameColumn,
            this.sDbFileNameColumn,
            this.sDbSizeColumn,
            this.sDbDateCreatedColumn,
            this.sDbLastModifiedColumn});
            this.sDbListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sDbListView.ExplorerTheme = false;
            this.sDbListView.ExplorerThemeMultiSelect = false;
            this.sDbListView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sDbListView.FullRowSelect = true;
            this.sDbListView.ItemContextMenuStrip = false;
            this.sDbListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.sDbListView.Location = new System.Drawing.Point(219, 0);
            this.sDbListView.LockColumnSize = false;
            this.sDbListView.MultiSelect = false;
            this.sDbListView.Name = "sDbListView";
            this.sDbListView.Size = new System.Drawing.Size(661, 474);
            this.sDbListView.SmallImageList = this.imageList1;
            this.sDbListView.TabIndex = 4;
            this.sDbListView.UseCompatibleStateImageBehavior = false;
            this.sDbListView.View = System.Windows.Forms.View.Details;
            // 
            // sDbNameColumn
            // 
            this.sDbNameColumn.Text = "Database Name";
            this.sDbNameColumn.Width = 150;
            // 
            // sDbFileNameColumn
            // 
            this.sDbFileNameColumn.Text = "File Name";
            this.sDbFileNameColumn.Width = 150;
            // 
            // sDbSizeColumn
            // 
            this.sDbSizeColumn.Text = "Size";
            this.sDbSizeColumn.Width = 65;
            // 
            // sDbDateCreatedColumn
            // 
            this.sDbDateCreatedColumn.Text = "Date Created";
            this.sDbDateCreatedColumn.Width = 140;
            // 
            // sDbLastModifiedColumn
            // 
            this.sDbLastModifiedColumn.Text = "Last Modified";
            this.sDbLastModifiedColumn.Width = 140;
            // 
            // DatabaseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 496);
            this.Controls.Add(this.sDbListView);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.sDbTreeView);
            this.Controls.Add(this.statusBar1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1082, 836);
            this.Menu = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(499, 329);
            this.Name = "DatabaseManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Manager";
            this.Load += new System.EventHandler(this.DatabaseManager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu MainMenu;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem menuItem16;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.ContextMenu sDbListContext;
        private System.Windows.Forms.MenuItem menuItem17;
        private System.Windows.Forms.MenuItem menuItem18;
        private System.Windows.Forms.MenuItem menuItem19;
        private System.Windows.Forms.MenuItem menuItem20;
        private System.Windows.Forms.MenuItem menuItem21;
        private System.Windows.Forms.MenuItem menuItem22;
        private System.Windows.Forms.MenuItem menuItem26;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem EditMenuItem;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.MenuItem menuItem13;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuItem menuItem23;
        private System.Windows.Forms.TreeView sDbTreeView;
        private System.Windows.Forms.Splitter splitter1;
        private FullListView sDbListView;
        private System.Windows.Forms.ColumnHeader sDbNameColumn;
        private System.Windows.Forms.ColumnHeader sDbFileNameColumn;
        private System.Windows.Forms.ColumnHeader sDbSizeColumn;
        private System.Windows.Forms.ColumnHeader sDbDateCreatedColumn;
        private System.Windows.Forms.ColumnHeader sDbLastModifiedColumn;
    }
}