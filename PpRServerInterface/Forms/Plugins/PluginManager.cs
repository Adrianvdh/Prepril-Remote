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
    public partial class PluginManager : Form
    {
        public PluginManager()
        {
            InitializeComponent();
            VistaControls.VistaConstants.SetWindowTheme(InstalledListView.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(InstalledListView.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
            
        }

        private void ServerPluginManager_Load(object sender, EventArgs e)
        {

        }
    }
}
