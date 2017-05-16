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
    public partial class UserDataAutoSync : Form
    {
        public UserDataAutoSync()
        {
            InitializeComponent();
            VistaControls.VistaConstants.SetWindowTheme(UserAccountsListView.Handle, "explorer", null);
        }

        private void udAutoSync_Load(object sender, EventArgs e)
        {

        }

        private void SetPrimaryButton_Click(object sender, EventArgs e)
        {

        }

        private void SelectDataButton_Click(object sender, EventArgs e)
        {
            var Form = new UserDataUtil();
            Form.ShowDialog(this);
            Form.Dispose();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itemSelected in UserAccountsListView.SelectedItems)
            { UserAccountsListView.Items.Remove(itemSelected); }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            UserAccountsListView.Items.Clear();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserAccountsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserAccountsListView.SelectedItems.Count == 0)
            { SetPrimaryButton.Enabled = false; SelectDataButton.Enabled = false; RemoveButton.Enabled = false; }
            else
            { SetPrimaryButton.Enabled = true; SelectDataButton.Enabled = true; RemoveButton.Enabled = true; }
        }
    }
}
