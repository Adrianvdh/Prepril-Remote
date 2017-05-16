using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PpRBuilder.Forms
{
    public partial class ProfileManager : Form
    {
        public ProfileManager()
        {
            InitializeComponent();
            VistaControls.VistaConstants.SetWindowTheme(ProfileManagerListView.Handle, "explorer", null);
            InterfaceToolStrip.Renderer = new ApplyRenderers.SystemToolStripRenderer();
            ProfileManagerListView.ContextMenu = contextMenu1;
        }

        private void ProfileManager_Load(object sender, EventArgs e)
        {

        }
        private void LoadProfileMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void EditProfileNameMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new ProfileMisc();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        private void DeleteProfileMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void PasswordLockProfileMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new ProfileMisc();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        private void DisablePasswordProfileMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new ProfileMisc();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        private void ProfileManagerListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            ListView listView = sender as ListView;
            e.Cancel = true;
            e.NewWidth = listView.Columns[e.ColumnIndex].Width;
        }
    }
}
