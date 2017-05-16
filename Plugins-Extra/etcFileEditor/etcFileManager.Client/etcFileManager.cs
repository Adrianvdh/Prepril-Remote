using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace etcFile_Manager
{
    public partial class etcFileManager : Form
    {
        public etcFileManager()
        {
            InitializeComponent();
            var tabControlRenderer = new TabPadding(tabControl1);
            VistaControls.VistaConstants.SetWindowTheme(HostsEditorListView.Handle, "explorer", null);
            VistaControls.VistaConstants.SetWindowTheme(ImHostsEditorListView.Handle, "explorer", null);
            VistaControls.VistaConstants.SetWindowTheme(NetworksEditorListView.Handle, "explorer", null);
        }

        private void StubsFileManager_Load(object sender, EventArgs e)
        {

        }

    }
}
