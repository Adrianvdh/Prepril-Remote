using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintManager_Client
{
    public partial class PrintManager : Form
    {
        public PrintManager()
        {
            InitializeComponent();
            var tabControlRenderer = new TabPadding(tabControl1);
        }

        private void PrintManager_Load(object sender, EventArgs e)
        {

        }
    }
}
