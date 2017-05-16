using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PpRClientInterface.Controls;

namespace PpRClientInterface.Forms
{
    public partial class AboutTb : Form
    {
        public AboutTb()
        {
            InitializeComponent();

            var Control = new about_version();
            panel2.Controls.Add(Control);
        }

        private void AboutTb_Load(object sender, EventArgs e)
        {

        }

        private void verLbl_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            var Control = new about_version();
            panel2.Controls.Add(Control);
        }

        private void licLbl_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            var Control = new about_licence();
            panel2.Controls.Add(Control);
        }

        private void comLbl_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            var Control = new about_components();
            panel2.Controls.Add(Control);
        }
    }
}
