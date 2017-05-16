using PpRStandardLib.Controls;
namespace SystemManager_Client
{
    partial class SystemManager
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("HKEY_CLASSES_ROOT");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("HKEY_CURRENT_USER");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("HKEY_LOCAL_MACHINE");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("HKEY_USERS");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("HKEY_CURRENT_CONFIG");
            this.InterfaceTabControl = new System.Windows.Forms.TabControl();
            this.RemoteRegistryTab = new System.Windows.Forms.TabPage();
            this.fullListView1 = new PpRStandardLib.Controls.FullListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fullListView2 = new PpRStandardLib.Controls.FullListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.fullListView3 = new PpRStandardLib.Controls.FullListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.fullListView4 = new PpRStandardLib.Controls.FullListView();
            this.appManDisplayNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.appManVersionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.appManKeyNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.appManPublisherColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.appManInstalledPathColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.appManUninstallCmdLineColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.contextMenu2 = new System.Windows.Forms.ContextMenu();
            this.contextMenu3 = new System.Windows.Forms.ContextMenu();
            this.contextMenu4 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.InterfaceTabControl.SuspendLayout();
            this.RemoteRegistryTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // InterfaceTabControl
            // 
            this.InterfaceTabControl.Controls.Add(this.RemoteRegistryTab);
            this.InterfaceTabControl.Controls.Add(this.tabPage2);
            this.InterfaceTabControl.Controls.Add(this.tabPage1);
            this.InterfaceTabControl.Controls.Add(this.tabPage3);
            this.InterfaceTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InterfaceTabControl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InterfaceTabControl.ItemSize = new System.Drawing.Size(125, 20);
            this.InterfaceTabControl.Location = new System.Drawing.Point(0, 0);
            this.InterfaceTabControl.Name = "InterfaceTabControl";
            this.InterfaceTabControl.SelectedIndex = 0;
            this.InterfaceTabControl.Size = new System.Drawing.Size(827, 461);
            this.InterfaceTabControl.TabIndex = 2;
            this.InterfaceTabControl.TabStop = false;
            // 
            // RemoteRegistryTab
            // 
            this.RemoteRegistryTab.Controls.Add(this.fullListView1);
            this.RemoteRegistryTab.Controls.Add(this.splitter1);
            this.RemoteRegistryTab.Controls.Add(this.treeView1);
            this.RemoteRegistryTab.Location = new System.Drawing.Point(4, 24);
            this.RemoteRegistryTab.Name = "RemoteRegistryTab";
            this.RemoteRegistryTab.Size = new System.Drawing.Size(819, 433);
            this.RemoteRegistryTab.TabIndex = 0;
            this.RemoteRegistryTab.Text = "Remote Registry";
            this.RemoteRegistryTab.UseVisualStyleBackColor = true;
            // 
            // fullListView1
            // 
            this.fullListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.fullListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullListView1.ExplorerTheme = false;
            this.fullListView1.ExplorerThemeMultiSelect = false;
            this.fullListView1.FullRowSelect = true;
            this.fullListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.fullListView1.ItemContextMenuStrip = false;
            this.fullListView1.Location = new System.Drawing.Point(205, 0);
            this.fullListView1.LockColumnSize = false;
            this.fullListView1.Name = "fullListView1";
            this.fullListView1.Size = new System.Drawing.Size(614, 433);
            this.fullListView1.SmallImageList = this.imageList1;
            this.fullListView1.TabIndex = 3;
            this.fullListView1.UseCompatibleStateImageBehavior = false;
            this.fullListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 194;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data";
            this.columnHeader3.Width = 271;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.splitter1.Location = new System.Drawing.Point(201, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 433);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.HideSelection = false;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode1.Text = "HKEY_CLASSES_ROOT";
            treeNode2.Name = "Node1";
            treeNode2.Text = "HKEY_CURRENT_USER";
            treeNode3.Name = "Node2";
            treeNode3.Text = "HKEY_LOCAL_MACHINE";
            treeNode4.Name = "Node3";
            treeNode4.Text = "HKEY_USERS";
            treeNode5.Name = "Node4";
            treeNode5.Text = "HKEY_CURRENT_CONFIG";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(201, 433);
            this.treeView1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.fullListView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(819, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registry Startup";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fullListView2
            // 
            this.fullListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.fullListView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullListView2.ExplorerTheme = false;
            this.fullListView2.ExplorerThemeMultiSelect = false;
            this.fullListView2.FullRowSelect = true;
            this.fullListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.fullListView2.ItemContextMenuStrip = false;
            this.fullListView2.Location = new System.Drawing.Point(0, 0);
            this.fullListView2.LockColumnSize = false;
            this.fullListView2.Name = "fullListView2";
            this.fullListView2.Size = new System.Drawing.Size(819, 433);
            this.fullListView2.SmallImageList = this.imageList1;
            this.fullListView2.TabIndex = 4;
            this.fullListView2.UseCompatibleStateImageBehavior = false;
            this.fullListView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "HKEY Name";
            this.columnHeader4.Width = 194;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Startup Item";
            this.columnHeader5.Width = 135;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Command Line";
            this.columnHeader6.Width = 234;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Regisrty Location";
            this.columnHeader7.Width = 234;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.fullListView3);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(819, 433);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Services Startup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // fullListView3
            // 
            this.fullListView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullListView3.ExplorerTheme = false;
            this.fullListView3.ExplorerThemeMultiSelect = false;
            this.fullListView3.FullRowSelect = true;
            this.fullListView3.ItemContextMenuStrip = false;
            this.fullListView3.Location = new System.Drawing.Point(0, 0);
            this.fullListView3.LockColumnSize = false;
            this.fullListView3.Name = "fullListView3";
            this.fullListView3.Size = new System.Drawing.Size(819, 433);
            this.fullListView3.TabIndex = 0;
            this.fullListView3.UseCompatibleStateImageBehavior = false;
            this.fullListView3.View = System.Windows.Forms.View.Details;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.fullListView4);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(819, 433);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Application Manager";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // fullListView4
            // 
            this.fullListView4.AllowColumnReorder = true;
            this.fullListView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.appManDisplayNameColumn,
            this.appManVersionColumn,
            this.appManKeyNameColumn,
            this.appManPublisherColumn,
            this.appManInstalledPathColumn,
            this.appManUninstallCmdLineColumn});
            this.fullListView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullListView4.ExplorerTheme = false;
            this.fullListView4.ExplorerThemeMultiSelect = false;
            this.fullListView4.FullRowSelect = true;
            this.fullListView4.ItemContextMenuStrip = false;
            this.fullListView4.Location = new System.Drawing.Point(0, 0);
            this.fullListView4.LockColumnSize = false;
            this.fullListView4.Name = "fullListView4";
            this.fullListView4.Size = new System.Drawing.Size(819, 433);
            this.fullListView4.TabIndex = 1;
            this.fullListView4.UseCompatibleStateImageBehavior = false;
            this.fullListView4.View = System.Windows.Forms.View.Details;
            // 
            // appManDisplayNameColumn
            // 
            this.appManDisplayNameColumn.Text = "Display Name";
            this.appManDisplayNameColumn.Width = 143;
            // 
            // appManVersionColumn
            // 
            this.appManVersionColumn.Text = "Version";
            this.appManVersionColumn.Width = 51;
            // 
            // appManKeyNameColumn
            // 
            this.appManKeyNameColumn.DisplayIndex = 3;
            this.appManKeyNameColumn.Text = "Key Name";
            this.appManKeyNameColumn.Width = 159;
            // 
            // appManPublisherColumn
            // 
            this.appManPublisherColumn.DisplayIndex = 2;
            this.appManPublisherColumn.Text = "Publisher";
            this.appManPublisherColumn.Width = 134;
            // 
            // appManInstalledPathColumn
            // 
            this.appManInstalledPathColumn.Text = "Installed Path";
            this.appManInstalledPathColumn.Width = 186;
            // 
            // appManUninstallCmdLineColumn
            // 
            this.appManUninstallCmdLineColumn.Text = "Uninstall Command Line";
            this.appManUninstallCmdLineColumn.Width = 227;
            // 
            // contextMenu4
            // 
            this.contextMenu4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem4,
            this.menuItem6,
            this.menuItem3,
            this.menuItem5});
            // 
            // menuItem1
            // 
            this.menuItem1.DefaultItem = true;
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Refresh";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "-";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Text = "Delete Registry Key";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 3;
            this.menuItem6.Text = "-";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 4;
            this.menuItem3.Text = "Rename Application";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 5;
            this.menuItem5.Text = "Uninstall Application";
            // 
            // SystemManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 461);
            this.Controls.Add(this.InterfaceTabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "SystemManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Manager";
            this.Load += new System.EventHandler(this.SystemManagement_Load);
            this.InterfaceTabControl.ResumeLayout(false);
            this.RemoteRegistryTab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl InterfaceTabControl;
        private System.Windows.Forms.TabPage RemoteRegistryTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TreeView treeView1;
        private FullListView fullListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.ContextMenu contextMenu2;
        private FullListView fullListView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private FullListView fullListView3;
        private FullListView fullListView4;
        private System.Windows.Forms.ColumnHeader appManDisplayNameColumn;
        private System.Windows.Forms.ColumnHeader appManVersionColumn;
        private System.Windows.Forms.ColumnHeader appManKeyNameColumn;
        private System.Windows.Forms.ColumnHeader appManPublisherColumn;
        private System.Windows.Forms.ColumnHeader appManInstalledPathColumn;
        private System.Windows.Forms.ColumnHeader appManUninstallCmdLineColumn;
        private System.Windows.Forms.ContextMenu contextMenu3;
        private System.Windows.Forms.ContextMenu contextMenu4;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem5;

    }
}