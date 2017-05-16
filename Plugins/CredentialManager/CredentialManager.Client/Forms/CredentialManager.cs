using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CredentialManager_Client
{
    public partial class CredentialManager : Form
    {
        public CredentialManager()
        {
            InitializeComponent();
            VistaControls.VistaConstants.SetWindowTheme(CredentialsListView.Handle, "explorer", null);
            CredentialsListView.ContextMenu = contextMenu1;
        }

        private void PasswordReset_Load(object sender, EventArgs e)
        {
        }


    }
}
