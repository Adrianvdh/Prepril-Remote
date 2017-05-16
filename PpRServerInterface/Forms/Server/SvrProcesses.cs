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
    public partial class SvrProcesses : Form
    {
        public SvrProcesses()
        {
            InitializeComponent();
            IntToolStrip.Renderer = new ApplyRenderers.SystemToolStripRenderer();


            #region StubServersListView
            VistaControls.VistaConstants.SetWindowTheme(fullListView1.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(fullListView1.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
            #endregion
        }

        private void SvrProcesses_Load(object sender, EventArgs e)
        {
        }
    }
}
