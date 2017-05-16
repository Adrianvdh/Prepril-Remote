using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MSReader_Client
{
    public partial class MSReader : Form
    {
        public MSReader()
        {
            InitializeComponent();
            VistaControls.VistaConstants.SetWindowTheme(MSReaderListView.Handle, "explorer", null); //Explorer style
        }

        private void Stubspeak_Load(object sender, EventArgs e)
        {

        }

        private void VoiceListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            ListView listView = sender as ListView;
            e.Cancel = true;
            e.NewWidth = listView.Columns[e.ColumnIndex].Width;
        }

        private void MSReaderListView_MouseUp(object sender, MouseEventArgs e)
        {
            ListView listView = sender as ListView;
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem item = listView.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    item.Selected = true;
                    VoiceListContext.Show(listView, e.Location);
                }
            }
        }
    }
}
