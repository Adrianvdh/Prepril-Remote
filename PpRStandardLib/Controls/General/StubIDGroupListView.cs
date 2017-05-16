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
    public partial class StubsListView : UserControl
    {
        public StubsListView()
        {
            InitializeComponent();
            VistaControls.VistaConstants.SetWindowTheme(StubIDGroupListView.Handle, "explorer", null);
            StubIDGroupListView.ContextMenu = contextMenu1;
        }


        private void ServicesListView_Load(object sender, EventArgs e)
        {

        }

        private void StubIDGroupListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            ListView listView = sender as ListView;
            e.Cancel = true;
            e.NewWidth = listView.Columns[e.ColumnIndex].Width;
        }
    }
}
