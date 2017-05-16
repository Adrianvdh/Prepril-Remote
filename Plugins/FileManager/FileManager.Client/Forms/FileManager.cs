using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PpRClientInterface.Controls;

namespace FileManager_Client
{
    public partial class FileManager : Form
    {
        public FileManager()
        {
            InitializeComponent();
            var tabControlRenderer = new TabPadding(tabControl1);

        }

        private int tabCount = 1;
        private void ServerExplorer_Load(object sender, EventArgs e)
        {

        }

        public void VistaMenu()
        {
            //vistaMenu1.SetImage(m_DeviceSelector, global::XboxDeviceExplorer.Properties.Resources.drive_add);
        }


        public void NewTab()
        {
            FileManagerControl dvEx = new FileManagerControl();

            TabPage tmpTabPage = new TabPage("New Tab " + (tabCount++));

            // Attempted FIX. 
            tmpTabPage.SuspendLayout();
            tmpTabPage.Controls.Add(dvEx); // This throws a NullReferenceException?? 
            tmpTabPage.ResumeLayout();

            dvEx.Parent = tmpTabPage;

            dvEx.Dock = DockStyle.Fill;

            //tmpTabPage.Controls.Add(tmpRichTextBox);
            tabControl1.TabPages.Add(tmpTabPage);
            tabControl1.SelectedIndex = tabControl1.TabCount - 1;

        }
    }
}
