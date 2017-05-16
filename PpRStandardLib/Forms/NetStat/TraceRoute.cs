using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PpRStandardLib.Forms
{
    public partial class TraceRoute : Form
    {
        public TraceRoute()
        {
            InitializeComponent();
            VistaControls.VistaConstants.SetWindowTheme(TraceRouteListView.Handle, "explorer", null);
        }

        private void TraceRoute_Load(object sender, EventArgs e)
        {

        }

        private void TraceRouteListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            ListView listView = sender as ListView;
            e.Cancel = true;
            e.NewWidth = listView.Columns[e.ColumnIndex].Width;
        }

        private void TraceRouteListView_MouseUp(object sender, MouseEventArgs e)
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
