namespace Chat_Client
{
    partial class UserChat
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Branson");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("[03:50 PM] Admin> Hi Branson! This is a test...");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserChat));
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ConnectedUsersListView = new PpRStandardLib.Controls.FullListView();
            this.ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.linkLabel23 = new wyDay.Controls.LinkLabel2();
            this.linkLabel22 = new wyDay.Controls.LinkLabel2();
            this.linkLabel21 = new wyDay.Controls.LinkLabel2();
            this.ChatContextMenu = new System.Windows.Forms.ContextMenu();
            this.MessageColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.linkLabel24 = new wyDay.Controls.LinkLabel2();
            this.label2 = new System.Windows.Forms.Label();
            this.UserChatListView = new PpRStandardLib.Controls.FullListView();
            this.MainStatusBar = new System.Windows.Forms.StatusBar();
            this.ConnectedBarPanel = new System.Windows.Forms.StatusBarPanel();
            this.ConnectedVarBarPanel = new System.Windows.Forms.StatusBarPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectedBarPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectedVarBarPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // menuItem1
            // 
            this.menuItem1.Enabled = false;
            this.menuItem1.Index = 1;
            this.menuItem1.Text = "Clear Chat";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.Location = new System.Drawing.Point(147, 293);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 23);
            this.textBox1.TabIndex = 102;
            // 
            // ConnectedUsersListView
            // 
            this.ConnectedUsersListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ConnectedUsersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader});
            this.ConnectedUsersListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ConnectedUsersListView.ExplorerTheme = false;
            this.ConnectedUsersListView.ExplorerThemeMultiSelect = false;
            this.ConnectedUsersListView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConnectedUsersListView.FullRowSelect = true;
            this.ConnectedUsersListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ConnectedUsersListView.ItemContextMenuStrip = false;
            this.ConnectedUsersListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ConnectedUsersListView.Location = new System.Drawing.Point(5, 21);
            this.ConnectedUsersListView.LockColumnSize = false;
            this.ConnectedUsersListView.MultiSelect = false;
            this.ConnectedUsersListView.Name = "ConnectedUsersListView";
            this.ConnectedUsersListView.ShowItemToolTips = true;
            this.ConnectedUsersListView.Size = new System.Drawing.Size(136, 296);
            this.ConnectedUsersListView.TabIndex = 105;
            this.ConnectedUsersListView.TileSize = new System.Drawing.Size(320, 54);
            this.ConnectedUsersListView.UseCompatibleStateImageBehavior = false;
            this.ConnectedUsersListView.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader
            // 
            this.ColumnHeader.Text = "Column Header";
            this.ColumnHeader.Width = 132;
            // 
            // menuItem2
            // 
            this.menuItem2.Enabled = false;
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "Copy";
            // 
            // linkLabel23
            // 
            this.linkLabel23.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkLabel23.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabel23.HoverColor = System.Drawing.Color.Red;
            this.linkLabel23.Location = new System.Drawing.Point(384, 3);
            this.linkLabel23.Name = "linkLabel23";
            this.linkLabel23.RegularColor = System.Drawing.Color.Empty;
            this.linkLabel23.Size = new System.Drawing.Size(67, 16);
            this.linkLabel23.TabIndex = 108;
            this.linkLabel23.Text = "7 Days Ago";
            // 
            // linkLabel22
            // 
            this.linkLabel22.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkLabel22.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabel22.HoverColor = System.Drawing.Color.Red;
            this.linkLabel22.Location = new System.Drawing.Point(319, 3);
            this.linkLabel22.Name = "linkLabel22";
            this.linkLabel22.RegularColor = System.Drawing.Color.Empty;
            this.linkLabel22.Size = new System.Drawing.Size(59, 16);
            this.linkLabel22.TabIndex = 107;
            this.linkLabel22.Text = "Yesterday";
            // 
            // linkLabel21
            // 
            this.linkLabel21.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkLabel21.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabel21.HoverColor = System.Drawing.Color.Red;
            this.linkLabel21.Location = new System.Drawing.Point(272, 3);
            this.linkLabel21.Name = "linkLabel21";
            this.linkLabel21.RegularColor = System.Drawing.Color.Empty;
            this.linkLabel21.Size = new System.Drawing.Size(41, 16);
            this.linkLabel21.TabIndex = 106;
            this.linkLabel21.Text = "Today";
            // 
            // ChatContextMenu
            // 
            this.ChatContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem1});
            // 
            // MessageColumn
            // 
            this.MessageColumn.Text = "Message";
            this.MessageColumn.Width = 408;
            // 
            // linkLabel24
            // 
            this.linkLabel24.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkLabel24.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabel24.HoverColor = System.Drawing.Color.Red;
            this.linkLabel24.Location = new System.Drawing.Point(457, 3);
            this.linkLabel24.Name = "linkLabel24";
            this.linkLabel24.RegularColor = System.Drawing.Color.Empty;
            this.linkLabel24.Size = new System.Drawing.Size(22, 16);
            this.linkLabel24.TabIndex = 109;
            this.linkLabel24.Text = "All";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(2, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 99;
            this.label2.Text = "Other Users:";
            // 
            // UserChatListView
            // 
            this.UserChatListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserChatListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MessageColumn});
            this.UserChatListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.UserChatListView.ExplorerTheme = false;
            this.UserChatListView.ExplorerThemeMultiSelect = false;
            this.UserChatListView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UserChatListView.FullRowSelect = true;
            this.UserChatListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.UserChatListView.ItemContextMenuStrip = false;
            this.UserChatListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.UserChatListView.Location = new System.Drawing.Point(147, 21);
            this.UserChatListView.LockColumnSize = false;
            this.UserChatListView.MultiSelect = false;
            this.UserChatListView.Name = "UserChatListView";
            this.UserChatListView.ShowItemToolTips = true;
            this.UserChatListView.Size = new System.Drawing.Size(412, 266);
            this.UserChatListView.TabIndex = 101;
            this.UserChatListView.TileSize = new System.Drawing.Size(320, 54);
            this.UserChatListView.UseCompatibleStateImageBehavior = false;
            this.UserChatListView.View = System.Windows.Forms.View.Details;
            // 
            // MainStatusBar
            // 
            this.MainStatusBar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainStatusBar.Location = new System.Drawing.Point(0, 322);
            this.MainStatusBar.Name = "MainStatusBar";
            this.MainStatusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.ConnectedBarPanel,
            this.ConnectedVarBarPanel});
            this.MainStatusBar.ShowPanels = true;
            this.MainStatusBar.Size = new System.Drawing.Size(564, 20);
            this.MainStatusBar.SizingGrip = false;
            this.MainStatusBar.TabIndex = 104;
            this.MainStatusBar.Text = "MainStatusBar";
            // 
            // ConnectedBarPanel
            // 
            this.ConnectedBarPanel.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
            this.ConnectedBarPanel.Name = "ConnectedBarPanel";
            this.ConnectedBarPanel.Text = "Connected:";
            this.ConnectedBarPanel.Width = 65;
            // 
            // ConnectedVarBarPanel
            // 
            this.ConnectedVarBarPanel.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
            this.ConnectedVarBarPanel.Name = "ConnectedVarBarPanel";
            this.ConnectedVarBarPanel.Text = "0";
            this.ConnectedVarBarPanel.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(144, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 100;
            this.label1.Text = "Show messages from:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.Location = new System.Drawing.Point(484, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 103;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UserChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 342);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ConnectedUsersListView);
            this.Controls.Add(this.linkLabel23);
            this.Controls.Add(this.linkLabel22);
            this.Controls.Add(this.linkLabel21);
            this.Controls.Add(this.linkLabel24);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserChatListView);
            this.Controls.Add(this.MainStatusBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Chat";
            this.Load += new System.EventHandler(this.UserChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConnectedBarPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectedVarBarPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.TextBox textBox1;
        private PpRStandardLib.Controls.FullListView ConnectedUsersListView;
        private System.Windows.Forms.ColumnHeader ColumnHeader;
        private System.Windows.Forms.MenuItem menuItem2;
        private wyDay.Controls.LinkLabel2 linkLabel23;
        private wyDay.Controls.LinkLabel2 linkLabel22;
        private wyDay.Controls.LinkLabel2 linkLabel21;
        private System.Windows.Forms.ContextMenu ChatContextMenu;
        private System.Windows.Forms.ColumnHeader MessageColumn;
        private wyDay.Controls.LinkLabel2 linkLabel24;
        private System.Windows.Forms.Label label2;
        private PpRStandardLib.Controls.FullListView UserChatListView;
        private System.Windows.Forms.StatusBar MainStatusBar;
        private System.Windows.Forms.StatusBarPanel ConnectedBarPanel;
        private System.Windows.Forms.StatusBarPanel ConnectedVarBarPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;

    }
}