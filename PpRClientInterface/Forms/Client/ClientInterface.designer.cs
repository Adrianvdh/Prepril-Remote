using PpRClientInterface.Controls;
namespace PpRClientInterface.Forms
{
    partial class ClientInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientInterface));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, " New Stub Server"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "149901-08ZA1135"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "197.87.190.101"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "1135"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "1168"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Damian-PC"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Offline", System.Drawing.SystemColors.WindowText, System.Drawing.Color.Red, new System.Drawing.Font("Segoe UI", 9F)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "52ms"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Damian"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Full"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "United States"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "8"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "3"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "5"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "1.0.0.0")}, 244);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "DDOS",
            "Target: moodle.schooltech.co.za",
            "116",
            "Running",
            "00:09:31",
            "Adrian",
            "04:57:51 PM"}, "us.png");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "New Task",
            "Message Box",
            "",
            "5 times",
            "Adrian",
            "2014/07/25 05:25:00 PM"}, -1);
            this.StbSvrCntxt = new System.Windows.Forms.ContextMenu();
            this.cstub_DirectConnect = new System.Windows.Forms.MenuItem();
            this.StbSvrCntxtSep1 = new System.Windows.Forms.MenuItem();
            this.cstub_CopyColumn = new System.Windows.Forms.MenuItem();
            this.cstub_Copy = new System.Windows.Forms.MenuItem();
            this.StbSvrCntxtSep2 = new System.Windows.Forms.MenuItem();
            this.cstub_Suspend = new System.Windows.Forms.MenuItem();
            this.cstub_Resume = new System.Windows.Forms.MenuItem();
            this.cstub_Restart = new System.Windows.Forms.MenuItem();
            this.StbSvrCntxtSep3 = new System.Windows.Forms.MenuItem();
            this.cstub_Remove = new System.Windows.Forms.MenuItem();
            this.cstub_Uninstall = new System.Windows.Forms.MenuItem();
            this.StbSvrCntxtSep5 = new System.Windows.Forms.MenuItem();
            this.cstub_BuildUpdater = new System.Windows.Forms.MenuItem();
            this.StbSvrCntxtSep6 = new System.Windows.Forms.MenuItem();
            this.cstub_TrackIP = new System.Windows.Forms.MenuItem();
            this.StbSvrCntxtSep7 = new System.Windows.Forms.MenuItem();
            this.cstub_Properties = new System.Windows.Forms.MenuItem();
            this.StbSvrClmsCntxt = new System.Windows.Forms.ContextMenu();
            this.cstub_SizeColumn = new System.Windows.Forms.MenuItem();
            this.cstub_SizeAllColumn = new System.Windows.Forms.MenuItem();
            this.cstub_HideColmun = new System.Windows.Forms.MenuItem();
            this.menuItem45 = new System.Windows.Forms.MenuItem();
            this.cstub_ChooseColumns = new System.Windows.Forms.MenuItem();
            this.TryIcnCntxt = new System.Windows.Forms.ContextMenu();
            this.trayShowHideMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem111 = new System.Windows.Forms.MenuItem();
            this.trayStubsProcessesMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem26 = new System.Windows.Forms.MenuItem();
            this.menuItem30 = new System.Windows.Forms.MenuItem();
            this.menuItem31 = new System.Windows.Forms.MenuItem();
            this.menuItem32 = new System.Windows.Forms.MenuItem();
            this.menuItem110 = new System.Windows.Forms.MenuItem();
            this.trayExitMenuItem = new System.Windows.Forms.MenuItem();
            this.IntMnu = new System.Windows.Forms.MainMenu(this.components);
            this.m_File = new System.Windows.Forms.MenuItem();
            this.m_AddManager = new System.Windows.Forms.MenuItem();
            this.FileMnuSep1 = new System.Windows.Forms.MenuItem();
            this.m_ExportUserData = new System.Windows.Forms.MenuItem();
            this.m_ImportUserData = new System.Windows.Forms.MenuItem();
            this.FileMnuSep3 = new System.Windows.Forms.MenuItem();
            this.m_SaveLogAs = new System.Windows.Forms.MenuItem();
            this.FileMnuSep2 = new System.Windows.Forms.MenuItem();
            this.m_Exit = new System.Windows.Forms.MenuItem();
            this.m_View = new System.Windows.Forms.MenuItem();
            this.m_TopMost = new System.Windows.Forms.MenuItem();
            this.ViewMnuSep1 = new System.Windows.Forms.MenuItem();
            this.m_ShowCheckBoxes = new System.Windows.Forms.MenuItem();
            this.m_ShowCategoryPane = new System.Windows.Forms.MenuItem();
            this.m_ShowToolStrip = new System.Windows.Forms.MenuItem();
            this.m_ShowStatusBar = new System.Windows.Forms.MenuItem();
            this.ViewMnuSep2 = new System.Windows.Forms.MenuItem();
            this.m_CategoryPane = new System.Windows.Forms.MenuItem();
            this.m_CategoryWrapContents = new System.Windows.Forms.MenuItem();
            this.m_StubServers = new System.Windows.Forms.MenuItem();
            this.m_ShowOffline = new System.Windows.Forms.MenuItem();
            this.m_ShowThumbnails = new System.Windows.Forms.MenuItem();
            this.m_Server = new System.Windows.Forms.MenuItem();
            this.m_QuickConnect = new System.Windows.Forms.MenuItem();
            this.SvrMnuSep1 = new System.Windows.Forms.MenuItem();
            this.m_DisconnectServer = new System.Windows.Forms.MenuItem();
            this.m_ReconnectServer = new System.Windows.Forms.MenuItem();
            this.SvrMnuSep2 = new System.Windows.Forms.MenuItem();
            this.ScptSchdlMnuItm = new System.Windows.Forms.MenuItem();
            this.UsrDatBckpRstrMnuItm = new System.Windows.Forms.MenuItem();
            this.m_Stubs = new System.Windows.Forms.MenuItem();
            this.m_DirectConnect = new System.Windows.Forms.MenuItem();
            this.StbsMnuSep1 = new System.Windows.Forms.MenuItem();
            this.m_AddNew = new System.Windows.Forms.MenuItem();
            this.m_NetworkScan = new System.Windows.Forms.MenuItem();
            this.StbsMnuSep2 = new System.Windows.Forms.MenuItem();
            this.m_BuildManager = new System.Windows.Forms.MenuItem();
            this.m_BuildUpdater = new System.Windows.Forms.MenuItem();
            this.StbsMnuSep3 = new System.Windows.Forms.MenuItem();
            this.m_RemotePluginManager = new System.Windows.Forms.MenuItem();
            this.StbsMnuSep4 = new System.Windows.Forms.MenuItem();
            this.m_Find = new System.Windows.Forms.MenuItem();
            this.m_Group = new System.Windows.Forms.MenuItem();
            this.m_GroupManager = new System.Windows.Forms.MenuItem();
            this.m_GroupBy = new System.Windows.Forms.MenuItem();
            this.m_GroupNone = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.m_GroupFav = new System.Windows.Forms.MenuItem();
            this.m_GroupBuildID = new System.Windows.Forms.MenuItem();
            this.m_GroupMostReliable = new System.Windows.Forms.MenuItem();
            this.m_GroupCountry = new System.Windows.Forms.MenuItem();
            this.m_GroupMostBusy = new System.Windows.Forms.MenuItem();
            this.m_Options = new System.Windows.Forms.MenuItem();
            this.LgExMnuItm = new System.Windows.Forms.MenuItem();
            this.AutScrllLogMnuItm = new System.Windows.Forms.MenuItem();
            this.AutSvLogMnuItm = new System.Windows.Forms.MenuItem();
            this.OptnMnuSep1 = new System.Windows.Forms.MenuItem();
            this.TlstrRndrExMnuItm = new System.Windows.Forms.MenuItem();
            this.SystemRendererMenuItem = new System.Windows.Forms.MenuItem();
            this.ExplorerRendererMenuItem = new System.Windows.Forms.MenuItem();
            this.System3DRendererMenuItem = new System.Windows.Forms.MenuItem();
            this.LstVwRndrExMnuItm = new System.Windows.Forms.MenuItem();
            this.menuItem47 = new System.Windows.Forms.MenuItem();
            this.menuItem51 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem54 = new System.Windows.Forms.MenuItem();
            this.TrVwRndrExMnuItm = new System.Windows.Forms.MenuItem();
            this.menuItem50 = new System.Windows.Forms.MenuItem();
            this.menuItem20 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.OptnMnuSep2 = new System.Windows.Forms.MenuItem();
            this.SttngMnuItm = new System.Windows.Forms.MenuItem();
            this.TlsMenu = new System.Windows.Forms.MenuItem();
            this.StatsMnuItm = new System.Windows.Forms.MenuItem();
            this.AnlytcsMnuItm = new System.Windows.Forms.MenuItem();
            this.TlsMenuSep1 = new System.Windows.Forms.MenuItem();
            this.IPTrckrMnuItm = new System.Windows.Forms.MenuItem();
            this.TlsMenuSep2 = new System.Windows.Forms.MenuItem();
            this.MediaManagerMenuItem = new System.Windows.Forms.MenuItem();
            this.ScriptEditorMenuItem = new System.Windows.Forms.MenuItem();
            this.ScriptManagerMenuItem = new System.Windows.Forms.MenuItem();
            this.TlsMenuSep3 = new System.Windows.Forms.MenuItem();
            this.NotesMenuItem = new System.Windows.Forms.MenuItem();
            this.UserDataMenuItem = new System.Windows.Forms.MenuItem();
            this.SetupAutoSyncMenuItem = new System.Windows.Forms.MenuItem();
            this.ClearDataMenuItem = new System.Windows.Forms.MenuItem();
            this.UserChatMenuItem = new System.Windows.Forms.MenuItem();
            this.PlgnsMnu = new System.Windows.Forms.MenuItem();
            this.PlgnMngrMnuItm = new System.Windows.Forms.MenuItem();
            this.CtgryEdtrMnuItm = new System.Windows.Forms.MenuItem();
            this.HelpMnu = new System.Windows.Forms.MenuItem();
            this.PayPlnMnuItm = new System.Windows.Forms.MenuItem();
            this.HelpMenuSep1 = new System.Windows.Forms.MenuItem();
            this.WebMnuItm = new System.Windows.Forms.MenuItem();
            this.ForumMnuItm = new System.Windows.Forms.MenuItem();
            this.HelpMenuSep2 = new System.Windows.Forms.MenuItem();
            this.DwnTrnsMnuItm = new System.Windows.Forms.MenuItem();
            this.ChckUpdtsMnuItm = new System.Windows.Forms.MenuItem();
            this.HelpMenuSep3 = new System.Windows.Forms.MenuItem();
            this.DirMnuItm = new System.Windows.Forms.MenuItem();
            this.DbDirMnuItm = new System.Windows.Forms.MenuItem();
            this.LogDirMnuItm = new System.Windows.Forms.MenuItem();
            this.PlgnsDirMnuItm = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.WelcDlgMnuItm = new System.Windows.Forms.MenuItem();
            this.AbtMnuItm = new System.Windows.Forms.MenuItem();
            this.NwVerMnu = new System.Windows.Forms.MenuItem();
            this.NwVerMnuItm = new System.Windows.Forms.MenuItem();
            this.menuItem23 = new System.Windows.Forms.MenuItem();
            this.menuItem25 = new System.Windows.Forms.MenuItem();
            this.menuItem24 = new System.Windows.Forms.MenuItem();
            this.InterfaceStatusBar = new System.Windows.Forms.StatusBar();
            this.RAMUsePanel = new System.Windows.Forms.StatusBarPanel();
            this.CPUUsePanel = new System.Windows.Forms.StatusBarPanel();
            this.StubsPanel = new System.Windows.Forms.StatusBarPanel();
            this.ProcessesPanel = new System.Windows.Forms.StatusBarPanel();
            this.DownSpeedPanel = new System.Windows.Forms.StatusBarPanel();
            this.UpSpeedPanel = new System.Windows.Forms.StatusBarPanel();
            this.TryIcn = new System.Windows.Forms.NotifyIcon(this.components);
            this.FlgsImgLst = new System.Windows.Forms.ImageList(this.components);
            this.OnConnectCntxt = new System.Windows.Forms.ContextMenu();
            this.CnfTskCntxtItm = new System.Windows.Forms.MenuItem();
            this.menuItem78 = new System.Windows.Forms.MenuItem();
            this.DsblTskCntxtItm = new System.Windows.Forms.MenuItem();
            this.EnblTskCntxtItm = new System.Windows.Forms.MenuItem();
            this.menuItem81 = new System.Windows.Forms.MenuItem();
            this.RmvTskCntxtItm = new System.Windows.Forms.MenuItem();
            this.IntToolStrip = new System.Windows.Forms.ToolStrip();
            this.AddManTlstrBt = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.TlstrSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.DscnnctSvrTlstrBt = new System.Windows.Forms.ToolStripButton();
            this.CnnctSvrTlstrBt = new System.Windows.Forms.ToolStripButton();
            this.TlstrSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.StatsTlstrBt = new System.Windows.Forms.ToolStripButton();
            this.AnlytcTlstrBt = new System.Windows.Forms.ToolStripButton();
            this.TlstrSep3 = new System.Windows.Forms.ToolStripSeparator();
            this.NwkScnTlstrBt = new System.Windows.Forms.ToolStripButton();
            this.FndTlstrBt = new System.Windows.Forms.ToolStripButton();
            this.TlstrSep4 = new System.Windows.Forms.ToolStripSeparator();
            this.SttngTlstrBt = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.LineLbl1 = new System.Windows.Forms.Label();
            this.ActiveToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.LineLbl2 = new System.Windows.Forms.Label();
            this.InterfaceTbCntrl = new System.Windows.Forms.TabControl();
            this.StubServersTab = new System.Windows.Forms.TabPage();
            this.StubServersLstVw = new PpRStandardLib.Controls.FullListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConnectionIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IPAddressColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PortColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeviceNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActivityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PingColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrivilegesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CountryColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RatingColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProcessesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PluginsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VersionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TasksTab = new System.Windows.Forms.TabPage();
            this.TsksLstVw = new PpRStandardLib.Controls.FullListView();
            this.columnHeader170 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader171 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DurationColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader172 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader173 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OnConnectTab = new System.Windows.Forms.TabPage();
            this.OnConnectLstVw = new PpRStandardLib.Controls.FullListView();
            this.TaskNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActionDataColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExecutedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OwnerColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.ClrTsksBtn = new System.Windows.Forms.Button();
            this.CfgCnnctTskBtn = new System.Windows.Forms.Button();
            this.TsksCmbx = new System.Windows.Forms.ComboBox();
            this.InterfaceLogTab = new System.Windows.Forms.TabPage();
            this.LogRchtxt = new System.Windows.Forms.RichTextBox();
            this.FindToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.vistaMenu = new wyDay.Controls.VistaMenu(this.components);
            this.StbSvrCntxt2 = new System.Windows.Forms.ContextMenu();
            this.cstub_SelectBy = new System.Windows.Forms.MenuItem();
            this.cstub_CurrentGroup = new System.Windows.Forms.MenuItem();
            this.cstub_FavOnly = new System.Windows.Forms.MenuItem();
            this.cstub_FavGroup = new System.Windows.Forms.MenuItem();
            this.cstub_FavAdd = new System.Windows.Forms.MenuItem();
            this.cstub_FavRemove = new System.Windows.Forms.MenuItem();
            this.menuItem33 = new System.Windows.Forms.MenuItem();
            this.cstub_ShowThumb = new System.Windows.Forms.MenuItem();
            this.cstub_ShowOffline = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.cstub_SelectAll = new System.Windows.Forms.MenuItem();
            this.cstub_CheckAll = new System.Windows.Forms.MenuItem();
            this.cstub_UncheckAll = new System.Windows.Forms.MenuItem();
            this.TasksContxt = new System.Windows.Forms.ContextMenu();
            this.cTsk_Terminate = new System.Windows.Forms.MenuItem();
            this.cTsk_Suspend = new System.Windows.Forms.MenuItem();
            this.cTsk_Resume = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.cTsk_Properties = new System.Windows.Forms.MenuItem();
            this.menuItem18 = new System.Windows.Forms.MenuItem();
            this.cTsk_CopyColumn = new System.Windows.Forms.MenuItem();
            this.cTsk_Copy = new System.Windows.Forms.MenuItem();
            this.categoryPanel1 = new PpRClientInterface.Controls.CategoryPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RAMUsePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPUUsePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StubsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessesPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownSpeedPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpSpeedPanel)).BeginInit();
            this.IntToolStrip.SuspendLayout();
            this.InterfaceTbCntrl.SuspendLayout();
            this.StubServersTab.SuspendLayout();
            this.TasksTab.SuspendLayout();
            this.OnConnectTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.InterfaceLogTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vistaMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // StbSvrCntxt
            // 
            this.StbSvrCntxt.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.cstub_DirectConnect,
            this.StbSvrCntxtSep1,
            this.cstub_CopyColumn,
            this.cstub_Copy,
            this.StbSvrCntxtSep2,
            this.cstub_Suspend,
            this.cstub_Resume,
            this.cstub_Restart,
            this.StbSvrCntxtSep3,
            this.cstub_Remove,
            this.cstub_Uninstall,
            this.StbSvrCntxtSep5,
            this.cstub_BuildUpdater,
            this.StbSvrCntxtSep6,
            this.cstub_TrackIP,
            this.StbSvrCntxtSep7,
            this.cstub_Properties});
            // 
            // cstub_DirectConnect
            // 
            this.cstub_DirectConnect.Index = 0;
            this.cstub_DirectConnect.Text = "Direct Connect";
            this.cstub_DirectConnect.Click += new System.EventHandler(this.cstub_DirectConnect_Click);
            // 
            // StbSvrCntxtSep1
            // 
            this.StbSvrCntxtSep1.Index = 1;
            this.StbSvrCntxtSep1.Text = "-";
            // 
            // cstub_CopyColumn
            // 
            this.cstub_CopyColumn.Index = 2;
            this.cstub_CopyColumn.Text = "Copy (Column)";
            this.cstub_CopyColumn.Click += new System.EventHandler(this.cstub_CopyColumn_Click);
            // 
            // cstub_Copy
            // 
            this.cstub_Copy.Index = 3;
            this.cstub_Copy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.cstub_Copy.Text = "Copy";
            this.cstub_Copy.Click += new System.EventHandler(this.cstub_Copy_Click);
            // 
            // StbSvrCntxtSep2
            // 
            this.StbSvrCntxtSep2.Index = 4;
            this.StbSvrCntxtSep2.Text = "-";
            // 
            // cstub_Suspend
            // 
            this.cstub_Suspend.Index = 5;
            this.cstub_Suspend.Text = "Suspend";
            this.cstub_Suspend.Click += new System.EventHandler(this.cstub_Suspend_Click);
            // 
            // cstub_Resume
            // 
            this.cstub_Resume.Index = 6;
            this.cstub_Resume.Text = "Resume";
            this.cstub_Resume.Click += new System.EventHandler(this.cstub_Resume_Click);
            // 
            // cstub_Restart
            // 
            this.cstub_Restart.Index = 7;
            this.cstub_Restart.Text = "Restart Socket";
            this.cstub_Restart.Click += new System.EventHandler(this.cstub_Restart_Click);
            // 
            // StbSvrCntxtSep3
            // 
            this.StbSvrCntxtSep3.Index = 8;
            this.StbSvrCntxtSep3.Text = "-";
            // 
            // cstub_Remove
            // 
            this.cstub_Remove.Index = 9;
            this.cstub_Remove.Text = "Remove";
            this.cstub_Remove.Click += new System.EventHandler(this.cstub_Remove_Click);
            // 
            // cstub_Uninstall
            // 
            this.cstub_Uninstall.Index = 10;
            this.cstub_Uninstall.Shortcut = System.Windows.Forms.Shortcut.CtrlU;
            this.cstub_Uninstall.Text = "Uninstall";
            this.cstub_Uninstall.Click += new System.EventHandler(this.cstub_Uninstall_Click);
            // 
            // StbSvrCntxtSep5
            // 
            this.StbSvrCntxtSep5.Index = 11;
            this.StbSvrCntxtSep5.Text = "-";
            // 
            // cstub_BuildUpdater
            // 
            this.cstub_BuildUpdater.Index = 12;
            this.cstub_BuildUpdater.Text = "Update Build";
            this.cstub_BuildUpdater.Click += new System.EventHandler(this.cstub_BuildUpdater_Click);
            // 
            // StbSvrCntxtSep6
            // 
            this.StbSvrCntxtSep6.Index = 13;
            this.StbSvrCntxtSep6.Text = "-";
            // 
            // cstub_TrackIP
            // 
            this.cstub_TrackIP.Index = 14;
            this.cstub_TrackIP.Text = "Track IP Address";
            this.cstub_TrackIP.Click += new System.EventHandler(this.cstub_TrackIP_Click);
            // 
            // StbSvrCntxtSep7
            // 
            this.StbSvrCntxtSep7.Index = 15;
            this.StbSvrCntxtSep7.Text = "-";
            // 
            // cstub_Properties
            // 
            this.cstub_Properties.DefaultItem = true;
            this.cstub_Properties.Index = 16;
            this.cstub_Properties.Text = "Properties";
            this.cstub_Properties.Click += new System.EventHandler(this.cstub_Properties_Click);
            // 
            // StbSvrClmsCntxt
            // 
            this.StbSvrClmsCntxt.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.cstub_SizeColumn,
            this.cstub_SizeAllColumn,
            this.cstub_HideColmun,
            this.menuItem45,
            this.cstub_ChooseColumns});
            // 
            // cstub_SizeColumn
            // 
            this.cstub_SizeColumn.Index = 0;
            this.cstub_SizeColumn.Text = "Size Columns to Fit";
            this.cstub_SizeColumn.Click += new System.EventHandler(this.cstub_SizeColumn_Click);
            // 
            // cstub_SizeAllColumn
            // 
            this.cstub_SizeAllColumn.Index = 1;
            this.cstub_SizeAllColumn.Text = "Size All Columns to Fit";
            this.cstub_SizeAllColumn.Click += new System.EventHandler(this.cstub_SizeAllColumn_Click);
            // 
            // cstub_HideColmun
            // 
            this.cstub_HideColmun.Index = 2;
            this.cstub_HideColmun.Text = "Hide Column";
            this.cstub_HideColmun.Click += new System.EventHandler(this.cstub_HideColmun_Click);
            // 
            // menuItem45
            // 
            this.menuItem45.Index = 3;
            this.menuItem45.Text = "-";
            // 
            // cstub_ChooseColumns
            // 
            this.cstub_ChooseColumns.Index = 4;
            this.cstub_ChooseColumns.Text = "Choose Columns";
            this.cstub_ChooseColumns.Click += new System.EventHandler(this.cstub_ChooseColumns_Click);
            // 
            // TryIcnCntxt
            // 
            this.TryIcnCntxt.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.trayShowHideMenuItem,
            this.menuItem111,
            this.trayStubsProcessesMenuItem,
            this.menuItem5,
            this.menuItem110,
            this.trayExitMenuItem});
            // 
            // trayShowHideMenuItem
            // 
            this.trayShowHideMenuItem.DefaultItem = true;
            this.trayShowHideMenuItem.Index = 0;
            this.trayShowHideMenuItem.Text = "Show/Hide";
            this.trayShowHideMenuItem.Click += new System.EventHandler(this.trayShowHideMenuItem_Click);
            // 
            // menuItem111
            // 
            this.menuItem111.Index = 1;
            this.menuItem111.Text = "-";
            // 
            // trayStubsProcessesMenuItem
            // 
            this.trayStubsProcessesMenuItem.Index = 2;
            this.trayStubsProcessesMenuItem.Text = "";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 3;
            this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem26,
            this.menuItem30,
            this.menuItem31,
            this.menuItem32});
            this.menuItem5.Text = "Notifications";
            // 
            // menuItem26
            // 
            this.menuItem26.Index = 0;
            this.menuItem26.Text = "Enabled All";
            // 
            // menuItem30
            // 
            this.menuItem30.Index = 1;
            this.menuItem30.Text = "Disable All";
            // 
            // menuItem31
            // 
            this.menuItem31.Index = 2;
            this.menuItem31.Text = "-";
            // 
            // menuItem32
            // 
            this.menuItem32.Index = 3;
            this.menuItem32.Text = "New Socket";
            // 
            // menuItem110
            // 
            this.menuItem110.Index = 4;
            this.menuItem110.Text = "-";
            // 
            // trayExitMenuItem
            // 
            this.trayExitMenuItem.Index = 5;
            this.trayExitMenuItem.Text = "Exit";
            this.trayExitMenuItem.Click += new System.EventHandler(this.trayExitMenuItem_Click);
            // 
            // IntMnu
            // 
            this.IntMnu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.m_File,
            this.m_View,
            this.m_Server,
            this.m_Stubs,
            this.m_Group,
            this.m_Options,
            this.TlsMenu,
            this.PlgnsMnu,
            this.HelpMnu,
            this.NwVerMnu});
            // 
            // m_File
            // 
            this.m_File.Index = 0;
            this.m_File.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.m_AddManager,
            this.FileMnuSep1,
            this.m_ExportUserData,
            this.m_ImportUserData,
            this.FileMnuSep3,
            this.m_SaveLogAs,
            this.FileMnuSep2,
            this.m_Exit});
            this.m_File.Text = "File";
            // 
            // m_AddManager
            // 
            this.m_AddManager.Index = 0;
            this.m_AddManager.Text = "Address Manager";
            this.m_AddManager.Click += new System.EventHandler(this.m_AddManager_Click);
            // 
            // FileMnuSep1
            // 
            this.FileMnuSep1.Index = 1;
            this.FileMnuSep1.Text = "-";
            // 
            // m_ExportUserData
            // 
            this.m_ExportUserData.Index = 2;
            this.m_ExportUserData.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftE;
            this.m_ExportUserData.Text = "Export User Data";
            this.m_ExportUserData.Click += new System.EventHandler(this.m_ExportUserData_Click);
            // 
            // m_ImportUserData
            // 
            this.m_ImportUserData.Index = 3;
            this.m_ImportUserData.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftI;
            this.m_ImportUserData.Text = "Import User Data";
            this.m_ImportUserData.Click += new System.EventHandler(this.m_ImportUserData_Click);
            // 
            // FileMnuSep3
            // 
            this.FileMnuSep3.Index = 4;
            this.FileMnuSep3.Text = "-";
            // 
            // m_SaveLogAs
            // 
            this.m_SaveLogAs.Index = 5;
            this.m_SaveLogAs.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.m_SaveLogAs.Text = "Save Log As...";
            this.m_SaveLogAs.Click += new System.EventHandler(this.m_SaveLogAs_Click);
            // 
            // FileMnuSep2
            // 
            this.FileMnuSep2.Index = 6;
            this.FileMnuSep2.Text = "-";
            // 
            // m_Exit
            // 
            this.m_Exit.Index = 7;
            this.m_Exit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.m_Exit.Text = "Exit";
            this.m_Exit.Click += new System.EventHandler(this.m_Exit_Click);
            // 
            // m_View
            // 
            this.m_View.Index = 1;
            this.m_View.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.m_TopMost,
            this.ViewMnuSep1,
            this.m_ShowCheckBoxes,
            this.m_ShowCategoryPane,
            this.m_ShowToolStrip,
            this.m_ShowStatusBar,
            this.ViewMnuSep2,
            this.m_CategoryPane,
            this.m_StubServers});
            this.m_View.Text = "View";
            // 
            // m_TopMost
            // 
            this.m_TopMost.Index = 0;
            this.m_TopMost.Text = "Always on Top";
            this.m_TopMost.Click += new System.EventHandler(this.m_TopMost_Click);
            // 
            // ViewMnuSep1
            // 
            this.ViewMnuSep1.Index = 1;
            this.ViewMnuSep1.Text = "-";
            // 
            // m_ShowCheckBoxes
            // 
            this.m_ShowCheckBoxes.Index = 2;
            this.m_ShowCheckBoxes.Text = "Show Check Boxes";
            this.m_ShowCheckBoxes.Click += new System.EventHandler(this.m_ShowCheckBoxes_Click);
            // 
            // m_ShowCategoryPane
            // 
            this.m_ShowCategoryPane.Checked = true;
            this.m_ShowCategoryPane.Index = 3;
            this.m_ShowCategoryPane.Text = "Show Category Panel";
            this.m_ShowCategoryPane.Click += new System.EventHandler(this.m_ShowCategoryPane_Click);
            // 
            // m_ShowToolStrip
            // 
            this.m_ShowToolStrip.Checked = true;
            this.m_ShowToolStrip.Index = 4;
            this.m_ShowToolStrip.Text = "Show Tool Strip";
            this.m_ShowToolStrip.Click += new System.EventHandler(this.m_ShowToolStrip_Click);
            // 
            // m_ShowStatusBar
            // 
            this.m_ShowStatusBar.Checked = true;
            this.m_ShowStatusBar.Index = 5;
            this.m_ShowStatusBar.Text = "Show Status Bar";
            this.m_ShowStatusBar.Click += new System.EventHandler(this.m_ShowStatusBar_Click);
            // 
            // ViewMnuSep2
            // 
            this.ViewMnuSep2.Index = 6;
            this.ViewMnuSep2.Text = "-";
            // 
            // m_CategoryPane
            // 
            this.m_CategoryPane.Index = 7;
            this.m_CategoryPane.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.m_CategoryWrapContents});
            this.m_CategoryPane.Text = "Category Panel";
            // 
            // m_CategoryWrapContents
            // 
            this.m_CategoryWrapContents.Checked = true;
            this.m_CategoryWrapContents.Index = 0;
            this.m_CategoryWrapContents.Text = "Wrap Contents";
            this.m_CategoryWrapContents.Click += new System.EventHandler(this.m_CategoryWrapContents_Click);
            // 
            // m_StubServers
            // 
            this.m_StubServers.Index = 8;
            this.m_StubServers.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.m_ShowOffline,
            this.m_ShowThumbnails});
            this.m_StubServers.Text = "Stub Servers";
            // 
            // m_ShowOffline
            // 
            this.m_ShowOffline.Index = 0;
            this.m_ShowOffline.Text = "Show Offline";
            this.m_ShowOffline.Click += new System.EventHandler(this.m_ShowOffline_Click);
            // 
            // m_ShowThumbnails
            // 
            this.m_ShowThumbnails.Index = 1;
            this.m_ShowThumbnails.Text = "Show Thumbnails";
            this.m_ShowThumbnails.Click += new System.EventHandler(this.m_ShowThumbnails_Click);
            // 
            // m_Server
            // 
            this.m_Server.Index = 2;
            this.m_Server.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.m_QuickConnect,
            this.SvrMnuSep1,
            this.m_DisconnectServer,
            this.m_ReconnectServer,
            this.SvrMnuSep2,
            this.ScptSchdlMnuItm,
            this.UsrDatBckpRstrMnuItm});
            this.m_Server.Text = "Server";
            // 
            // m_QuickConnect
            // 
            this.m_QuickConnect.Index = 0;
            this.m_QuickConnect.Shortcut = System.Windows.Forms.Shortcut.CtrlQ;
            this.m_QuickConnect.Text = "Quick Connect...";
            this.m_QuickConnect.Click += new System.EventHandler(this.m_QuickConnect_Click);
            // 
            // SvrMnuSep1
            // 
            this.SvrMnuSep1.Index = 1;
            this.SvrMnuSep1.Text = "-";
            // 
            // m_DisconnectServer
            // 
            this.m_DisconnectServer.Enabled = false;
            this.m_DisconnectServer.Index = 2;
            this.m_DisconnectServer.Shortcut = System.Windows.Forms.Shortcut.CtrlD;
            this.m_DisconnectServer.Text = "Disconnect";
            this.m_DisconnectServer.Click += new System.EventHandler(this.m_DisconnectServer_Click);
            // 
            // m_ReconnectServer
            // 
            this.m_ReconnectServer.Index = 3;
            this.m_ReconnectServer.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
            this.m_ReconnectServer.Text = "Reconnect";
            this.m_ReconnectServer.Click += new System.EventHandler(this.m_ReconnectServer_Click);
            // 
            // SvrMnuSep2
            // 
            this.SvrMnuSep2.Index = 4;
            this.SvrMnuSep2.Text = "-";
            // 
            // ScptSchdlMnuItm
            // 
            this.ScptSchdlMnuItm.Index = 5;
            this.ScptSchdlMnuItm.Text = "Script Schedule";
            this.ScptSchdlMnuItm.Click += new System.EventHandler(this.ScptSchdlMnuItm_Click);
            // 
            // UsrDatBckpRstrMnuItm
            // 
            this.UsrDatBckpRstrMnuItm.Index = 6;
            this.UsrDatBckpRstrMnuItm.Text = "User Data Backup And Restore";
            this.UsrDatBckpRstrMnuItm.Click += new System.EventHandler(this.UsrDatBckpRstrMnuItm_Click);
            // 
            // m_Stubs
            // 
            this.m_Stubs.Index = 3;
            this.m_Stubs.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.m_DirectConnect,
            this.StbsMnuSep1,
            this.m_AddNew,
            this.m_NetworkScan,
            this.StbsMnuSep2,
            this.m_BuildManager,
            this.m_BuildUpdater,
            this.StbsMnuSep3,
            this.m_RemotePluginManager,
            this.StbsMnuSep4,
            this.m_Find});
            this.m_Stubs.Text = "Stubs";
            // 
            // m_DirectConnect
            // 
            this.m_DirectConnect.Index = 0;
            this.m_DirectConnect.Text = "Direct Connect";
            this.m_DirectConnect.Click += new System.EventHandler(this.m_DirectConnect_Click);
            // 
            // StbsMnuSep1
            // 
            this.StbsMnuSep1.Index = 1;
            this.StbsMnuSep1.Text = "-";
            // 
            // m_AddNew
            // 
            this.m_AddNew.Index = 2;
            this.m_AddNew.Text = "Add New [Listening] (WAN/LAN)";
            this.m_AddNew.Click += new System.EventHandler(this.m_AddNew_Click);
            // 
            // m_NetworkScan
            // 
            this.m_NetworkScan.Index = 3;
            this.m_NetworkScan.Text = "Network Scan [Listening] (LAN)";
            this.m_NetworkScan.Click += new System.EventHandler(this.m_NetworkScan_Click);
            // 
            // StbsMnuSep2
            // 
            this.StbsMnuSep2.Index = 4;
            this.StbsMnuSep2.Text = "-";
            // 
            // m_BuildManager
            // 
            this.m_BuildManager.Index = 5;
            this.m_BuildManager.Shortcut = System.Windows.Forms.Shortcut.CtrlB;
            this.m_BuildManager.Text = "Build Manager";
            this.m_BuildManager.Click += new System.EventHandler(this.m_BuildManager_Click);
            // 
            // m_BuildUpdater
            // 
            this.m_BuildUpdater.Index = 6;
            this.m_BuildUpdater.Text = "Build Updater";
            this.m_BuildUpdater.Click += new System.EventHandler(this.m_BuildUpdater_Click);
            // 
            // StbsMnuSep3
            // 
            this.StbsMnuSep3.Index = 7;
            this.StbsMnuSep3.Text = "-";
            // 
            // m_RemotePluginManager
            // 
            this.m_RemotePluginManager.Index = 8;
            this.m_RemotePluginManager.Text = "Plugin Manager";
            this.m_RemotePluginManager.Click += new System.EventHandler(this.m_RemotePluginManager_Click);
            // 
            // StbsMnuSep4
            // 
            this.StbsMnuSep4.Index = 9;
            this.StbsMnuSep4.Text = "-";
            // 
            // m_Find
            // 
            this.m_Find.Index = 10;
            this.m_Find.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
            this.m_Find.Text = "Find";
            this.m_Find.Click += new System.EventHandler(this.m_Find_Click);
            // 
            // m_Group
            // 
            this.m_Group.Index = 4;
            this.m_Group.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.m_GroupManager,
            this.m_GroupBy});
            this.m_Group.Text = "Group";
            // 
            // m_GroupManager
            // 
            this.m_GroupManager.Index = 0;
            this.m_GroupManager.Shortcut = System.Windows.Forms.Shortcut.CtrlG;
            this.m_GroupManager.Text = "Group Manager";
            this.m_GroupManager.Click += new System.EventHandler(this.m_GroupManager_Click);
            // 
            // m_GroupBy
            // 
            this.m_GroupBy.Enabled = false;
            this.m_GroupBy.Index = 1;
            this.m_GroupBy.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.m_GroupNone,
            this.menuItem2,
            this.m_GroupFav,
            this.m_GroupBuildID,
            this.m_GroupMostReliable,
            this.m_GroupCountry,
            this.m_GroupMostBusy});
            this.m_GroupBy.Text = "Group By";
            // 
            // m_GroupNone
            // 
            this.m_GroupNone.Index = 0;
            this.m_GroupNone.Text = "None";
            this.m_GroupNone.Click += new System.EventHandler(this.m_GroupNone_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "-";
            // 
            // m_GroupFav
            // 
            this.m_GroupFav.Index = 2;
            this.m_GroupFav.RadioCheck = true;
            this.m_GroupFav.Text = "Favorite";
            this.m_GroupFav.Click += new System.EventHandler(this.m_GroupFav_Click);
            // 
            // m_GroupBuildID
            // 
            this.m_GroupBuildID.Index = 3;
            this.m_GroupBuildID.Text = "Build ID";
            // 
            // m_GroupMostReliable
            // 
            this.m_GroupMostReliable.Index = 4;
            this.m_GroupMostReliable.RadioCheck = true;
            this.m_GroupMostReliable.Text = "Most Reliable";
            this.m_GroupMostReliable.Click += new System.EventHandler(this.m_GroupMostReliable_Click);
            // 
            // m_GroupCountry
            // 
            this.m_GroupCountry.Index = 5;
            this.m_GroupCountry.RadioCheck = true;
            this.m_GroupCountry.Text = "Country";
            this.m_GroupCountry.Click += new System.EventHandler(this.m_GroupCountry_Click);
            // 
            // m_GroupMostBusy
            // 
            this.m_GroupMostBusy.Index = 6;
            this.m_GroupMostBusy.RadioCheck = true;
            this.m_GroupMostBusy.Text = "Most Busy";
            this.m_GroupMostBusy.Click += new System.EventHandler(this.m_GroupMostBusy_Click);
            // 
            // m_Options
            // 
            this.m_Options.Index = 5;
            this.m_Options.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.LgExMnuItm,
            this.OptnMnuSep1,
            this.TlstrRndrExMnuItm,
            this.LstVwRndrExMnuItm,
            this.TrVwRndrExMnuItm,
            this.OptnMnuSep2,
            this.SttngMnuItm});
            this.m_Options.Text = "Options";
            // 
            // LgExMnuItm
            // 
            this.LgExMnuItm.Index = 0;
            this.LgExMnuItm.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.AutScrllLogMnuItm,
            this.AutSvLogMnuItm});
            this.LgExMnuItm.Text = "Log";
            // 
            // AutScrllLogMnuItm
            // 
            this.AutScrllLogMnuItm.Checked = true;
            this.AutScrllLogMnuItm.Index = 0;
            this.AutScrllLogMnuItm.Text = "Automatically Scroll";
            this.AutScrllLogMnuItm.Click += new System.EventHandler(this.AutoScrollServerLogMenuItem_Click);
            // 
            // AutSvLogMnuItm
            // 
            this.AutSvLogMnuItm.Checked = true;
            this.AutSvLogMnuItm.Index = 1;
            this.AutSvLogMnuItm.Text = "Automatically Save";
            // 
            // OptnMnuSep1
            // 
            this.OptnMnuSep1.Index = 1;
            this.OptnMnuSep1.Text = "-";
            // 
            // TlstrRndrExMnuItm
            // 
            this.TlstrRndrExMnuItm.Index = 2;
            this.TlstrRndrExMnuItm.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.SystemRendererMenuItem,
            this.ExplorerRendererMenuItem,
            this.System3DRendererMenuItem});
            this.TlstrRndrExMnuItm.Text = "Tool Strip Renderer";
            // 
            // SystemRendererMenuItem
            // 
            this.SystemRendererMenuItem.Checked = true;
            this.SystemRendererMenuItem.Index = 0;
            this.SystemRendererMenuItem.RadioCheck = true;
            this.SystemRendererMenuItem.Text = "System";
            this.SystemRendererMenuItem.Click += new System.EventHandler(this.SystemRendererMenuItem_Click);
            // 
            // ExplorerRendererMenuItem
            // 
            this.ExplorerRendererMenuItem.Index = 1;
            this.ExplorerRendererMenuItem.RadioCheck = true;
            this.ExplorerRendererMenuItem.Text = "Windows Explorer";
            this.ExplorerRendererMenuItem.Click += new System.EventHandler(this.ExplorerRendererMenuItem_Click);
            // 
            // System3DRendererMenuItem
            // 
            this.System3DRendererMenuItem.Index = 2;
            this.System3DRendererMenuItem.RadioCheck = true;
            this.System3DRendererMenuItem.Text = "System 3D";
            this.System3DRendererMenuItem.Click += new System.EventHandler(this.System3DRendererMenuItem_Click);
            // 
            // LstVwRndrExMnuItm
            // 
            this.LstVwRndrExMnuItm.Index = 3;
            this.LstVwRndrExMnuItm.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem47,
            this.menuItem51,
            this.menuItem13,
            this.menuItem54});
            this.LstVwRndrExMnuItm.Text = "List View Renderer";
            // 
            // menuItem47
            // 
            this.menuItem47.Checked = true;
            this.menuItem47.Index = 0;
            this.menuItem47.RadioCheck = true;
            this.menuItem47.Text = "Aero Theme";
            // 
            // menuItem51
            // 
            this.menuItem51.Checked = true;
            this.menuItem51.Index = 1;
            this.menuItem51.Text = "Aero Muliselect";
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 2;
            this.menuItem13.Text = "-";
            // 
            // menuItem54
            // 
            this.menuItem54.Index = 3;
            this.menuItem54.RadioCheck = true;
            this.menuItem54.Text = "None";
            // 
            // TrVwRndrExMnuItm
            // 
            this.TrVwRndrExMnuItm.Index = 4;
            this.TrVwRndrExMnuItm.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem50,
            this.menuItem20,
            this.menuItem12});
            this.TrVwRndrExMnuItm.Text = "Tree View Renderer";
            // 
            // menuItem50
            // 
            this.menuItem50.Checked = true;
            this.menuItem50.Index = 0;
            this.menuItem50.RadioCheck = true;
            this.menuItem50.Text = "Aero Theme";
            // 
            // menuItem20
            // 
            this.menuItem20.Index = 1;
            this.menuItem20.Text = "-";
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 2;
            this.menuItem12.RadioCheck = true;
            this.menuItem12.Text = "None";
            // 
            // OptnMnuSep2
            // 
            this.OptnMnuSep2.Index = 5;
            this.OptnMnuSep2.Text = "-";
            // 
            // SttngMnuItm
            // 
            this.SttngMnuItm.Index = 6;
            this.SttngMnuItm.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            this.SttngMnuItm.Text = "Settings...";
            this.SttngMnuItm.Click += new System.EventHandler(this.SettingsMenuItem_Click);
            // 
            // TlsMenu
            // 
            this.TlsMenu.Index = 6;
            this.TlsMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.StatsMnuItm,
            this.AnlytcsMnuItm,
            this.TlsMenuSep1,
            this.IPTrckrMnuItm,
            this.TlsMenuSep2,
            this.MediaManagerMenuItem,
            this.ScriptEditorMenuItem,
            this.ScriptManagerMenuItem,
            this.TlsMenuSep3,
            this.NotesMenuItem,
            this.UserDataMenuItem,
            this.UserChatMenuItem});
            this.TlsMenu.Text = "Tools";
            // 
            // StatsMnuItm
            // 
            this.StatsMnuItm.Index = 0;
            this.StatsMnuItm.Shortcut = System.Windows.Forms.Shortcut.F10;
            this.StatsMnuItm.Text = "Statistics...";
            this.StatsMnuItm.Click += new System.EventHandler(this.StatisticsMenuItem_Click);
            // 
            // AnlytcsMnuItm
            // 
            this.AnlytcsMnuItm.Index = 1;
            this.AnlytcsMnuItm.Shortcut = System.Windows.Forms.Shortcut.F11;
            this.AnlytcsMnuItm.Text = "Analytics...";
            this.AnlytcsMnuItm.Click += new System.EventHandler(this.AnalyticsMenuItem_Click);
            // 
            // TlsMenuSep1
            // 
            this.TlsMenuSep1.Index = 2;
            this.TlsMenuSep1.Text = "-";
            // 
            // IPTrckrMnuItm
            // 
            this.IPTrckrMnuItm.Index = 3;
            this.IPTrckrMnuItm.Text = "IP Address Tracker";
            this.IPTrckrMnuItm.Click += new System.EventHandler(this.IPTrackerMenuItem_Click);
            // 
            // TlsMenuSep2
            // 
            this.TlsMenuSep2.Index = 4;
            this.TlsMenuSep2.Text = "-";
            // 
            // MediaManagerMenuItem
            // 
            this.MediaManagerMenuItem.Index = 5;
            this.MediaManagerMenuItem.Text = "Media Manager";
            this.MediaManagerMenuItem.Click += new System.EventHandler(this.MediaManagerMenuItem_Click);
            // 
            // ScriptEditorMenuItem
            // 
            this.ScriptEditorMenuItem.Index = 6;
            this.ScriptEditorMenuItem.Text = "Script Editor";
            this.ScriptEditorMenuItem.Click += new System.EventHandler(this.ScriptEditorMenuItem_Click);
            // 
            // ScriptManagerMenuItem
            // 
            this.ScriptManagerMenuItem.Index = 7;
            this.ScriptManagerMenuItem.Text = "Script Manager";
            this.ScriptManagerMenuItem.Click += new System.EventHandler(this.ScriptManagerMenuItem_Click);
            // 
            // TlsMenuSep3
            // 
            this.TlsMenuSep3.Index = 8;
            this.TlsMenuSep3.Text = "-";
            // 
            // NotesMenuItem
            // 
            this.NotesMenuItem.Index = 9;
            this.NotesMenuItem.Text = "Notes...";
            this.NotesMenuItem.Click += new System.EventHandler(this.NotesMenuItem_Click);
            // 
            // UserDataMenuItem
            // 
            this.UserDataMenuItem.Index = 10;
            this.UserDataMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.SetupAutoSyncMenuItem,
            this.ClearDataMenuItem});
            this.UserDataMenuItem.Text = "User Data";
            // 
            // SetupAutoSyncMenuItem
            // 
            this.SetupAutoSyncMenuItem.Index = 0;
            this.SetupAutoSyncMenuItem.Text = "Setup AutoSync";
            this.SetupAutoSyncMenuItem.Click += new System.EventHandler(this.SetupAutoSyncMenuItem_Click);
            // 
            // ClearDataMenuItem
            // 
            this.ClearDataMenuItem.Index = 1;
            this.ClearDataMenuItem.Text = "Clear Private Data";
            this.ClearDataMenuItem.Click += new System.EventHandler(this.ClearDataMenuItem_Click);
            // 
            // UserChatMenuItem
            // 
            this.UserChatMenuItem.Index = 11;
            this.UserChatMenuItem.Text = "User Chat";
            this.UserChatMenuItem.Click += new System.EventHandler(this.UserChatMenuItem_Click);
            // 
            // PlgnsMnu
            // 
            this.PlgnsMnu.Index = 7;
            this.PlgnsMnu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.PlgnMngrMnuItm,
            this.CtgryEdtrMnuItm});
            this.PlgnsMnu.Text = "Plugins";
            // 
            // PlgnMngrMnuItm
            // 
            this.PlgnMngrMnuItm.Index = 0;
            this.PlgnMngrMnuItm.Text = "Plugin Manager";
            this.PlgnMngrMnuItm.Click += new System.EventHandler(this.PlgnMngrMnuItm_Click);
            // 
            // CtgryEdtrMnuItm
            // 
            this.CtgryEdtrMnuItm.Index = 1;
            this.CtgryEdtrMnuItm.Shortcut = System.Windows.Forms.Shortcut.CtrlE;
            this.CtgryEdtrMnuItm.Text = "Category Editor";
            this.CtgryEdtrMnuItm.Click += new System.EventHandler(this.CtgryEdtrMnuItm_Click);
            // 
            // HelpMnu
            // 
            this.HelpMnu.Index = 8;
            this.HelpMnu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.PayPlnMnuItm,
            this.HelpMenuSep1,
            this.WebMnuItm,
            this.ForumMnuItm,
            this.HelpMenuSep2,
            this.DwnTrnsMnuItm,
            this.ChckUpdtsMnuItm,
            this.HelpMenuSep3,
            this.DirMnuItm,
            this.menuItem9,
            this.WelcDlgMnuItm,
            this.AbtMnuItm});
            this.HelpMnu.Text = "Help";
            // 
            // PayPlnMnuItm
            // 
            this.PayPlnMnuItm.Index = 0;
            this.PayPlnMnuItm.Text = "Payment Plans";
            this.PayPlnMnuItm.Click += new System.EventHandler(this.PayPlnMnuItm_Click);
            // 
            // HelpMenuSep1
            // 
            this.HelpMenuSep1.Index = 1;
            this.HelpMenuSep1.Text = "-";
            // 
            // WebMnuItm
            // 
            this.WebMnuItm.Index = 2;
            this.WebMnuItm.Text = "Prepril Website";
            this.WebMnuItm.Click += new System.EventHandler(this.WebMnuItm_Click);
            // 
            // ForumMnuItm
            // 
            this.ForumMnuItm.Index = 3;
            this.ForumMnuItm.Text = "Prepril Forum";
            this.ForumMnuItm.Click += new System.EventHandler(this.ForumMnuItm_Click);
            // 
            // HelpMenuSep2
            // 
            this.HelpMenuSep2.Index = 4;
            this.HelpMenuSep2.Text = "-";
            // 
            // DwnTrnsMnuItm
            // 
            this.DwnTrnsMnuItm.Index = 5;
            this.DwnTrnsMnuItm.Text = "Download Translations";
            this.DwnTrnsMnuItm.Click += new System.EventHandler(this.DwnTrnsMnuItm_Click);
            // 
            // ChckUpdtsMnuItm
            // 
            this.ChckUpdtsMnuItm.Index = 6;
            this.ChckUpdtsMnuItm.Text = "Check for Updates";
            this.ChckUpdtsMnuItm.Click += new System.EventHandler(this.ChckUpdtsMnuItm_Click);
            // 
            // HelpMenuSep3
            // 
            this.HelpMenuSep3.Index = 7;
            this.HelpMenuSep3.Text = "-";
            // 
            // DirMnuItm
            // 
            this.DirMnuItm.Index = 8;
            this.DirMnuItm.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.DbDirMnuItm,
            this.LogDirMnuItm,
            this.PlgnsDirMnuItm});
            this.DirMnuItm.Text = "Folders";
            // 
            // DbDirMnuItm
            // 
            this.DbDirMnuItm.Index = 0;
            this.DbDirMnuItm.Text = "Databases Folder";
            this.DbDirMnuItm.Click += new System.EventHandler(this.DbDirMnuItm_Click);
            // 
            // LogDirMnuItm
            // 
            this.LogDirMnuItm.Index = 1;
            this.LogDirMnuItm.Text = "Logs Folder";
            this.LogDirMnuItm.Click += new System.EventHandler(this.LogDirMnuItm_Click);
            // 
            // PlgnsDirMnuItm
            // 
            this.PlgnsDirMnuItm.Index = 2;
            this.PlgnsDirMnuItm.Text = "Plugins Folder";
            this.PlgnsDirMnuItm.Click += new System.EventHandler(this.PlgnsDirMnuItm_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 9;
            this.menuItem9.Text = "-";
            // 
            // WelcDlgMnuItm
            // 
            this.WelcDlgMnuItm.Index = 10;
            this.WelcDlgMnuItm.Text = "Show Welcome Dialog";
            this.WelcDlgMnuItm.Click += new System.EventHandler(this.WelcDlgMnuItm_Click);
            // 
            // AbtMnuItm
            // 
            this.AbtMnuItm.Index = 11;
            this.AbtMnuItm.Shortcut = System.Windows.Forms.Shortcut.F1;
            this.AbtMnuItm.Text = "About";
            this.AbtMnuItm.Click += new System.EventHandler(this.AbtMnuItm_Click);
            // 
            // NwVerMnu
            // 
            this.NwVerMnu.Index = 9;
            this.NwVerMnu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.NwVerMnuItm});
            this.NwVerMnu.Text = "New version available!";
            this.NwVerMnu.Visible = false;
            // 
            // NwVerMnuItm
            // 
            this.NwVerMnuItm.Index = 0;
            this.NwVerMnuItm.Text = "...";
            this.NwVerMnuItm.Click += new System.EventHandler(this.NewVersionMenuItem_Click);
            // 
            // menuItem23
            // 
            this.menuItem23.Index = -1;
            this.menuItem23.Text = "";
            // 
            // menuItem25
            // 
            this.menuItem25.Index = -1;
            this.menuItem25.Text = "";
            // 
            // menuItem24
            // 
            this.menuItem24.Index = -1;
            this.menuItem24.Text = "";
            // 
            // InterfaceStatusBar
            // 
            this.InterfaceStatusBar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterfaceStatusBar.Location = new System.Drawing.Point(0, 552);
            this.InterfaceStatusBar.Name = "InterfaceStatusBar";
            this.InterfaceStatusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.RAMUsePanel,
            this.CPUUsePanel,
            this.StubsPanel,
            this.ProcessesPanel,
            this.DownSpeedPanel,
            this.UpSpeedPanel});
            this.InterfaceStatusBar.ShowPanels = true;
            this.InterfaceStatusBar.Size = new System.Drawing.Size(891, 22);
            this.InterfaceStatusBar.TabIndex = 7;
            // 
            // RAMUsePanel
            // 
            this.RAMUsePanel.Name = "RAMUsePanel";
            this.RAMUsePanel.Text = "RAM Usage: 0%";
            this.RAMUsePanel.Width = 105;
            // 
            // CPUUsePanel
            // 
            this.CPUUsePanel.Name = "CPUUsePanel";
            this.CPUUsePanel.Text = "CPU Usage: 0%";
            // 
            // StubsPanel
            // 
            this.StubsPanel.Name = "StubsPanel";
            this.StubsPanel.Text = "Stubs: 0";
            this.StubsPanel.Width = 80;
            // 
            // ProcessesPanel
            // 
            this.ProcessesPanel.Name = "ProcessesPanel";
            this.ProcessesPanel.Text = "Processes: 0";
            this.ProcessesPanel.Width = 110;
            // 
            // DownSpeedPanel
            // 
            this.DownSpeedPanel.Name = "DownSpeedPanel";
            this.DownSpeedPanel.Text = "D: 0 KB/s T: 0 KB";
            this.DownSpeedPanel.Width = 130;
            // 
            // UpSpeedPanel
            // 
            this.UpSpeedPanel.Name = "UpSpeedPanel";
            this.UpSpeedPanel.Text = "U: 0 KB/s T: 0 KB";
            this.UpSpeedPanel.Width = 130;
            // 
            // TryIcn
            // 
            this.TryIcn.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TryIcn.Icon = ((System.Drawing.Icon)(resources.GetObject("TryIcn.Icon")));
            this.TryIcn.Text = "Prepril Remote Client";
            this.TryIcn.Visible = true;
            this.TryIcn.DoubleClick += new System.EventHandler(this.TrayIcon_DoubleClick);
            // 
            // FlgsImgLst
            // 
            this.FlgsImgLst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("FlgsImgLst.ImageStream")));
            this.FlgsImgLst.TransparentColor = System.Drawing.Color.Transparent;
            this.FlgsImgLst.Images.SetKeyName(0, "ad.png");
            this.FlgsImgLst.Images.SetKeyName(1, "ae.png");
            this.FlgsImgLst.Images.SetKeyName(2, "af.png");
            this.FlgsImgLst.Images.SetKeyName(3, "ag.png");
            this.FlgsImgLst.Images.SetKeyName(4, "ai.png");
            this.FlgsImgLst.Images.SetKeyName(5, "al.png");
            this.FlgsImgLst.Images.SetKeyName(6, "am.png");
            this.FlgsImgLst.Images.SetKeyName(7, "an.png");
            this.FlgsImgLst.Images.SetKeyName(8, "ao.png");
            this.FlgsImgLst.Images.SetKeyName(9, "ar.png");
            this.FlgsImgLst.Images.SetKeyName(10, "as.png");
            this.FlgsImgLst.Images.SetKeyName(11, "at.png");
            this.FlgsImgLst.Images.SetKeyName(12, "au.png");
            this.FlgsImgLst.Images.SetKeyName(13, "aw.png");
            this.FlgsImgLst.Images.SetKeyName(14, "ax.png");
            this.FlgsImgLst.Images.SetKeyName(15, "az.png");
            this.FlgsImgLst.Images.SetKeyName(16, "ba.png");
            this.FlgsImgLst.Images.SetKeyName(17, "bb.png");
            this.FlgsImgLst.Images.SetKeyName(18, "bd.png");
            this.FlgsImgLst.Images.SetKeyName(19, "be.png");
            this.FlgsImgLst.Images.SetKeyName(20, "bf.png");
            this.FlgsImgLst.Images.SetKeyName(21, "bg.png");
            this.FlgsImgLst.Images.SetKeyName(22, "bh.png");
            this.FlgsImgLst.Images.SetKeyName(23, "bi.png");
            this.FlgsImgLst.Images.SetKeyName(24, "bj.png");
            this.FlgsImgLst.Images.SetKeyName(25, "bm.png");
            this.FlgsImgLst.Images.SetKeyName(26, "bn.png");
            this.FlgsImgLst.Images.SetKeyName(27, "bo.png");
            this.FlgsImgLst.Images.SetKeyName(28, "br.png");
            this.FlgsImgLst.Images.SetKeyName(29, "bs.png");
            this.FlgsImgLst.Images.SetKeyName(30, "bt.png");
            this.FlgsImgLst.Images.SetKeyName(31, "bv.png");
            this.FlgsImgLst.Images.SetKeyName(32, "bw.png");
            this.FlgsImgLst.Images.SetKeyName(33, "by.png");
            this.FlgsImgLst.Images.SetKeyName(34, "bz.png");
            this.FlgsImgLst.Images.SetKeyName(35, "ca.png");
            this.FlgsImgLst.Images.SetKeyName(36, "catalonia.png");
            this.FlgsImgLst.Images.SetKeyName(37, "cc.png");
            this.FlgsImgLst.Images.SetKeyName(38, "cd.png");
            this.FlgsImgLst.Images.SetKeyName(39, "cf.png");
            this.FlgsImgLst.Images.SetKeyName(40, "cg.png");
            this.FlgsImgLst.Images.SetKeyName(41, "ch.png");
            this.FlgsImgLst.Images.SetKeyName(42, "ci.png");
            this.FlgsImgLst.Images.SetKeyName(43, "ck.png");
            this.FlgsImgLst.Images.SetKeyName(44, "cl.png");
            this.FlgsImgLst.Images.SetKeyName(45, "cm.png");
            this.FlgsImgLst.Images.SetKeyName(46, "cn.png");
            this.FlgsImgLst.Images.SetKeyName(47, "co.png");
            this.FlgsImgLst.Images.SetKeyName(48, "cr.png");
            this.FlgsImgLst.Images.SetKeyName(49, "cs.png");
            this.FlgsImgLst.Images.SetKeyName(50, "cu.png");
            this.FlgsImgLst.Images.SetKeyName(51, "cv.png");
            this.FlgsImgLst.Images.SetKeyName(52, "cx.png");
            this.FlgsImgLst.Images.SetKeyName(53, "cy.png");
            this.FlgsImgLst.Images.SetKeyName(54, "cz.png");
            this.FlgsImgLst.Images.SetKeyName(55, "de.png");
            this.FlgsImgLst.Images.SetKeyName(56, "dj.png");
            this.FlgsImgLst.Images.SetKeyName(57, "dk.png");
            this.FlgsImgLst.Images.SetKeyName(58, "dm.png");
            this.FlgsImgLst.Images.SetKeyName(59, "do.png");
            this.FlgsImgLst.Images.SetKeyName(60, "dz.png");
            this.FlgsImgLst.Images.SetKeyName(61, "ec.png");
            this.FlgsImgLst.Images.SetKeyName(62, "ee.png");
            this.FlgsImgLst.Images.SetKeyName(63, "eg.png");
            this.FlgsImgLst.Images.SetKeyName(64, "eh.png");
            this.FlgsImgLst.Images.SetKeyName(65, "england.png");
            this.FlgsImgLst.Images.SetKeyName(66, "er.png");
            this.FlgsImgLst.Images.SetKeyName(67, "es.png");
            this.FlgsImgLst.Images.SetKeyName(68, "et.png");
            this.FlgsImgLst.Images.SetKeyName(69, "europeanunion.png");
            this.FlgsImgLst.Images.SetKeyName(70, "fam.png");
            this.FlgsImgLst.Images.SetKeyName(71, "fi.png");
            this.FlgsImgLst.Images.SetKeyName(72, "fj.png");
            this.FlgsImgLst.Images.SetKeyName(73, "fk.png");
            this.FlgsImgLst.Images.SetKeyName(74, "fm.png");
            this.FlgsImgLst.Images.SetKeyName(75, "fo.png");
            this.FlgsImgLst.Images.SetKeyName(76, "fr.png");
            this.FlgsImgLst.Images.SetKeyName(77, "ga.png");
            this.FlgsImgLst.Images.SetKeyName(78, "gb.png");
            this.FlgsImgLst.Images.SetKeyName(79, "gd.png");
            this.FlgsImgLst.Images.SetKeyName(80, "ge.png");
            this.FlgsImgLst.Images.SetKeyName(81, "gf.png");
            this.FlgsImgLst.Images.SetKeyName(82, "gh.png");
            this.FlgsImgLst.Images.SetKeyName(83, "gi.png");
            this.FlgsImgLst.Images.SetKeyName(84, "gl.png");
            this.FlgsImgLst.Images.SetKeyName(85, "gm.png");
            this.FlgsImgLst.Images.SetKeyName(86, "gn.png");
            this.FlgsImgLst.Images.SetKeyName(87, "gp.png");
            this.FlgsImgLst.Images.SetKeyName(88, "gq.png");
            this.FlgsImgLst.Images.SetKeyName(89, "gr.png");
            this.FlgsImgLst.Images.SetKeyName(90, "gs.png");
            this.FlgsImgLst.Images.SetKeyName(91, "gt.png");
            this.FlgsImgLst.Images.SetKeyName(92, "gu.png");
            this.FlgsImgLst.Images.SetKeyName(93, "gw.png");
            this.FlgsImgLst.Images.SetKeyName(94, "gy.png");
            this.FlgsImgLst.Images.SetKeyName(95, "hk.png");
            this.FlgsImgLst.Images.SetKeyName(96, "hm.png");
            this.FlgsImgLst.Images.SetKeyName(97, "hn.png");
            this.FlgsImgLst.Images.SetKeyName(98, "hr.png");
            this.FlgsImgLst.Images.SetKeyName(99, "ht.png");
            this.FlgsImgLst.Images.SetKeyName(100, "hu.png");
            this.FlgsImgLst.Images.SetKeyName(101, "id.png");
            this.FlgsImgLst.Images.SetKeyName(102, "ie.png");
            this.FlgsImgLst.Images.SetKeyName(103, "il.png");
            this.FlgsImgLst.Images.SetKeyName(104, "in.png");
            this.FlgsImgLst.Images.SetKeyName(105, "io.png");
            this.FlgsImgLst.Images.SetKeyName(106, "iq.png");
            this.FlgsImgLst.Images.SetKeyName(107, "ir.png");
            this.FlgsImgLst.Images.SetKeyName(108, "is.png");
            this.FlgsImgLst.Images.SetKeyName(109, "it.png");
            this.FlgsImgLst.Images.SetKeyName(110, "jm.png");
            this.FlgsImgLst.Images.SetKeyName(111, "jo.png");
            this.FlgsImgLst.Images.SetKeyName(112, "jp.png");
            this.FlgsImgLst.Images.SetKeyName(113, "ke.png");
            this.FlgsImgLst.Images.SetKeyName(114, "kg.png");
            this.FlgsImgLst.Images.SetKeyName(115, "kh.png");
            this.FlgsImgLst.Images.SetKeyName(116, "ki.png");
            this.FlgsImgLst.Images.SetKeyName(117, "km.png");
            this.FlgsImgLst.Images.SetKeyName(118, "kn.png");
            this.FlgsImgLst.Images.SetKeyName(119, "kp.png");
            this.FlgsImgLst.Images.SetKeyName(120, "kr.png");
            this.FlgsImgLst.Images.SetKeyName(121, "kw.png");
            this.FlgsImgLst.Images.SetKeyName(122, "ky.png");
            this.FlgsImgLst.Images.SetKeyName(123, "kz.png");
            this.FlgsImgLst.Images.SetKeyName(124, "la.png");
            this.FlgsImgLst.Images.SetKeyName(125, "lb.png");
            this.FlgsImgLst.Images.SetKeyName(126, "lc.png");
            this.FlgsImgLst.Images.SetKeyName(127, "li.png");
            this.FlgsImgLst.Images.SetKeyName(128, "lk.png");
            this.FlgsImgLst.Images.SetKeyName(129, "lr.png");
            this.FlgsImgLst.Images.SetKeyName(130, "ls.png");
            this.FlgsImgLst.Images.SetKeyName(131, "lt.png");
            this.FlgsImgLst.Images.SetKeyName(132, "lu.png");
            this.FlgsImgLst.Images.SetKeyName(133, "lv.png");
            this.FlgsImgLst.Images.SetKeyName(134, "ly.png");
            this.FlgsImgLst.Images.SetKeyName(135, "ma.png");
            this.FlgsImgLst.Images.SetKeyName(136, "mc.png");
            this.FlgsImgLst.Images.SetKeyName(137, "md.png");
            this.FlgsImgLst.Images.SetKeyName(138, "me.png");
            this.FlgsImgLst.Images.SetKeyName(139, "mg.png");
            this.FlgsImgLst.Images.SetKeyName(140, "mh.png");
            this.FlgsImgLst.Images.SetKeyName(141, "mk.png");
            this.FlgsImgLst.Images.SetKeyName(142, "ml.png");
            this.FlgsImgLst.Images.SetKeyName(143, "mm.png");
            this.FlgsImgLst.Images.SetKeyName(144, "mn.png");
            this.FlgsImgLst.Images.SetKeyName(145, "mo.png");
            this.FlgsImgLst.Images.SetKeyName(146, "mp.png");
            this.FlgsImgLst.Images.SetKeyName(147, "mq.png");
            this.FlgsImgLst.Images.SetKeyName(148, "mr.png");
            this.FlgsImgLst.Images.SetKeyName(149, "ms.png");
            this.FlgsImgLst.Images.SetKeyName(150, "mt.png");
            this.FlgsImgLst.Images.SetKeyName(151, "mu.png");
            this.FlgsImgLst.Images.SetKeyName(152, "mv.png");
            this.FlgsImgLst.Images.SetKeyName(153, "mw.png");
            this.FlgsImgLst.Images.SetKeyName(154, "mx.png");
            this.FlgsImgLst.Images.SetKeyName(155, "my.png");
            this.FlgsImgLst.Images.SetKeyName(156, "mz.png");
            this.FlgsImgLst.Images.SetKeyName(157, "na.png");
            this.FlgsImgLst.Images.SetKeyName(158, "nc.png");
            this.FlgsImgLst.Images.SetKeyName(159, "ne.png");
            this.FlgsImgLst.Images.SetKeyName(160, "nf.png");
            this.FlgsImgLst.Images.SetKeyName(161, "ng.png");
            this.FlgsImgLst.Images.SetKeyName(162, "ni.png");
            this.FlgsImgLst.Images.SetKeyName(163, "nl.png");
            this.FlgsImgLst.Images.SetKeyName(164, "no.png");
            this.FlgsImgLst.Images.SetKeyName(165, "np.png");
            this.FlgsImgLst.Images.SetKeyName(166, "nr.png");
            this.FlgsImgLst.Images.SetKeyName(167, "nu.png");
            this.FlgsImgLst.Images.SetKeyName(168, "nz.png");
            this.FlgsImgLst.Images.SetKeyName(169, "om.png");
            this.FlgsImgLst.Images.SetKeyName(170, "pa.png");
            this.FlgsImgLst.Images.SetKeyName(171, "pe.png");
            this.FlgsImgLst.Images.SetKeyName(172, "pf.png");
            this.FlgsImgLst.Images.SetKeyName(173, "pg.png");
            this.FlgsImgLst.Images.SetKeyName(174, "ph.png");
            this.FlgsImgLst.Images.SetKeyName(175, "pk.png");
            this.FlgsImgLst.Images.SetKeyName(176, "pl.png");
            this.FlgsImgLst.Images.SetKeyName(177, "pm.png");
            this.FlgsImgLst.Images.SetKeyName(178, "pn.png");
            this.FlgsImgLst.Images.SetKeyName(179, "pr.png");
            this.FlgsImgLst.Images.SetKeyName(180, "ps.png");
            this.FlgsImgLst.Images.SetKeyName(181, "pt.png");
            this.FlgsImgLst.Images.SetKeyName(182, "pw.png");
            this.FlgsImgLst.Images.SetKeyName(183, "py.png");
            this.FlgsImgLst.Images.SetKeyName(184, "qa.png");
            this.FlgsImgLst.Images.SetKeyName(185, "re.png");
            this.FlgsImgLst.Images.SetKeyName(186, "ro.png");
            this.FlgsImgLst.Images.SetKeyName(187, "rs.png");
            this.FlgsImgLst.Images.SetKeyName(188, "ru.png");
            this.FlgsImgLst.Images.SetKeyName(189, "rw.png");
            this.FlgsImgLst.Images.SetKeyName(190, "sa.png");
            this.FlgsImgLst.Images.SetKeyName(191, "sb.png");
            this.FlgsImgLst.Images.SetKeyName(192, "sc.png");
            this.FlgsImgLst.Images.SetKeyName(193, "scotland.png");
            this.FlgsImgLst.Images.SetKeyName(194, "sd.png");
            this.FlgsImgLst.Images.SetKeyName(195, "se.png");
            this.FlgsImgLst.Images.SetKeyName(196, "sg.png");
            this.FlgsImgLst.Images.SetKeyName(197, "sh.png");
            this.FlgsImgLst.Images.SetKeyName(198, "si.png");
            this.FlgsImgLst.Images.SetKeyName(199, "sj.png");
            this.FlgsImgLst.Images.SetKeyName(200, "sk.png");
            this.FlgsImgLst.Images.SetKeyName(201, "sl.png");
            this.FlgsImgLst.Images.SetKeyName(202, "sm.png");
            this.FlgsImgLst.Images.SetKeyName(203, "sn.png");
            this.FlgsImgLst.Images.SetKeyName(204, "so.png");
            this.FlgsImgLst.Images.SetKeyName(205, "sr.png");
            this.FlgsImgLst.Images.SetKeyName(206, "st.png");
            this.FlgsImgLst.Images.SetKeyName(207, "sv.png");
            this.FlgsImgLst.Images.SetKeyName(208, "sy.png");
            this.FlgsImgLst.Images.SetKeyName(209, "sz.png");
            this.FlgsImgLst.Images.SetKeyName(210, "tc.png");
            this.FlgsImgLst.Images.SetKeyName(211, "td.png");
            this.FlgsImgLst.Images.SetKeyName(212, "tf.png");
            this.FlgsImgLst.Images.SetKeyName(213, "tg.png");
            this.FlgsImgLst.Images.SetKeyName(214, "th.png");
            this.FlgsImgLst.Images.SetKeyName(215, "tj.png");
            this.FlgsImgLst.Images.SetKeyName(216, "tk.png");
            this.FlgsImgLst.Images.SetKeyName(217, "tl.png");
            this.FlgsImgLst.Images.SetKeyName(218, "tm.png");
            this.FlgsImgLst.Images.SetKeyName(219, "tn.png");
            this.FlgsImgLst.Images.SetKeyName(220, "to.png");
            this.FlgsImgLst.Images.SetKeyName(221, "tr.png");
            this.FlgsImgLst.Images.SetKeyName(222, "tt.png");
            this.FlgsImgLst.Images.SetKeyName(223, "tv.png");
            this.FlgsImgLst.Images.SetKeyName(224, "tw.png");
            this.FlgsImgLst.Images.SetKeyName(225, "tz.png");
            this.FlgsImgLst.Images.SetKeyName(226, "ua.png");
            this.FlgsImgLst.Images.SetKeyName(227, "ug.png");
            this.FlgsImgLst.Images.SetKeyName(228, "um.png");
            this.FlgsImgLst.Images.SetKeyName(229, "us.png");
            this.FlgsImgLst.Images.SetKeyName(230, "uy.png");
            this.FlgsImgLst.Images.SetKeyName(231, "uz.png");
            this.FlgsImgLst.Images.SetKeyName(232, "va.png");
            this.FlgsImgLst.Images.SetKeyName(233, "vc.png");
            this.FlgsImgLst.Images.SetKeyName(234, "ve.png");
            this.FlgsImgLst.Images.SetKeyName(235, "vg.png");
            this.FlgsImgLst.Images.SetKeyName(236, "vi.png");
            this.FlgsImgLst.Images.SetKeyName(237, "vn.png");
            this.FlgsImgLst.Images.SetKeyName(238, "vu.png");
            this.FlgsImgLst.Images.SetKeyName(239, "wales.png");
            this.FlgsImgLst.Images.SetKeyName(240, "wf.png");
            this.FlgsImgLst.Images.SetKeyName(241, "ws.png");
            this.FlgsImgLst.Images.SetKeyName(242, "ye.png");
            this.FlgsImgLst.Images.SetKeyName(243, "yt.png");
            this.FlgsImgLst.Images.SetKeyName(244, "za.png");
            this.FlgsImgLst.Images.SetKeyName(245, "zm.png");
            this.FlgsImgLst.Images.SetKeyName(246, "zw.png");
            // 
            // OnConnectCntxt
            // 
            this.OnConnectCntxt.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.CnfTskCntxtItm,
            this.menuItem78,
            this.DsblTskCntxtItm,
            this.EnblTskCntxtItm,
            this.menuItem81,
            this.RmvTskCntxtItm});
            // 
            // CnfTskCntxtItm
            // 
            this.CnfTskCntxtItm.Index = 0;
            this.CnfTskCntxtItm.Text = "Configure";
            this.CnfTskCntxtItm.Click += new System.EventHandler(this.CnfTskCntxtItm_Click);
            // 
            // menuItem78
            // 
            this.menuItem78.Index = 1;
            this.menuItem78.Text = "-";
            // 
            // DsblTskCntxtItm
            // 
            this.DsblTskCntxtItm.Index = 2;
            this.DsblTskCntxtItm.Text = "Disable Selected";
            this.DsblTskCntxtItm.Click += new System.EventHandler(this.DsblTskCntxtItm_Click);
            // 
            // EnblTskCntxtItm
            // 
            this.EnblTskCntxtItm.Index = 3;
            this.EnblTskCntxtItm.Text = "Enable Selected";
            this.EnblTskCntxtItm.Click += new System.EventHandler(this.EnblTskCntxtItm_Click);
            // 
            // menuItem81
            // 
            this.menuItem81.Index = 4;
            this.menuItem81.Text = "-";
            // 
            // RmvTskCntxtItm
            // 
            this.RmvTskCntxtItm.Index = 5;
            this.RmvTskCntxtItm.Text = "Remove Selected";
            this.RmvTskCntxtItm.Click += new System.EventHandler(this.RmvTskCntxtItm_Click);
            // 
            // IntToolStrip
            // 
            this.IntToolStrip.AutoSize = false;
            this.IntToolStrip.CanOverflow = false;
            this.IntToolStrip.GripMargin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.IntToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.IntToolStrip.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.IntToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddManTlstrBt,
            this.toolStripButton1,
            this.TlstrSep1,
            this.DscnnctSvrTlstrBt,
            this.CnnctSvrTlstrBt,
            this.TlstrSep2,
            this.StatsTlstrBt,
            this.AnlytcTlstrBt,
            this.TlstrSep3,
            this.NwkScnTlstrBt,
            this.FndTlstrBt,
            this.TlstrSep4,
            this.SttngTlstrBt,
            this.toolStripTextBox1});
            this.IntToolStrip.Location = new System.Drawing.Point(0, 0);
            this.IntToolStrip.Name = "IntToolStrip";
            this.IntToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.IntToolStrip.Size = new System.Drawing.Size(891, 25);
            this.IntToolStrip.Stretch = true;
            this.IntToolStrip.TabIndex = 1;
            // 
            // AddManTlstrBt
            // 
            this.AddManTlstrBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddManTlstrBt.Image = global::PpRClientInterface.Properties.Resources.book_addresses;
            this.AddManTlstrBt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddManTlstrBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddManTlstrBt.Margin = new System.Windows.Forms.Padding(3, 1, 1, 2);
            this.AddManTlstrBt.Name = "AddManTlstrBt";
            this.AddManTlstrBt.Size = new System.Drawing.Size(23, 22);
            this.AddManTlstrBt.Text = "Address Manager";
            this.AddManTlstrBt.Click += new System.EventHandler(this.AddManTlstrBt_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Direct Connect";
            // 
            // TlstrSep1
            // 
            this.TlstrSep1.Name = "TlstrSep1";
            this.TlstrSep1.Size = new System.Drawing.Size(6, 25);
            // 
            // DscnnctSvrTlstrBt
            // 
            this.DscnnctSvrTlstrBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DscnnctSvrTlstrBt.Image = ((System.Drawing.Image)(resources.GetObject("DscnnctSvrTlstrBt.Image")));
            this.DscnnctSvrTlstrBt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DscnnctSvrTlstrBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DscnnctSvrTlstrBt.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.DscnnctSvrTlstrBt.Name = "DscnnctSvrTlstrBt";
            this.DscnnctSvrTlstrBt.Size = new System.Drawing.Size(23, 22);
            this.DscnnctSvrTlstrBt.Text = "Disconnect";
            this.DscnnctSvrTlstrBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DscnnctSvrTlstrBt.ToolTipText = "Disconnects from current server connection";
            this.DscnnctSvrTlstrBt.Click += new System.EventHandler(this.DscnnctSvrTlstrBt_Click);
            // 
            // CnnctSvrTlstrBt
            // 
            this.CnnctSvrTlstrBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CnnctSvrTlstrBt.Image = ((System.Drawing.Image)(resources.GetObject("CnnctSvrTlstrBt.Image")));
            this.CnnctSvrTlstrBt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CnnctSvrTlstrBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CnnctSvrTlstrBt.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.CnnctSvrTlstrBt.Name = "CnnctSvrTlstrBt";
            this.CnnctSvrTlstrBt.Size = new System.Drawing.Size(23, 22);
            this.CnnctSvrTlstrBt.Text = "Reconnect";
            this.CnnctSvrTlstrBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CnnctSvrTlstrBt.ToolTipText = "Reconnect to the last used server";
            this.CnnctSvrTlstrBt.Click += new System.EventHandler(this.CnnctSvrTlstrBt_Click);
            // 
            // TlstrSep2
            // 
            this.TlstrSep2.Name = "TlstrSep2";
            this.TlstrSep2.Size = new System.Drawing.Size(6, 25);
            // 
            // StatsTlstrBt
            // 
            this.StatsTlstrBt.AutoToolTip = false;
            this.StatsTlstrBt.Image = ((System.Drawing.Image)(resources.GetObject("StatsTlstrBt.Image")));
            this.StatsTlstrBt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.StatsTlstrBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StatsTlstrBt.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.StatsTlstrBt.Name = "StatsTlstrBt";
            this.StatsTlstrBt.Size = new System.Drawing.Size(73, 22);
            this.StatsTlstrBt.Text = "Statistics";
            this.StatsTlstrBt.Click += new System.EventHandler(this.StatsTlstrBt_Click);
            // 
            // AnlytcTlstrBt
            // 
            this.AnlytcTlstrBt.AutoToolTip = false;
            this.AnlytcTlstrBt.Image = ((System.Drawing.Image)(resources.GetObject("AnlytcTlstrBt.Image")));
            this.AnlytcTlstrBt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AnlytcTlstrBt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AnlytcTlstrBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AnlytcTlstrBt.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.AnlytcTlstrBt.Name = "AnlytcTlstrBt";
            this.AnlytcTlstrBt.Size = new System.Drawing.Size(75, 22);
            this.AnlytcTlstrBt.Text = "Analytics";
            this.AnlytcTlstrBt.Click += new System.EventHandler(this.AnlytcTlstrBt_Click);
            // 
            // TlstrSep3
            // 
            this.TlstrSep3.Name = "TlstrSep3";
            this.TlstrSep3.Size = new System.Drawing.Size(6, 25);
            // 
            // NwkScnTlstrBt
            // 
            this.NwkScnTlstrBt.AutoToolTip = false;
            this.NwkScnTlstrBt.Image = global::PpRClientInterface.Properties.Resources.network_tools;
            this.NwkScnTlstrBt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NwkScnTlstrBt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NwkScnTlstrBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NwkScnTlstrBt.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.NwkScnTlstrBt.Name = "NwkScnTlstrBt";
            this.NwkScnTlstrBt.Size = new System.Drawing.Size(100, 22);
            this.NwkScnTlstrBt.Text = "Network Scan";
            this.NwkScnTlstrBt.ToolTipText = "Add a new Stubs on the local network via a Network Scan";
            this.NwkScnTlstrBt.Click += new System.EventHandler(this.NwkScnTlstrBt_Click);
            // 
            // FndTlstrBt
            // 
            this.FndTlstrBt.AutoToolTip = false;
            this.FndTlstrBt.Image = ((System.Drawing.Image)(resources.GetObject("FndTlstrBt.Image")));
            this.FndTlstrBt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FndTlstrBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FndTlstrBt.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.FndTlstrBt.Name = "FndTlstrBt";
            this.FndTlstrBt.Size = new System.Drawing.Size(50, 22);
            this.FndTlstrBt.Text = "Find";
            this.FndTlstrBt.Click += new System.EventHandler(this.FndTlstrBt_Click);
            // 
            // TlstrSep4
            // 
            this.TlstrSep4.Name = "TlstrSep4";
            this.TlstrSep4.Size = new System.Drawing.Size(6, 25);
            // 
            // SttngTlstrBt
            // 
            this.SttngTlstrBt.AutoToolTip = false;
            this.SttngTlstrBt.Image = global::PpRClientInterface.Properties.Resources.cog_edit;
            this.SttngTlstrBt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SttngTlstrBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SttngTlstrBt.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.SttngTlstrBt.Name = "SttngTlstrBt";
            this.SttngTlstrBt.Size = new System.Drawing.Size(69, 22);
            this.SttngTlstrBt.Text = "Settings";
            this.SttngTlstrBt.ToolTipText = "Show the settings dialog";
            this.SttngTlstrBt.Click += new System.EventHandler(this.SttngTlstrBt_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(175, 23);
            this.toolStripTextBox1.Text = "Search (Ctrl+K)";
            // 
            // LineLbl1
            // 
            this.LineLbl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LineLbl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.LineLbl1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LineLbl1.Location = new System.Drawing.Point(0, 25);
            this.LineLbl1.Name = "LineLbl1";
            this.LineLbl1.Size = new System.Drawing.Size(891, 2);
            this.LineLbl1.TabIndex = 2;
            this.LineLbl1.Text = "label1";
            // 
            // ActiveToolStripBt
            // 
            this.ActiveToolStripBt.Name = "ActiveToolStripBt";
            this.ActiveToolStripBt.Size = new System.Drawing.Size(23, 23);
            // 
            // LineLbl2
            // 
            this.LineLbl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LineLbl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.LineLbl2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LineLbl2.Location = new System.Drawing.Point(0, 57);
            this.LineLbl2.Name = "LineLbl2";
            this.LineLbl2.Size = new System.Drawing.Size(891, 2);
            this.LineLbl2.TabIndex = 16;
            this.LineLbl2.Text = "label2";
            // 
            // InterfaceTbCntrl
            // 
            this.InterfaceTbCntrl.Controls.Add(this.StubServersTab);
            this.InterfaceTbCntrl.Controls.Add(this.TasksTab);
            this.InterfaceTbCntrl.Controls.Add(this.OnConnectTab);
            this.InterfaceTbCntrl.Controls.Add(this.InterfaceLogTab);
            this.InterfaceTbCntrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InterfaceTbCntrl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InterfaceTbCntrl.ItemSize = new System.Drawing.Size(100, 20);
            this.InterfaceTbCntrl.Location = new System.Drawing.Point(0, 59);
            this.InterfaceTbCntrl.Name = "InterfaceTbCntrl";
            this.InterfaceTbCntrl.Padding = new System.Drawing.Point(7, 3);
            this.InterfaceTbCntrl.SelectedIndex = 0;
            this.InterfaceTbCntrl.Size = new System.Drawing.Size(891, 493);
            this.InterfaceTbCntrl.TabIndex = 17;
            this.InterfaceTbCntrl.TabStop = false;
            // 
            // StubServersTab
            // 
            this.StubServersTab.BackColor = System.Drawing.SystemColors.Control;
            this.StubServersTab.Controls.Add(this.StubServersLstVw);
            this.StubServersTab.Location = new System.Drawing.Point(4, 24);
            this.StubServersTab.Name = "StubServersTab";
            this.StubServersTab.Size = new System.Drawing.Size(883, 465);
            this.StubServersTab.TabIndex = 0;
            this.StubServersTab.Text = "Stub Servers";
            // 
            // StubServersLstVw
            // 
            this.StubServersLstVw.AllowColumnReorder = true;
            this.StubServersLstVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.ConnectionIDColumn,
            this.IPAddressColumn,
            this.PortColumn,
            this.columnHeader1,
            this.DeviceNameColumn,
            this.ActivityColumn,
            this.PingColumn,
            this.UserNameColumn,
            this.PrivilegesColumn,
            this.CountryColumn,
            this.RatingColumn,
            this.ProcessesColumn,
            this.PluginsColumn,
            this.VersionColumn});
            this.StubServersLstVw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StubServersLstVw.ExplorerTheme = false;
            this.StubServersLstVw.ExplorerThemeMultiSelect = false;
            this.StubServersLstVw.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StubServersLstVw.FullRowSelect = true;
            this.StubServersLstVw.ItemContextMenuStrip = false;
            listViewItem1.StateImageIndex = 0;
            this.StubServersLstVw.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.StubServersLstVw.LabelWrap = false;
            this.StubServersLstVw.Location = new System.Drawing.Point(0, 0);
            this.StubServersLstVw.LockColumnSize = false;
            this.StubServersLstVw.Name = "StubServersLstVw";
            this.StubServersLstVw.ShowItemToolTips = true;
            this.StubServersLstVw.Size = new System.Drawing.Size(883, 465);
            this.StubServersLstVw.SmallImageList = this.FlgsImgLst;
            this.StubServersLstVw.TabIndex = 7;
            this.StubServersLstVw.TileSize = new System.Drawing.Size(320, 54);
            this.StubServersLstVw.UseCompatibleStateImageBehavior = false;
            this.StubServersLstVw.View = System.Windows.Forms.View.Details;
            this.StubServersLstVw.ItemActivate += new System.EventHandler(this.StubServersLstVw_ItemActivate);
            this.StubServersLstVw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StubServersLstVw_MouseUp);
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 132;
            // 
            // ConnectionIDColumn
            // 
            this.ConnectionIDColumn.Text = "Connection ID";
            this.ConnectionIDColumn.Width = 106;
            // 
            // IPAddressColumn
            // 
            this.IPAddressColumn.Text = "IP Address";
            this.IPAddressColumn.Width = 92;
            // 
            // PortColumn
            // 
            this.PortColumn.Text = "Port";
            this.PortColumn.Width = 45;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Socket Handle";
            this.columnHeader1.Width = 89;
            // 
            // DeviceNameColumn
            // 
            this.DeviceNameColumn.Text = "Device Name";
            this.DeviceNameColumn.Width = 90;
            // 
            // ActivityColumn
            // 
            this.ActivityColumn.Text = "Activity";
            this.ActivityColumn.Width = 54;
            // 
            // PingColumn
            // 
            this.PingColumn.Text = "Ping";
            this.PingColumn.Width = 51;
            // 
            // UserNameColumn
            // 
            this.UserNameColumn.Text = "User Name";
            this.UserNameColumn.Width = 75;
            // 
            // PrivilegesColumn
            // 
            this.PrivilegesColumn.Text = "Privileges";
            this.PrivilegesColumn.Width = 62;
            // 
            // CountryColumn
            // 
            this.CountryColumn.Text = "Country";
            this.CountryColumn.Width = 107;
            // 
            // RatingColumn
            // 
            this.RatingColumn.Text = "Rating";
            this.RatingColumn.Width = 46;
            // 
            // ProcessesColumn
            // 
            this.ProcessesColumn.Text = "Processes";
            this.ProcessesColumn.Width = 63;
            // 
            // PluginsColumn
            // 
            this.PluginsColumn.Text = "Plugins";
            this.PluginsColumn.Width = 51;
            // 
            // VersionColumn
            // 
            this.VersionColumn.Text = "Version";
            this.VersionColumn.Width = 51;
            // 
            // TasksTab
            // 
            this.TasksTab.Controls.Add(this.TsksLstVw);
            this.TasksTab.Location = new System.Drawing.Point(4, 24);
            this.TasksTab.Name = "TasksTab";
            this.TasksTab.Size = new System.Drawing.Size(871, 432);
            this.TasksTab.TabIndex = 5;
            this.TasksTab.Text = "Tasks";
            this.TasksTab.UseVisualStyleBackColor = true;
            // 
            // TsksLstVw
            // 
            this.TsksLstVw.AllowColumnReorder = true;
            this.TsksLstVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader170,
            this.DescriptionColumn,
            this.PIDColumn,
            this.columnHeader171,
            this.DurationColumn,
            this.columnHeader172,
            this.columnHeader173});
            this.TsksLstVw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TsksLstVw.ExplorerTheme = false;
            this.TsksLstVw.ExplorerThemeMultiSelect = false;
            this.TsksLstVw.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TsksLstVw.FullRowSelect = true;
            this.TsksLstVw.ItemContextMenuStrip = false;
            listViewItem2.StateImageIndex = 0;
            this.TsksLstVw.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.TsksLstVw.Location = new System.Drawing.Point(0, 0);
            this.TsksLstVw.LockColumnSize = false;
            this.TsksLstVw.Name = "TsksLstVw";
            this.TsksLstVw.Size = new System.Drawing.Size(871, 432);
            this.TsksLstVw.TabIndex = 7;
            this.TsksLstVw.UseCompatibleStateImageBehavior = false;
            this.TsksLstVw.View = System.Windows.Forms.View.Details;
            this.TsksLstVw.ItemActivate += new System.EventHandler(this.TsksLstVw_ItemActivate);
            this.TsksLstVw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TsksLstVw_MouseUp);
            // 
            // columnHeader170
            // 
            this.columnHeader170.Text = "Name";
            this.columnHeader170.Width = 189;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.Text = "Description";
            this.DescriptionColumn.Width = 240;
            // 
            // PIDColumn
            // 
            this.PIDColumn.Text = "PID";
            this.PIDColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PIDColumn.Width = 54;
            // 
            // columnHeader171
            // 
            this.columnHeader171.Text = "Status";
            this.columnHeader171.Width = 103;
            // 
            // DurationColumn
            // 
            this.DurationColumn.Text = "Duration";
            // 
            // columnHeader172
            // 
            this.columnHeader172.DisplayIndex = 6;
            this.columnHeader172.Text = "Owner";
            this.columnHeader172.Width = 115;
            // 
            // columnHeader173
            // 
            this.columnHeader173.DisplayIndex = 5;
            this.columnHeader173.Text = "Added";
            this.columnHeader173.Width = 77;
            // 
            // OnConnectTab
            // 
            this.OnConnectTab.BackColor = System.Drawing.SystemColors.Control;
            this.OnConnectTab.Controls.Add(this.OnConnectLstVw);
            this.OnConnectTab.Controls.Add(this.panel2);
            this.OnConnectTab.Location = new System.Drawing.Point(4, 24);
            this.OnConnectTab.Name = "OnConnectTab";
            this.OnConnectTab.Size = new System.Drawing.Size(871, 432);
            this.OnConnectTab.TabIndex = 4;
            this.OnConnectTab.Text = "On Connect";
            this.OnConnectTab.ToolTipText = "Tool Tip Text Test";
            // 
            // OnConnectLstVw
            // 
            this.OnConnectLstVw.AllowColumnReorder = true;
            this.OnConnectLstVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TaskNameColumn,
            this.ActionColumn,
            this.ActionDataColumn,
            this.ExecutedColumn,
            this.OwnerColumn,
            this.AddedColumn});
            this.OnConnectLstVw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OnConnectLstVw.ExplorerTheme = false;
            this.OnConnectLstVw.ExplorerThemeMultiSelect = false;
            this.OnConnectLstVw.FullRowSelect = true;
            this.OnConnectLstVw.ItemContextMenuStrip = false;
            listViewItem3.Checked = true;
            listViewItem3.StateImageIndex = 1;
            this.OnConnectLstVw.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.OnConnectLstVw.Location = new System.Drawing.Point(0, 0);
            this.OnConnectLstVw.LockColumnSize = false;
            this.OnConnectLstVw.Name = "OnConnectLstVw";
            this.OnConnectLstVw.Size = new System.Drawing.Size(871, 403);
            this.OnConnectLstVw.TabIndex = 18;
            this.OnConnectLstVw.UseCompatibleStateImageBehavior = false;
            this.OnConnectLstVw.View = System.Windows.Forms.View.Details;
            this.OnConnectLstVw.ItemActivate += new System.EventHandler(this.OnConnectLstVw_ItemActivate);
            this.OnConnectLstVw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnConnectLstVw_MouseUp);
            // 
            // TaskNameColumn
            // 
            this.TaskNameColumn.Text = "Task Name";
            this.TaskNameColumn.Width = 119;
            // 
            // ActionColumn
            // 
            this.ActionColumn.Text = "Action";
            this.ActionColumn.Width = 170;
            // 
            // ActionDataColumn
            // 
            this.ActionDataColumn.Text = "Action Data";
            this.ActionDataColumn.Width = 272;
            // 
            // ExecutedColumn
            // 
            this.ExecutedColumn.Text = "Executed";
            // 
            // OwnerColumn
            // 
            this.OwnerColumn.Text = "Owner";
            this.OwnerColumn.Width = 78;
            // 
            // AddedColumn
            // 
            this.AddedColumn.Text = "Added";
            this.AddedColumn.Width = 139;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.ClrTsksBtn);
            this.panel2.Controls.Add(this.CfgCnnctTskBtn);
            this.panel2.Controls.Add(this.TsksCmbx);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panel2.Location = new System.Drawing.Point(0, 403);
            this.panel2.MaximumSize = new System.Drawing.Size(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(871, 29);
            this.panel2.TabIndex = 9;
            // 
            // ClrTsksBtn
            // 
            this.ClrTsksBtn.Location = new System.Drawing.Point(300, 4);
            this.ClrTsksBtn.Name = "ClrTsksBtn";
            this.ClrTsksBtn.Size = new System.Drawing.Size(75, 23);
            this.ClrTsksBtn.TabIndex = 2;
            this.ClrTsksBtn.Text = "Clear All";
            this.ClrTsksBtn.UseVisualStyleBackColor = true;
            this.ClrTsksBtn.Click += new System.EventHandler(this.ClrTsksBtn_Click);
            // 
            // CfgCnnctTskBtn
            // 
            this.CfgCnnctTskBtn.Location = new System.Drawing.Point(219, 4);
            this.CfgCnnctTskBtn.Name = "CfgCnnctTskBtn";
            this.CfgCnnctTskBtn.Size = new System.Drawing.Size(75, 23);
            this.CfgCnnctTskBtn.TabIndex = 1;
            this.CfgCnnctTskBtn.Text = "Configure";
            this.CfgCnnctTskBtn.UseVisualStyleBackColor = true;
            this.CfgCnnctTskBtn.Click += new System.EventHandler(this.CfgCnnctTskBtn_Click);
            // 
            // TsksCmbx
            // 
            this.TsksCmbx.DropDownHeight = 110;
            this.TsksCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TsksCmbx.FormattingEnabled = true;
            this.TsksCmbx.IntegralHeight = false;
            this.TsksCmbx.Items.AddRange(new object[] {
            "Group Assign",
            "Update/Install Plugin(s)",
            "Execute Script",
            "Execute Shell",
            "Ping",
            "Update/Install Build"});
            this.TsksCmbx.Location = new System.Drawing.Point(0, 4);
            this.TsksCmbx.Name = "TsksCmbx";
            this.TsksCmbx.Size = new System.Drawing.Size(213, 23);
            this.TsksCmbx.TabIndex = 0;
            // 
            // InterfaceLogTab
            // 
            this.InterfaceLogTab.BackColor = System.Drawing.SystemColors.Control;
            this.InterfaceLogTab.Controls.Add(this.LogRchtxt);
            this.InterfaceLogTab.Location = new System.Drawing.Point(4, 24);
            this.InterfaceLogTab.Name = "InterfaceLogTab";
            this.InterfaceLogTab.Size = new System.Drawing.Size(871, 432);
            this.InterfaceLogTab.TabIndex = 2;
            this.InterfaceLogTab.Text = "Log";
            // 
            // LogRchtxt
            // 
            this.LogRchtxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogRchtxt.Location = new System.Drawing.Point(0, 0);
            this.LogRchtxt.Name = "LogRchtxt";
            this.LogRchtxt.Size = new System.Drawing.Size(871, 432);
            this.LogRchtxt.TabIndex = 0;
            this.LogRchtxt.Text = "";
            // 
            // FindToolStripBt
            // 
            this.FindToolStripBt.Name = "FindToolStripBt";
            this.FindToolStripBt.Size = new System.Drawing.Size(23, 23);
            // 
            // vistaMenu
            // 
            this.vistaMenu.ContainerControl = this;
            // 
            // StbSvrCntxt2
            // 
            this.StbSvrCntxt2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.cstub_SelectBy,
            this.cstub_FavGroup,
            this.menuItem33,
            this.cstub_ShowThumb,
            this.cstub_ShowOffline,
            this.menuItem10,
            this.cstub_SelectAll,
            this.cstub_CheckAll,
            this.cstub_UncheckAll});
            // 
            // cstub_SelectBy
            // 
            this.cstub_SelectBy.Index = 0;
            this.cstub_SelectBy.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.cstub_CurrentGroup,
            this.cstub_FavOnly});
            this.cstub_SelectBy.Text = "Select By";
            // 
            // cstub_CurrentGroup
            // 
            this.cstub_CurrentGroup.Index = 0;
            this.cstub_CurrentGroup.Text = "Current Group";
            this.cstub_CurrentGroup.Click += new System.EventHandler(this.cstub_CurrentGroup_Click);
            // 
            // cstub_FavOnly
            // 
            this.cstub_FavOnly.Index = 1;
            this.cstub_FavOnly.Text = "Favorites Only";
            this.cstub_FavOnly.Click += new System.EventHandler(this.cstub_FavOnly_Click);
            // 
            // cstub_FavGroup
            // 
            this.cstub_FavGroup.Index = 1;
            this.cstub_FavGroup.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.cstub_FavAdd,
            this.cstub_FavRemove});
            this.cstub_FavGroup.Text = "Favorites Group";
            // 
            // cstub_FavAdd
            // 
            this.cstub_FavAdd.Index = 0;
            this.cstub_FavAdd.Text = "Add Selected";
            this.cstub_FavAdd.Click += new System.EventHandler(this.cstub_FavAdd_Click);
            // 
            // cstub_FavRemove
            // 
            this.cstub_FavRemove.Index = 1;
            this.cstub_FavRemove.Text = "Remove Selected";
            this.cstub_FavRemove.Click += new System.EventHandler(this.cstub_FavRemove_Click);
            // 
            // menuItem33
            // 
            this.menuItem33.Index = 2;
            this.menuItem33.Text = "-";
            // 
            // cstub_ShowThumb
            // 
            this.cstub_ShowThumb.Index = 3;
            this.cstub_ShowThumb.Text = "Show Thumbnails";
            this.cstub_ShowThumb.Click += new System.EventHandler(this.cstub_ShowThumb_Click);
            // 
            // cstub_ShowOffline
            // 
            this.cstub_ShowOffline.Index = 4;
            this.cstub_ShowOffline.Text = "Show Offline";
            this.cstub_ShowOffline.Click += new System.EventHandler(this.cstub_ShowOffline_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 5;
            this.menuItem10.Text = "-";
            // 
            // cstub_SelectAll
            // 
            this.cstub_SelectAll.Index = 6;
            this.cstub_SelectAll.Text = "Select All";
            this.cstub_SelectAll.Click += new System.EventHandler(this.cstub_SelectAll_Click);
            // 
            // cstub_CheckAll
            // 
            this.cstub_CheckAll.Index = 7;
            this.cstub_CheckAll.Text = "Check All";
            this.cstub_CheckAll.Click += new System.EventHandler(this.cstub_CheckAll_Click);
            // 
            // cstub_UncheckAll
            // 
            this.cstub_UncheckAll.Index = 8;
            this.cstub_UncheckAll.Text = "Uncheck All";
            this.cstub_UncheckAll.Click += new System.EventHandler(this.cstub_UncheckAll_Click);
            // 
            // TasksContxt
            // 
            this.TasksContxt.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.cTsk_Terminate,
            this.cTsk_Suspend,
            this.cTsk_Resume,
            this.menuItem16,
            this.cTsk_Properties,
            this.menuItem18,
            this.cTsk_CopyColumn,
            this.cTsk_Copy});
            // 
            // cTsk_Terminate
            // 
            this.cTsk_Terminate.Index = 0;
            this.cTsk_Terminate.Text = "Terminate";
            this.cTsk_Terminate.Click += new System.EventHandler(this.cTsk_Terminate_Click);
            // 
            // cTsk_Suspend
            // 
            this.cTsk_Suspend.Index = 1;
            this.cTsk_Suspend.Text = "Suspend";
            this.cTsk_Suspend.Click += new System.EventHandler(this.cTsk_Suspend_Click);
            // 
            // cTsk_Resume
            // 
            this.cTsk_Resume.Index = 2;
            this.cTsk_Resume.Text = "Resume";
            this.cTsk_Resume.Click += new System.EventHandler(this.cTsk_Resume_Click);
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 3;
            this.menuItem16.Text = "-";
            // 
            // cTsk_Properties
            // 
            this.cTsk_Properties.DefaultItem = true;
            this.cTsk_Properties.Index = 4;
            this.cTsk_Properties.Text = "Properties";
            this.cTsk_Properties.Click += new System.EventHandler(this.cTsk_Properties_Click);
            // 
            // menuItem18
            // 
            this.menuItem18.Index = 5;
            this.menuItem18.Text = "-";
            // 
            // cTsk_CopyColumn
            // 
            this.cTsk_CopyColumn.Index = 6;
            this.cTsk_CopyColumn.Text = "Copy (Column)";
            this.cTsk_CopyColumn.Click += new System.EventHandler(this.cTsk_CopyColumn_Click);
            // 
            // cTsk_Copy
            // 
            this.cTsk_Copy.Index = 7;
            this.cTsk_Copy.Text = "Copy";
            this.cTsk_Copy.Click += new System.EventHandler(this.cTsk_Copy_Click);
            // 
            // categoryPanel1
            // 
            this.categoryPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoryPanel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryPanel1.Location = new System.Drawing.Point(0, 27);
            this.categoryPanel1.Name = "categoryPanel1";
            this.categoryPanel1.Size = new System.Drawing.Size(891, 30);
            this.categoryPanel1.TabIndex = 15;
            // 
            // ClientInterface
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(891, 574);
            this.Controls.Add(this.InterfaceTbCntrl);
            this.Controls.Add(this.LineLbl2);
            this.Controls.Add(this.categoryPanel1);
            this.Controls.Add(this.LineLbl1);
            this.Controls.Add(this.IntToolStrip);
            this.Controls.Add(this.InterfaceStatusBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.IntMnu;
            this.MinimumSize = new System.Drawing.Size(347, 440);
            this.Name = "ClientInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prepril Remote Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Interface_FormClosing);
            this.Load += new System.EventHandler(this.Interface_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.ClientInterface_Layout);
            this.Resize += new System.EventHandler(this.Interface_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.RAMUsePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPUUsePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StubsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessesPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownSpeedPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpSpeedPanel)).EndInit();
            this.IntToolStrip.ResumeLayout(false);
            this.IntToolStrip.PerformLayout();
            this.InterfaceTbCntrl.ResumeLayout(false);
            this.StubServersTab.ResumeLayout(false);
            this.TasksTab.ResumeLayout(false);
            this.OnConnectTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.InterfaceLogTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vistaMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenu StbSvrCntxt;
        private System.Windows.Forms.MenuItem StbSvrCntxtSep2;
        private System.Windows.Forms.ContextMenu StbSvrClmsCntxt;
        private System.Windows.Forms.MenuItem cstub_SizeColumn;
        private System.Windows.Forms.MenuItem cstub_SizeAllColumn;
        private System.Windows.Forms.MenuItem cstub_HideColmun;
        private System.Windows.Forms.MenuItem cstub_ChooseColumns;
        private System.Windows.Forms.MenuItem menuItem45;
        private System.Windows.Forms.MenuItem StbSvrCntxtSep3;
        private System.Windows.Forms.ContextMenu TryIcnCntxt;
        private System.Windows.Forms.MenuItem trayShowHideMenuItem;
        private System.Windows.Forms.MenuItem menuItem111;
        private System.Windows.Forms.MenuItem trayStubsProcessesMenuItem;
        private System.Windows.Forms.MenuItem menuItem110;
        private System.Windows.Forms.MenuItem trayExitMenuItem;
        private System.Windows.Forms.MainMenu IntMnu;
        private System.Windows.Forms.MenuItem m_File;
        private System.Windows.Forms.MenuItem m_ExportUserData;
        private System.Windows.Forms.MenuItem FileMnuSep3;
        private System.Windows.Forms.MenuItem m_Exit;
        private System.Windows.Forms.MenuItem m_View;
        private System.Windows.Forms.MenuItem m_TopMost;
        private System.Windows.Forms.MenuItem ViewMnuSep1;
        private System.Windows.Forms.MenuItem m_ShowCategoryPane;
        private System.Windows.Forms.MenuItem m_ShowStatusBar;
        private System.Windows.Forms.MenuItem m_ShowToolStrip;
        private System.Windows.Forms.MenuItem m_ShowCheckBoxes;
        private System.Windows.Forms.MenuItem m_Server;
        private System.Windows.Forms.MenuItem m_QuickConnect;
        private System.Windows.Forms.MenuItem m_DisconnectServer;
        private System.Windows.Forms.MenuItem m_Stubs;
        private System.Windows.Forms.MenuItem m_Group;
        private System.Windows.Forms.MenuItem m_GroupFav;
        private System.Windows.Forms.MenuItem m_GroupMostReliable;
        private System.Windows.Forms.MenuItem m_GroupCountry;
        private System.Windows.Forms.MenuItem m_GroupMostBusy;
        private System.Windows.Forms.MenuItem m_GroupNone;
        private System.Windows.Forms.MenuItem TlsMenu;
        private System.Windows.Forms.MenuItem IPTrckrMnuItm;
        private System.Windows.Forms.MenuItem StbsMnuSep3;
        private System.Windows.Forms.MenuItem StatsMnuItm;
        private System.Windows.Forms.StatusBar InterfaceStatusBar;
        private System.Windows.Forms.StatusBarPanel CPUUsePanel;
        private System.Windows.Forms.StatusBarPanel RAMUsePanel;
        private System.Windows.Forms.StatusBarPanel StubsPanel;
        private System.Windows.Forms.MenuItem UserChatMenuItem;
        private System.Windows.Forms.MenuItem ChckUpdtsMnuItm;
        private System.Windows.Forms.MenuItem PlgnsMnu;
        private System.Windows.Forms.MenuItem PlgnMngrMnuItm;
        private System.Windows.Forms.MenuItem CtgryEdtrMnuItm;
        private System.Windows.Forms.ToolStripButton ActiveToolStripBt;
        private System.Windows.Forms.MenuItem HelpMnu;
        private System.Windows.Forms.MenuItem AbtMnuItm;
        private System.Windows.Forms.MenuItem HelpMenuSep1;
        private System.Windows.Forms.MenuItem LogDirMnuItm;
        private System.Windows.Forms.MenuItem PlgnsDirMnuItm;
        private System.Windows.Forms.MenuItem DbDirMnuItm;
        private System.Windows.Forms.MenuItem m_GroupManager;
        private System.Windows.Forms.NotifyIcon TryIcn;
        private System.Windows.Forms.MenuItem m_Options;
        private System.Windows.Forms.MenuItem LgExMnuItm;
        private System.Windows.Forms.MenuItem AutScrllLogMnuItm;
        private System.Windows.Forms.MenuItem OptnMnuSep1;
        private System.Windows.Forms.MenuItem SttngMnuItm;
        private System.Windows.Forms.MenuItem m_BuildUpdater;
        private System.Windows.Forms.MenuItem StbsMnuSep4;
        private System.Windows.Forms.MenuItem m_AddNew;
        private System.Windows.Forms.MenuItem m_NetworkScan;
        private System.Windows.Forms.MenuItem HelpMenuSep2;
        private System.Windows.Forms.MenuItem NwVerMnu;
        private System.Windows.Forms.MenuItem NwVerMnuItm;
        private System.Windows.Forms.MenuItem m_ReconnectServer;
        private System.Windows.Forms.MenuItem StbSvrCntxtSep7;
        private System.Windows.Forms.MenuItem WelcDlgMnuItm;
        private System.Windows.Forms.MenuItem HelpMenuSep3;
        private System.Windows.Forms.MenuItem m_SaveLogAs;
        private System.Windows.Forms.MenuItem FileMnuSep2;
        private System.Windows.Forms.MenuItem ScriptEditorMenuItem;
        private System.Windows.Forms.MenuItem StbSvrCntxtSep5;
        private System.Windows.Forms.MenuItem StbSvrCntxtSep6;
        private System.Windows.Forms.MenuItem ScptSchdlMnuItm;
        private System.Windows.Forms.MenuItem SvrMnuSep2;
        private System.Windows.Forms.MenuItem TlstrRndrExMnuItm;
        private System.Windows.Forms.MenuItem LstVwRndrExMnuItm;
        private System.Windows.Forms.MenuItem TrVwRndrExMnuItm;
        private System.Windows.Forms.MenuItem SystemRendererMenuItem;
        private System.Windows.Forms.MenuItem ExplorerRendererMenuItem;
        private System.Windows.Forms.MenuItem menuItem47;
        private System.Windows.Forms.MenuItem menuItem51;
        private System.Windows.Forms.MenuItem menuItem50;
        private System.Windows.Forms.MenuItem m_ImportUserData;
        private System.Windows.Forms.MenuItem menuItem54;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.MenuItem OptnMnuSep2;
        private System.Windows.Forms.MenuItem ClearDataMenuItem;
        private System.Windows.Forms.MenuItem UsrDatBckpRstrMnuItm;
        private System.Windows.Forms.MenuItem System3DRendererMenuItem;
        private System.Windows.Forms.MenuItem SvrMnuSep1;
        private System.Windows.Forms.MenuItem StbsMnuSep2;
        private System.Windows.Forms.MenuItem menuItem13;
        private System.Windows.Forms.MenuItem menuItem20;
        private System.Windows.Forms.MenuItem NotesMenuItem;
        private System.Windows.Forms.StatusBarPanel ProcessesPanel;
        private System.Windows.Forms.StatusBarPanel DownSpeedPanel;
        private System.Windows.Forms.StatusBarPanel UpSpeedPanel;
        private System.Windows.Forms.MenuItem menuItem23;
        private System.Windows.Forms.MenuItem menuItem25;
        private System.Windows.Forms.MenuItem menuItem24;
        private System.Windows.Forms.MenuItem m_RemotePluginManager;
        private wyDay.Controls.VistaMenu vistaMenu;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem26;
        private System.Windows.Forms.MenuItem menuItem30;
        private System.Windows.Forms.MenuItem menuItem31;
        private System.Windows.Forms.MenuItem menuItem32;
        private System.Windows.Forms.MenuItem m_GroupBuildID;
        private System.Windows.Forms.MenuItem m_BuildManager;
        private System.Windows.Forms.MenuItem MediaManagerMenuItem;
        private System.Windows.Forms.MenuItem ScriptManagerMenuItem;
        private System.Windows.Forms.MenuItem TlsMenuSep3;
        private System.Windows.Forms.MenuItem UserDataMenuItem;
        private System.Windows.Forms.MenuItem SetupAutoSyncMenuItem;
        private System.Windows.Forms.MenuItem TlsMenuSep1;
        private System.Windows.Forms.MenuItem TlsMenuSep2;
        private System.Windows.Forms.MenuItem AnlytcsMnuItm;
        private System.Windows.Forms.MenuItem AutSvLogMnuItm;
        private System.Windows.Forms.ContextMenu OnConnectCntxt;
        private System.Windows.Forms.MenuItem cstub_CopyColumn;
        private System.Windows.Forms.MenuItem cstub_Copy;
        private System.Windows.Forms.MenuItem cstub_Suspend;
        private System.Windows.Forms.MenuItem cstub_Resume;
        private System.Windows.Forms.MenuItem cstub_Remove;
        private System.Windows.Forms.MenuItem cstub_Uninstall;
        private System.Windows.Forms.MenuItem cstub_BuildUpdater;
        private System.Windows.Forms.MenuItem cstub_TrackIP;
        private System.Windows.Forms.MenuItem CnfTskCntxtItm;
        private System.Windows.Forms.MenuItem menuItem78;
        private System.Windows.Forms.MenuItem DsblTskCntxtItm;
        private System.Windows.Forms.MenuItem EnblTskCntxtItm;
        private System.Windows.Forms.MenuItem menuItem81;
        private System.Windows.Forms.MenuItem RmvTskCntxtItm;
        private System.Windows.Forms.MenuItem m_ShowOffline;
        private System.Windows.Forms.MenuItem ViewMnuSep2;
        private System.Windows.Forms.MenuItem cstub_Properties;
        private System.Windows.Forms.MenuItem m_StubServers;
        private System.Windows.Forms.MenuItem m_ShowThumbnails;
        public System.Windows.Forms.ImageList FlgsImgLst;
        private System.Windows.Forms.ToolStripButton FindToolStripBt;
        private System.Windows.Forms.MenuItem m_Find;
        private System.Windows.Forms.MenuItem m_CategoryPane;
        private System.Windows.Forms.MenuItem m_CategoryWrapContents;
        private System.Windows.Forms.MenuItem FileMnuSep1;
        private System.Windows.Forms.Label LineLbl1;
        private System.Windows.Forms.ToolStrip IntToolStrip;
        private System.Windows.Forms.ToolStripButton DscnnctSvrTlstrBt;
        private System.Windows.Forms.ToolStripButton CnnctSvrTlstrBt;
        private System.Windows.Forms.ToolStripSeparator TlstrSep2;
        private System.Windows.Forms.ToolStripButton StatsTlstrBt;
        private System.Windows.Forms.ToolStripButton AnlytcTlstrBt;
        private System.Windows.Forms.ToolStripSeparator TlstrSep3;
        private System.Windows.Forms.ToolStripButton NwkScnTlstrBt;
        private System.Windows.Forms.ToolStripButton FndTlstrBt;
        private System.Windows.Forms.ToolStripSeparator TlstrSep4;
        private System.Windows.Forms.ToolStripButton SttngTlstrBt;
        private System.Windows.Forms.ToolStripButton AddManTlstrBt;
        private System.Windows.Forms.ToolStripSeparator TlstrSep1;
        private System.Windows.Forms.MenuItem m_AddManager;
        private System.Windows.Forms.MenuItem StbsMnuSep1;
        private System.Windows.Forms.MenuItem m_DirectConnect;
        private System.Windows.Forms.TabControl InterfaceTbCntrl;
        private System.Windows.Forms.TabPage StubServersTab;
        private PpRStandardLib.Controls.FullListView StubServersLstVw;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader ConnectionIDColumn;
        private System.Windows.Forms.ColumnHeader IPAddressColumn;
        private System.Windows.Forms.ColumnHeader PortColumn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader DeviceNameColumn;
        private System.Windows.Forms.ColumnHeader ActivityColumn;
        private System.Windows.Forms.ColumnHeader PingColumn;
        private System.Windows.Forms.ColumnHeader UserNameColumn;
        private System.Windows.Forms.ColumnHeader PrivilegesColumn;
        private System.Windows.Forms.ColumnHeader CountryColumn;
        private System.Windows.Forms.ColumnHeader RatingColumn;
        private System.Windows.Forms.ColumnHeader ProcessesColumn;
        private System.Windows.Forms.ColumnHeader PluginsColumn;
        private System.Windows.Forms.ColumnHeader VersionColumn;
        private System.Windows.Forms.TabPage OnConnectTab;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ClrTsksBtn;
        private System.Windows.Forms.Button CfgCnnctTskBtn;
        private System.Windows.Forms.ComboBox TsksCmbx;
        private System.Windows.Forms.TabPage InterfaceLogTab;
        private System.Windows.Forms.Label LineLbl2;
        private CategoryPanel categoryPanel1;
        private PpRStandardLib.Controls.FullListView OnConnectLstVw;
        private System.Windows.Forms.ColumnHeader TaskNameColumn;
        private System.Windows.Forms.ColumnHeader ActionColumn;
        private System.Windows.Forms.ColumnHeader ActionDataColumn;
        private System.Windows.Forms.ColumnHeader ExecutedColumn;
        private System.Windows.Forms.ColumnHeader OwnerColumn;
        private System.Windows.Forms.ColumnHeader AddedColumn;
        private System.Windows.Forms.MenuItem m_GroupBy;
        private System.Windows.Forms.MenuItem DwnTrnsMnuItm;
        private System.Windows.Forms.MenuItem PayPlnMnuItm;
        private System.Windows.Forms.MenuItem WebMnuItm;
        private System.Windows.Forms.MenuItem ForumMnuItm;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem cstub_DirectConnect;
        private System.Windows.Forms.MenuItem StbSvrCntxtSep1;
        private System.Windows.Forms.MenuItem cstub_Restart;
        private System.Windows.Forms.RichTextBox LogRchtxt;
        private System.Windows.Forms.TabPage TasksTab;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.MenuItem DirMnuItm;
        private PpRStandardLib.Controls.FullListView TsksLstVw;
        private System.Windows.Forms.ColumnHeader columnHeader170;
        private System.Windows.Forms.ColumnHeader DescriptionColumn;
        private System.Windows.Forms.ColumnHeader PIDColumn;
        private System.Windows.Forms.ColumnHeader columnHeader171;
        private System.Windows.Forms.ColumnHeader DurationColumn;
        private System.Windows.Forms.ColumnHeader columnHeader172;
        private System.Windows.Forms.ColumnHeader columnHeader173;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.ContextMenu StbSvrCntxt2;
        private System.Windows.Forms.MenuItem cstub_SelectBy;
        private System.Windows.Forms.MenuItem cstub_CurrentGroup;
        private System.Windows.Forms.MenuItem cstub_FavOnly;
        private System.Windows.Forms.MenuItem cstub_FavGroup;
        private System.Windows.Forms.MenuItem cstub_FavAdd;
        private System.Windows.Forms.MenuItem cstub_FavRemove;
        private System.Windows.Forms.MenuItem menuItem33;
        private System.Windows.Forms.MenuItem cstub_ShowThumb;
        private System.Windows.Forms.MenuItem cstub_ShowOffline;
        private System.Windows.Forms.MenuItem cstub_SelectAll;
        private System.Windows.Forms.MenuItem cstub_CheckAll;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem cstub_UncheckAll;
        private System.Windows.Forms.ContextMenu TasksContxt;
        private System.Windows.Forms.MenuItem cTsk_Terminate;
        private System.Windows.Forms.MenuItem cTsk_Suspend;
        private System.Windows.Forms.MenuItem cTsk_Resume;
        private System.Windows.Forms.MenuItem menuItem16;
        private System.Windows.Forms.MenuItem cTsk_Properties;
        private System.Windows.Forms.MenuItem menuItem18;
        private System.Windows.Forms.MenuItem cTsk_CopyColumn;
        private System.Windows.Forms.MenuItem cTsk_Copy;
    }
}

