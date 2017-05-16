using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PpRClientInterface.Forms
{
    public partial class ManualAddStubs : Form
    {
        public ManualAddStubs()
        {
            InitializeComponent();
        }

        private void AddStubs_Load(object sender, EventArgs e)
        {
            GroupComboBox.Text = "None";
        }
    }
}
