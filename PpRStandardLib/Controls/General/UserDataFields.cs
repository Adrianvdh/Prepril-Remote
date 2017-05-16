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
    public partial class UserDataFields : UserControl
    {
        public UserDataFields()
        {
            InitializeComponent();
            CategoriesGroupBox.ContextMenu = contextMenu1;
        }
        private void UserDataFields_Load(object sender, EventArgs e)
        {

        }
        private void SelectAllMenuItem_Click(object sender, EventArgs e)
        {
            SettingsCheckBox.Checked = true;
            InterfaceLayoutCheckBox.Checked = true;
            CategoriesCheckBox.Checked = true;
            GroupManagerCheckBox.Checked = true;
            ServerManagerCheckBox.Checked = true;
            QuickConnectFieldsCheckBox.Checked = true;
            FileTransferCheckBox.Checked = true;
            InterfaceStatisticsCheckBox.Checked = true;
            PresetDataCheckBox.Checked = true;
            PluginDataCheckBox.Checked = true;
            AllDbCheckBox.Checked = true;

        }

        private void SelectNoneMenuItem_Click(object sender, EventArgs e)
        {
            SettingsCheckBox.Checked = false;
            InterfaceLayoutCheckBox.Checked = false;
            CategoriesCheckBox.Checked = false;
            GroupManagerCheckBox.Checked = false;
            ServerManagerCheckBox.Checked = false;
            QuickConnectFieldsCheckBox.Checked = false;
            FileTransferCheckBox.Checked = false;
            InterfaceStatisticsCheckBox.Checked = false;
            PresetDataCheckBox.Checked = false;
            PluginDataCheckBox.Checked = false;
            AllDbCheckBox.Checked = false;
        }

        private void CategoriesGroupBox_Enter(object sender, EventArgs e)
        {

        }

    }
}
