using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PpRServerInterface.Forms
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            label1.Text = "Prepril Remote Client " + Application.ProductVersion;
        }


        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FtrsLnk_Click(object sender, EventArgs e)
        {

        }

        private void UsgeLnk_Click(object sender, EventArgs e)
        {

        }

        private void DocLnk_Click(object sender, EventArgs e)
        {

        }

        private void QstnsLnk_Click(object sender, EventArgs e)
        {

        }

        private void RprtLnk_Click(object sender, EventArgs e)
        {

        }



    }
}
