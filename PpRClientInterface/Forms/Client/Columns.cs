using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PpRClientInterface.Forms
{
    public partial class Columns : Form
    {
        public Columns()
        {
            InitializeComponent();
            VistaControls.VistaConstants.SetWindowTheme(ColumnsListView.Handle, "explorer", null);
        }

        private void StubsListColumns_Load(object sender, EventArgs e)
        {
            
        }
    }
}
