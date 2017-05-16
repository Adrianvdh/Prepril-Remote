using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace PpRStandardLib.Controls
{
    public partial class ProjectPanel : UserControl
    {
        public ProjectPanel()
        {
            InitializeComponent();
            comboBox1.Text = "Select Project";
        }

        private void ProjectPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
