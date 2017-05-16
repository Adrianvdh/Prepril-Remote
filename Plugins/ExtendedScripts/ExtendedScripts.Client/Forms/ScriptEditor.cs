using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApplyRenderers;

namespace ExtendedScripts_Client
{
    public partial class ScriptEditor : Form
    {
        public ScriptEditor()
        {
            InitializeComponent();
            var tabControlRenderer = new TabPadding(tabControl1);
            toolStrip1.Renderer = new ApplyRenderers.SystemToolStripRenderer();
        }

        #region File Menu
        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new CreateScript();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        private void OpenMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void SaveAsMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Edit Menu
        #endregion
        #region Mode Menu
        private void SaveMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void LoadMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Language Menu
        private void BatchLangMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PowershellLangMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Mode Menu
        private void VBSLangMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Execute Menu
        private void ExecuteMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExecuteServerMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void ScriptEditor_Load(object sender, EventArgs e)
        {

        }

        private void CreateScriptToolStripBt_Click(object sender, EventArgs e)
        {
            NewMenuItem.PerformClick();
        }



    }
}
