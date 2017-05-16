using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PpRServerInterface.Forms
{
    public partial class AddressManager : Form
    {
        public AddressManager()
        {
            InitializeComponent();
            var tabControlRenderer = new TabPadding(tabControl1);
            VistaControls.VistaConstants.SetWindowTheme(AddressesTreeView.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(AddressesTreeView.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
            
        }

        private void Book_Load(object sender, EventArgs e)
        {

        }
    }
}
