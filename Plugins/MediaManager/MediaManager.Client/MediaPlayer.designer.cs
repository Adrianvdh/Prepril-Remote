namespace MediaManager_Client
{
    partial class MediaPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlayer));
            this.CommandPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SnapshotButton = new System.Windows.Forms.Button();
            this.FullScreenButton = new System.Windows.Forms.Button();
            this.SpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.VolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.PlayPauseButton = new System.Windows.Forms.Button();
            this.ControlImageList = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.TimeTrackBar = new System.Windows.Forms.TrackBar();
            this.TimePanel = new System.Windows.Forms.Panel();
            this.TotalRemainingTimeLabel = new System.Windows.Forms.Label();
            this.ElapsedTimeLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PictureScreen = new System.Windows.Forms.Panel();
            this.CommandPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTrackBar)).BeginInit();
            this.TimePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CommandPanel
            // 
            this.CommandPanel.Controls.Add(this.label1);
            this.CommandPanel.Controls.Add(this.pictureBox1);
            this.CommandPanel.Controls.Add(this.SnapshotButton);
            this.CommandPanel.Controls.Add(this.FullScreenButton);
            this.CommandPanel.Controls.Add(this.SpeedTrackBar);
            this.CommandPanel.Controls.Add(this.VolumeTrackBar);
            this.CommandPanel.Controls.Add(this.ForwardButton);
            this.CommandPanel.Controls.Add(this.StopButton);
            this.CommandPanel.Controls.Add(this.BackButton);
            this.CommandPanel.Controls.Add(this.PlayPauseButton);
            this.CommandPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CommandPanel.Location = new System.Drawing.Point(0, 331);
            this.CommandPanel.Name = "CommandPanel";
            this.CommandPanel.Size = new System.Drawing.Size(528, 34);
            this.CommandPanel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(415, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "0%";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(395, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 14);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // SnapshotButton
            // 
            this.SnapshotButton.Location = new System.Drawing.Point(172, 3);
            this.SnapshotButton.Name = "SnapshotButton";
            this.SnapshotButton.Size = new System.Drawing.Size(28, 26);
            this.SnapshotButton.TabIndex = 16;
            this.SnapshotButton.TabStop = false;
            this.toolTip1.SetToolTip(this.SnapshotButton, "Take a snapshot");
            this.SnapshotButton.UseVisualStyleBackColor = true;
            this.SnapshotButton.Click += new System.EventHandler(this.SnapshotButton_Click);
            this.SnapshotButton.MouseLeave += new System.EventHandler(this.SnapshotButton_MouseLeave);
            // 
            // FullScreenButton
            // 
            this.FullScreenButton.Location = new System.Drawing.Point(137, 3);
            this.FullScreenButton.Name = "FullScreenButton";
            this.FullScreenButton.Size = new System.Drawing.Size(28, 26);
            this.FullScreenButton.TabIndex = 12;
            this.FullScreenButton.TabStop = false;
            this.toolTip1.SetToolTip(this.FullScreenButton, "Toggle fullscreen view");
            this.FullScreenButton.UseVisualStyleBackColor = true;
            this.FullScreenButton.Click += new System.EventHandler(this.FullScreenButton_Click);
            this.FullScreenButton.MouseLeave += new System.EventHandler(this.FullScreenButton_MouseLeave);
            // 
            // SpeedTrackBar
            // 
            this.SpeedTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpeedTrackBar.AutoSize = false;
            this.SpeedTrackBar.LargeChange = 1;
            this.SpeedTrackBar.Location = new System.Drawing.Point(256, 3);
            this.SpeedTrackBar.Maximum = 4;
            this.SpeedTrackBar.Name = "SpeedTrackBar";
            this.SpeedTrackBar.Size = new System.Drawing.Size(118, 28);
            this.SpeedTrackBar.TabIndex = 13;
            this.SpeedTrackBar.TabStop = false;
            this.toolTip1.SetToolTip(this.SpeedTrackBar, "Current play back speed: 1.00x");
            this.SpeedTrackBar.Value = 2;
            // 
            // VolumeTrackBar
            // 
            this.VolumeTrackBar.AutoSize = false;
            this.VolumeTrackBar.LargeChange = 1;
            this.VolumeTrackBar.Location = new System.Drawing.Point(407, 3);
            this.VolumeTrackBar.Maximum = 100;
            this.VolumeTrackBar.Name = "VolumeTrackBar";
            this.VolumeTrackBar.Size = new System.Drawing.Size(118, 28);
            this.VolumeTrackBar.TabIndex = 15;
            this.VolumeTrackBar.TabStop = false;
            this.VolumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.toolTip1.SetToolTip(this.VolumeTrackBar, "Current volume: 75%");
            this.VolumeTrackBar.Value = 75;
            this.VolumeTrackBar.Scroll += new System.EventHandler(this.VolumeTrackBar_Scroll);
            // 
            // ForwardButton
            // 
            this.ForwardButton.ImageKey = "(none)";
            this.ForwardButton.Location = new System.Drawing.Point(102, 3);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(28, 26);
            this.ForwardButton.TabIndex = 11;
            this.ForwardButton.TabStop = false;
            this.toolTip1.SetToolTip(this.ForwardButton, "Jump to next media");
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            this.ForwardButton.MouseLeave += new System.EventHandler(this.ForwardButton_MouseLeave);
            // 
            // StopButton
            // 
            this.StopButton.ImageKey = "(none)";
            this.StopButton.Location = new System.Drawing.Point(71, 3);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(28, 26);
            this.StopButton.TabIndex = 10;
            this.StopButton.TabStop = false;
            this.toolTip1.SetToolTip(this.StopButton, "Stop playback");
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            this.StopButton.MouseLeave += new System.EventHandler(this.StopButton_MouseLeave);
            // 
            // BackButton
            // 
            this.BackButton.ImageKey = "vlc_preivous.png";
            this.BackButton.Location = new System.Drawing.Point(40, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(28, 26);
            this.BackButton.TabIndex = 9;
            this.BackButton.TabStop = false;
            this.toolTip1.SetToolTip(this.BackButton, "Jump to previous media");
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            this.BackButton.MouseLeave += new System.EventHandler(this.BackButton_MouseLeave);
            // 
            // PlayPauseButton
            // 
            this.PlayPauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PlayPauseButton.ImageKey = "vlc_play.png";
            this.PlayPauseButton.Location = new System.Drawing.Point(5, 3);
            this.PlayPauseButton.Name = "PlayPauseButton";
            this.PlayPauseButton.Size = new System.Drawing.Size(28, 26);
            this.PlayPauseButton.TabIndex = 8;
            this.PlayPauseButton.TabStop = false;
            this.PlayPauseButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.PlayPauseButton, "Play ");
            this.PlayPauseButton.UseVisualStyleBackColor = true;
            this.PlayPauseButton.Click += new System.EventHandler(this.PlayPauseButton_Click);
            this.PlayPauseButton.MouseLeave += new System.EventHandler(this.PlayPauseButton_MouseLeave);
            // 
            // ControlImageList
            // 
            this.ControlImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ControlImageList.ImageStream")));
            this.ControlImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ControlImageList.Images.SetKeyName(0, "vlc_de_fullscreen.png");
            this.ControlImageList.Images.SetKeyName(1, "vlc_fullscreen.png");
            this.ControlImageList.Images.SetKeyName(2, "vlc_next.png");
            this.ControlImageList.Images.SetKeyName(3, "vlc_play.png");
            this.ControlImageList.Images.SetKeyName(4, "vlc_preivous.png");
            this.ControlImageList.Images.SetKeyName(5, "vlc_snapshot.png");
            this.ControlImageList.Images.SetKeyName(6, "vlc_stop.png");
            this.ControlImageList.Images.SetKeyName(7, "volume_down.png");
            this.ControlImageList.Images.SetKeyName(8, "volume_up.png");
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(0, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(528, 2);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // TimeTrackBar
            // 
            this.TimeTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeTrackBar.AutoSize = false;
            this.TimeTrackBar.LargeChange = 35;
            this.TimeTrackBar.Location = new System.Drawing.Point(55, 0);
            this.TimeTrackBar.Maximum = 1000;
            this.TimeTrackBar.Name = "TimeTrackBar";
            this.TimeTrackBar.Size = new System.Drawing.Size(417, 23);
            this.TimeTrackBar.TabIndex = 4;
            this.TimeTrackBar.TabStop = false;
            this.TimeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // TimePanel
            // 
            this.TimePanel.Controls.Add(this.TotalRemainingTimeLabel);
            this.TimePanel.Controls.Add(this.ElapsedTimeLabel);
            this.TimePanel.Controls.Add(this.TimeTrackBar);
            this.TimePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TimePanel.Location = new System.Drawing.Point(0, 306);
            this.TimePanel.Name = "TimePanel";
            this.TimePanel.Size = new System.Drawing.Size(528, 23);
            this.TimePanel.TabIndex = 2;
            // 
            // TotalRemainingTimeLabel
            // 
            this.TotalRemainingTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalRemainingTimeLabel.AutoSize = true;
            this.TotalRemainingTimeLabel.Location = new System.Drawing.Point(476, 3);
            this.TotalRemainingTimeLabel.Name = "TotalRemainingTimeLabel";
            this.TotalRemainingTimeLabel.Size = new System.Drawing.Size(49, 15);
            this.TotalRemainingTimeLabel.TabIndex = 5;
            this.TotalRemainingTimeLabel.Text = "00:00:00";
            this.toolTip1.SetToolTip(this.TotalRemainingTimeLabel, "Total/Remaining time\r\nClick to toggle between total and remaining time");
            this.TotalRemainingTimeLabel.Click += new System.EventHandler(this.TotalRemainingTimeLabel_Click);
            // 
            // ElapsedTimeLabel
            // 
            this.ElapsedTimeLabel.AutoSize = true;
            this.ElapsedTimeLabel.Location = new System.Drawing.Point(3, 3);
            this.ElapsedTimeLabel.Name = "ElapsedTimeLabel";
            this.ElapsedTimeLabel.Size = new System.Drawing.Size(49, 15);
            this.ElapsedTimeLabel.TabIndex = 3;
            this.ElapsedTimeLabel.Text = "00:00:00";
            this.toolTip1.SetToolTip(this.ElapsedTimeLabel, "Elapsed time");
            // 
            // PictureScreen
            // 
            this.PictureScreen.BackColor = System.Drawing.SystemColors.WindowText;
            this.PictureScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureScreen.Location = new System.Drawing.Point(0, 0);
            this.PictureScreen.Name = "PictureScreen";
            this.PictureScreen.Size = new System.Drawing.Size(528, 306);
            this.PictureScreen.TabIndex = 0;
            this.PictureScreen.DoubleClick += new System.EventHandler(this.PictureScreen_DoubleClick);
            // 
            // MediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 365);
            this.Controls.Add(this.PictureScreen);
            this.Controls.Add(this.TimePanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CommandPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 101);
            this.Name = "MediaPlayer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MediaPlayer_Load);
            this.CommandPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTrackBar)).EndInit();
            this.TimePanel.ResumeLayout(false);
            this.TimePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CommandPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar TimeTrackBar;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button PlayPauseButton;
        private System.Windows.Forms.Panel TimePanel;
        private System.Windows.Forms.Label TotalRemainingTimeLabel;
        private System.Windows.Forms.Label ElapsedTimeLabel;
        private System.Windows.Forms.TrackBar VolumeTrackBar;
        private System.Windows.Forms.TrackBar SpeedTrackBar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button FullScreenButton;
        private System.Windows.Forms.Panel PictureScreen;
        private System.Windows.Forms.Button SnapshotButton;
        private System.Windows.Forms.ImageList ControlImageList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}