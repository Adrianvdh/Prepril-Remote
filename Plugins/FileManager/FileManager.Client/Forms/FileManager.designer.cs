namespace FileManager_Client
{
    partial class FileManager
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
            this.MainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem18 = new System.Windows.Forms.MenuItem();
            this.menuItem39 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.MainStatusBar = new System.Windows.Forms.StatusBar();
            this.QueuedBarPanel = new System.Windows.Forms.StatusBarPanel();
            this.SuccessfulBarPanel = new System.Windows.Forms.StatusBarPanel();
            this.FailedBarPanel = new System.Windows.Forms.StatusBarPanel();
            this.SpeedBarPanel = new System.Windows.Forms.StatusBarPanel();
            this.TrnsfrUxTbCntrl = new VSControls.UxTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tLocalFileColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tDirectionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tRemoteFileColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tStatusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tSizeColumng = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tTransferedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tSpeedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.vistaMenu1 = new wyDay.Controls.VistaMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.QueuedBarPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuccessfulBarPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailedBarPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBarPanel)).BeginInit();
            this.TrnsfrUxTbCntrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vistaMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem18,
            this.menuItem5,
            this.menuItem6});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem4,
            this.menuItem7,
            this.menuItem3});
            this.menuItem1.Text = "File";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "New Tab";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.Text = "Close Tab";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 2;
            this.menuItem7.Text = "-";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 3;
            this.menuItem3.Text = "Close";
            // 
            // menuItem18
            // 
            this.menuItem18.Index = 1;
            this.menuItem18.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem39});
            this.menuItem18.Text = "View";
            // 
            // menuItem39
            // 
            this.menuItem39.Enabled = false;
            this.menuItem39.Index = 0;
            this.menuItem39.Shortcut = System.Windows.Forms.Shortcut.F5;
            this.menuItem39.Text = "Refresh";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 2;
            this.menuItem5.Text = "Transfer";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 3;
            this.menuItem6.Text = "Server";
            // 
            // MainStatusBar
            // 
            this.MainStatusBar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainStatusBar.Location = new System.Drawing.Point(0, 599);
            this.MainStatusBar.Name = "MainStatusBar";
            this.MainStatusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.QueuedBarPanel,
            this.SuccessfulBarPanel,
            this.FailedBarPanel,
            this.SpeedBarPanel});
            this.MainStatusBar.ShowPanels = true;
            this.MainStatusBar.Size = new System.Drawing.Size(927, 22);
            this.MainStatusBar.TabIndex = 5;
            this.MainStatusBar.Text = "MainStatusBar";
            // 
            // QueuedBarPanel
            // 
            this.QueuedBarPanel.Name = "QueuedBarPanel";
            this.QueuedBarPanel.Text = "Queued: 0";
            this.QueuedBarPanel.Width = 80;
            // 
            // SuccessfulBarPanel
            // 
            this.SuccessfulBarPanel.Name = "SuccessfulBarPanel";
            this.SuccessfulBarPanel.Text = "Successful: 0";
            // 
            // FailedBarPanel
            // 
            this.FailedBarPanel.Name = "FailedBarPanel";
            this.FailedBarPanel.Text = "Failed: 0";
            this.FailedBarPanel.Width = 80;
            // 
            // SpeedBarPanel
            // 
            this.SpeedBarPanel.Name = "SpeedBarPanel";
            this.SpeedBarPanel.Text = "Speed: 0 kB/s";
            // 
            // TrnsfrUxTbCntrl
            // 
            this.TrnsfrUxTbCntrl.Controls.Add(this.tabPage1);
            this.TrnsfrUxTbCntrl.Controls.Add(this.tabPage2);
            this.TrnsfrUxTbCntrl.Controls.Add(this.tabPage3);
            this.TrnsfrUxTbCntrl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TrnsfrUxTbCntrl.Location = new System.Drawing.Point(0, 434);
            this.TrnsfrUxTbCntrl.Name = "TrnsfrUxTbCntrl";
            this.TrnsfrUxTbCntrl.Padding = new System.Drawing.Point(7, 3);
            this.TrnsfrUxTbCntrl.SelectedIndex = 0;
            this.TrnsfrUxTbCntrl.Size = new System.Drawing.Size(927, 165);
            this.TrnsfrUxTbCntrl.TabIndex = 69;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(919, 137);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Queued Files";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(934, 137);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Failed Transfers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(934, 137);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Successful Transfers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tLocalFileColumn
            // 
            this.tLocalFileColumn.Text = "Local File";
            this.tLocalFileColumn.Width = 266;
            // 
            // tDirectionColumn
            // 
            this.tDirectionColumn.Text = "Direction";
            this.tDirectionColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tRemoteFileColumn
            // 
            this.tRemoteFileColumn.Text = "Device File";
            this.tRemoteFileColumn.Width = 266;
            // 
            // tStatusColumn
            // 
            this.tStatusColumn.Text = "Status";
            this.tStatusColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tStatusColumn.Width = 128;
            // 
            // tSizeColumng
            // 
            this.tSizeColumng.Text = "Size";
            this.tSizeColumng.Width = 57;
            // 
            // tTransferedColumn
            // 
            this.tTransferedColumn.Text = "Transfered";
            this.tTransferedColumn.Width = 68;
            // 
            // tSpeedColumn
            // 
            this.tSpeedColumn.Text = "Speed";
            this.tSpeedColumn.Width = 66;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Local File";
            this.columnHeader1.Width = 255;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Direction";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Device File";
            this.columnHeader3.Width = 243;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 128;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Size";
            this.columnHeader5.Width = 57;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Transfered";
            this.columnHeader6.Width = 68;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Speed";
            this.columnHeader7.Width = 66;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Local File";
            this.columnHeader8.Width = 255;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Direction";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Device File";
            this.columnHeader10.Width = 243;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Status";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 128;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Size";
            this.columnHeader12.Width = 57;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Transfered";
            this.columnHeader13.Width = 68;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Speed";
            this.columnHeader14.Width = 66;
            // 
            // splitter2
            // 
            this.splitter2.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 431);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(927, 3);
            this.splitter2.TabIndex = 70;
            this.splitter2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(927, 431);
            this.tabControl1.TabIndex = 71;
            // 
            // vistaMenu1
            // 
            this.vistaMenu1.ContainerControl = this;
            // 
            // FileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 621);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.TrnsfrUxTbCntrl);
            this.Controls.Add(this.MainStatusBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Menu = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(499, 329);
            this.Name = "FileManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Manager";
            this.Load += new System.EventHandler(this.ServerExplorer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QueuedBarPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuccessfulBarPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailedBarPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBarPanel)).EndInit();
            this.TrnsfrUxTbCntrl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vistaMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu MainMenu;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem18;
        private System.Windows.Forms.MenuItem menuItem39;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.StatusBar MainStatusBar;
        private System.Windows.Forms.StatusBarPanel QueuedBarPanel;
        private System.Windows.Forms.StatusBarPanel SuccessfulBarPanel;
        private System.Windows.Forms.StatusBarPanel FailedBarPanel;
        private System.Windows.Forms.StatusBarPanel SpeedBarPanel;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem7;
        private VSControls.UxTabControl TrnsfrUxTbCntrl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ColumnHeader tLocalFileColumn;
        private System.Windows.Forms.ColumnHeader tDirectionColumn;
        private System.Windows.Forms.ColumnHeader tRemoteFileColumn;
        private System.Windows.Forms.ColumnHeader tStatusColumn;
        private System.Windows.Forms.ColumnHeader tSizeColumng;
        private System.Windows.Forms.ColumnHeader tTransferedColumn;
        private System.Windows.Forms.ColumnHeader tSpeedColumn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.TabControl tabControl1;
        private wyDay.Controls.VistaMenu vistaMenu1;
    }
}