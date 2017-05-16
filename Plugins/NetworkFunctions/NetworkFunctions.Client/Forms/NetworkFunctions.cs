using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace NetworkFunctions_Client
{
    public partial class NetworkFunctions : Form
    {
        public NetworkFunctions()
        {
            InitializeComponent();

            var tabControlRenderer = new TabPadding(tabControl);
        }

        private void NetworkFunctions_Load(object sender, EventArgs e)
        {

        }
    }
}
