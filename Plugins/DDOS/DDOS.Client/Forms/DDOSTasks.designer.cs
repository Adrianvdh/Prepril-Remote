namespace DDOS_Client
{
    partial class DDOSTasks
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
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddTaskToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.CloseTaskToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TaskPropertiesToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.TargetInfoToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ddosTaskListView1 = new DDOS_Client.DDOSTaskListView();
            this.ddosTaskListView2 = new DDOS_Client.DDOSTaskListView();
            this.ddosTaskListView3 = new DDOS_Client.DDOSTaskListView();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(0, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 2);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTaskToolStripBt,
            this.CloseTaskToolStripBt,
            this.toolStripSeparator2,
            this.TaskPropertiesToolStripBt,
            this.TargetInfoToolStripBt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(504, 26);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddTaskToolStripBt
            // 
            this.AddTaskToolStripBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddTaskToolStripBt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 1);
            this.AddTaskToolStripBt.Name = "AddTaskToolStripBt";
            this.AddTaskToolStripBt.Size = new System.Drawing.Size(60, 23);
            this.AddTaskToolStripBt.Text = "Add Task";
            this.AddTaskToolStripBt.ToolTipText = "Add new DDOS task";
            this.AddTaskToolStripBt.Click += new System.EventHandler(this.AddTaskToolStripBt_Click);
            // 
            // CloseTaskToolStripBt
            // 
            this.CloseTaskToolStripBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseTaskToolStripBt.Margin = new System.Windows.Forms.Padding(0, 2, 1, 1);
            this.CloseTaskToolStripBt.Name = "CloseTaskToolStripBt";
            this.CloseTaskToolStripBt.Size = new System.Drawing.Size(67, 23);
            this.CloseTaskToolStripBt.Text = "Close Task";
            this.CloseTaskToolStripBt.ToolTipText = "Close current DDOS task";
            this.CloseTaskToolStripBt.Click += new System.EventHandler(this.CloseTaskToolStripBt_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // TaskPropertiesToolStripBt
            // 
            this.TaskPropertiesToolStripBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TaskPropertiesToolStripBt.Margin = new System.Windows.Forms.Padding(0, 2, 3, 1);
            this.TaskPropertiesToolStripBt.Name = "TaskPropertiesToolStripBt";
            this.TaskPropertiesToolStripBt.Size = new System.Drawing.Size(91, 23);
            this.TaskPropertiesToolStripBt.Text = "Task Properties";
            this.TaskPropertiesToolStripBt.Click += new System.EventHandler(this.TaskPropertiesToolStripBt_Click);
            // 
            // TargetInfoToolStripBt
            // 
            this.TargetInfoToolStripBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TargetInfoToolStripBt.Margin = new System.Windows.Forms.Padding(1, 2, 1, 1);
            this.TargetInfoToolStripBt.Name = "TargetInfoToolStripBt";
            this.TargetInfoToolStripBt.Size = new System.Drawing.Size(111, 23);
            this.TargetInfoToolStripBt.Text = "Target Information";
            this.TargetInfoToolStripBt.Click += new System.EventHandler(this.TargetInfoToolStripBt_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(504, 450);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ddosTaskListView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(496, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "fcc.gov";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ddosTaskListView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(479, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "woodycraft.net";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ddosTaskListView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(479, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "197.83.234.167";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ddosTaskListView1
            // 
            this.ddosTaskListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddosTaskListView1.Location = new System.Drawing.Point(0, 0);
            this.ddosTaskListView1.Name = "ddosTaskListView1";
            this.ddosTaskListView1.Size = new System.Drawing.Size(496, 422);
            this.ddosTaskListView1.TabIndex = 1;
            // 
            // ddosTaskListView2
            // 
            this.ddosTaskListView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddosTaskListView2.Location = new System.Drawing.Point(0, 0);
            this.ddosTaskListView2.Name = "ddosTaskListView2";
            this.ddosTaskListView2.Size = new System.Drawing.Size(479, 422);
            this.ddosTaskListView2.TabIndex = 1;
            // 
            // ddosTaskListView3
            // 
            this.ddosTaskListView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddosTaskListView3.Location = new System.Drawing.Point(0, 0);
            this.ddosTaskListView3.Name = "ddosTaskListView3";
            this.ddosTaskListView3.Size = new System.Drawing.Size(479, 422);
            this.ddosTaskListView3.TabIndex = 1;
            // 
            // DDOSTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 478);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DDOSTasks";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DDOS Tasks";
            this.Load += new System.EventHandler(this.DDOSTasks_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddTaskToolStripBt;
        private System.Windows.Forms.ToolStripButton CloseTaskToolStripBt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TaskPropertiesToolStripBt;
        private System.Windows.Forms.ToolStripButton TargetInfoToolStripBt;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private DDOSTaskListView ddosTaskListView1;
        private System.Windows.Forms.TabPage tabPage2;
        private DDOSTaskListView ddosTaskListView2;
        private System.Windows.Forms.TabPage tabPage3;
        private DDOSTaskListView ddosTaskListView3;
    }
}