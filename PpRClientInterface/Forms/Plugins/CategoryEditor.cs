using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CenterParentMsgBox;

namespace PpRClientInterface.Forms
{
    public partial class CategoryEditor : Form
    {
        public CategoryEditor()
        {
            InitializeComponent();
            VistaControls.VistaConstants.SetWindowTheme(CategoriesListView.Handle, "explorer", null);
            VistaControls.VistaConstants.SetWindowTheme(InstalledPluginsListView.Handle, "explorer", null);
            VistaControls.VistaConstants.SetWindowTheme(ContextMenuListView.Handle, "explorer", null);
        }

        private void CategoryEditor_Load(object sender, EventArgs e)
        {

        }
        private void NewCategoryButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteCategoryButton_Click(object sender, EventArgs e)
        {

        }

        private void RenameCategoryButton_Click(object sender, EventArgs e)
        {

        }

        private void DuplicateCategoryButton_Click(object sender, EventArgs e)
        {
            DuplicateContext.Show(DuplicateCategoryButton, new Point(1, DuplicateCategoryButton.Height - 1));
        }

        private void RestoreDefaultButton_Click(object sender, EventArgs e)
        {
            MsgBox.Show("Reset ALL the options to their default values?\n\nClicking 'No' will just reset the options on the 'General' page.", "Category Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void CategoriesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoriesListView.SelectedItems.Count > 0)
            { NewCategoryButton.Enabled = true; DeleteCategoryButton.Enabled = true; RenameCategoryButton.Enabled = true; DuplicateCategoryButton.Enabled = true; }
            else
            { NewCategoryButton.Enabled = false; DeleteCategoryButton.Enabled = false; RenameCategoryButton.Enabled = false; DuplicateCategoryButton.Enabled = false; }

        }


    }
}
