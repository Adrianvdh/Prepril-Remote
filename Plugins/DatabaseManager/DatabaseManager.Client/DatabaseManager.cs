using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DatabaseManager_Client
{
    public partial class DatabaseManager : Form
    {
        public DatabaseManager()
        {
            InitializeComponent();

            #region ServerDatabases
            sDbTreeView.ExpandAll();
            VistaControls.VistaConstants.SetWindowTheme(sDbTreeView.Handle, "explorer", null);
            VistaControls.VistaConstants.SetWindowTheme(sDbListView.Handle, "explorer", null);
            #endregion
        }

        private void DatabaseManager_Load(object sender, EventArgs e)
        {

        }

        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new DatabaseEditor();
            Form.Show(this);
            Form.Activate();
        }

  

    }
}
