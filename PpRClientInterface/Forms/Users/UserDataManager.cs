using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PpRClientInterface.Forms
{
    public partial class UserDataBackup : Form
    {
        public UserDataBackup()
        {
            InitializeComponent();
            VistaControls.VistaConstants.SetWindowTheme(BackupRecordsListView.Handle, "explorer", null);
        }

        private void UserDataBackup_Load(object sender, EventArgs e)
        {

        }

        private void BackupRecordsListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            ListView listView = sender as ListView;
            e.Cancel = true;
            e.NewWidth = listView.Columns[e.ColumnIndex].Width;
        }

    }
}
