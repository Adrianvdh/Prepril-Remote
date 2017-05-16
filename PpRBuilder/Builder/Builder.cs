using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Configuration;
using PpRBuilder.Controls;

namespace PpRBuilder.Forms
{
    public partial class Builder : Form
    {
        private System.Windows.Forms.TreeView m_optionsTV;
        private StatusBar statusBar1;
        private ImageList imageList1;
        private CSharpCustomPanelControl.RoundCornerPanel m_mainPanel;
        private CSharpCustomPanelControl.RoundCornerPanel m_headPanel;
        private PictureBox pictureBox1;
        private Label m_configLabel;
        private MainMenu mainMenu1;
        private MenuItem FileMnu;
        private MenuItem TlsMenu;
        private TreeView treeView1;
        private CSharpCustomPanelControl.RoundCornerPanel roundCornerPanel1;
        private ProgressBar progressBar1;
        private Button button1;
        private MenuItem menuItem4;
        private MenuItem menuItem5;
        private MenuItem HelpMnu;
        private MenuItem menuItem6;
        private MenuItem menuItem7;
        private MenuItem menuItem8;
        private MenuItem menuItem9;
        private MenuItem menuItem10;
        private MenuItem menuItem11;
        private MenuItem menuItem12;
        private MenuItem menuItem13;
        private MenuItem menuItem14;
        private MenuItem menuItem15;
        private MenuItem menuItem16;
        private MenuItem menuItem17;
        private MenuItem menuItem18;
        private MenuItem menuItem19;
        private MenuItem menuItem20;
        private MenuItem menuItem1;
        private IContainer components;

        private enum Action
        {
            Apply = 1,
            Restore = 2
        }

        public Builder()
        {
            InitializeComponent();

            this.Text = "Prepril Remote Builder "+"<v10.0>";
            VistaControls.VistaConstants.SetWindowTheme(m_optionsTV.Handle, "explorer", null);

            //m_configurationForm = new Settings2();
            //m_configurationForm.ApplyBtn += new EventHandler(OnApplyClicked);

            this.PopulateConfigurationForm();

            //m_restoreBtn.Click += new EventHandler(OnRestoreButtonClicked);
            //m_applyBtn.Click += new EventHandler(OnApplyButtonClicked);
            //m_cancelBtn.Click += new EventHandler(OnCancelButtonClicked);
            //m_okBtn.Click += new EventHandler(OnOkButtonClicked);
            m_optionsTV.ExpandAll();
        }

        private void PopulateConfigurationForm()
        {

            m_optionsTV.ImageList = this.imageList1;

            ConfigTreeNode config;
            TreeNode treeNode;

            config = new ConfigTreeNode("General", new create_stub_General("General"));
            AddConfigItem(config, "arrow_direction_back.png");

            
            treeNode = new ConfigTreeNode("Connections", new create_stub_Connections("Connections"));

            config = new ConfigTreeNode("Permissions", new create_stub_Permissions("Permissions"));
            config.ImageKey = "check_box_list.png";
            config.SelectedImageKey = "check_box_list.png";
            treeNode.Nodes.Add(config);

            config = new ConfigTreeNode("SSL/TLS", new create_stub_SSLTLS("SSL/TLS"));
            config.ImageKey = "connections.png";
            config.SelectedImageKey = "connections.png";
            treeNode.Nodes.Add(config);

            AddConfigItem(treeNode, "connections.png");


            
            treeNode = new ConfigTreeNode("Installation", new create_stub_Installation("Installation"));

            config = new ConfigTreeNode("Kernal-mode Driver", new create_stub_SSLTLS("Kernal-mode Driver"));
            config.ImageKey = "Setup.ico";
            config.SelectedImageKey = "Setup.ico";
            treeNode.Nodes.Add(config);

            AddConfigItem(treeNode, "Setup.ico");



            config = new ConfigTreeNode("Safe Mode", new create_stub_SafeMode("Safe Mode"));
            AddConfigItem(config, "shield.png");

            config = new ConfigTreeNode("Display MsgBox", new create_stub_DisplayMsgBox("Display Message Box"));
            AddConfigItem(config, "dialog.png");

            config = new ConfigTreeNode("Rootkit", new create_stub_Rootkit("Rootkit"));
            AddConfigItem(config, "distribution.png");

            config = new ConfigTreeNode("Redistribution", new create_stub_Redistribution("Redistribution"));
            AddConfigItem(config, "Processes.ico");

            config = new ConfigTreeNode("Process Injection", new create_stub_ProcessInjection("Process Injection"));
            AddConfigItem(config, "chart_bar.png");

            config = new ConfigTreeNode("Black List", new create_stub_BlackList("Black List"));
            AddConfigItem(config, "chart_bar.png");

            config = new ConfigTreeNode("Hosts Editor", new create_stub_HostsEditor("Hosts Editor"));
            AddConfigItem(config, "chart_bar.png");

            config = new ConfigTreeNode("Plugins", new create_stub_AddPlugins("Plugins"));
            AddConfigItem(config, "Plugin Add.ico");

            config = new ConfigTreeNode("File Binder", new create_stub_FileBinder("File Binder"));
            AddConfigItem(config, "Execute.ico");

            config = new ConfigTreeNode("Choose Icon", new create_stub_ChooseIcon("Choose Icon"));
            AddConfigItem(config, "chart_bar.png");

            config = new ConfigTreeNode("Assembly Binding", new create_stub_AssemblyBinding("Assembly Binding"));
            AddConfigItem(config, "application.png");

            config = new ConfigTreeNode("Overview", new create_stub_Overview("Brief Overview"));
            AddConfigItem(config, "chart_bar.png");

            config = new ConfigTreeNode("Build Finalization", new create_stub_BuildFinalization("Build Finalization"));
            AddConfigItem(config, "chart_bar.png");

            config = new ConfigTreeNode("Profile Manager", new create_stub_General("Profile Manager"));
            AddConfigItem(config, "User.ico");
            
            

            //RemoveConfigItem("Database Writer");
        }

        
		/// </summary>
		public event EventHandler OkBtn;
		/// <summary>
		/// Additional event handler for cancel button
		/// </summary>
		public event EventHandler CancelBtn;

		/// <summary>
		/// Add the next configuration tree node item
		/// </summary>
		/// <param name="configurationNode"></param>
        public void AddConfigItem(TreeNode configurationNode, String configurationImage)
		{

            if (m_optionsTV.Nodes.Count == 0)
            {
                m_optionsTV.Nodes.Add(configurationNode);
                m_optionsTV.SelectedNode = configurationNode;
                m_optionsTV.Select();
            }
            else
            {
                m_optionsTV.Nodes.Add(configurationNode);
            }
                configurationNode.ImageKey = configurationImage;
                configurationNode.SelectedImageKey = configurationImage;
		}

        /// <summary>
		/// Remove the tree node item with specified config name
		/// </summary>
		/// <param name="configName"></param>
		public void RemoveConfigItem(string configName)
		{
			this.RemoveItem(m_optionsTV.Nodes, configName);
		}

        private void SelectConfig(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			if (e.Node is ConfigTreeNode)
			{
				//removes any controls
				if (m_mainPanel.Controls.Count > 0) m_mainPanel.Controls.RemoveAt(0);
				OptionsBaseControl control = ((ConfigTreeNode)e.Node).GetConfigurationControl();
				//add the current control to the main panel
				
				this.ResizeIfNeeded(control);
				m_mainPanel.Controls.Add(control);
				//set the name of the control
				this.SetLabel(((ConfigTreeNode)e.Node).GetConfigurationName());
			}
		}

        /// <summary>
		/// Resize the width of the form if needed
		/// </summary>
		/// <param name="control"></param>

		private void ResizeIfNeeded(OptionsBaseControl control)
		{
            
			int controlWidth = control.Width;
            int controlHeight= control.Height;

			int panelWidth = m_mainPanel.Width;
            int panelHeight = m_mainPanel.Height;

			int formWidth = this.Width;
            int formHeight = this.Height;

            int diffWidth = formWidth - panelWidth;
            int diffHeight = formHeight - panelHeight;
            
            if (controlWidth > panelWidth)
            {
                this.Width = controlWidth + diffWidth;
                m_mainPanel.Width = controlWidth;
            }
            if (controlHeight > panelHeight)
            {
                this.Height = controlHeight + diffHeight;
                m_mainPanel.Height = controlHeight;
            }
            
		}

        /// <summary>
		/// When the control is active, set its name in the upper side of the form
		/// </summary>
		/// <param name="label"></param>
		private void SetLabel(string label)
		{
			this.m_configLabel.Text = label;
		}


        /// <summary>
		/// Default handler for apply,restor,ok,cancel buttons
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClickHandler(object sender, System.EventArgs e)
		{

            if (sender == button1)
			{
				this.TreeWalker(m_optionsTV.Nodes,Action.Apply);
			}
		}

        /// <summary>
		/// When the Restor or Apply command are initiated, visit each tree node, get its related control and call the method (Restore, Apply)
		/// </summary>
		/// <param name="treeCollection"></param>
		/// <param name="action"></param>
		private void TreeWalker(TreeNodeCollection treeCollection,Action action)
		{
			if (treeCollection == null) return;

			foreach(TreeNode node in treeCollection)
			{
				if (node is ConfigTreeNode)
				{
					OptionsBaseControl configurationBaseControl = ((ConfigTreeNode) node).GetConfigurationControl();
					//if (action == Action.Apply) configurationBaseControl.Apply();
					//else if (action == Action.Restore) configurationBaseControl.Restore();
         
					this.TreeWalker(node.Nodes,action);
				}
			}
		}

        /// <summary>
		/// Remove tree node item with specified name
		/// </summary>
		/// <param name="treeCollection"></param>
		/// <param name="name"></param>
		private void RemoveItem(TreeNodeCollection treeCollection,string name)
		{
			if (treeCollection == null) return;
			foreach(TreeNode node in treeCollection)
			{
				if (string.Equals(node.Text, name)) 
				{
					m_optionsTV.Nodes.Remove(node);
					if (node is ConfigTreeNode)
					{
						OptionsBaseControl control = ((ConfigTreeNode)node).GetConfigurationControl();
						if (m_mainPanel.Controls.Contains((control))) m_mainPanel.Controls.RemoveAt(0);
					}
					break;
				}
				this.RemoveItem(node.Nodes,name);
			}
		}

		[Category("Button Clicks"),Description("Occurs when Ok button is clicked")]
		protected void OnOkButtonClicked(object sender,EventArgs e)
		{
			if (OkBtn != null) OkBtn(sender,e);
		}
		[Category("Button Clicks"),Description("Occurs when Cancel button is clicked")]
		protected void OnCancelButtonClicked(object sender,EventArgs e)
		{
			if (CancelBtn != null) CancelBtn(sender,e);
		}


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Builder));
            this.m_optionsTV = new System.Windows.Forms.TreeView();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.m_headPanel = new CSharpCustomPanelControl.RoundCornerPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.m_configLabel = new System.Windows.Forms.Label();
            this.m_mainPanel = new CSharpCustomPanelControl.RoundCornerPanel();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.FileMnu = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.TlsMenu = new System.Windows.Forms.MenuItem();
            this.HelpMnu = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.menuItem18 = new System.Windows.Forms.MenuItem();
            this.menuItem19 = new System.Windows.Forms.MenuItem();
            this.menuItem20 = new System.Windows.Forms.MenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.roundCornerPanel1 = new CSharpCustomPanelControl.RoundCornerPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.m_headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.roundCornerPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_optionsTV
            // 
            this.m_optionsTV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_optionsTV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.m_optionsTV.FullRowSelect = true;
            this.m_optionsTV.HideSelection = false;
            this.m_optionsTV.Location = new System.Drawing.Point(6, 5);
            this.m_optionsTV.Name = "m_optionsTV";
            this.m_optionsTV.Size = new System.Drawing.Size(190, 349);
            this.m_optionsTV.TabIndex = 92;
            this.m_optionsTV.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SelectConfig);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 427);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(818, 22);
            this.statusBar1.SizingGrip = false;
            this.statusBar1.TabIndex = 100;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Information.ico");
            this.imageList1.Images.SetKeyName(1, "Execute.ico");
            this.imageList1.Images.SetKeyName(2, "Message.ico");
            this.imageList1.Images.SetKeyName(3, "Plugin Add.ico");
            this.imageList1.Images.SetKeyName(4, "Processes.ico");
            this.imageList1.Images.SetKeyName(5, "User.ico");
            this.imageList1.Images.SetKeyName(6, "Setup.ico");
            this.imageList1.Images.SetKeyName(7, "Keyboard.ico");
            this.imageList1.Images.SetKeyName(8, "radioactivity.png");
            this.imageList1.Images.SetKeyName(9, "shield.png");
            this.imageList1.Images.SetKeyName(10, "dialog.png");
            this.imageList1.Images.SetKeyName(11, "distribution.png");
            this.imageList1.Images.SetKeyName(12, "connections.png");
            this.imageList1.Images.SetKeyName(13, "application.png");
            this.imageList1.Images.SetKeyName(14, "check_box_list.png");
            // 
            // m_headPanel
            // 
            this.m_headPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_headPanel.BackColor = System.Drawing.SystemColors.Control;
            this.m_headPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_headPanel.Controls.Add(this.pictureBox1);
            this.m_headPanel.Controls.Add(this.m_configLabel);
            this.m_headPanel.Curvature = 1;
            this.m_headPanel.Location = new System.Drawing.Point(202, 5);
            this.m_headPanel.Name = "m_headPanel";
            this.m_headPanel.Size = new System.Drawing.Size(428, 21);
            this.m_headPanel.TabIndex = 102;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PpRBuilder.Properties.Resources.information;
            this.pictureBox1.Location = new System.Drawing.Point(409, 3);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(16, 16);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(16, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 147;
            this.pictureBox1.TabStop = false;
            // 
            // m_configLabel
            // 
            this.m_configLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_configLabel.Location = new System.Drawing.Point(3, 2);
            this.m_configLabel.Name = "m_configLabel";
            this.m_configLabel.Size = new System.Drawing.Size(397, 16);
            this.m_configLabel.TabIndex = 0;
            this.m_configLabel.Text = "Title";
            // 
            // m_mainPanel
            // 
            this.m_mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.m_mainPanel.BackColor2 = System.Drawing.SystemColors.Control;
            this.m_mainPanel.BorderColor = System.Drawing.Color.Gray;
            this.m_mainPanel.Curvature = 1;
            this.m_mainPanel.Location = new System.Drawing.Point(202, 30);
            this.m_mainPanel.Name = "m_mainPanel";
            this.m_mainPanel.Size = new System.Drawing.Size(428, 324);
            this.m_mainPanel.TabIndex = 101;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FileMnu,
            this.TlsMenu,
            this.HelpMnu});
            // 
            // FileMnu
            // 
            this.FileMnu.Index = 0;
            this.FileMnu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem5,
            this.menuItem4});
            this.FileMnu.Text = "File";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Create New";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.Text = "-";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Text = "Exit";
            // 
            // TlsMenu
            // 
            this.TlsMenu.Index = 1;
            this.TlsMenu.Text = "Tools";
            // 
            // HelpMnu
            // 
            this.HelpMnu.Index = 2;
            this.HelpMnu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem6,
            this.menuItem7,
            this.menuItem8,
            this.menuItem9,
            this.menuItem10,
            this.menuItem11,
            this.menuItem12,
            this.menuItem13,
            this.menuItem14,
            this.menuItem18,
            this.menuItem19,
            this.menuItem20});
            this.HelpMnu.Text = "Help";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 0;
            this.menuItem6.Text = "Payment Plans";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 1;
            this.menuItem7.Text = "-";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 2;
            this.menuItem8.Text = "Prepril Website";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 3;
            this.menuItem9.Text = "Prepril Forum";
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 4;
            this.menuItem10.Text = "-";
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 5;
            this.menuItem11.Text = "Download Translations";
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 6;
            this.menuItem12.Text = "Check for Updates";
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 7;
            this.menuItem13.Text = "-";
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 8;
            this.menuItem14.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem15,
            this.menuItem16,
            this.menuItem17});
            this.menuItem14.Text = "Folders";
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 0;
            this.menuItem15.Text = "Databases Folder";
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 1;
            this.menuItem16.Text = "Logs Folder";
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 2;
            this.menuItem17.Text = "Plugins Folder";
            // 
            // menuItem18
            // 
            this.menuItem18.Index = 9;
            this.menuItem18.Text = "-";
            // 
            // menuItem19
            // 
            this.menuItem19.Index = 10;
            this.menuItem19.Text = "Show Welcome Dialog";
            // 
            // menuItem20
            // 
            this.menuItem20.Index = 11;
            this.menuItem20.Text = "About";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(636, 5);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(176, 415);
            this.treeView1.TabIndex = 104;
            // 
            // roundCornerPanel1
            // 
            this.roundCornerPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundCornerPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.roundCornerPanel1.BackColor2 = System.Drawing.SystemColors.Control;
            this.roundCornerPanel1.BorderColor = System.Drawing.Color.Gray;
            this.roundCornerPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundCornerPanel1.Controls.Add(this.progressBar1);
            this.roundCornerPanel1.Controls.Add(this.button1);
            this.roundCornerPanel1.Curvature = 1;
            this.roundCornerPanel1.Location = new System.Drawing.Point(6, 360);
            this.roundCornerPanel1.Name = "roundCornerPanel1";
            this.roundCornerPanel1.Size = new System.Drawing.Size(624, 60);
            this.roundCornerPanel1.TabIndex = 105;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(206, 27);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(320, 20);
            this.progressBar1.TabIndex = 98;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.Location = new System.Drawing.Point(532, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 99;
            this.button1.Text = "Build";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Builder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 449);
            this.Controls.Add(this.m_optionsTV);
            this.Controls.Add(this.m_mainPanel);
            this.Controls.Add(this.m_headPanel);
            this.Controls.Add(this.roundCornerPanel1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.statusBar1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "Builder";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Builder_Load);
            this.m_headPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.roundCornerPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private void Builder_Load(object sender, EventArgs e)
        {

        }



    }
}
