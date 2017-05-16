using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApplyRenderers;

namespace UserNotes_Client
{
    public partial class UserNotes : Form
    {
        public UserNotes()
        {
            InitializeComponent();
            var tabControlRenderer = new TabPadding(tabControl1);
            toolStrip1.Renderer = new ApplyRenderers.SystemToolStripRenderer();
        }

        private void AddNoteToolStripBt_Click(object sender, EventArgs e)
        {
            //Adds a new tab page task
            string title = "New Note " + (tabControl1.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            tabControl1.TabPages.Add(myTabPage);

            //Adds the DDOSTaskListView control to the new tab
            var MyControl = new TextBox();
            MyControl.Dock = DockStyle.Fill;
            MyControl.Multiline = true;
            myTabPage.Controls.Add(MyControl);
        }

        private void User_Notes_Load(object sender, EventArgs e)
        {
            AddNoteToolStripBt.PerformClick();
        }

    }
}
