using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using wyDay.Controls;

namespace PpRClientInterface.Forms
{
    public partial class PluginManager : Form
    {
        public PluginManager()
        {
            InitializeComponent();

            var tabControlRenderer = new TabPadding(tabControl1);

            
            VistaControls.VistaConstants.SetWindowTheme(AvailableListView.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(AvailableListView.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);


            AvailableListView.ContextMenu = contextMenu1;

        }


    }
}
