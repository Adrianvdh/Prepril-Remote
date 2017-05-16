using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Torrent_Seeder
{
    public partial class TorrentSeeder : Form
    {
        public TorrentSeeder()
        {
            InitializeComponent();
            IntToolStrip.Renderer = new ApplyRenderers.SystemToolStripRenderer();
        }

        private void TorrentSeeder_Load(object sender, EventArgs e)
        {

        }
    }
}
