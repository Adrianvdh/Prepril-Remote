using PpRStandardLib.Controls;
namespace MediaManager_Client
{
    partial class MediaManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaManager));
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Branson");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Received Files", new System.Windows.Forms.TreeNode[] {
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("RDP Recordings");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Webcam Recordings");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Sound Recordings");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Screenshots");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Connection ID: 149901-08ZA1135",
            "Webcam Capture",
            "Lenght: 00:01:45"}, "2_2014-07-19_02-05-00_large.jpg");
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.PlayMenuItem = new System.Windows.Forms.MenuItem();
            this.PlayDefaultMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.OpenFolderMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.CopyToMenuItem = new System.Windows.Forms.MenuItem();
            this.MoveToMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.ArchiveMenuItem = new System.Windows.Forms.MenuItem();
            this.DeleteMenuItem = new System.Windows.Forms.MenuItem();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DisconnectToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.ReconnectToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.vistaMenu1 = new wyDay.Controls.VistaMenu(this.components);
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.MediaListView = new FullListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vistaMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.PlayMenuItem,
            this.PlayDefaultMenuItem,
            this.menuItem3,
            this.OpenFolderMenuItem,
            this.menuItem7,
            this.CopyToMenuItem,
            this.MoveToMenuItem,
            this.menuItem12,
            this.menuItem1,
            this.menuItem14,
            this.menuItem6,
            this.ArchiveMenuItem,
            this.DeleteMenuItem});
            // 
            // PlayMenuItem
            // 
            this.PlayMenuItem.DefaultItem = true;
            this.PlayMenuItem.Index = 0;
            this.PlayMenuItem.Text = "Play";
            this.PlayMenuItem.Click += new System.EventHandler(this.PlayMenuItem_Click);
            // 
            // PlayDefaultMenuItem
            // 
            this.PlayDefaultMenuItem.Index = 1;
            this.PlayDefaultMenuItem.Text = "Play with &Default player";
            this.PlayDefaultMenuItem.Click += new System.EventHandler(this.PlayDefaultMenuItem_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "-";
            // 
            // OpenFolderMenuItem
            // 
            this.OpenFolderMenuItem.Index = 3;
            this.OpenFolderMenuItem.Text = "Open Folder Location...";
            this.OpenFolderMenuItem.Click += new System.EventHandler(this.OpenFolderMenuItem_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 4;
            this.menuItem7.Text = "-";
            // 
            // CopyToMenuItem
            // 
            this.CopyToMenuItem.Index = 5;
            this.CopyToMenuItem.Text = "Copy to...";
            this.CopyToMenuItem.Click += new System.EventHandler(this.CopyToMenuItem_Click);
            // 
            // MoveToMenuItem
            // 
            this.MoveToMenuItem.Index = 6;
            this.MoveToMenuItem.Text = "Move to..";
            this.MoveToMenuItem.Click += new System.EventHandler(this.MoveToMenuItem_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 7;
            this.menuItem12.Text = "-";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 8;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem13,
            this.menuItem4,
            this.menuItem5,
            this.menuItem8,
            this.menuItem9,
            this.menuItem11});
            this.menuItem1.Text = "Send to";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "Skype";
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 1;
            this.menuItem13.Text = "Dropbox";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Text = "-";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 3;
            this.menuItem5.Text = "Branson";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 4;
            this.menuItem8.Text = "(user)";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 5;
            this.menuItem9.Text = "(user)";
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 6;
            this.menuItem11.Text = "(user)";
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 9;
            this.menuItem14.Text = "Generate URL...";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 10;
            this.menuItem6.Text = "-";
            // 
            // ArchiveMenuItem
            // 
            this.ArchiveMenuItem.Index = 11;
            this.ArchiveMenuItem.Text = "Archive";
            this.ArchiveMenuItem.Click += new System.EventHandler(this.ArchiveMenuItem_Click);
            // 
            // DeleteMenuItem
            // 
            this.DeleteMenuItem.Index = 12;
            this.DeleteMenuItem.Text = "Delete";
            this.DeleteMenuItem.Click += new System.EventHandler(this.DeleteMenuItem_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 472);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(805, 22);
            this.statusBar1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 409);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 63);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(0, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(805, 2);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "2_2014-07-19_02-05-00_large.jpg");
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 50;
            this.toolTip1.ShowAlways = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(805, 29);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 8;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(22, 22);
            this.toolStripButton1.Text = "Play";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(22, 22);
            this.toolStripButton2.Text = "Play";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(22, 22);
            this.toolStripButton3.Text = "Select All";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // DisconnectToolStripBt
            // 
            this.DisconnectToolStripBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DisconnectToolStripBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DisconnectToolStripBt.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
            this.DisconnectToolStripBt.Name = "DisconnectToolStripBt";
            this.DisconnectToolStripBt.Size = new System.Drawing.Size(23, 26);
            this.DisconnectToolStripBt.Text = "Disconnect";
            this.DisconnectToolStripBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DisconnectToolStripBt.ToolTipText = "Disconnects from current server connection";
            // 
            // ReconnectToolStripBt
            // 
            this.ReconnectToolStripBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ReconnectToolStripBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReconnectToolStripBt.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.ReconnectToolStripBt.Name = "ReconnectToolStripBt";
            this.ReconnectToolStripBt.Size = new System.Drawing.Size(23, 26);
            this.ReconnectToolStripBt.Text = "Disconnect";
            this.ReconnectToolStripBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ReconnectToolStripBt.ToolTipText = "Reconnect to the last used server";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 26);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // vistaMenu1
            // 
            this.vistaMenu1.ContainerControl = this;
            // 
            // splitter2
            // 
            this.splitter2.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.splitter2.Location = new System.Drawing.Point(198, 29);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 378);
            this.splitter2.TabIndex = 12;
            this.splitter2.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.treeView1.FullRowSelect = true;
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(0, 29);
            this.treeView1.Name = "treeView1";
            treeNode19.Name = "Node2";
            treeNode19.Text = "Branson";
            treeNode20.Name = "Node0";
            treeNode20.Text = "Received Files";
            treeNode21.Name = "Node0";
            treeNode21.Text = "RDP Recordings";
            treeNode22.Name = "Node1";
            treeNode22.Text = "Webcam Recordings";
            treeNode23.Name = "Node0";
            treeNode23.Text = "Sound Recordings";
            treeNode24.Name = "Node1";
            treeNode24.Text = "Screenshots";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24});
            this.treeView1.Size = new System.Drawing.Size(198, 378);
            this.treeView1.TabIndex = 11;
            // 
            // MediaListView
            // 
            this.MediaListView.AllowColumnReorder = true;
            this.MediaListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.MediaListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MediaListView.ExplorerTheme = false;
            this.MediaListView.ExplorerThemeMultiSelect = false;
            this.MediaListView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MediaListView.FullRowSelect = true;
            this.MediaListView.ItemContextMenuStrip = false;
            listViewItem2.StateImageIndex = 0;
            listViewItem2.ToolTipText = "Length: 00:01:45";
            this.MediaListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.MediaListView.LargeImageList = this.imageList1;
            this.MediaListView.Location = new System.Drawing.Point(201, 29);
            this.MediaListView.LockColumnSize = false;
            this.MediaListView.Name = "MediaListView";
            this.MediaListView.ShowItemToolTips = true;
            this.MediaListView.Size = new System.Drawing.Size(604, 378);
            this.MediaListView.SmallImageList = this.imageList1;
            this.MediaListView.TabIndex = 13;
            this.MediaListView.TileSize = new System.Drawing.Size(320, 54);
            this.MediaListView.UseCompatibleStateImageBehavior = false;
            this.MediaListView.ItemActivate += new System.EventHandler(this.MediaListView_ItemActivate);
            this.MediaListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MediaListView_MouseUp);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 137;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 137;
            // 
            // MediaManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 494);
            this.Controls.Add(this.MediaListView);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusBar1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "MediaManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Manager";
            this.Load += new System.EventHandler(this.ThumbnailManager_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vistaMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem PlayDefaultMenuItem;
        private System.Windows.Forms.MenuItem PlayMenuItem;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuItem OpenFolderMenuItem;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem CopyToMenuItem;
        private System.Windows.Forms.MenuItem MoveToMenuItem;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem ArchiveMenuItem;
        private System.Windows.Forms.MenuItem DeleteMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem12;
        private wyDay.Controls.VistaMenu vistaMenu1;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem menuItem13;
        private System.Windows.Forms.MenuItem menuItem14;
        private FullListView MediaListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton DisconnectToolStripBt;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton ReconnectToolStripBt;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}