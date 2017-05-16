using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CredentialManager_Client
{
    public partial class WebBrowserDataListView : UserControl
    {
        public WebBrowserDataListView()
        {
            InitializeComponent();
            VistaControls.VistaConstants.SetWindowTheme(listView1.Handle, "explorer", null);
            listView1.ContextMenu = contextMenu1;
        }

        private void WebBrowserDataListView_Load(object sender, EventArgs e)
        {

        }
    }
}
