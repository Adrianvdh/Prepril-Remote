using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using PpRClientInterface.Controls;
using PpRClientInterface.Forms.Configuration;
using PpRStandardLib.Forms;

using Chat_Client;
using DemoPlugin;
using MediaManager_Client;
using ExtendedScripts_Client;
using CenterParentMsgBox;


namespace PpRClientInterface.Forms
{
    public partial class ClientInterface : Form
    {
        private bool ExitNow = false;
        private bool m_bLayoutCalled = false;
        private DateTime m_dt;

        public ClientInterface()
        {
            InitializeComponent();
            ApplyRenderer();
            VistaMenu();

            var tabControlRenderer = new TabPadding(InterfaceTbCntrl);

            TryIcn.ContextMenu = TryIcnCntxt;

            TsksCmbx.SelectedIndex = 0;

        }

        
        private void ApplyRenderer()
        {
            IntToolStrip.Renderer = new ApplyRenderers.SystemToolStripRenderer();
            #region StubServersListView
            VistaControls.VistaConstants.SetWindowTheme(StubServersLstVw.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(StubServersLstVw.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
            #endregion
            #region TsksLstVw
            VistaControls.VistaConstants.SetWindowTheme(TsksLstVw.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(TsksLstVw.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
            #endregion
            #region OnConnectListView
            VistaControls.VistaConstants.SetWindowTheme(OnConnectLstVw.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(OnConnectLstVw.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
            #endregion
            #region LogEventsListView
            //VistaControls.VistaConstants.SetWindowTheme(richTextBox1.Handle, "explorer", null);
            //VistaControls.VistaConstants.SendMessage(LogEventsListView.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
            #endregion
        }

        public void VistaMenu()
        {
            vistaMenu.SetImage(m_Find, global::PpRClientInterface.Properties.Resources.find);
        }

        #region Interface
        private void Interface_Load(object sender, EventArgs e)
        {

        }
        bool MinimizeOnClose = false;
        bool MinimizeTray = false;
        private void Interface_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ExitNow)
            {
                if (MinimizeOnClose)
                {
                    e.Cancel = true;
                    if (MinimizeTray)
                    { trayShowHideMenuItem.PerformClick(); }
                    else
                    { WindowState = FormWindowState.Minimized; }
                }
            }
        }
        private void Interface_Resize(object sender, EventArgs e)
        {
            if (MinimizeTray)
            {
                if (WindowState == FormWindowState.Minimized)
                {
                    VisibleView = true;
                    trayShowHideMenuItem.PerformClick();
                    WindowState = FormWindowState.Normal; TryIcn.Visible = true;
                }

                else if (WindowState == FormWindowState.Normal)
                {
                    VisibleView = false;
                    WindowState = FormWindowState.Minimized;
                    trayShowHideMenuItem.PerformClick();
                    // TrayIcon.Visible = false;
                }
            }
 
        }
        //Slpash Screen
        private void ClientInterface_Layout(object sender, System.Windows.Forms.LayoutEventArgs e)
        {
            if (m_bLayoutCalled == false)
            {
                m_bLayoutCalled = true;
                m_dt = DateTime.Now;
                this.Activate();
                SplashScreen.CloseForm();
            }
        }
        #endregion

        #region ToolStrip Buttons
        private void AddManTlstrBt_Click(object sender, EventArgs e)
        {
            m_AddManager.PerformClick();
        }

        private void DscnnctSvrTlstrBt_Click(object sender, EventArgs e)
        {
            m_DisconnectServer.PerformClick();
        }

        private void CnnctSvrTlstrBt_Click(object sender, EventArgs e)
        {
            m_ReconnectServer.PerformClick();
        }

        private void StatsTlstrBt_Click(object sender, EventArgs e)
        {
            StatsMnuItm.PerformClick();
        }

        private void AnlytcTlstrBt_Click(object sender, EventArgs e)
        {
            AnlytcsMnuItm.PerformClick();
        }

        private void NwkScnTlstrBt_Click(object sender, EventArgs e)
        {
            m_NetworkScan.PerformClick();
        }

        private void FndTlstrBt_Click(object sender, EventArgs e)
        {
            m_Find.PerformClick();
        }

        private void SttngTlstrBt_Click(object sender, EventArgs e)
        {
            SttngMnuItm.PerformClick();
        }

        #endregion


        //MainMenu
        #region File Menu
        private void m_AddManager_Click(object sender, EventArgs e)
        {
            var Form = new AddressManager();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        private void m_ExportUserData_Click(object sender, EventArgs e)
        {
            var Form = new UserDataUtil();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        private void m_ImportUserData_Click(object sender, EventArgs e)
        {

        }
        private void m_SaveLogAs_Click(object sender, EventArgs e)
        {

        }

        private void m_Exit_Click(object sender, EventArgs e)
        {
            ExitNow = true;
            this.Close();
        }
        #endregion
        #region View Menu
        private bool TopMostView = false;
        private bool StubsCheckBoxes = false;
        private bool ToolStripView = true;
        private bool CategoryPanelView = true;
        private bool StatusBarView = true;
        private bool CategoryPanelWrapContents = true;

        private void m_TopMost_Click(object sender, EventArgs e)
        {
            m_TopMost.Checked = !TopMostView;
            this.TopMost = !TopMostView;

            TopMostView = !TopMostView;
        }
        private void m_ShowCheckBoxes_Click(object sender, EventArgs e)
        {
            m_ShowCheckBoxes.Checked = !StubsCheckBoxes;
            StubServersLstVw.CheckBoxes = !StubsCheckBoxes;
            OnConnectLstVw.CheckBoxes = !StubsCheckBoxes;

            StubsCheckBoxes = !StubsCheckBoxes;
            ApplyRenderer();
        }
        private void m_ShowCategoryPane_Click(object sender, EventArgs e)
        {
            m_ShowCategoryPane.Checked = !CategoryPanelView;
            categoryPanel1.Visible = !CategoryPanelView;
            LineLbl2.Visible = !CategoryPanelView;

            CategoryPanelView = !CategoryPanelView;
        }
        private void m_ShowToolStrip_Click(object sender, EventArgs e)
        {
            m_ShowToolStrip.Checked = !ToolStripView;
            IntToolStrip.Visible = !ToolStripView;
            LineLbl1.Visible = !ToolStripView;

            ToolStripView = !ToolStripView;
        }

        private void m_ShowStatusBar_Click(object sender, EventArgs e)
        {
            m_ShowStatusBar.Checked = !StatusBarView; 
            InterfaceStatusBar.Visible = !StatusBarView;

            StatusBarView = !StatusBarView;
        }

        #region Category Panel
        private void m_CategoryWrapContents_Click(object sender, EventArgs e)
        {
            if (CategoryPanelWrapContents)
            { CategoryPanelWrapContents = false; }
            else
            { CategoryPanelWrapContents = true; }
            m_CategoryWrapContents.Checked = CategoryPanelWrapContents; //CategoryPanel.WrapContents = CategoryPanelWrapContents;

        }
        #endregion

        private void m_ShowOffline_Click(object sender, EventArgs e)
        {

        }

        private void m_ShowThumbnails_Click(object sender, EventArgs e)
        {

        }

        #endregion
        #region Server Menu
        public bool connection_exists = false;

        private void m_QuickConnect_Click(object sender, EventArgs e)
        {
            var Form = new QuickConnect();
            Form.ShowDialog(this);
            Form.Dispose();

            connection_exists = !connection_exists;
            server_connection();
        }
        private void m_DisconnectServer_Click(object sender, EventArgs e)
        {

        }
        private void m_ReconnectServer_Click(object sender, EventArgs e)
        {

        }
        private void ScptSchdlMnuItm_Click(object sender, EventArgs e)
        {
            var Form = new ScriptSchedule();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        private void UsrDatBckpRstrMnuItm_Click(object sender, EventArgs e)
        {
            var Form = new UserDataBackup();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        #endregion
        #region Stubs Menu
        private void m_DirectConnect_Click(object sender, EventArgs e)
        {
            var Form = new DirectConnect();
            Form.Show(this);
            Form.Activate();
        }
        private void m_AddNew_Click(object sender, EventArgs e)
        {
            var Form = new ManualAddStubs();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        private void m_NetworkScan_Click(object sender, EventArgs e)
        {
            var Form = new NetworkScan();
            Form.Show(this);
            Form.Activate();
        }
        private void m_BuildManager_Click(object sender, EventArgs e)
        {
            var Form = new BuildManager();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        private void m_BuildUpdater_Click(object sender, EventArgs e)
        {
            var Form = new BuildUpdate();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        private void m_RemotePluginManager_Click(object sender, EventArgs e)
        {
            var Form = new RemotePluginManager();
            Form.Show(this);
            Form.Activate();
        }
        private void m_Find_Click(object sender, EventArgs e)
        {
            var Form = new Find();
            Form.Show(this);
            Form.Activate();
        }

        #endregion
        #region Group Menu
        private void m_GroupManager_Click(object sender, EventArgs e)
        {
            var Form = new GroupManager();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        private void m_GroupNone_Click(object sender, EventArgs e)
        {

        }
        private void m_GroupFav_Click(object sender, EventArgs e)
        {

        }
        private void m_GroupMostReliable_Click(object sender, EventArgs e)
        {

        }
        private void m_GroupCountry_Click(object sender, EventArgs e)
        {

        }
        private void m_GroupMostBusy_Click (object sender, EventArgs e)
        {

        }
        
        #endregion
        #region Options Menu
        #region Log Options
        private void AutoScrollServerLogMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void AutoScrollInterfaceLogMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Tool Strip Renderer
        //
        //bool ToolStripSystemRenderer = true;
        //bool ToolStripExplorerRenderer = true;
        //bool ToolStripSilverRenderer = true;
        //

        private void SystemRendererMenuItem_Click(object sender, EventArgs e)
        {
            SystemRendererMenuItem.Checked = true; ExplorerRendererMenuItem.Checked = false; System3DRendererMenuItem.Checked = false;
            IntToolStrip.Renderer = new ApplyRenderers.SystemToolStripRenderer();
            //InterfaceToolStrip.Size = new System.Drawing.Size(925, 28);
        }
        private void ExplorerRendererMenuItem_Click(object sender, EventArgs e)
        {
            SystemRendererMenuItem.Checked = false; ExplorerRendererMenuItem.Checked = true; System3DRendererMenuItem.Checked = false;
            IntToolStrip.Renderer = Antiufo.Controls.Windows7Renderer.Instance;
        }
        private void System3DRendererMenuItem_Click(object sender, EventArgs e)
        {
            SystemRendererMenuItem.Checked = false; ExplorerRendererMenuItem.Checked = false; System3DRendererMenuItem.Checked = true;
            IntToolStrip.Renderer = new ApplyRenderers.SystemToolStripRenderer();
        }
        #endregion

        private void SettingsMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new Settings();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        #endregion
        #region Tools Menu
        private void MediaManagerMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new MediaManager();
            Form.Show(this);
            Form.Activate();
        }
        private void ScriptEditorMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new ScriptEditor();
            Form.Show(this);
            Form.Activate();
        }
        private void ScriptManagerMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new ScriptManager();
            Form.Show(this);
            Form.Activate();
        }
        private void IPTrackerMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new IPAddressTracker();
            Form.Show(this);
            Form.Activate();
        }
        private void SetupAutoSyncMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new UserDataAutoSync();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        private void ClearDataMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new UserDataUtil();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        private void UserChatMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new UserChat();
            Form.Show(this);
            Form.Activate();
        }
        #endregion
        #region Misc Menu

        private void NotesMenuItem_Click(object sender, EventArgs e)
        {
            //var Form = new UserNotes();
            //Form.Show(this);
            //Form.Activate();
        }
        private void StatisticsMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new Statistics();
            Form.Show(this);
            Form.Activate();
        }
        private void AnalyticsMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new Analytics();
            Form.Show(this);
            Form.Activate();
        }

        #endregion
        #region Plugins Menu
        private void PlgnMngrMnuItm_Click(object sender, EventArgs e)
        {
            var Form = new PluginManager
                ();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        private void CtgryEdtrMnuItm_Click(object sender, EventArgs e)
        {
            var Form = new CategoryEditor();
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
            var Form = new AboutTb();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        #endregion
        #region New Version Menu
        private void NewVersionMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new ModuleUpdate();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        #endregion

        //Context Menus
        #region StubServers Contxt
        private void cstub_DirectConnect_Click(object sender, EventArgs e)
        {
            var Form = new DirectConnect();
            Form.Show(this);
            Form.Activate();
        }
        private void cstub_CopyColumn_Click(object sender, EventArgs e)
        {

        }
        private void cstub_Copy_Click(object sender, EventArgs e)
        {

        }
        private void cstub_Suspend_Click(object sender, EventArgs e)
        {
            MsgBox.Show("Blah Blah Blah", "Prepril Remote Client", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        
        }
        private void cstub_Resume_Click(object sender, EventArgs e)
        {

        }
        private void cstub_Restart_Click(object sender, EventArgs e)
        {
            MsgBox.Show("The stub server will restart", "Prepril Remote Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        
        }
        private void cstub_Remove_Click(object sender, EventArgs e)
        {
            MsgBox.Show("Are you sure you want to remove the stub from the servers connection?","Prepril Remote Client",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }
        private void cstub_Uninstall_Click(object sender, EventArgs e)
        {
            MsgBox.Show("Uninstalling the stub server will remove it from the users computer.\nThis cannot be undone!\n\nAre you sure you want to continue?", "Prepril Remote Client", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        
        }
        private void cstub_BuildUpdater_Click(object sender, EventArgs e)
        {
            var Form = new BuildUpdate();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        private void UpdateAllContextItem_Click(object sender, EventArgs e)
        {
            m_BuildUpdater.PerformClick();
        }
        private void cstub_TrackIP_Click(object sender, EventArgs e)
        {
            
        }
        private void cstub_Properties_Click(object sender, EventArgs e)
        {
            var Form = new StubsProperties();
            Form.Show(this);
            Form.Activate();
        }
        #endregion
        #region StubServerContxt2
        private void cstub_ShowThumb_Click(object sender, EventArgs e)
        {

        }
        private void cstub_ShowOffline_Click(object sender, EventArgs e)
        {

        }
        private void cstub_SelectAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listItem in StubServersLstVw.Items)
            {
                listItem.Selected = true;
            }
        }
        private void cstub_CheckAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listItem in StubServersLstVw.Items)
            { 
                listItem.Checked = true;
            }
            if(!StubsCheckBoxes)
            {
                m_ShowCheckBoxes.PerformClick();
            }

        }
        private void cstub_UncheckAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listItem in StubServersLstVw.Items)
            { 
                listItem.Checked = false;
            }
        }

        #region Sort By
        private void cstub_CurrentGroup_Click(object sender, EventArgs e)
        {

        }

        private void cstub_FavOnly_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Favs
        private void cstub_FavAdd_Click(object sender, EventArgs e)
        {

        }

        private void cstub_FavRemove_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #endregion
        #region Stub Server Header
        private void cstub_SizeColumn_Click(object sender, EventArgs e)
        {

        }

        private void cstub_SizeAllColumn_Click(object sender, EventArgs e)
        {

        }

        private void cstub_HideColmun_Click(object sender, EventArgs e)
        {

        }
        private void cstub_ChooseColumns_Click(object sender, EventArgs e)
        {
            var Form = new Columns();
            Form.ShowDialog(this);
            Form.Dispose();
        }
        #endregion

        #region TasksCntxt
        private void cTsk_Terminate_Click(object sender, EventArgs e)
        {

        }

        private void cTsk_Suspend_Click(object sender, EventArgs e)
        {

        }

        private void cTsk_Resume_Click(object sender, EventArgs e)
        {

        }

        private void cTsk_Properties_Click(object sender, EventArgs e)
        {

        }

        private void cTsk_CopyColumn_Click(object sender, EventArgs e)
        {

        }

        private void cTsk_Copy_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region OnConnectCntxt
        private void CnfTskCntxtItm_Click(object sender, EventArgs e)
        {
            var Form = new ConfTaskName();
            Form.ShowDialog(this);
            Form.Dispose();
        }

        private void DsblTskCntxtItm_Click(object sender, EventArgs e)
        {

        }

        private void EnblTskCntxtItm_Click(object sender, EventArgs e)
        {

        }

        private void RmvTskCntxtItm_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region OnConnectBtns
        private void CfgCnnctTskBtn_Click(object sender, EventArgs e)
        {
            var Form = new ConfTaskName();
            Form.ShowDialog(this);
            Form.Dispose();
        }

        private void ClrTsksBtn_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Tray Context
        bool VisibleView = true;
        private void trayShowHideMenuItem_Click(object sender, EventArgs e)
        {
            if (VisibleView)
            { VisibleView = false; }
            else
            { VisibleView = true; }
            this.Visible = VisibleView;
        }
        private void trayExitMenuItem_Click(object sender, EventArgs e)
        {
            m_Exit.PerformClick();
        }
        private void TrayIcon_DoubleClick(object sender, EventArgs e)
        {
            trayShowHideMenuItem.PerformClick();
        }
        #endregion

        #region ListViews Mouse Click
        //Double click action
        private void StubServersLstVw_ItemActivate(object sender, EventArgs e)
        {
            cstub_Properties.PerformClick();
        }
        private void TsksLstVw_ItemActivate(object sender, EventArgs e)
        {

        }

        private void OnConnectLstVw_ItemActivate(object sender, EventArgs e)
        {

        }


        private void StubServersLstVw_MouseUp(object sender, MouseEventArgs e)
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
                if (listView.SelectedItems.Count == 0)
                { StbSvrCntxt2.Show(listView, e.Location); }
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
                    TasksContxt.Show(listView, e.Location);
                }
            }
        }

        private void OnConnectLstVw_MouseUp(object sender, MouseEventArgs e)
        {
            ListView listView = sender as ListView;
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem item = listView.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    item.Selected = true;
                    OnConnectCntxt.Show(listView, e.Location);
                }
            } 
        }

        #endregion



        private void server_connection()
        {
            if (connection_exists)
            {
                //ActiveMenuItem.Enabled = connection_exists;
                //ActiveToolStripBt.Enabled = connection_exists;
                //ActiveMenuItem.PerformClick();

                //LockedMenuItem.Enabled = connection_exists;
                //LockToolStripBt.Enabled = connection_exists;

            }

        }

        

        

        

        


        
        









    }

}
