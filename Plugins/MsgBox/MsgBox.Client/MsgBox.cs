using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MsgBox_Client
{
    public partial class SendMsgBox : Form
    {
        public SendMsgBox()
        {
            InitializeComponent();
        }

        private void StubMsgBox_Load(object sender, EventArgs e)
        {
            OKBtComboBox.SelectedIndex = 0;
            YesBtComboBox.SelectedIndex = 0;
            NoBtComboBox.SelectedIndex = 0;
            CancelBtComboBox.SelectedIndex = 0;
        }

        #region IconGroupBox
        private void iconInfoRadioBt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void iconQuestionRadioBt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void iconWarningRadioBt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void iconErrorRadioBt_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region ButtonsGroupBox
        //int ButtonsMode = 1;
        private void BtOKRadioBt_CheckedChanged(object sender, EventArgs e)
        {
            //ButtonsMode = 1;
            OKBtComboBox.Enabled = true; OkBtLabel.Enabled = true;
            YesBtComboBox.Enabled = false; YesBtLabel.Enabled = false;
            NoBtComboBox.Enabled = false; NoBtLabel.Enabled = false;
            CancelBtComboBox.Enabled = false; CancelBtLabel.Enabled = false;
        }
        private void BtYesNoRadioBt_CheckedChanged(object sender, EventArgs e)
        {
            //ButtonsMode = 2;
            OKBtComboBox.Enabled = false; OkBtLabel.Enabled = false;
            YesBtComboBox.Enabled = true; YesBtLabel.Enabled = true;
            NoBtComboBox.Enabled = true; NoBtLabel.Enabled = true;
            CancelBtComboBox.Enabled = false; CancelBtLabel.Enabled = false;
        }
        private void BtYesNoCancelRadioBt_CheckedChanged(object sender, EventArgs e)
        {
            //ButtonsMode = 3;
            OKBtComboBox.Enabled = false; OkBtLabel.Enabled = false;
            YesBtComboBox.Enabled = true; YesBtLabel.Enabled = true;
            NoBtComboBox.Enabled = true; NoBtLabel.Enabled = true;
            CancelBtComboBox.Enabled = true; CancelBtLabel.Enabled = true;
        }
        #endregion

        private void PreviewBtn_Click(object sender, EventArgs e)
        {

        }

        private void SendBtn_Click(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
