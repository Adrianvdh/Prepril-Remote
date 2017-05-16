using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RDPCapture_Client
{
    public partial class RDPCapture : Form
    {
        public RDPCapture()
        {
            InitializeComponent();
            CommandToolStrip.Renderer = new ApplyRenderers.SystemToolStripRenderer();

        }

        private void RDP_Load(object sender, EventArgs e)
        {
            //CommandlPanel.BringToFront();

            CaptureOptionsBt.PerformClick();
        }

        private void StartStopCaptureBt_Click(object sender, EventArgs e)
        {

        }

        private void MouseControlBt_Click(object sender, EventArgs e)
        {

        }

        private void KeyboardControlBt_Click(object sender, EventArgs e)
        {
            //MouseControlToolStripBt.Image = RDP_Capture.Properties.Resources.lightning_delete;
        }

        private bool FullScreen = false;
        private void FullScreenBt_Click(object sender, EventArgs e)
        {
            if (FullScreen)
            {
                FullScreen = false; FormBorderStyle = FormBorderStyle.Sizable; WindowState = FormWindowState.Normal;
            }
            else
            {
                FullScreen = true; FormBorderStyle = FormBorderStyle.None; WindowState = FormWindowState.Maximized;
            }
            TopMost = FullScreen;
        }

        private void CaptureOptionsBt_Click(object sender, EventArgs e)
        {
            var Form = new CaptureOptions();
            Form.Show(this);
            Form.Activate();
        }

        private void PeripheralsToggleBt_Click(object sender, EventArgs e)
        {

        }

        private void PinToolbarBt_Click(object sender, EventArgs e)
        {

        }

        private void CommandsDropBt_Click(object sender, EventArgs e)
        {

        }






    }





}