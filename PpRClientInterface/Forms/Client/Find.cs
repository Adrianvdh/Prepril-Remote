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
    public partial class Find : Form
    {
        public Find()
        {
            InitializeComponent();

            #region FullListView1
            VistaControls.VistaConstants.SetWindowTheme(FullListView1.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(FullListView1.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
            #endregion

            FullListView1.ContextMenu = contextMenu1;
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }
    }
}
