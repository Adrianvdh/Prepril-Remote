using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PpRClientInterface.Forms
{
    public partial class GroupManager : Form
    {
        public GroupManager()
        {
            InitializeComponent();
            VistaControls.VistaConstants.SetWindowTheme(listView1.Handle, "explorer", null);
        }

        private void GroupManager_Load(object sender, EventArgs e)
        {

        }
    }
}
