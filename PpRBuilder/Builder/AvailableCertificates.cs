using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PpRBuilder.Forms
{
    public partial class AvailableCertificates : Form
    {
        public AvailableCertificates()
        {
            InitializeComponent();
            VistaControls.VistaConstants.SetWindowTheme(listView1.Handle, "explorer", null);
        }

        private void AvailableCertificates_Load(object sender, EventArgs e)
        {

        }
    }
}
