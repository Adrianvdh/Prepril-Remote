namespace PpRStandardLib.Forms
{
    partial class PingTool
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AnalyticsGraph = new CustomUIControls.Graphing.C2DPushGraph();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.clsBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(7, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Pinging (Address) with 0 bytes of data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ping: 0ms";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AnalyticsGraph);
            this.panel1.Location = new System.Drawing.Point(11, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 81);
            this.panel1.TabIndex = 25;
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
            this.AnalyticsGraph.Location = new System.Drawing.Point(0, 0);
            this.AnalyticsGraph.MaxLabel = "Max";
            this.AnalyticsGraph.MaxPeekMagnitude = 100;
            this.AnalyticsGraph.MinLabel = "0 Bytes";
            this.AnalyticsGraph.MinPeekMagnitude = 0;
            this.AnalyticsGraph.Name = "AnalyticsGraph";
            this.AnalyticsGraph.ShowGrid = true;
            this.AnalyticsGraph.ShowLabels = false;
            this.AnalyticsGraph.Size = new System.Drawing.Size(381, 81);
            this.AnalyticsGraph.TabIndex = 0;
            this.AnalyticsGraph.Text = "c2DPushGraph1";
            this.AnalyticsGraph.TextColor = System.Drawing.Color.Black;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label63);
            this.groupBox1.Controls.Add(this.label64);
            this.groupBox1.Controls.Add(this.label65);
            this.groupBox1.Controls.Add(this.label66);
            this.groupBox1.Controls.Add(this.label67);
            this.groupBox1.Controls.Add(this.label68);
            this.groupBox1.Location = new System.Drawing.Point(10, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 81);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ping Statistics";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(207, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 139;
            this.label2.Text = "0ms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 138;
            this.label4.Text = "Pings Lost:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(207, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 137;
            this.label5.Text = "0ms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 136;
            this.label6.Text = "Pings Sent:";
            // 
            // label63
            // 
            this.label63.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label63.Location = new System.Drawing.Point(76, 38);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(56, 15);
            this.label63.TabIndex = 133;
            this.label63.Text = "0ms";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(7, 38);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(63, 15);
            this.label64.TabIndex = 132;
            this.label64.Text = "Minimum:";
            // 
            // label65
            // 
            this.label65.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label65.Location = new System.Drawing.Point(76, 19);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(56, 15);
            this.label65.TabIndex = 131;
            this.label65.Text = "0ms";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(7, 19);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(53, 15);
            this.label66.TabIndex = 130;
            this.label66.Text = "Average:";
            // 
            // label67
            // 
            this.label67.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label67.Location = new System.Drawing.Point(76, 57);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(56, 15);
            this.label67.TabIndex = 129;
            this.label67.Text = "0ms";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(7, 57);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(61, 15);
            this.label68.TabIndex = 128;
            this.label68.Text = "Maximum";
            // 
            // clsBtn
            // 
            this.clsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clsBtn.Location = new System.Drawing.Point(317, 203);
            this.clsBtn.Name = "clsBtn";
            this.clsBtn.Size = new System.Drawing.Size(75, 23);
            this.clsBtn.TabIndex = 27;
            this.clsBtn.Text = "OK";
            this.clsBtn.UseVisualStyleBackColor = true;
            this.clsBtn.Click += new System.EventHandler(this.clsBtn_Click);
            // 
            // PingTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(402, 236);
            this.Controls.Add(this.clsBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(410, 248);
            this.Name = "PingTool";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping (Network Address)";
            this.Load += new System.EventHandler(this.NetStatPing_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private CustomUIControls.Graphing.C2DPushGraph AnalyticsGraph;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Button clsBtn;

    }
}