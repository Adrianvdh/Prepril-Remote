namespace ExtendedScripts_Client
{
    partial class ScriptEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptEditor));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.FileMenu = new System.Windows.Forms.MenuItem();
            this.NewMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.OpenMenuItem = new System.Windows.Forms.MenuItem();
            this.SaveAsMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.ExitMenuItem = new System.Windows.Forms.MenuItem();
            this.EditMenu = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.LanguageMenu = new System.Windows.Forms.MenuItem();
            this.BatchLangMenuItem = new System.Windows.Forms.MenuItem();
            this.PowershellLangMenuItem = new System.Windows.Forms.MenuItem();
            this.VBSLangMenuItem = new System.Windows.Forms.MenuItem();
            this.MainStatusBar = new System.Windows.Forms.StatusBar();
            this.StatusBarPanel = new System.Windows.Forms.StatusBarPanel();
            this.LengthBarPanel = new System.Windows.Forms.StatusBarPanel();
            this.LinesBarPanel = new System.Windows.Forms.StatusBarPanel();
            this.TabsBarPanel = new System.Windows.Forms.StatusBarPanel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CreateScriptToolStripBt = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthBarPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinesBarPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabsBarPanel)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FileMenu,
            this.EditMenu,
            this.LanguageMenu});
            // 
            // FileMenu
            // 
            this.FileMenu.Index = 0;
            this.FileMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.NewMenuItem,
            this.menuItem7,
            this.OpenMenuItem,
            this.SaveAsMenuItem,
            this.menuItem4,
            this.ExitMenuItem});
            this.FileMenu.Text = "File";
            // 
            // NewMenuItem
            // 
            this.NewMenuItem.Index = 0;
            this.NewMenuItem.Text = "New";
            this.NewMenuItem.Click += new System.EventHandler(this.NewMenuItem_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 1;
            this.menuItem7.Text = "-";
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Index = 2;
            this.OpenMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.OpenMenuItem.Text = "Open...";
            this.OpenMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // SaveAsMenuItem
            // 
            this.SaveAsMenuItem.Index = 3;
            this.SaveAsMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.SaveAsMenuItem.Text = "Save As...";
            this.SaveAsMenuItem.Click += new System.EventHandler(this.SaveAsMenuItem_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 4;
            this.menuItem4.Text = "-";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Index = 5;
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // EditMenu
            // 
            this.EditMenu.Index = 1;
            this.EditMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem1,
            this.menuItem3,
            this.menuItem5,
            this.menuItem6,
            this.menuItem8,
            this.menuItem9,
            this.menuItem10,
            this.menuItem11});
            this.EditMenu.Text = "Edit";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "Undo";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.Text = "Redo";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "-";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 3;
            this.menuItem5.Text = "Cut";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 4;
            this.menuItem6.Text = "Copy";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 5;
            this.menuItem8.Text = "Paste";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 6;
            this.menuItem9.Text = "Delete";
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 7;
            this.menuItem10.Text = "-";
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 8;
            this.menuItem11.Text = "Select All";
            // 
            // LanguageMenu
            // 
            this.LanguageMenu.Index = 2;
            this.LanguageMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.BatchLangMenuItem,
            this.PowershellLangMenuItem,
            this.VBSLangMenuItem});
            this.LanguageMenu.Text = "Syntax Highlighter ";
            // 
            // BatchLangMenuItem
            // 
            this.BatchLangMenuItem.Checked = true;
            this.BatchLangMenuItem.Index = 0;
            this.BatchLangMenuItem.RadioCheck = true;
            this.BatchLangMenuItem.Text = "Batch";
            this.BatchLangMenuItem.Click += new System.EventHandler(this.BatchLangMenuItem_Click);
            // 
            // PowershellLangMenuItem
            // 
            this.PowershellLangMenuItem.Index = 1;
            this.PowershellLangMenuItem.RadioCheck = true;
            this.PowershellLangMenuItem.Text = "Powershell";
            this.PowershellLangMenuItem.Click += new System.EventHandler(this.PowershellLangMenuItem_Click);
            // 
            // VBSLangMenuItem
            // 
            this.VBSLangMenuItem.Index = 2;
            this.VBSLangMenuItem.Text = "VB Script";
            this.VBSLangMenuItem.Click += new System.EventHandler(this.VBSLangMenuItem_Click);
            // 
            // MainStatusBar
            // 
            this.MainStatusBar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainStatusBar.Location = new System.Drawing.Point(0, 528);
            this.MainStatusBar.Name = "MainStatusBar";
            this.MainStatusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.StatusBarPanel,
            this.LengthBarPanel,
            this.LinesBarPanel,
            this.TabsBarPanel});
            this.MainStatusBar.ShowPanels = true;
            this.MainStatusBar.Size = new System.Drawing.Size(544, 22);
            this.MainStatusBar.TabIndex = 42;
            this.MainStatusBar.Text = "MainStatusBar";
            // 
            // StatusBarPanel
            // 
            this.StatusBarPanel.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.Raised;
            this.StatusBarPanel.Name = "StatusBarPanel";
            this.StatusBarPanel.Text = "Downloading Projects: 0%";
            this.StatusBarPanel.Width = 200;
            // 
            // LengthBarPanel
            // 
            this.LengthBarPanel.Name = "LengthBarPanel";
            this.LengthBarPanel.Text = "Length: 0";
            this.LengthBarPanel.Width = 80;
            // 
            // LinesBarPanel
            // 
            this.LinesBarPanel.Name = "LinesBarPanel";
            this.LinesBarPanel.Text = "Lines: 0";
            this.LinesBarPanel.Width = 70;
            // 
            // TabsBarPanel
            // 
            this.TabsBarPanel.Name = "TabsBarPanel";
            this.TabsBarPanel.Text = "Tabs: 1";
            this.TabsBarPanel.Width = 65;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(0, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 2);
            this.label1.TabIndex = 79;
            this.label1.Text = "label1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowItemReorder = true;
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(544, 26);
            this.toolStrip1.TabIndex = 78;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CreateScriptToolStripBt
            // 
            this.CreateScriptToolStripBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CreateScriptToolStripBt.Image = ((System.Drawing.Image)(resources.GetObject("CreateScriptToolStripBt.Image")));
            this.CreateScriptToolStripBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateScriptToolStripBt.Margin = new System.Windows.Forms.Padding(3, 1, 1, 2);
            this.CreateScriptToolStripBt.Name = "CreateScriptToolStripBt";
            this.CreateScriptToolStripBt.Size = new System.Drawing.Size(23, 23);
            this.CreateScriptToolStripBt.Text = "New";
            this.CreateScriptToolStripBt.ToolTipText = "Create new script";
            this.CreateScriptToolStripBt.Click += new System.EventHandler(this.CreateScriptToolStripBt_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Margin = new System.Windows.Forms.Padding(3, 1, 1, 2);
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 23);
            this.toolStripButton2.Text = "Script Manager";
            this.toolStripButton2.ToolTipText = "Script Manager";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 23);
            this.toolStripButton1.Text = "Execute Script";
            this.toolStripButton1.ToolTipText = "Execute script";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Margin = new System.Windows.Forms.Padding(1, 1, 1, 2);
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 23);
            this.toolStripButton7.Text = "Execute Script";
            this.toolStripButton7.ToolTipText = "Execute script on server";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 23);
            this.toolStripButton8.Text = "Sync";
            this.toolStripButton8.ToolTipText = "Upload project to server";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(544, 500);
            this.tabControl1.TabIndex = 80;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.textBox1);
            this.TabPage1.Location = new System.Drawing.Point(4, 24);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(536, 472);
            this.TabPage1.TabIndex = 1;
            this.TabPage1.Text = "Tab 1";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(536, 472);
            this.textBox1.TabIndex = 77;
            // 
            // ScriptEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(544, 550);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MainStatusBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.MinimumSize = new System.Drawing.Size(390, 394);
            this.Name = "ScriptEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Script Editor";
            this.Load += new System.EventHandler(this.ScriptEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StatusBarPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthBarPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinesBarPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabsBarPanel)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.StatusBar MainStatusBar;
        private System.Windows.Forms.StatusBarPanel StatusBarPanel;
        private System.Windows.Forms.StatusBarPanel LengthBarPanel;
        private System.Windows.Forms.StatusBarPanel LinesBarPanel;
        private System.Windows.Forms.StatusBarPanel TabsBarPanel;
        private System.Windows.Forms.MenuItem FileMenu;
        private System.Windows.Forms.MenuItem OpenMenuItem;
        private System.Windows.Forms.MenuItem SaveAsMenuItem;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem ExitMenuItem;
        private System.Windows.Forms.MenuItem LanguageMenu;
        private System.Windows.Forms.MenuItem BatchLangMenuItem;
        private System.Windows.Forms.MenuItem PowershellLangMenuItem;
        private System.Windows.Forms.MenuItem VBSLangMenuItem;
        private System.Windows.Forms.MenuItem NewMenuItem;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem EditMenu;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton CreateScriptToolStripBt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}