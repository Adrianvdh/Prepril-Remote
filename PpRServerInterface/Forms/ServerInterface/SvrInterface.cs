using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PpRStandardLib.Forms;

namespace PpRServerInterface.Forms
{
    public partial class SvrInterface : Form
    {
        public SvrInterface()
        {
            InitializeComponent();
            IntToolStrip.Renderer = new ApplyRenderers.SystemToolStripRenderer();
            var tabControlRenderer = new TabPadding(InterfaceTabControl);

            TryIcn.ContextMenu = TryIcnCntxt;

            #region StubServersListView
            VistaControls.VistaConstants.SetWindowTheme(StbSvrLstVw.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(StbSvrLstVw.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
            #endregion

            #region SocketsListView
            VistaControls.VistaConstants.SetWindowTheme(ScktsLstVw.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(ScktsLstVw.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
            #endregion
            #region NetStatListView
            VistaControls.VistaConstants.SetWindowTheme(NetStatLstVw.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(NetStatLstVw.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
            #endregion

            #region TsksLstVw
            VistaControls.VistaConstants.SetWindowTheme(TsksLstVw.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(TsksLstVw.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
            #endregion
            #region UserAccountsListView
            VistaControls.VistaConstants.SetWindowTheme(UsrAccLstVw.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(UsrAccLstVw.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
            #endregion
            

        }

        private void Interface_Load(object sender, EventArgs e)
        {

        }

        #region File Menu
        private void AddManMnuItm_Click(object sender, EventArgs e)
        {
            var Form = new AddressManager();
            Form.ShowDialog(this);
            Form.Dispose();
        }

        private void SvLogMnuItm_Click(object sender, EventArgs e)
        {

        }

        private void EscMnuItm_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Edit Menu
        private void AwysTopMnuItm_Click(object sender, EventArgs e)
        {

        }

        private void ShwChkbxMnuItm_Click(object sender, EventArgs e)
        {

        }

        private void ShwToolStripMnuItm_Click(object sender, EventArgs e)
        {

        }

        private void ShwStsBarMnuItm_Click(object sender, EventArgs e)
        {

        }

        private void ShwOfflneMnuItm_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Server Menu
        public bool connection_exists = false;

        private bool ServerActive = false;
        private bool ServerLocked = false;

        private void QckCnnctMnuItm_Click(object sender, EventArgs e)
        {
            var Form = new QuickConnect();
            Form.ShowDialog(this);
            Form.Dispose();

            connection_exists = !connection_exists;
            server_connection();
        }

        private void server_connection()
        {
            if (connection_exists)
            {
                ActvMnuItm.Enabled = true;
                ActvTlstrBt.Enabled = true;
                //ActvMnuItm.PerformClick();

                LckTlstrBt.Enabled = true;
                LckTlstrBt.Enabled = true;

                DscnnctMnuItm.Enabled = true;
                DscnnctSvrTlstrBt.Enabled = true;

                RcnnctSvrMnuItm.Enabled = false;
                CnnctSvrTlstrBt.Enabled = false;

            }
            else
            {
                ActvMnuItm.Enabled = false;
                ActvTlstrBt.Enabled = false;
                //ActvMnuItm.PerformClick();

                LckTlstrBt.Enabled = false;
                LckTlstrBt.Enabled = false;

                DscnnctMnuItm.Enabled = false;
                DscnnctSvrTlstrBt.Enabled = false;

                RcnnctSvrMnuItm.Enabled = true;
                CnnctSvrTlstrBt.Enabled = true;

            }

        }

        private void ActvMnuItm_Click(object sender, EventArgs e)
        {
            if (ServerActive)
            {
                ServerActive = false;
                ActvTlstrBt.Image = PpRServerInterface.Properties.Resources.lightning;
            }
            else
            {
                ServerActive = true;
                ActvTlstrBt.Image = PpRServerInterface.Properties.Resources.lightning_go;
            }

            ActvMnuItm.Checked = ServerActive; tryActvCntxt.Checked = ServerActive;
            LckTlstrBt.Enabled = ServerActive;

        }

        private void LckdMnuItm_Click(object sender, EventArgs e)
        {

            if (ServerLocked)
            {
                ServerLocked = false;
                LckTlstrBt.Image = PpRServerInterface.Properties.Resources._lock;
            }
            else
            {
                ServerLocked = true;
                LckTlstrBt.Image = PpRServerInterface.Properties.Resources.lock_go;
            }
            LckdMnuItm.Checked = ServerLocked;
            tryLckdCntxt.Checked = ServerLocked;

        }

        private void RstrtMnuItm_Click(object sender, EventArgs e)
        {
            RstrtMnuItm.Enabled = false;
            RstrtTlstrBt.Enabled = false;
        }

        private void DscnnctMnuItm_Click(object sender, EventArgs e)
        {
            connection_exists = !connection_exists;
            server_connection();
        }

        private void RcnnctSvrMnuItm_Click(object sender, EventArgs e)
        {
            connection_exists = !connection_exists;
            server_connection();
        }
        private void CrtLstPrtMnuItm_Click(object sender, EventArgs e)
        {
            InterfaceTabControl.SelectedIndex = 2;

            var Form = new SocketProperties();
            Form.ShowDialog(this);
            Form.Dispose();
        }

        private void SvrStpMnuItm_Click(object sender, EventArgs e)
        {
            var Form = new ServerSetup();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        
        #endregion
        #region Tools Menu
        private void EvntMngrMnuItm_Click(object sender, EventArgs e)
        {
            var Form = new EventManager();
            Form.ShowDialog(this);
            Form.Dispose();
        }

        private void UsrFeatMnuItm_Click(object sender, EventArgs e)
        {
            var Form = new UserFeatures();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        private void SttngMnuItm_Click(object sender, EventArgs e)
        {
            var Form = new Settings();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        #endregion
        #region Plugins Menu
        private void PlgnMngrMnuItm_Click(object sender, EventArgs e)
        {
            var Form = new PluginManager();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        #endregion
        #region Help Menu
        private void PayPlnMnuItm_Click(object sender, EventArgs e)
        {

        }

        private void WebMnuItm_Click(object sender, EventArgs e)
        {

        }

        private void ForumMnuItm_Click(object sender, EventArgs e)
        {

        }

        private void DwnTrnsMnuItm_Click(object sender, EventArgs e)
        {

        }

        private void ChckUpdtsMnuItm_Click(object sender, EventArgs e)
        {
            var Form = new ModuleUpdate();
            Form.ShowDialog(this);
            Form.Dispose();
        }

        private void DbDirMnuItm_Click(object sender, EventArgs e)
        {

        }

        private void LogDirMnuItm_Click(object sender, EventArgs e)
        {

        }

        private void PlgnsDirMnuItm_Click(object sender, EventArgs e)
        {

        }

        private void WelcDlgMnuItm_Click(object sender, EventArgs e)
        {
            var Form = new Welcome();
            Form.ShowDialog(this);
            Form.Dispose();
        }

        private void AbtMnuItm_Click(object sender, EventArgs e)
        {
            var Form = new About();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        #endregion

        #region ToolStrip Buttons
        private void ActvTlstrBt_Click(object sender, EventArgs e)
        {
            ActvMnuItm.PerformClick();
        }

        private void LckTlstrBt_Click(object sender, EventArgs e)
        {
            LckdMnuItm.PerformClick();
        }

        private void RstrtTlstrBt_Click(object sender, EventArgs e)
        {
            RstrtMnuItm.PerformClick();
        }

        private void DscnnctSvrTlstrBt_Click(object sender, EventArgs e)
        {
            DscnnctMnuItm.PerformClick();
        }

        private void CnnctSvrTlstrBt_Click(object sender, EventArgs e)
        {
            RcnnctSvrMnuItm.PerformClick();
        }

        private void UsrFeatTlstrBt_Click(object sender, EventArgs e)
        {
            UsrFeatMnuItm.PerformClick();
        }
        private void PlgnMngrTlstrBt_Click(object sender, EventArgs e)
        {
            PlgnMngrMnuItm.PerformClick();
        }
        private void SttngTlstrBt_Click(object sender, EventArgs e)
        {
            SttngMnuItm.PerformClick();
        }
        #endregion

        #region StbSvrCntxt
        private void stbsvrCpyClmnCntxtItm_Click(object sender, EventArgs e)
        {

        }

        private void stbsvrCpySlctCntxtItm_Click(object sender, EventArgs e)
        {

        }

        private void stbsvrSpndCntxtItm_Click(object sender, EventArgs e)
        {

        }

        private void stbsvrRsumCntxtItm_Click(object sender, EventArgs e)
        {

        }

        private void stbsvrRstrtCntxtItm_Click(object sender, EventArgs e)
        {

        }

        private void stbsvrRmvCntxtItm_Click(object sender, EventArgs e)
        {

        }

        private void stbsvrUnstllCntxtItm_Click(object sender, EventArgs e)
        {

        }

        private void stbsvrPrptsCntxtItm_Click(object sender, EventArgs e)
        {
            var Form = new StubsProperties();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        #endregion

        #region ScktsCntxt
        private void scktsCnnctdMnuItm_Click(object sender, EventArgs e)
        {
            
        }

        private void scktStrtMnuItm_Click(object sender, EventArgs e)
        {

        }

        private void scktStpMnuItm_Click(object sender, EventArgs e)
        {

        }

        private void scktDelMnuItm_Click(object sender, EventArgs e)
        {

        }

        private void scktPrprtMnuItm_Click(object sender, EventArgs e)
        {
            var Form = new SocketProperties();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        #endregion
        #region NetStat
        private void ntSttCpyClmCntxt_Click(object sender, EventArgs e)
        {

        }
        private void ntSttCpySlctCntxt_Click(object sender, EventArgs e)
        {

        }
        private void ntSttClseCntxt_Click(object sender, EventArgs e)
        {

        }
        private void ntSttPngCntxt_Click(object sender, EventArgs e)
        {
            var Form = new PingTool();
            Form.Show(this);
            Form.Activate();
        }
        #endregion

        #region TasksCntxt
        private void tskKillCntxtItm_Click(object sender, EventArgs e)
        {

        }

        private void tskSpndCntxtItm_Click(object sender, EventArgs e)
        {

        }

        private void tskRsmCntxtItm_Click(object sender, EventArgs e)
        {

        }

        private void tskPrptsCntxtItm_Click(object sender, EventArgs e)
        {
            var Form = new TaskProperties();
            Form.ShowDialog(this);
            Form.Dispose();
        }

        private void tskCpyClmnCntxtItm_Click(object sender, EventArgs e)
        {

        }

        private void tskCpySlctCntxtItm_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region UsrAccCntxt
        private void usrSsnInfCntxtItm_Click(object sender, EventArgs e)
        {
            var Form = new SessionInfo();
            Form.ShowDialog(this);
            Form.Dispose();
        }

        private void usrCpyClmnCntxtItm_Click(object sender, EventArgs e)
        {

        }

        private void usrCpySlctCntxtItm_Click(object sender, EventArgs e)
        {

        }

        private void usrEdtCntxtItm_Click(object sender, EventArgs e)
        {
            var Form = new UserFeatures();
            Form.ShowDialog(this);
            Form.Dispose();
        }

        private void usrDscnntCntxtItm_Click(object sender, EventArgs e)
        {

        }

        private void usrBanIPCntxtItm_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region TryIcnCntxt
        bool VisibleView = true;
        private void tryShwHdCntxt_Click(object sender, EventArgs e)
        {
            if (VisibleView)
            { VisibleView = false; }
            else
            { VisibleView = true; }
            this.Visible = VisibleView;
        }

        private void tryActvCntxt_Click(object sender, EventArgs e)
        {
            EscMnuItm.PerformClick();
        }

        private void tryLckdCntxt_Click(object sender, EventArgs e)
        {

        }

        private void tryRstrtCntxt_Click(object sender, EventArgs e)
        {

        }

        private void tryEnbleNtfCntxt_Click(object sender, EventArgs e)
        {

        }

        private void tryDsblNftCntxt_Click(object sender, EventArgs e)
        {

        }

        private void tryNwScktCntxt_Click(object sender, EventArgs e)
        {

        }

        private void tryStrtWinCntxt_Click(object sender, EventArgs e)
        {

        }

        private void tryExtCntxt_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void TryIcn_DoubleClick(object sender, EventArgs e)
        {
            tryShwHdCntxt.PerformClick();
        }

        #region ListViews Mouse Click
        private void StbSvrLstVw_MouseUp(object sender, MouseEventArgs e)
        {
            ListView listView = sender as ListView;
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem item = listView.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    item.Selected = true;
                    StbSvrCntxt.Show(listView, e.Location);
                }
            } 
        }

        private void UsrAccLstVw_MouseUp(object sender, MouseEventArgs e)
        {
            ListView listView = sender as ListView;
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem item = listView.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    item.Selected = true;
                    UsrAccCntxt.Show(listView, e.Location);
                }
            } 
        }

        private void SocketsListView_MouseUp(object sender, MouseEventArgs e)
        {
            ListView listView = sender as ListView;
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem item = listView.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    item.Selected = true;
                    ScktsCntxt.Show(listView, e.Location);
                }
            }
        }

        private void NetStatListView_MouseUp(object sender, MouseEventArgs e)
        {
            ListView listView = sender as ListView;
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem item = listView.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    item.Selected = true;
                    NtSttCntxt.Show(listView, e.Location);
                }
            } 
        }

        private void TsksLstVw_MouseUp(object sender, MouseEventArgs e)
        {
            ListView listView = sender as ListView;
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem item = listView.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    item.Selected = true;
                    TsksCntxt.Show(listView, e.Location);
                }
            }
        }
        #endregion

        private void SvrPrcMnuItm_Click(object sender, EventArgs e)
        {
            var Form = new SvrProcesses();
            Form.Show(this);
            Form.Activate();
        }

        //Stub servers list view item double clicked
        private void StbSvrLstVw_ItemActivate(object sender, EventArgs e)
        {
            //Double click action
            stbsvrPrptsCntxtItm.PerformClick();
        }

        private void ScktsLstVw_ItemActivate(object sender, EventArgs e)
        {
            //Double click action
            scktPrprtMnuItm.PerformClick();
        }

        private void NetStatLstVw_ItemActivate(object sender, EventArgs e)
        {
            //Double click action
            ntSttPngCntxt.PerformClick();
        }

        private void TsksLstVw_ItemActivate(object sender, EventArgs e)
        {
            //Double click action
            tskPrptsCntxtItm.PerformClick();
        }

        private void UsrAccLstVw_ItemActivate(object sender, EventArgs e)
        {
            //Double click action
            usrSsnInfCntxtItm.PerformClick();
        }

        

        

























    }
}
