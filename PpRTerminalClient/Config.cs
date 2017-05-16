using System;
using System.ComponentModel;
using System.Windows.Forms;
using Configuration;
using Configuration.Controls;

namespace PpRTerminalClient
{
    public partial class Config : Form
    {
        private System.ComponentModel.IContainer components = null;

        public Config()
        {
            InitializeComponent();
            VistaControls.VistaConstants.SetWindowTheme(m_optionsTV.Handle, "explorer", null);

			this.PopulateConfigurationForm();

			m_cancelBtn.Click += new EventHandler(OnCancelButtonClicked);
			m_okBtn.Click += new EventHandler(OnOkButtonClicked);

            m_optionsTV.ExpandAll();
        }

        private void Config_Load(object sender, EventArgs e)
        {

        }


        private enum Action
        {
            Apply = 1,
            Restore = 2
        }

        private void PopulateConfigurationForm()
        {
            TreeNode treeNode;
            ConfigTreeNode config;

            treeNode = new ConfigTreeNode("Session", new config_session("Basic Connection Configuration"));
            treeNode.Nodes.Add(new ConfigTreeNode("Logging", new conf_template("Available Plugin Updates")));
            AddConfigItem(treeNode);

            //regular TreeNode as root will hold three ConfigurationTreeNode
            treeNode = new ConfigTreeNode("Connection", new conf_template("Connection"));
            treeNode.Nodes.Add(new ConfigTreeNode("Proxy", new conf_template("Proxy Server Setup")));
            treeNode.Nodes.Add(new ConfigTreeNode("Data", new conf_template("Data to send to server")));
            AddConfigItem(treeNode);
            
           treeNode = new ConfigTreeNode("Plugins", new conf_plugins("Installed Plugins"));
           treeNode.Nodes.Add(new ConfigTreeNode("Updates", new conf_template("Available Plugin Updates")));
           treeNode.Nodes.Add(new ConfigTreeNode("Available", new conf_template("Available Plugins")));
           AddConfigItem(treeNode);

           config = new ConfigTreeNode("Directories", new conf_template("Directories"));
           AddConfigItem(config);

           config = new ConfigTreeNode("Language", new conf_language("Language"));
           AddConfigItem(config);

           config = new ConfigTreeNode("Updates", new conf_template("Updates"));
           AddConfigItem(config);

           config = new ConfigTreeNode("About", new conf_template("About"));
           AddConfigItem(config);

           //RemoveConfigItem("Database Writer");
        }

        
		/// <summary>
		/// Additional event handler for apply button
		/// </summary>
		public event EventHandler ApplyBtn;
		/// <summary>
		/// Additional event handler for restore button
		/// </summary>
		public event EventHandler RestoreBtn;
		/// <summary>
		/// Additional event handler for ok button
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
		public void AddConfigItem(TreeNode configurationNode)
		{
			if (m_optionsTV.Nodes.Count == 0) 
			{
				m_optionsTV.Nodes.Add(configurationNode);
				m_optionsTV.SelectedNode = configurationNode;
				m_optionsTV.Select();
			}
			else m_optionsTV.Nodes.Add(configurationNode);
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
            
			if (sender == m_okBtn)
			{
				this.TreeWalker(m_optionsTV.Nodes,Action.Apply);
			}
			else if (sender == m_cancelBtn)
			{
				this.Hide();
			}
            /*
			else if (sender == m_restoreBtn)
			{
				this.TreeWalker(m_optionsTV.Nodes,Action.Restore);
			}
			else if (sender == m_applyBtn)
			{
				this.TreeWalker(m_optionsTV.Nodes,Action.Apply);
			}
             */
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

		[Category("Button Clicks"),Description("Occurs when Apply button is clicked")]
		protected void OnApplyButtonClicked(object sender,EventArgs e)
		{
			if (ApplyBtn != null) ApplyBtn(sender,e);
		}
		[Category("Button Clicks"),Description("Occurs when Restore button is clicked")]
		protected void OnRestoreButtonClicked(object sender,EventArgs e)
		{
			if (RestoreBtn != null) RestoreBtn(sender,e);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.m_mainPanel = new System.Windows.Forms.Panel();
            this.m_optionsTV = new System.Windows.Forms.TreeView();
            this.roundCornerPanel1 = new CSharpCustomPanelControl.RoundCornerPanel();
            this.m_okBtn = new System.Windows.Forms.Button();
            this.m_cancelBtn = new System.Windows.Forms.Button();
            this.m_headPanel = new CSharpCustomPanelControl.RoundCornerPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.m_configLabel = new System.Windows.Forms.Label();
            this.roundCornerPanel1.SuspendLayout();
            this.m_headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // m_mainPanel
            // 
            this.m_mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_mainPanel.Location = new System.Drawing.Point(168, 34);
            this.m_mainPanel.Name = "m_mainPanel";
            this.m_mainPanel.Size = new System.Drawing.Size(289, 280);
            this.m_mainPanel.TabIndex = 93;
            // 
            // m_optionsTV
            // 
            this.m_optionsTV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_optionsTV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.m_optionsTV.FullRowSelect = true;
            this.m_optionsTV.HideSelection = false;
            this.m_optionsTV.Location = new System.Drawing.Point(7, 7);
            this.m_optionsTV.Name = "m_optionsTV";
            this.m_optionsTV.Size = new System.Drawing.Size(154, 236);
            this.m_optionsTV.TabIndex = 92;
            this.m_optionsTV.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SelectConfig);
            // 
            // roundCornerPanel1
            // 
            this.roundCornerPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.roundCornerPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.roundCornerPanel1.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.roundCornerPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundCornerPanel1.Controls.Add(this.m_okBtn);
            this.roundCornerPanel1.Controls.Add(this.m_cancelBtn);
            this.roundCornerPanel1.Curvature = 1;
            this.roundCornerPanel1.Location = new System.Drawing.Point(7, 249);
            this.roundCornerPanel1.Name = "roundCornerPanel1";
            this.roundCornerPanel1.Size = new System.Drawing.Size(154, 64);
            this.roundCornerPanel1.TabIndex = 101;
            // 
            // m_okBtn
            // 
            this.m_okBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.m_okBtn.Location = new System.Drawing.Point(36, 6);
            this.m_okBtn.Name = "m_okBtn";
            this.m_okBtn.Size = new System.Drawing.Size(75, 23);
            this.m_okBtn.TabIndex = 94;
            this.m_okBtn.Text = "Open";
            this.m_okBtn.UseVisualStyleBackColor = true;
            // 
            // m_cancelBtn
            // 
            this.m_cancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.m_cancelBtn.Location = new System.Drawing.Point(36, 35);
            this.m_cancelBtn.Name = "m_cancelBtn";
            this.m_cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.m_cancelBtn.TabIndex = 95;
            this.m_cancelBtn.Text = "Cancel";
            this.m_cancelBtn.UseVisualStyleBackColor = true;
            // 
            // m_headPanel
            // 
            this.m_headPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_headPanel.BackColor = System.Drawing.SystemColors.Control;
            this.m_headPanel.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.m_headPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_headPanel.Controls.Add(this.pictureBox1);
            this.m_headPanel.Controls.Add(this.m_configLabel);
            this.m_headPanel.Curvature = 1;
            this.m_headPanel.Location = new System.Drawing.Point(168, 7);
            this.m_headPanel.Name = "m_headPanel";
            this.m_headPanel.Size = new System.Drawing.Size(289, 21);
            this.m_headPanel.TabIndex = 99;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(270, 3);
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
            this.m_configLabel.Size = new System.Drawing.Size(258, 16);
            this.m_configLabel.TabIndex = 0;
            this.m_configLabel.Text = "Title";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 320);
            this.Controls.Add(this.roundCornerPanel1);
            this.Controls.Add(this.m_headPanel);
            this.Controls.Add(this.m_mainPanel);
            this.Controls.Add(this.m_optionsTV);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prepril Remote Terminal";
            this.Load += new System.EventHandler(this.Config_Load);
            this.roundCornerPanel1.ResumeLayout(false);
            this.m_headPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_okBtn;
        private System.Windows.Forms.Button m_cancelBtn;
        private System.Windows.Forms.Panel m_mainPanel;
        private System.Windows.Forms.TreeView m_optionsTV;
        private CSharpCustomPanelControl.RoundCornerPanel m_headPanel;
        private PictureBox pictureBox1;
        private CSharpCustomPanelControl.RoundCornerPanel roundCornerPanel1;
        private Label m_configLabel;

        

    }
}
