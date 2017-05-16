using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileManager_Client
{
    public partial class FileManagerControl : UserControl
    {
        public FileManagerControl()
        {
            InitializeComponent();

            #region LocalListView
            VistaControls.VistaConstants.SetWindowTheme(LocalListView.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(LocalListView.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
            LocalToolStrip.Renderer = new ApplyRenderers.SystemToolStripRenderer();
            #endregion
            #region RemoteListView
            VistaControls.VistaConstants.SetWindowTheme(RemoteListView.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(RemoteListView.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
            RemoteToolStrip.Renderer = new ApplyRenderers.SystemToolStripRenderer();
            #endregion
            
        }

        private void LocalListView_MouseUp(object sender, MouseEventArgs e)
        {
            ListView listView = sender as ListView;
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem item = listView.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    item.Selected = true;
                    LocalListViewContext.Show(listView, e.Location);
                }
                if (listView.SelectedItems.Count == 0)
                { LocalListViewContext2.Show(listView, e.Location); }
            } 
        }

        private void RemoteListView_MouseUp(object sender, MouseEventArgs e)
        {
            ListView listView = sender as ListView;
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem item = listView.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    item.Selected = true;
                    RemoteListViewContext.Show(listView, e.Location);
                }
                if (listView.SelectedItems.Count == 0)
                { RemoteListViewContext2.Show(listView, e.Location); }
            } 
        }


    }
}
