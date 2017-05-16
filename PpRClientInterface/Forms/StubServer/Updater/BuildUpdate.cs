using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PpRClientInterface.Forms
{
    public partial class BuildUpdate : Form
    {
        public BuildUpdate()
        {
            InitializeComponent();
            VistaControls.VistaConstants.SetWindowTheme(BuildSubmissionsListView.Handle, "explorer", null);
        }

        private void UpdateStubs_Load(object sender, EventArgs e)
        {

        }
        private void BuildSubmissionsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BuildSubmissionsListView.SelectedItems.Count != 0)
            { groupBox1.Enabled = false; }
            else
            { groupBox1.Enabled = true; }
        }
        private void SelectFileRadioButton_CheckedChanged(object sender, EventArgs e)
        { button12.Enabled = true; }
        private void ProvideURLRadioButton_CheckedChanged(object sender, EventArgs e)
        { button12.Enabled = false; }

        private void BuildSubmissionsListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            ListView listView = sender as ListView;
            e.Cancel = true;
            e.NewWidth = listView.Columns[e.ColumnIndex].Width;
        }

        private void BuildSubmissionsListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

    }
}
