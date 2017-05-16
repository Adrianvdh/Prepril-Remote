namespace CredentialManager_Client
{
    partial class CredentialManager2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.OpenURLMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem20 = new System.Windows.Forms.MenuItem();
            this.ImportMenuItem = new System.Windows.Forms.MenuItem();
            this.ExportMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.CopyURLsMenuItem = new System.Windows.Forms.MenuItem();
            this.CopyItemsMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.RefreshMenuItem = new System.Windows.Forms.MenuItem();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(524, 270);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(516, 242);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(516, 242);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(516, 242);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(516, 242);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.OpenURLMenuItem,
            this.menuItem20,
            this.ImportMenuItem,
            this.ExportMenuItem});
            this.menuItem1.Text = "File";
            // 
            // OpenURLMenuItem
            // 
            this.OpenURLMenuItem.Index = 0;
            this.OpenURLMenuItem.Text = "Open URL";
            // 
            // menuItem20
            // 
            this.menuItem20.Index = 1;
            this.menuItem20.Text = "-";
            // 
            // ImportMenuItem
            // 
            this.ImportMenuItem.Index = 2;
            this.ImportMenuItem.Text = "Import";
            // 
            // ExportMenuItem
            // 
            this.ExportMenuItem.Index = 3;
            this.ExportMenuItem.Text = "Export";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.CopyURLsMenuItem,
            this.CopyItemsMenuItem});
            this.menuItem2.Text = "Edit";
            // 
            // CopyURLsMenuItem
            // 
            this.CopyURLsMenuItem.Index = 0;
            this.CopyURLsMenuItem.Text = "Copy URL";
            // 
            // CopyItemsMenuItem
            // 
            this.CopyItemsMenuItem.Index = 1;
            this.CopyItemsMenuItem.Text = "Copy Selected Item";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem10,
            this.menuItem12,
            this.menuItem13,
            this.menuItem14,
            this.menuItem11,
            this.RefreshMenuItem});
            this.menuItem3.Text = "View";
            // 
            // menuItem10
            // 
            this.menuItem10.Checked = true;
            this.menuItem10.Index = 0;
            this.menuItem10.RadioCheck = true;
            this.menuItem10.Text = "%username%";
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 1;
            this.menuItem12.RadioCheck = true;
            this.menuItem12.Text = "%username%";
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 2;
            this.menuItem13.RadioCheck = true;
            this.menuItem13.Text = "%username%";
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 3;
            this.menuItem14.RadioCheck = true;
            this.menuItem14.Text = "%username%";
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 4;
            this.menuItem11.Text = "-";
            // 
            // RefreshMenuItem
            // 
            this.RefreshMenuItem.Index = 5;
            this.RefreshMenuItem.Text = "Refresh";
            // 
            // CredentialManager2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 316);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "CredentialManager2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Credential Manager 2";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem OpenURLMenuItem;
        private System.Windows.Forms.MenuItem menuItem20;
        private System.Windows.Forms.MenuItem ImportMenuItem;
        private System.Windows.Forms.MenuItem ExportMenuItem;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem CopyURLsMenuItem;
        private System.Windows.Forms.MenuItem CopyItemsMenuItem;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.MenuItem menuItem13;
        private System.Windows.Forms.MenuItem menuItem14;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem RefreshMenuItem;
    }
}