﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PpRServerInterface.Forms
{
    public partial class CreateCertificate : Form
    {
        public CreateCertificate()
        {
            InitializeComponent();
        }

        private void CreateCertificate_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 0;

        }
    }
}
