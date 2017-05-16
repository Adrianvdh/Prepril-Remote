using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DatabaseManager_Client
{
    public partial class DatabaseEditor : Form
    {
        public DatabaseEditor()
        {
            InitializeComponent();
            var tabControlRenderer = new TabPadding(tabControl1);
        }

        private void DbEditor_Load(object sender, EventArgs e)
        {

        }
    }
}
