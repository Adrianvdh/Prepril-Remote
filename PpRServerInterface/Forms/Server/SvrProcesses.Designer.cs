namespace PpRServerInterface.Forms
{
    partial class SvrProcesses
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
            this.MainStatusBar = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.IntToolStrip = new System.Windows.Forms.ToolStrip();
            this.BuiltInServerToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.ActiveToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.LockToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.RestartToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.label1 = new System.Windows.Forms.Label();
            this.fullListView1 = new PpRStandardLib.Controls.FullListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            this.IntToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainStatusBar
            // 
            this.MainStatusBar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainStatusBar.Location = new System.Drawing.Point(0, 429);
            this.MainStatusBar.Name = "MainStatusBar";
            this.MainStatusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.MainStatusBar.ShowPanels = true;
            this.MainStatusBar.Size = new System.Drawing.Size(568, 22);
            this.MainStatusBar.TabIndex = 91;
            this.MainStatusBar.Text = "MainStatusBar";
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "Processes: 0";
            // 
            // IntToolStrip
            // 
            this.IntToolStrip.GripMargin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.IntToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.IntToolStrip.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.IntToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BuiltInServerToolStripBt,
            this.ToolStripSep1,
            this.ActiveToolStripBt,
            this.LockToolStripBt,
            this.RestartToolStripBt,
            this.ToolStripSep2});
            this.IntToolStrip.Location = new System.Drawing.Point(0, 0);
            this.IntToolStrip.Name = "IntToolStrip";
            this.IntToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.IntToolStrip.Size = new System.Drawing.Size(568, 25);
            this.IntToolStrip.Stretch = true;
            this.IntToolStrip.TabIndex = 92;
            // 
            // BuiltInServerToolStripBt
            // 
            this.BuiltInServerToolStripBt.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.BuiltInServerToolStripBt.Name = "BuiltInServerToolStripBt";
            this.BuiltInServerToolStripBt.Size = new System.Drawing.Size(23, 22);
            // 
            // ToolStripSep1
            // 
            this.ToolStripSep1.Name = "ToolStripSep1";
            this.ToolStripSep1.Size = new System.Drawing.Size(6, 25);
            // 
            // ActiveToolStripBt
            // 
            this.ActiveToolStripBt.Name = "ActiveToolStripBt";
            this.ActiveToolStripBt.Size = new System.Drawing.Size(23, 22);
            // 
            // LockToolStripBt
            // 
            this.LockToolStripBt.Name = "LockToolStripBt";
            this.LockToolStripBt.Size = new System.Drawing.Size(23, 22);
            // 
            // RestartToolStripBt
            // 
            this.RestartToolStripBt.Name = "RestartToolStripBt";
            this.RestartToolStripBt.Size = new System.Drawing.Size(23, 22);
            // 
            // ToolStripSep2
            // 
            this.ToolStripSep2.Name = "ToolStripSep2";
            this.ToolStripSep2.Size = new System.Drawing.Size(6, 25);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(0, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 2);
            this.label1.TabIndex = 96;
            this.label1.Text = "label1";
            // 
            // fullListView1
            // 
            this.fullListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fullListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.fullListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullListView1.ExplorerTheme = false;
            this.fullListView1.ExplorerThemeMultiSelect = false;
            this.fullListView1.FullRowSelect = true;
            this.fullListView1.ItemContextMenuStrip = false;
            this.fullListView1.Location = new System.Drawing.Point(0, 27);
            this.fullListView1.LockColumnSize = false;
            this.fullListView1.Name = "fullListView1";
            this.fullListView1.Size = new System.Drawing.Size(568, 402);
            this.fullListView1.TabIndex = 97;
            this.fullListView1.UseCompatibleStateImageBehavior = false;
            this.fullListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Process Name";
            this.columnHeader1.Width = 171;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Duration";
            // 
            // SvrProcesses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 451);
            this.Controls.Add(this.fullListView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainStatusBar);
            this.Controls.Add(this.IntToolStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(483, 449);
            this.Name = "SvrProcesses";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Processes";
            this.Load += new System.EventHandler(this.SvrProcesses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            this.IntToolStrip.ResumeLayout(false);
            this.IntToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusBar MainStatusBar;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.ToolStrip IntToolStrip;
        private System.Windows.Forms.ToolStripButton BuiltInServerToolStripBt;
        private System.Windows.Forms.ToolStripSeparator ToolStripSep1;
        private System.Windows.Forms.ToolStripButton ActiveToolStripBt;
        private System.Windows.Forms.ToolStripButton LockToolStripBt;
        private System.Windows.Forms.ToolStripButton RestartToolStripBt;
        private System.Windows.Forms.ToolStripSeparator ToolStripSep2;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.Label label1;
        private PpRStandardLib.Controls.FullListView fullListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}