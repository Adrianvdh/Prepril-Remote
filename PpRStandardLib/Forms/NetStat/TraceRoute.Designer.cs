namespace PpRStandardLib.Forms
{
    partial class TraceRoute
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
            "1",
            "192.168.1.4",
            "vdhouten.no-ip.org",
            "0 ms",
            "0"}, -1);
            this.TraceRouteListView = new PpRStandardLib.Controls.FullListView();
            this.HopColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IPAddressColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HostNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PingColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LostColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TraceRouteListView
            // 
            this.TraceRouteListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TraceRouteListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HopColumn,
            this.IPAddressColumn,
            this.HostNameColumn,
            this.PingColumn,
            this.LostColumn});
            this.TraceRouteListView.ExplorerTheme = true;
            this.TraceRouteListView.ExplorerThemeMultiSelect = true;
            this.TraceRouteListView.FullRowSelect = true;
            this.TraceRouteListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.TraceRouteListView.ItemContextMenuStrip = true;
            this.TraceRouteListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.TraceRouteListView.Location = new System.Drawing.Point(7, 32);
            this.TraceRouteListView.LockColumnSize = true;
            this.TraceRouteListView.MultiSelect = false;
            this.TraceRouteListView.Name = "TraceRouteListView";
            this.TraceRouteListView.Size = new System.Drawing.Size(510, 287);
            this.TraceRouteListView.TabIndex = 0;
            this.TraceRouteListView.UseCompatibleStateImageBehavior = false;
            this.TraceRouteListView.View = System.Windows.Forms.View.Details;
            this.TraceRouteListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.TraceRouteListView_ColumnWidthChanging);
            this.TraceRouteListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TraceRouteListView_MouseUp);
            // 
            // HopColumn
            // 
            this.HopColumn.Text = "Hop";
            this.HopColumn.Width = 38;
            // 
            // IPAddressColumn
            // 
            this.IPAddressColumn.Text = "IP Address";
            this.IPAddressColumn.Width = 149;
            // 
            // HostNameColumn
            // 
            this.HostNameColumn.Text = "Host Name";
            this.HostNameColumn.Width = 191;
            // 
            // PingColumn
            // 
            this.PingColumn.Text = "Ping";
            // 
            // LostColumn
            // 
            this.LostColumn.Text = "Lost (%)";
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 327);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(524, 22);
            this.statusBar1.SizingGrip = false;
            this.statusBar1.TabIndex = 1;
            this.statusBar1.Text = "Status: Trace Route is not running...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(7, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(453, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tracing route to db3wns2010910.wns.windows.com [157.56.124.52]:";
            // 
            // TraceRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(524, 349);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.TraceRouteListView);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(460, 298);
            this.Name = "TraceRoute";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trace Route";
            this.Load += new System.EventHandler(this.TraceRoute_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PpRStandardLib.Controls.FullListView TraceRouteListView;
        private System.Windows.Forms.ColumnHeader HopColumn;
        private System.Windows.Forms.ColumnHeader IPAddressColumn;
        private System.Windows.Forms.ColumnHeader HostNameColumn;
        private System.Windows.Forms.ColumnHeader PingColumn;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.ColumnHeader LostColumn;
        private System.Windows.Forms.Label label3;
    }
}