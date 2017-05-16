using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DDOS_Client
{
    public partial class DDOSTaskProperties : Form
    {
        public DDOSTaskProperties()
        {
            InitializeComponent();
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DDOSTaskProperties_Load(object sender, EventArgs e)
        {

        }
    }
}
