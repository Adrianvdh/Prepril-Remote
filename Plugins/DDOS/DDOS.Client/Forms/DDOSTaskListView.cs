using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DDOS_Client;

namespace DDOS_Client
{
    public partial class DDOSTaskListView : UserControl
    {
        public DDOSTaskListView()
        {
            InitializeComponent();
            VistaControls.VistaConstants.SetWindowTheme(listView1.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(listView1.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
            listView1.ContextMenu = contextMenu1;
        }

        private void ServicesListView_Load(object sender, EventArgs e)
        {

        }

        private void StubDDOSTaskPropertiesMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new StubDDOSTaskProperties();
            Form.ShowDialog(this);
            Form.Dispose();
        }

        private void RemoveStubMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itemSelected in listView1.SelectedItems)
            { listView1.Items.Remove(itemSelected); }
        }

    }
}
