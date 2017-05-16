using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SystemManager_Client
{
    public partial class SystemManager : Form
    {
        public SystemManager()
        {
            InitializeComponent();
            var tabControlRenderer = new TabPadding(InterfaceTabControl);
            #region 
            VistaControls.VistaConstants.SetWindowTheme(treeView1.Handle, "explorer", null);
            VistaControls.VistaConstants.SetWindowTheme(fullListView1.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(fullListView1.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
            #endregion
            #region 
            VistaControls.VistaConstants.SetWindowTheme(fullListView2.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(fullListView2.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
            #endregion
            #region 
            VistaControls.VistaConstants.SetWindowTheme(fullListView3.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(fullListView3.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
            #endregion
            #region 
            VistaControls.VistaConstants.SetWindowTheme(fullListView4.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(fullListView4.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
            #endregion
        }

        private void SystemManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
