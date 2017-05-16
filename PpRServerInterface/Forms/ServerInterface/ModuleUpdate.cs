using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PpRStandardLib.Forms;

namespace PpRServerInterface.Forms
{
    public partial class ModuleUpdate : Form
    {
        public ModuleUpdate()
        {
            InitializeComponent();
            
        }

        private void ModuleUpdate_Load(object sender, EventArgs e)
        {
            instverLbl.Text = Application.ProductVersion;
        }

        private void PrcdBtn_Click(object sender, EventArgs e)
        {
            
            var Form = new DataUpdater();
            Form.ShowDialog(this);
            Form.Dispose();
            this.Hide();

            
        }

        private void CnlBtn_Click(object sender, EventArgs e)
        {

        }

        private void ChngLgLnk_Click(object sender, EventArgs e)
        {

        }


    }
}
