namespace RDPCapture_Client
{
    partial class CaptureOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureOptions));
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imagedComboBox1 = new ComboxExtended.ImagedComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CaptureQualityTrackBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.StartCaptureButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.GeneralTab = new System.Windows.Forms.TabPage();
            this.RecordingTab = new System.Windows.Forms.TabPage();
            this.WebcamCaptureTab = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureQualityTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.GeneralTab.SuspendLayout();
            this.RecordingTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 47);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(132, 19);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Disable Aero Theme";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imagedComboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CaptureQualityTrackBar);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 103);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available Monitor(s)";
            // 
            // imagedComboBox1
            // 
            this.imagedComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.imagedComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.imagedComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imagedComboBox1.FormattingEnabled = true;
            this.imagedComboBox1.Location = new System.Drawing.Point(6, 22);
            this.imagedComboBox1.Name = "imagedComboBox1";
            this.imagedComboBox1.Size = new System.Drawing.Size(293, 24);
            this.imagedComboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Capture Quality: 85%";
            // 
            // CaptureQualityTrackBar
            // 
            this.CaptureQualityTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CaptureQualityTrackBar.AutoSize = false;
            this.CaptureQualityTrackBar.BackColor = System.Drawing.SystemColors.Window;
            this.CaptureQualityTrackBar.LargeChange = 1;
            this.CaptureQualityTrackBar.Location = new System.Drawing.Point(6, 66);
            this.CaptureQualityTrackBar.Maximum = 20;
            this.CaptureQualityTrackBar.MaximumSize = new System.Drawing.Size(750, 30);
            this.CaptureQualityTrackBar.MinimumSize = new System.Drawing.Size(150, 30);
            this.CaptureQualityTrackBar.Name = "CaptureQualityTrackBar";
            this.CaptureQualityTrackBar.Size = new System.Drawing.Size(293, 30);
            this.CaptureQualityTrackBar.TabIndex = 2;
            this.CaptureQualityTrackBar.Value = 17;
            this.CaptureQualityTrackBar.Scroll += new System.EventHandler(this.CaptureQualityTrackBar_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "%";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 72);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(161, 19);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Turn Off Remote Monitor";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(94, 17);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(73, 23);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 97);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(243, 19);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Attempt To Disable Mouse and Keyboard";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(6, 72);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(211, 19);
            this.checkBox6.TabIndex = 2;
            this.checkBox6.Text = "Show Connection Bar on fullscreen";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.checkBox6);
            this.groupBox3.Controls.Add(this.checkBox7);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox3.Location = new System.Drawing.Point(5, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 96);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Miscellaneous Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resize Picture:";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(6, 46);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(166, 19);
            this.checkBox7.TabIndex = 1;
            this.checkBox7.Text = "Reconnect if disconnected";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // StartCaptureButton
            // 
            this.StartCaptureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartCaptureButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartCaptureButton.Location = new System.Drawing.Point(172, 370);
            this.StartCaptureButton.Name = "StartCaptureButton";
            this.StartCaptureButton.Size = new System.Drawing.Size(75, 23);
            this.StartCaptureButton.TabIndex = 23;
            this.StartCaptureButton.Text = "OK";
            this.StartCaptureButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseButton.Location = new System.Drawing.Point(253, 370);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 24;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox2.Location = new System.Drawing.Point(5, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 121);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Performance Options";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(131, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Disable Background";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(3, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(297, 170);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Picture In Picture";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.GeneralTab);
            this.tabControl1.Controls.Add(this.RecordingTab);
            this.tabControl1.Controls.Add(this.WebcamCaptureTab);
            this.tabControl1.ItemSize = new System.Drawing.Size(52, 20);
            this.tabControl1.Location = new System.Drawing.Point(5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(326, 360);
            this.tabControl1.TabIndex = 27;
            // 
            // GeneralTab
            // 
            this.GeneralTab.Controls.Add(this.groupBox1);
            this.GeneralTab.Controls.Add(this.groupBox2);
            this.GeneralTab.Controls.Add(this.groupBox3);
            this.GeneralTab.Location = new System.Drawing.Point(4, 24);
            this.GeneralTab.Name = "GeneralTab";
            this.GeneralTab.Size = new System.Drawing.Size(318, 332);
            this.GeneralTab.TabIndex = 0;
            this.GeneralTab.Text = "General";
            this.GeneralTab.UseVisualStyleBackColor = true;
            // 
            // RecordingTab
            // 
            this.RecordingTab.Controls.Add(this.groupBox4);
            this.RecordingTab.Location = new System.Drawing.Point(4, 24);
            this.RecordingTab.Name = "RecordingTab";
            this.RecordingTab.Size = new System.Drawing.Size(318, 332);
            this.RecordingTab.TabIndex = 1;
            this.RecordingTab.Text = "Recording";
            this.RecordingTab.UseVisualStyleBackColor = true;
            // 
            // WebcamCaptureTab
            // 
            this.WebcamCaptureTab.Location = new System.Drawing.Point(4, 24);
            this.WebcamCaptureTab.Name = "WebcamCaptureTab";
            this.WebcamCaptureTab.Size = new System.Drawing.Size(318, 332);
            this.WebcamCaptureTab.TabIndex = 2;
            this.WebcamCaptureTab.Text = "Webcam Capture";
            this.WebcamCaptureTab.UseVisualStyleBackColor = true;
            // 
            // CaptureOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 400);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.StartCaptureButton);
            this.Controls.Add(this.CloseButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CaptureOptions";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capture Options";
            this.Load += new System.EventHandler(this.RDPCaptureOptions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureQualityTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.GeneralTab.ResumeLayout(false);
            this.RecordingTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar CaptureQualityTrackBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.Button StartCaptureButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private ComboxExtended.ImagedComboBox imagedComboBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage GeneralTab;
        private System.Windows.Forms.TabPage RecordingTab;
        private System.Windows.Forms.TabPage WebcamCaptureTab;

    }
}