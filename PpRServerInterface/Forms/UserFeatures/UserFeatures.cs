﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Configuration;
using Configuration.Controls;

namespace PpRServerInterface.Forms
{
    public class UserFeatures : Form
    {
        public UserFeatures()
        {
            InitializeComponent();
            VistaControls.VistaConstants.SetWindowTheme(m_optionsTV.Handle, "explorer", null);

			this.PopulateConfigurationForm();

            //m_restoreBtn.Click += new EventHandler(OnRestoreButtonClicked);
			//m_applyBtn.Click += new EventHandler(OnApplyButtonClicked);
			m_cancelBtn.Click += new EventHandler(OnCancelButtonClicked);
			m_okBtn.Click += new EventHandler(OnOkButtonClicked);

            m_optionsTV.ExpandAll();
        }

        private void UserFeatures_Load(object sender, EventArgs e)
        {

        }


        private enum Action
        {
            Apply = 1,
            Restore = 2
        }

        private void PopulateConfigurationForm()
        {
            ConfigTreeNode config;
            TreeNode treeNode;

            treeNode = new ConfigTreeNode("Users", new settings_connections("Configure Users"));
            treeNode.Nodes.Add(new ConfigTreeNode("General", new settings_ip_binding("IP Filter")));
            treeNode.Nodes.Add(new ConfigTreeNode("IP Binding", new settings_ip_filter("IP Binding")));
            treeNode.Nodes.Add(new ConfigTreeNode("Autoban", new settings_autoban("Autoban Settings")));
            AddConfigItem(treeNode);

            treeNode = new ConfigTreeNode("Groups", new settings_connections("Configure Groups"));
            treeNode.Nodes.Add(new ConfigTreeNode("IP Filter", new settings_ip_binding("IP Filter")));
            treeNode.Nodes.Add(new ConfigTreeNode("IP Binding", new settings_ip_filter("IP Binding")));
            treeNode.Nodes.Add(new ConfigTreeNode("Autoban", new settings_autoban("Autoban Settings")));
            AddConfigItem(treeNode);

            treeNode = new ConfigTreeNode("Policy", new settings_connections("Policy"));
            treeNode.Nodes.Add(new ConfigTreeNode("IP Filter", new settings_ip_binding("IP Filter")));
            treeNode.Nodes.Add(new ConfigTreeNode("IP Binding", new settings_ip_filter("IP Binding")));
            treeNode.Nodes.Add(new ConfigTreeNode("Autoban", new settings_autoban("Autoban Settings")));
            AddConfigItem(treeNode);
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
            this.m_mainPanel = new System.Windows.Forms.Panel();
            this.m_okBtn = new System.Windows.Forms.Button();
            this.m_cancelBtn = new System.Windows.Forms.Button();
            this.m_optionsTV = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.m_headPanel = new CSharpCustomPanelControl.RoundCornerPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.m_configLabel = new System.Windows.Forms.Label();
            this.m_headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // m_mainPanel
            // 
            this.m_mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_mainPanel.Location = new System.Drawing.Point(149, 34);
            this.m_mainPanel.Name = "m_mainPanel";
            this.m_mainPanel.Size = new System.Drawing.Size(484, 328);
            this.m_mainPanel.TabIndex = 83;
            // 
            // m_okBtn
            // 
            this.m_okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_okBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.m_okBtn.Location = new System.Drawing.Point(478, 376);
            this.m_okBtn.Name = "m_okBtn";
            this.m_okBtn.Size = new System.Drawing.Size(75, 23);
            this.m_okBtn.TabIndex = 85;
            this.m_okBtn.Text = "OK";
            this.m_okBtn.UseVisualStyleBackColor = true;
            this.m_okBtn.Click += new System.EventHandler(this.ClickHandler);
            // 
            // m_cancelBtn
            // 
            this.m_cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_cancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.m_cancelBtn.Location = new System.Drawing.Point(559, 376);
            this.m_cancelBtn.Name = "m_cancelBtn";
            this.m_cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.m_cancelBtn.TabIndex = 86;
            this.m_cancelBtn.Text = "Cancel";
            this.m_cancelBtn.UseVisualStyleBackColor = true;
            this.m_cancelBtn.Click += new System.EventHandler(this.ClickHandler);
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
            this.m_optionsTV.Size = new System.Drawing.Size(136, 355);
            this.m_optionsTV.TabIndex = 82;
            this.m_optionsTV.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SelectConfig);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(0, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(640, 2);
            this.label3.TabIndex = 89;
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
            this.m_headPanel.Location = new System.Drawing.Point(149, 7);
            this.m_headPanel.Name = "m_headPanel";
            this.m_headPanel.Size = new System.Drawing.Size(484, 21);
            this.m_headPanel.TabIndex = 99;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(465, 3);
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
            this.m_configLabel.Size = new System.Drawing.Size(453, 16);
            this.m_configLabel.TabIndex = 0;
            this.m_configLabel.Text = "Title";
            // 
            // UserFeatures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 405);
            this.Controls.Add(this.m_headPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_okBtn);
            this.Controls.Add(this.m_cancelBtn);
            this.Controls.Add(this.m_mainPanel);
            this.Controls.Add(this.m_optionsTV);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserFeatures";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Features";
            this.Load += new System.EventHandler(this.UserFeatures_Load);
            this.m_headPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.ComponentModel.Container components = null;

        private System.Windows.Forms.Button m_okBtn;
        private System.Windows.Forms.Button m_cancelBtn;
        private Panel m_mainPanel;
        private System.Windows.Forms.TreeView m_optionsTV;
        private CSharpCustomPanelControl.RoundCornerPanel m_headPanel;
        private PictureBox pictureBox1;
        private Label m_configLabel;
        private System.Windows.Forms.Label label3;

    }
}
