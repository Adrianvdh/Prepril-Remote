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
    public partial class LogEventsListView : UserControl
    {
        public LogEventsListView()
        {
            InitializeComponent();
            richTextBox1.ContextMenu = contextMenu1;

        }

        private void LogEventsListView_Load(object sender, EventArgs e)
        {

        }

        private void LogListView_MouseUp(object sender, MouseEventArgs e)
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

        private void LogListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}
