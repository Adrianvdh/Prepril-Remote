namespace PpRClientInterface.Forms
{
    partial class Analytics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analytics));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.GrapghTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AnalyticsGraph = new CustomUIControls.Graphing.C2DPushGraph();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.GrapghTypeComboBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 29);
            this.panel2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Show:";
            // 
            // GrapghTypeComboBox
            // 
            this.GrapghTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GrapghTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GrapghTypeComboBox.FormattingEnabled = true;
            this.GrapghTypeComboBox.Items.AddRange(new object[] {
            "Send Bytes",
            "Received Bytes",
            "Server Send Bytes",
            "Server Received Bytes"});
            this.GrapghTypeComboBox.Location = new System.Drawing.Point(48, 3);
            this.GrapghTypeComboBox.Name = "GrapghTypeComboBox";
            this.GrapghTypeComboBox.Size = new System.Drawing.Size(206, 23);
            this.GrapghTypeComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(0, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(590, 2);
            this.label2.TabIndex = 20;
            this.label2.Text = "label2";
            // 
            // AnalyticsGraph
            // 
            this.AnalyticsGraph.AutoAdjustPeek = false;
            this.AnalyticsGraph.BackColor = System.Drawing.SystemColors.Control;
            this.AnalyticsGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnalyticsGraph.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.AnalyticsGraph.GridSize = ((ushort)(20));
            this.AnalyticsGraph.HighQuality = true;
            this.AnalyticsGraph.LineInterval = ((ushort)(5));
            this.AnalyticsGraph.Location = new System.Drawing.Point(0, 31);
            this.AnalyticsGraph.MaxLabel = "Max";
            this.AnalyticsGraph.MaxPeekMagnitude = 100;
            this.AnalyticsGraph.MinLabel = "0 Bytes";
            this.AnalyticsGraph.MinPeekMagnitude = 0;
            this.AnalyticsGraph.Name = "AnalyticsGraph";
            this.AnalyticsGraph.ShowGrid = true;
            this.AnalyticsGraph.ShowLabels = true;
            this.AnalyticsGraph.Size = new System.Drawing.Size(590, 321);
            this.AnalyticsGraph.TabIndex = 21;
            this.AnalyticsGraph.Text = "c2DPushGraph1";
            this.AnalyticsGraph.TextColor = System.Drawing.Color.Black;
            // 
            // Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 352);
            this.Controls.Add(this.AnalyticsGraph);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(464, 290);
            this.Name = "Analytics";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analytics";
            this.Load += new System.EventHandler(this.Analytics_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox GrapghTypeComboBox;
        private System.Windows.Forms.Label label2;
        private CustomUIControls.Graphing.C2DPushGraph AnalyticsGraph;
        private System.Windows.Forms.Label label1;
    }
}