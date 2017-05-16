using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PpRStandardLib.Controls
{
    public partial class ProcessesListView : UserControl
    {
        public ProcessesListView()
        {
            InitializeComponent();
            VistaControls.VistaConstants.SetWindowTheme(TasksListView.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(TasksListView.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
            
        }

        private void ProcossesListView_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProcListView_MouseUp(object sender, MouseEventArgs e)
        {
            ListView listView = sender as ListView;
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem item = listView.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    item.Selected = true;
                    contextMenu1.Show(listView, e.Location);
                }
            } 
        }
    }
}
