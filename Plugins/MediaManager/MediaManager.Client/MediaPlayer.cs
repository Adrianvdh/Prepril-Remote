using System;
using System.Drawing;
using System.Windows.Forms;

namespace MediaManager_Client
{
    public partial class MediaPlayer : Form
    {
        public MediaPlayer()
        {
            InitializeComponent();
        }

        private void MediaPlayer_Load(object sender, EventArgs e)
        {

        }

        private void PictureScreen_DoubleClick(object sender, EventArgs e)
        {
            //FullScreenButton.PerformClick();
        }

        private void PlayPauseButton_Click(object sender, EventArgs e)
        {
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            

        }
        private bool FullScreen = false;
        private void FullScreenButton_Click(object sender, EventArgs e)
        {

            if (FullScreen)
            { FullScreen = false; FormBorderStyle = FormBorderStyle.Sizable; WindowState = FormWindowState.Normal; }
            else
            { FullScreen = true; FormBorderStyle = FormBorderStyle.None; WindowState = FormWindowState.Maximized; }
            TopMost = FullScreen;
        }
        private void SnapshotButton_Click(object sender, EventArgs e)
        {
            
        }

        private void MuteButton_Click(object sender, EventArgs e)
        {
            
        }

        private void TotalRemainingTimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void VolumeTrackBar_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.VolumeTrackBar, "Current volume: " + VolumeTrackBar.Value.ToString() + "%");
        }




        private void PlayPauseButton_MouseLeave(object sender, EventArgs e)
        {
            PictureScreen.Focus();
        }
        private void BackButton_MouseLeave(object sender, EventArgs e)
        {
            PictureScreen.Focus();
        }
        private void StopButton_MouseLeave(object sender, EventArgs e)
        {
            PictureScreen.Focus();
        }
        private void ForwardButton_MouseLeave(object sender, EventArgs e)
        {
            PictureScreen.Focus();
        }
        private void FullScreenButton_MouseLeave(object sender, EventArgs e)
        {
            PictureScreen.Focus();
        }
        private void SnapshotButton_MouseLeave(object sender, EventArgs e)
        {
            PictureScreen.Focus();
        }
        private void MuteButton_MouseLeave(object sender, EventArgs e)
        {
            PictureScreen.Focus();
        }






    }
}
