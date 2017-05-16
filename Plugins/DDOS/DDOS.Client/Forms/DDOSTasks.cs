using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DDOS_Client;
using ApplyRenderers;

namespace DDOS_Client
{
    public partial class DDOSTasks : Form
    {
        public DDOSTasks()
        {
            InitializeComponent();
            var tabControlRenderer = new TabPadding(tabControl1);

            //toolStrip1.Renderer = Antiufo.Controls.Windows7Renderer.Instance;
            toolStrip1.Renderer = new ApplyRenderers.SystemToolStripRenderer();
            //toolStrip1.Renderer = new ApplyRenderers.System3DToolStripRenderer();
        }

        private void AddTaskToolStripBt_Click(object sender, EventArgs e)
        {
            var Form = new DDOSTaskProperties();
            Form.ShowDialog(this);
            Form.Dispose();

            //Adds a new tab page task
            string title = "TabPage " + (tabControl1.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            tabControl1.TabPages.Add(myTabPage);

            //Adds the DDOSTaskListView control to the new tab
            var MyControl = new DDOSTaskListView();
            MyControl.Dock = DockStyle.Fill;
            myTabPage.Controls.Add(MyControl);
        }
        private void CloseTaskToolStripBt_Click(object sender, EventArgs e)
        {

        }
        private void TaskPropertiesToolStripBt_Click(object sender, EventArgs e)
        {
            var Form = new DDOSTaskProperties();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        private void TargetInfoToolStripBt_Click(object sender, EventArgs e)
        {
            var Form = new DDOSTaskTargetInfo();
            Form.ShowDialog(this);
            Form.Dispose();
        }

        private void DDOSTasks_Load(object sender, EventArgs e)
        {

        }

    }
}
