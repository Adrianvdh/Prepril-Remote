using PpRStandardLib.Controls;
namespace NppExtendedScripts
{
    partial class Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("dropboxBackup.bat");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Project \'Dropbox Backup\'", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ConnectServerToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.CreateNewToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSep3 = new System.Windows.Forms.ToolStripSeparator();
            this.ExeLocalToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.ExeRemoteToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSep4 = new System.Windows.Forms.ToolStripSeparator();
            this.ReloadServerToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.SyncServerToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSep5 = new System.Windows.Forms.ToolStripSeparator();
            this.DelToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSep6 = new System.Windows.Forms.ToolStripSeparator();
            this.ModeToggleToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.OutPanelToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSep7 = new System.Windows.Forms.ToolStripSeparator();
            this.OptionsToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSep8 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ProjectTreeViewContext = new System.Windows.Forms.ContextMenu();
            this.ProjectTreeView = new System.Windows.Forms.TreeView();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowItemReorder = true;
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectServerToolStripBt,
            this.ToolStripSep2,
            this.CreateNewToolStripBt,
            this.ToolStripSep3,
            this.ExeLocalToolStripBt,
            this.ExeRemoteToolStripBt,
            this.ToolStripSep4,
            this.ReloadServerToolStripBt,
            this.SyncServerToolStripBt,
            this.ToolStripSep5,
            this.DelToolStripBt,
            this.ToolStripSep6,
            this.ModeToggleToolStripBt,
            this.OutPanelToolStripBt,
            this.ToolStripSep7,
            this.OptionsToolStripBt,
            this.ToolStripSep8,
            this.AboutToolStripBt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(525, 26);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ConnectServerToolStripBt
            // 
            this.ConnectServerToolStripBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ConnectServerToolStripBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConnectServerToolStripBt.Name = "ConnectServerToolStripBt";
            this.ConnectServerToolStripBt.Size = new System.Drawing.Size(23, 23);
            this.ConnectServerToolStripBt.Text = "Connect";
            this.ConnectServerToolStripBt.ToolTipText = "Connect to a server";
            this.ConnectServerToolStripBt.Click += new System.EventHandler(this.ConnectServerToolStripBt_Click);
            // 
            // ToolStripSep2
            // 
            this.ToolStripSep2.Name = "ToolStripSep2";
            this.ToolStripSep2.Size = new System.Drawing.Size(6, 26);
            // 
            // CreateNewToolStripBt
            // 
            this.CreateNewToolStripBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CreateNewToolStripBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateNewToolStripBt.Name = "CreateNewToolStripBt";
            this.CreateNewToolStripBt.Size = new System.Drawing.Size(23, 23);
            this.CreateNewToolStripBt.Text = "New";
            this.CreateNewToolStripBt.ToolTipText = "Create new script";
            this.CreateNewToolStripBt.Click += new System.EventHandler(this.CreateNewToolStripBt_Click);
            // 
            // ToolStripSep3
            // 
            this.ToolStripSep3.Name = "ToolStripSep3";
            this.ToolStripSep3.Size = new System.Drawing.Size(6, 26);
            // 
            // ExeLocalToolStripBt
            // 
            this.ExeLocalToolStripBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExeLocalToolStripBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExeLocalToolStripBt.Name = "ExeLocalToolStripBt";
            this.ExeLocalToolStripBt.Size = new System.Drawing.Size(23, 23);
            this.ExeLocalToolStripBt.Text = "Execute Script";
            this.ExeLocalToolStripBt.ToolTipText = "Execute current script";
            this.ExeLocalToolStripBt.Click += new System.EventHandler(this.ExeLocalToolStripBt_Click);
            // 
            // ExeRemoteToolStripBt
            // 
            this.ExeRemoteToolStripBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExeRemoteToolStripBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExeRemoteToolStripBt.Name = "ExeRemoteToolStripBt";
            this.ExeRemoteToolStripBt.Size = new System.Drawing.Size(23, 23);
            this.ExeRemoteToolStripBt.Text = "Execute Script";
            this.ExeRemoteToolStripBt.ToolTipText = "Execute current script on server";
            this.ExeRemoteToolStripBt.Click += new System.EventHandler(this.ExeRemoteToolStripBt_Click);
            // 
            // ToolStripSep4
            // 
            this.ToolStripSep4.Name = "ToolStripSep4";
            this.ToolStripSep4.Size = new System.Drawing.Size(6, 26);
            // 
            // ReloadServerToolStripBt
            // 
            this.ReloadServerToolStripBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ReloadServerToolStripBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReloadServerToolStripBt.Name = "ReloadServerToolStripBt";
            this.ReloadServerToolStripBt.Size = new System.Drawing.Size(23, 23);
            this.ReloadServerToolStripBt.Text = "Reload";
            this.ReloadServerToolStripBt.ToolTipText = "Reload script from server";
            this.ReloadServerToolStripBt.Click += new System.EventHandler(this.ReloadServerToolStripBt_Click);
            // 
            // SyncServerToolStripBt
            // 
            this.SyncServerToolStripBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SyncServerToolStripBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SyncServerToolStripBt.Name = "SyncServerToolStripBt";
            this.SyncServerToolStripBt.Size = new System.Drawing.Size(23, 23);
            this.SyncServerToolStripBt.Text = "Sync";
            this.SyncServerToolStripBt.ToolTipText = "Sync script with server";
            this.SyncServerToolStripBt.Click += new System.EventHandler(this.SyncServerToolStripBt_Click);
            // 
            // ToolStripSep5
            // 
            this.ToolStripSep5.Name = "ToolStripSep5";
            this.ToolStripSep5.Size = new System.Drawing.Size(6, 26);
            // 
            // DelToolStripBt
            // 
            this.DelToolStripBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DelToolStripBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DelToolStripBt.Name = "DelToolStripBt";
            this.DelToolStripBt.Size = new System.Drawing.Size(23, 23);
            this.DelToolStripBt.Text = "Delete Project";
            this.DelToolStripBt.ToolTipText = "Delete Project\r\nDel";
            this.DelToolStripBt.Click += new System.EventHandler(this.DelToolStripBt_Click);
            // 
            // ToolStripSep6
            // 
            this.ToolStripSep6.Name = "ToolStripSep6";
            this.ToolStripSep6.Size = new System.Drawing.Size(6, 26);
            // 
            // ModeToggleToolStripBt
            // 
            this.ModeToggleToolStripBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ModeToggleToolStripBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ModeToggleToolStripBt.Name = "ModeToggleToolStripBt";
            this.ModeToggleToolStripBt.Size = new System.Drawing.Size(23, 23);
            this.ModeToggleToolStripBt.Text = "Mode";
            this.ModeToggleToolStripBt.ToolTipText = "Toggle save/load mode";
            this.ModeToggleToolStripBt.Click += new System.EventHandler(this.ModeToggleToolStripBt_Click);
            // 
            // OutPanelToolStripBt
            // 
            this.OutPanelToolStripBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OutPanelToolStripBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OutPanelToolStripBt.Name = "OutPanelToolStripBt";
            this.OutPanelToolStripBt.Size = new System.Drawing.Size(23, 23);
            this.OutPanelToolStripBt.Text = "Output Panel";
            this.OutPanelToolStripBt.ToolTipText = "Toggle server output panel visibility";
            this.OutPanelToolStripBt.Click += new System.EventHandler(this.OutPanelToolStripBt_Click);
            // 
            // ToolStripSep7
            // 
            this.ToolStripSep7.Name = "ToolStripSep7";
            this.ToolStripSep7.Size = new System.Drawing.Size(6, 26);
            // 
            // OptionsToolStripBt
            // 
            this.OptionsToolStripBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OptionsToolStripBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OptionsToolStripBt.Name = "OptionsToolStripBt";
            this.OptionsToolStripBt.Size = new System.Drawing.Size(23, 23);
            this.OptionsToolStripBt.Text = "Options";
            this.OptionsToolStripBt.ToolTipText = "Show options dialog";
            this.OptionsToolStripBt.Click += new System.EventHandler(this.OptionsToolStripBt_Click);
            // 
            // ToolStripSep8
            // 
            this.ToolStripSep8.Name = "ToolStripSep8";
            this.ToolStripSep8.Size = new System.Drawing.Size(6, 26);
            // 
            // AboutToolStripBt
            // 
            this.AboutToolStripBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AboutToolStripBt.Image = ((System.Drawing.Image)(resources.GetObject("AboutToolStripBt.Image")));
            this.AboutToolStripBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutToolStripBt.Name = "AboutToolStripBt";
            this.AboutToolStripBt.Size = new System.Drawing.Size(23, 23);
            this.AboutToolStripBt.Text = "About";
            this.AboutToolStripBt.ToolTipText = "About Project Controller-Script plugin";
            this.AboutToolStripBt.Click += new System.EventHandler(this.AboutToolStripBt_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Folder.ico");
            this.imageList1.Images.SetKeyName(1, "Script.ico");
            // 
            // ProjectTreeView
            // 
            this.ProjectTreeView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProjectTreeView.ImageIndex = 0;
            this.ProjectTreeView.ImageList = this.imageList1;
            this.ProjectTreeView.Location = new System.Drawing.Point(12, 108);
            this.ProjectTreeView.Name = "ProjectTreeView";
            treeNode3.ImageKey = "Script.ico";
            treeNode3.Name = "Node1";
            treeNode3.Text = "dropboxBackup.bat";
            treeNode4.ImageKey = "Folder.ico";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Project \'Dropbox Backup\'";
            this.ProjectTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.ProjectTreeView.SelectedImageIndex = 0;
            this.ProjectTreeView.Size = new System.Drawing.Size(458, 168);
            this.ProjectTreeView.TabIndex = 4;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 322);
            this.Controls.Add(this.ProjectTreeView);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Interface";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NppExtendedScripts";
            this.Load += new System.EventHandler(this.Interface_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ExeLocalToolStripBt;
        private System.Windows.Forms.ToolStripButton DelToolStripBt;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenu ProjectTreeViewContext;
        private System.Windows.Forms.ToolStripSeparator ToolStripSep6;
        private System.Windows.Forms.ToolStripButton AboutToolStripBt;
        private System.Windows.Forms.ToolStripButton ExeRemoteToolStripBt;
        private System.Windows.Forms.ToolStripSeparator ToolStripSep4;
        private System.Windows.Forms.ToolStripButton CreateNewToolStripBt;
        private System.Windows.Forms.ToolStripSeparator ToolStripSep3;
        private System.Windows.Forms.ToolStripButton ReloadServerToolStripBt;
        private System.Windows.Forms.ToolStripButton SyncServerToolStripBt;
        private System.Windows.Forms.ToolStripSeparator ToolStripSep5;
        private System.Windows.Forms.ToolStripButton ConnectServerToolStripBt;
        private System.Windows.Forms.ToolStripSeparator ToolStripSep2;
        private System.Windows.Forms.ToolStripButton OutPanelToolStripBt;
        private System.Windows.Forms.ToolStripSeparator ToolStripSep7;
        private System.Windows.Forms.ToolStripButton OptionsToolStripBt;
        private System.Windows.Forms.ToolStripButton ModeToggleToolStripBt;
        private System.Windows.Forms.ToolStripSeparator ToolStripSep8;
        private System.Windows.Forms.TreeView ProjectTreeView;

    }
}