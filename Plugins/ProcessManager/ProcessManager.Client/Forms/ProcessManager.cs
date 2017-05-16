using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProcessManager_Client
{
    public partial class ProcessManager : Form
    {
        public ProcessManager()
        {
            InitializeComponent();

            var tabControlRenderer = new TabPadding(tabControl);
            #region ProcessesListView
            VistaControls.VistaConstants.SetWindowTheme(ProcessesListView.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(ProcessesListView.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
            #endregion
            #region ServicesListView
            VistaControls.VistaConstants.SetWindowTheme(ServicesListView.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(ServicesListView.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
            #endregion
            #region NetworkListView
            VistaControls.VistaConstants.SetWindowTheme(NetworkListView.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(NetworkListView.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
            #endregion
            #region WindowsListView
            VistaControls.VistaConstants.SetWindowTheme(WindowsListView.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(WindowsListView.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
            #endregion
        }

        private void ProcessManager_Load(object sender, EventArgs e)
        {

        }
    }
}
