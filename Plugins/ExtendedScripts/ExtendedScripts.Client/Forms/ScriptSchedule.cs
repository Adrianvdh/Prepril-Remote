using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExtendedScripts_Client
{
    public partial class ScriptSchedule : Form
    {
        public ScriptSchedule()
        {
            InitializeComponent();
            #region ScheduleListView
            VistaControls.VistaConstants.SetWindowTheme(ScheduleListView.Handle, "explorer", null);
            ScheduleListView.ContextMenu = ScheduleContext;
            #endregion
        }

        private void ScriptSchedule_Load(object sender, EventArgs e)
        {

        }

        private void ScheduleListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            ListView listView = sender as ListView;
            e.Cancel = true;
            e.NewWidth = listView.Columns[e.ColumnIndex].Width;
        }

        private void EnableScheduleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Deselects all items in listview
            foreach (ListViewItem item in ScheduleListView.Items)
            { item.Selected = false; }

            //Enable/Disable schedule
            if (EnableScheduleCheckBox.Checked)
            { projectPanel1.Enabled = true; ScheduleListView.Enabled = true; }
            else
            { projectPanel1.Enabled = false; ScheduleListView.Enabled = false; }
        }

        private void DailyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            label1.Enabled = true; dateTimePicker1.Enabled = true;
            label2.Enabled = false; textBox1.Enabled = false; label5.Enabled = false;
            flowLayoutPanel1.Enabled = false;
        }
        private void WeeklyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            label1.Enabled = true; dateTimePicker1.Enabled = true;
            label2.Enabled = true; textBox1.Enabled = true; label5.Enabled = true;
            flowLayoutPanel1.Enabled = true;
        }
        private void OneTimeRadioButton_CheckedChanged(object sender, EventArgs e)
        { DisableSchedule(); }
        private void UserLogOnRadioButton_CheckedChanged(object sender, EventArgs e)
        { DisableSchedule(); }
        private void DisabledRadioButton_CheckedChanged(object sender, EventArgs e)
        { DisableSchedule(); }
        private void DisableSchedule()
        {
            label1.Enabled = false; dateTimePicker1.Enabled = false;
            label2.Enabled = false; textBox1.Enabled = false; label5.Enabled = false;
            flowLayoutPanel1.Enabled = false;
        }

        private void ScheduleListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ScheduleListView.SelectedItems.Count == 0)
            { groupBox1.Enabled = false; }
            else
            { groupBox1.Enabled = true; }
        }
    }
}
