using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NppExtendedScripts;

namespace NppExtendedScripts
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
            #region ProjectTreeView
            ProjectTreeView.ExpandAll();
            ProjectTreeView.ContextMenu = ProjectTreeViewContext;
            VistaControls.VistaConstants.SetWindowTheme(ProjectTreeView.Handle, "explorer", null);
            #endregion
        }

        private void Interface_Load(object sender, EventArgs e)
        {

        }

        private void ConnectServerToolStripBt_Click(object sender, EventArgs e)
        {
            //var Form = new QuickConnect();
            //Form.ShowDialog(this);
            //Form.Dispose();
        }

        private void CreateNewToolStripBt_Click(object sender, EventArgs e)
        {

        }

        private void ExeLocalToolStripBt_Click(object sender, EventArgs e)
        {

        }

        private void ExeRemoteToolStripBt_Click(object sender, EventArgs e)
        {

        }

        private void ReloadServerToolStripBt_Click(object sender, EventArgs e)
        {

        }

        private void SyncServerToolStripBt_Click(object sender, EventArgs e)
        {

        }

        private void DelToolStripBt_Click(object sender, EventArgs e)
        {

        }

        private void ModeToggleToolStripBt_Click(object sender, EventArgs e)
        {

        }

        private void OutPanelToolStripBt_Click(object sender, EventArgs e)
        {
            var Form = new ServerOutput();
            Form.ShowDialog(this);
            Form.Dispose();
        }

        private void OptionsToolStripBt_Click(object sender, EventArgs e)
        {
            var Form = new Options();
            Form.ShowDialog(this);
            Form.Dispose();
        }

        private void AboutToolStripBt_Click(object sender, EventArgs e)
        {
            var Form = new About();
            Form.ShowDialog(this);
            Form.Dispose();
        }
    }
}
