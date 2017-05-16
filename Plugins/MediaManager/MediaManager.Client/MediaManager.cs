using System;
using System.Drawing;
using System.Windows.Forms;

namespace MediaManager_Client
{
    public partial class MediaManager : Form
    {
        public MediaManager()
        {
            InitializeComponent();

            treeView1.ExpandAll();
            VistaControls.VistaConstants.SetWindowTheme(treeView1.Handle, "explorer", null);
            VistaControls.VistaConstants.SetWindowTheme(MediaListView.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(MediaListView.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);

            //toolStrip1.Renderer = Antiufo.Controls.Windows7Renderer.Instance;
            toolStrip1.Renderer = new ApplyRenderers.SystemToolStripRenderer();
            //toolStrip1.Renderer = new ApplyRenderers.System3DToolStripRenderer();
        }

        private void ThumbnailManager_Load(object sender, EventArgs e)
        {

        }



        private void PlayMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new MediaPlayer();
            Form.Show(this);
            Form.Activate();
        }

        private void PlayDefaultMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpenFolderMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CopyToMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MoveToMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ArchiveMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MediaListView_MouseUp(object sender, MouseEventArgs e)
        {
            ListView listView = sender as ListView;
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem item = listView.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    item.Selected = true;
                    contextMenu1.Show(listView, e.Location);
                }
            } 
        }

        private void MediaListView_ItemActivate(object sender, EventArgs e)
        {
            PlayMenuItem.PerformClick();
        }





    }
}
