using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PpRClientInterface.Forms
{
    public partial class Analytics : Form
    {
        public Analytics()
        {
            InitializeComponent();
        }

        private void Analytics_Load(object sender, EventArgs e)
        {
           GrapghTypeComboBox.SelectedIndex = 0;
        }
    }
}
