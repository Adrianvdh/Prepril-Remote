using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DemoPlugin.Client
{
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VistaControls.VistaConstants.SetWindowTheme(listView1.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(listView1.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var Form = new QuickConnect();
            //Form.ShowDialog(this);
            //Form.Dispose();
        }
    }
}
