using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PpRClientInterface.Forms
{
    public partial class AllTasks : Form
    {
        public AllTasks()
        {
            InitializeComponent();

            InterfaceToolStrip.Renderer = new ApplyRenderers.SystemToolStripRenderer();
            var tabControlRenderer = new TabPadding(tabControl1);
        }

        private void StubsProcesses_Load(object sender, EventArgs e)
        {

        }
    }
}
