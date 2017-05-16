using PpRStandardLib.Controls;
namespace PpRClientInterface.Forms
{
    partial class AllTasks
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
            this.InterfaceToolStrip = new System.Windows.Forms.ToolStrip();
            this.BuiltInServerToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.ActiveToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.LockToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.RestartToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.procossesListView1 = new PpRStandardLib.Controls.ProcessesListView();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            this.InterfaceToolStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainStatusBar
            // 
            this.MainStatusBar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainStatusBar.Location = new System.Drawing.Point(0, 410);
            this.MainStatusBar.Name = "MainStatusBar";
            this.MainStatusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.MainStatusBar.ShowPanels = true;
            this.MainStatusBar.Size = new System.Drawing.Size(646, 22);
            this.MainStatusBar.TabIndex = 15;
            this.MainStatusBar.Text = "MainStatusBar";
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "Processes: 0";
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
            this.RestartToolStripBt,
            this.ToolStripSep2});
            this.InterfaceToolStrip.Location = new System.Drawing.Point(0, 0);
            this.InterfaceToolStrip.Name = "InterfaceToolStrip";
            this.InterfaceToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.InterfaceToolStrip.Size = new System.Drawing.Size(646, 25);
            this.InterfaceToolStrip.Stretch = true;
            this.InterfaceToolStrip.TabIndex = 18;
            // 
            // BuiltInServerToolStripBt
            // 
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
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label13.Location = new System.Drawing.Point(0, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(646, 2);
            this.label13.TabIndex = 88;
            this.label13.Text = "label13";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 383);
            this.tabControl1.TabIndex = 90;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.procossesListView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(638, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(638, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // procossesListView1
            // 
            this.procossesListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.procossesListView1.Location = new System.Drawing.Point(0, 0);
            this.procossesListView1.Name = "procossesListView1";
            this.procossesListView1.Size = new System.Drawing.Size(638, 355);
            this.procossesListView1.TabIndex = 90;
            // 
            // AllTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 432);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.InterfaceToolStrip);
            this.Controls.Add(this.MainStatusBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(327, 306);
            this.Name = "AllTasks";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Tasks";
            this.Load += new System.EventHandler(this.StubsProcesses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            this.InterfaceToolStrip.ResumeLayout(false);
            this.InterfaceToolStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusBar MainStatusBar;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.ToolStrip InterfaceToolStrip;
        private System.Windows.Forms.ToolStripButton BuiltInServerToolStripBt;
        private System.Windows.Forms.ToolStripSeparator ToolStripSep1;
        private System.Windows.Forms.ToolStripButton ActiveToolStripBt;
        private System.Windows.Forms.ToolStripButton LockToolStripBt;
        private System.Windows.Forms.ToolStripButton RestartToolStripBt;
        private System.Windows.Forms.ToolStripSeparator ToolStripSep2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private ProcessesListView procossesListView1;
        private System.Windows.Forms.TabPage tabPage2;

    }
}