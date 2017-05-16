using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClipboardManager_Client
{
    public partial class ClipboardManager : Form
    {
        public ClipboardManager()
        {
            InitializeComponent();
            var tabControlRenderer = new TabPadding(tabControl1);
            VistaControls.VistaConstants.SetWindowTheme(listView1.Handle, "explorer", null);
        }

        private void ClipboardManager_Load(object sender, EventArgs e)
        {
            textBox1.ContextMenu = contextMenu1;
            listView1.ContextMenu = contextMenu2;
        }
    }
}
