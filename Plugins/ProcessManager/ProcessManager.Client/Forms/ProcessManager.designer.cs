using PpRStandardLib.Controls;
namespace ProcessManager_Client
{
    partial class ProcessManager
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.ProcessesTab = new System.Windows.Forms.TabPage();
            this.ProcessesListView = new PpRStandardLib.Controls.FullListView();
            this.processNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processPIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processThreadsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processPriorityClumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processPrivateBytesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processUserNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processDescriptionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ServicesTab = new System.Windows.Forms.TabPage();
            this.ServicesListView = new PpRStandardLib.Controls.FullListView();
            this.NetworkTab = new System.Windows.Forms.TabPage();
            this.NetworkListView = new PpRStandardLib.Controls.FullListView();
            this.WindowsListTab = new System.Windows.Forms.TabPage();
            this.WindowsListView = new PpRStandardLib.Controls.FullListView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AnalyticsGraph = new CustomUIControls.Graphing.C2DPushGraph();
            this.CPUUsageGraph = new CustomUIControls.Graphing.C2DPushGraph();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.menuItem18 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.tabControl.SuspendLayout();
            this.ProcessesTab.SuspendLayout();
            this.ServicesTab.SuspendLayout();
            this.NetworkTab.SuspendLayout();
            this.WindowsListTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.ProcessesTab);
            this.tabControl.Controls.Add(this.ServicesTab);
            this.tabControl.Controls.Add(this.NetworkTab);
            this.tabControl.Controls.Add(this.WindowsListTab);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabControl.ItemSize = new System.Drawing.Size(102, 20);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(746, 387);
            this.tabControl.TabIndex = 1;
            this.tabControl.TabStop = false;
            // 
            // ProcessesTab
            // 
            this.ProcessesTab.Controls.Add(this.ProcessesListView);
            this.ProcessesTab.Location = new System.Drawing.Point(4, 24);
            this.ProcessesTab.Name = "ProcessesTab";
            this.ProcessesTab.Size = new System.Drawing.Size(738, 359);
            this.ProcessesTab.TabIndex = 0;
            this.ProcessesTab.Text = "Processes";
            this.ProcessesTab.UseVisualStyleBackColor = true;
            // 
            // ProcessesListView
            // 
            this.ProcessesListView.AllowColumnReorder = true;
            this.ProcessesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.processNameColumn,
            this.processPIDColumn,
            this.processThreadsColumn,
            this.processPriorityClumn,
            this.processPrivateBytesColumn,
            this.processUserNameColumn,
            this.processDescriptionColumn});
            this.ProcessesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProcessesListView.ExplorerTheme = false;
            this.ProcessesListView.ExplorerThemeMultiSelect = false;
            this.ProcessesListView.FullRowSelect = true;
            this.ProcessesListView.ItemContextMenuStrip = false;
            this.ProcessesListView.Location = new System.Drawing.Point(0, 0);
            this.ProcessesListView.LockColumnSize = false;
            this.ProcessesListView.Name = "ProcessesListView";
            this.ProcessesListView.Size = new System.Drawing.Size(738, 359);
            this.ProcessesListView.TabIndex = 0;
            this.ProcessesListView.UseCompatibleStateImageBehavior = false;
            this.ProcessesListView.View = System.Windows.Forms.View.Details;
            // 
            // processNameColumn
            // 
            this.processNameColumn.Text = "Name";
            this.processNameColumn.Width = 172;
            // 
            // processPIDColumn
            // 
            this.processPIDColumn.Text = "PID";
            this.processPIDColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.processPIDColumn.Width = 54;
            // 
            // processThreadsColumn
            // 
            this.processThreadsColumn.Text = "Threads";
            // 
            // processPriorityClumn
            // 
            this.processPriorityClumn.Text = "Priority";
            // 
            // processPrivateBytesColumn
            // 
            this.processPrivateBytesColumn.Text = "Private Bytes";
            this.processPrivateBytesColumn.Width = 67;
            // 
            // processUserNameColumn
            // 
            this.processUserNameColumn.Text = "User Name";
            this.processUserNameColumn.Width = 145;
            // 
            // processDescriptionColumn
            // 
            this.processDescriptionColumn.Text = "Description";
            this.processDescriptionColumn.Width = 164;
            // 
            // ServicesTab
            // 
            this.ServicesTab.Controls.Add(this.ServicesListView);
            this.ServicesTab.Location = new System.Drawing.Point(4, 24);
            this.ServicesTab.Name = "ServicesTab";
            this.ServicesTab.Size = new System.Drawing.Size(738, 359);
            this.ServicesTab.TabIndex = 1;
            this.ServicesTab.Text = "Services";
            this.ServicesTab.UseVisualStyleBackColor = true;
            // 
            // ServicesListView
            // 
            this.ServicesListView.AllowColumnReorder = true;
            this.ServicesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServicesListView.ExplorerTheme = false;
            this.ServicesListView.ExplorerThemeMultiSelect = false;
            this.ServicesListView.FullRowSelect = true;
            this.ServicesListView.ItemContextMenuStrip = false;
            this.ServicesListView.Location = new System.Drawing.Point(0, 0);
            this.ServicesListView.LockColumnSize = false;
            this.ServicesListView.Name = "ServicesListView";
            this.ServicesListView.Size = new System.Drawing.Size(738, 359);
            this.ServicesListView.TabIndex = 1;
            this.ServicesListView.UseCompatibleStateImageBehavior = false;
            this.ServicesListView.View = System.Windows.Forms.View.Details;
            // 
            // NetworkTab
            // 
            this.NetworkTab.Controls.Add(this.NetworkListView);
            this.NetworkTab.Location = new System.Drawing.Point(4, 24);
            this.NetworkTab.Name = "NetworkTab";
            this.NetworkTab.Size = new System.Drawing.Size(738, 359);
            this.NetworkTab.TabIndex = 2;
            this.NetworkTab.Text = "Network";
            this.NetworkTab.UseVisualStyleBackColor = true;
            // 
            // NetworkListView
            // 
            this.NetworkListView.AllowColumnReorder = true;
            this.NetworkListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NetworkListView.ExplorerTheme = false;
            this.NetworkListView.ExplorerThemeMultiSelect = false;
            this.NetworkListView.FullRowSelect = true;
            this.NetworkListView.ItemContextMenuStrip = false;
            this.NetworkListView.Location = new System.Drawing.Point(0, 0);
            this.NetworkListView.LockColumnSize = false;
            this.NetworkListView.Name = "NetworkListView";
            this.NetworkListView.Size = new System.Drawing.Size(738, 359);
            this.NetworkListView.TabIndex = 1;
            this.NetworkListView.UseCompatibleStateImageBehavior = false;
            this.NetworkListView.View = System.Windows.Forms.View.Details;
            // 
            // WindowsListTab
            // 
            this.WindowsListTab.Controls.Add(this.WindowsListView);
            this.WindowsListTab.Location = new System.Drawing.Point(4, 24);
            this.WindowsListTab.Name = "WindowsListTab";
            this.WindowsListTab.Size = new System.Drawing.Size(738, 359);
            this.WindowsListTab.TabIndex = 3;
            this.WindowsListTab.Text = "Windows List";
            this.WindowsListTab.UseVisualStyleBackColor = true;
            // 
            // WindowsListView
            // 
            this.WindowsListView.AllowColumnReorder = true;
            this.WindowsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindowsListView.ExplorerTheme = false;
            this.WindowsListView.ExplorerThemeMultiSelect = false;
            this.WindowsListView.FullRowSelect = true;
            this.WindowsListView.ItemContextMenuStrip = false;
            this.WindowsListView.Location = new System.Drawing.Point(0, 0);
            this.WindowsListView.LockColumnSize = false;
            this.WindowsListView.Name = "WindowsListView";
            this.WindowsListView.Size = new System.Drawing.Size(738, 359);
            this.WindowsListView.TabIndex = 1;
            this.WindowsListView.UseCompatibleStateImageBehavior = false;
            this.WindowsListView.View = System.Windows.Forms.View.Details;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AnalyticsGraph);
            this.tabPage1.Controls.Add(this.CPUUsageGraph);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(738, 359);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Performance";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AnalyticsGraph
            // 
            this.AnalyticsGraph.AutoAdjustPeek = false;
            this.AnalyticsGraph.BackColor = System.Drawing.SystemColors.Control;
            this.AnalyticsGraph.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.AnalyticsGraph.GridSize = ((ushort)(20));
            this.AnalyticsGraph.HighQuality = true;
            this.AnalyticsGraph.LineInterval = ((ushort)(1));
            this.AnalyticsGraph.Location = new System.Drawing.Point(33, 220);
            this.AnalyticsGraph.MaxLabel = "Max";
            this.AnalyticsGraph.MaxPeekMagnitude = 100;
            this.AnalyticsGraph.MinLabel = "0 Bytes";
            this.AnalyticsGraph.MinPeekMagnitude = 0;
            this.AnalyticsGraph.Name = "AnalyticsGraph";
            this.AnalyticsGraph.ShowGrid = true;
            this.AnalyticsGraph.ShowLabels = false;
            this.AnalyticsGraph.Size = new System.Drawing.Size(614, 186);
            this.AnalyticsGraph.TabIndex = 22;
            this.AnalyticsGraph.Text = "c2DPushGraph1";
            this.AnalyticsGraph.TextColor = System.Drawing.Color.Black;
            // 
            // CPUUsageGraph
            // 
            this.CPUUsageGraph.AutoAdjustPeek = false;
            this.CPUUsageGraph.BackColor = System.Drawing.Color.Black;
            this.CPUUsageGraph.GridColor = System.Drawing.Color.Green;
            this.CPUUsageGraph.GridSize = ((ushort)(15));
            this.CPUUsageGraph.HighQuality = true;
            this.CPUUsageGraph.LineInterval = ((ushort)(5));
            this.CPUUsageGraph.Location = new System.Drawing.Point(3, 3);
            this.CPUUsageGraph.MaxLabel = "Max";
            this.CPUUsageGraph.MaxPeekMagnitude = 100;
            this.CPUUsageGraph.MinLabel = "Minimum";
            this.CPUUsageGraph.MinPeekMagnitude = 0;
            this.CPUUsageGraph.Name = "CPUUsageGraph";
            this.CPUUsageGraph.ShowGrid = true;
            this.CPUUsageGraph.ShowLabels = false;
            this.CPUUsageGraph.Size = new System.Drawing.Size(735, 195);
            this.CPUUsageGraph.TabIndex = 0;
            this.CPUUsageGraph.Text = "c2DPushGraph1";
            this.CPUUsageGraph.TextColor = System.Drawing.Color.Yellow;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem3,
            this.menuItem2});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4,
            this.menuItem5,
            this.menuItem6,
            this.menuItem17,
            this.menuItem18});
            this.menuItem1.Text = "Manager";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.Text = "Run...";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.Text = "Run As Administrator...";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 2;
            this.menuItem6.Text = "Run As Limited User...";
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 3;
            this.menuItem17.Text = "-";
            // 
            // menuItem18
            // 
            this.menuItem18.Index = 4;
            this.menuItem18.Text = "Exit";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem7,
            this.menuItem8});
            this.menuItem3.Text = "View";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 0;
            this.menuItem7.Text = "Refresh";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 1;
            this.menuItem8.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem9,
            this.menuItem10,
            this.menuItem12,
            this.menuItem13});
            this.menuItem8.Text = "Update Interval";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 0;
            this.menuItem9.RadioCheck = true;
            this.menuItem9.Text = "High";
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 1;
            this.menuItem10.RadioCheck = true;
            this.menuItem10.Text = "Normal";
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 2;
            this.menuItem12.RadioCheck = true;
            this.menuItem12.Text = "Low";
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 3;
            this.menuItem13.Text = "Paused";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem11,
            this.menuItem14,
            this.menuItem15,
            this.menuItem16});
            this.menuItem2.Text = "Tools";
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 0;
            this.menuItem11.Text = "Create Service...";
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 1;
            this.menuItem14.Text = "Pagefiles";
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 2;
            this.menuItem15.Text = "-";
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 3;
            this.menuItem16.Text = "Terminate Sandboxed Processes";
            // 
            // ProcessManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 387);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Menu = this.mainMenu1;
            this.Name = "ProcessManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process Manager";
            this.Load += new System.EventHandler(this.ProcessManager_Load);
            this.tabControl.ResumeLayout(false);
            this.ProcessesTab.ResumeLayout(false);
            this.ServicesTab.ResumeLayout(false);
            this.NetworkTab.ResumeLayout(false);
            this.WindowsListTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage ProcessesTab;
        private System.Windows.Forms.TabPage ServicesTab;
        private System.Windows.Forms.TabPage NetworkTab;
        private System.Windows.Forms.TabPage WindowsListTab;
        private PpRStandardLib.Controls.FullListView ProcessesListView;
        private FullListView ServicesListView;
        private FullListView NetworkListView;
        private FullListView WindowsListView;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.ColumnHeader processNameColumn;
        private System.Windows.Forms.ColumnHeader processPIDColumn;
        private System.Windows.Forms.ColumnHeader processThreadsColumn;
        private System.Windows.Forms.ColumnHeader processPriorityClumn;
        private System.Windows.Forms.ColumnHeader processPrivateBytesColumn;
        private System.Windows.Forms.ColumnHeader processUserNameColumn;
        private System.Windows.Forms.ColumnHeader processDescriptionColumn;
        private CustomUIControls.Graphing.C2DPushGraph CPUUsageGraph;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private CustomUIControls.Graphing.C2DPushGraph AnalyticsGraph;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.MenuItem menuItem13;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem menuItem14;
        private System.Windows.Forms.MenuItem menuItem15;
        private System.Windows.Forms.MenuItem menuItem16;
        private System.Windows.Forms.MenuItem menuItem17;
        private System.Windows.Forms.MenuItem menuItem18;
    }
}