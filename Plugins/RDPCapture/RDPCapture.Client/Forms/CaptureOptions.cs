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
    public partial class CaptureOptions : Form
    {
        public CaptureOptions()
        {
            InitializeComponent();
            var tab = new TabPadding(tabControl1);
        }



        private void RDPCaptureOptions_Load(object sender, EventArgs e)
        {

        }
        private void StartCaptureButton_Click(object sender, EventArgs e)
        {

        }
        private void CloseButton_Click(object sender, EventArgs e)
        {

        }

        private void CaptureQualityTrackBar_Scroll(object sender, EventArgs e)
        {
            int percentage = (int)(((double)CaptureQualityTrackBar.Value / (double)CaptureQualityTrackBar.Maximum) * 100);
            label1.Text = "Capture Quality: " + percentage.ToString() + "%";
        }

    }
}
