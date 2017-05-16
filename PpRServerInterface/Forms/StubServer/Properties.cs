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
    public partial class StubsProperties : Form
    {
        public StubsProperties()
        {
            InitializeComponent();
            var tabControlRenderer = new TabPadding(tabControl1);

            #region TsksLstVw
            VistaControls.VistaConstants.SetWindowTheme(TsksLstVw.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(TsksLstVw.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
            #endregion
        }

        private void StubsProperties_Load(object sender, EventArgs e)
        {

        }
    }
}
