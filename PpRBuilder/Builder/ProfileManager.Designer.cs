using PpRBuilder.Controls;
namespace PpRBuilder.Forms
{
    partial class ProfileManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileManager));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Stub 01", "User.ico");
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.LoadProfileMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.EditProfileNameMenuItem = new System.Windows.Forms.MenuItem();
            this.DeleteProfileMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.PasswordLockProfileMenuItem = new System.Windows.Forms.MenuItem();
            this.DisablePasswordProfileMenuItem = new System.Windows.Forms.MenuItem();
            this.InterfaceToolStrip = new System.Windows.Forms.ToolStrip();
            this.BuiltInServerToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.ActiveToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.LockToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.RestartToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.label13 = new System.Windows.Forms.Label();
            this.ProfileManagerListView = new PpRStandardLib.Controls.FullListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InterfaceToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "User.ico");
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.LoadProfileMenuItem,
            this.menuItem2,
            this.EditProfileNameMenuItem,
            this.DeleteProfileMenuItem,
            this.menuItem5,
            this.PasswordLockProfileMenuItem,
            this.DisablePasswordProfileMenuItem});
            // 
            // LoadProfileMenuItem
            // 
            this.LoadProfileMenuItem.Enabled = false;
            this.LoadProfileMenuItem.Index = 0;
            this.LoadProfileMenuItem.Text = "Load Profile";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "-";
            // 
            // EditProfileNameMenuItem
            // 
            this.EditProfileNameMenuItem.Index = 2;
            this.EditProfileNameMenuItem.Text = "Edit Profile Name";
            // 
            // DeleteProfileMenuItem
            // 
            this.DeleteProfileMenuItem.Enabled = false;
            this.DeleteProfileMenuItem.Index = 3;
            this.DeleteProfileMenuItem.Text = "Delete Profile";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 4;
            this.menuItem5.Text = "-";
            // 
            // PasswordLockProfileMenuItem
            // 
            this.PasswordLockProfileMenuItem.Index = 5;
            this.PasswordLockProfileMenuItem.Text = "Password Lock";
            // 
            // DisablePasswordProfileMenuItem
            // 
            this.DisablePasswordProfileMenuItem.Enabled = false;
            this.DisablePasswordProfileMenuItem.Index = 6;
            this.DisablePasswordProfileMenuItem.Text = "Disable Password";
            // 
            // InterfaceToolStrip
            // 
            this.InterfaceToolStrip.GripMargin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.InterfaceToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.InterfaceToolStrip.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.InterfaceToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BuiltInServerToolStripBt,
            this.ToolStripSep1,
            this.ActiveToolStripBt,
            this.LockToolStripBt,
            this.RestartToolStripBt});
            this.InterfaceToolStrip.Location = new System.Drawing.Point(0, 0);
            this.InterfaceToolStrip.Name = "InterfaceToolStrip";
            this.InterfaceToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.InterfaceToolStrip.Size = new System.Drawing.Size(217, 25);
            this.InterfaceToolStrip.Stretch = true;
            this.InterfaceToolStrip.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label13.Location = new System.Drawing.Point(0, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(217, 2);
            this.label13.TabIndex = 88;
            this.label13.Text = "label13";
            // 
            // ProfileManagerListView
            // 
            this.ProfileManagerListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProfileManagerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.ProfileManagerListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfileManagerListView.ExplorerTheme = true;
            this.ProfileManagerListView.ExplorerThemeMultiSelect = true;
            this.ProfileManagerListView.FullRowSelect = true;
            this.ProfileManagerListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ProfileManagerListView.ItemContextMenuStrip = true;
            this.ProfileManagerListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ProfileManagerListView.Location = new System.Drawing.Point(0, 27);
            this.ProfileManagerListView.LockColumnSize = true;
            this.ProfileManagerListView.MultiSelect = false;
            this.ProfileManagerListView.Name = "ProfileManagerListView";
            this.ProfileManagerListView.Size = new System.Drawing.Size(217, 135);
            this.ProfileManagerListView.SmallImageList = this.imageList1;
            this.ProfileManagerListView.TabIndex = 89;
            this.ProfileManagerListView.UseCompatibleStateImageBehavior = false;
            this.ProfileManagerListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Saved Profile";
            this.columnHeader2.Width = 217;
            // 
            // ProfileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 162);
            this.Controls.Add(this.ProfileManagerListView);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.InterfaceToolStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfileManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profile Manager";
            this.Load += new System.EventHandler(this.ProfileManager_Load);
            this.InterfaceToolStrip.ResumeLayout(false);
            this.InterfaceToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem LoadProfileMenuItem;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem EditProfileNameMenuItem;
        private System.Windows.Forms.MenuItem DeleteProfileMenuItem;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem PasswordLockProfileMenuItem;
        private System.Windows.Forms.MenuItem DisablePasswordProfileMenuItem;
        private System.Windows.Forms.ToolStrip InterfaceToolStrip;
        private System.Windows.Forms.ToolStripButton BuiltInServerToolStripBt;
        private System.Windows.Forms.ToolStripSeparator ToolStripSep1;
        private System.Windows.Forms.ToolStripButton ActiveToolStripBt;
        private System.Windows.Forms.ToolStripButton LockToolStripBt;
        private System.Windows.Forms.ToolStripButton RestartToolStripBt;
        private System.Windows.Forms.Label label13;
        private PpRStandardLib.Controls.FullListView ProfileManagerListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}