using PpRClientInterface.Controls;
namespace PpRClientInterface.Forms
{
    partial class CategoryEditor
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("DDOS");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("DDOS Target Information");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("-");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Key Logger");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Credential Manager");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Computer");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Credential Manager");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("DDOS");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Key Logger");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Script Executer");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Services");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Monitor");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("System");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("Misc");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Other");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("Computer");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryEditor));
            this.ContextMenuListView = new PpRStandardLib.Controls.FullListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InstalledPluginsListView = new PpRStandardLib.Controls.FullListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button5 = new System.Windows.Forms.Button();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.RestoreDefaultButton = new System.Windows.Forms.Button();
            this.DuplicateContext = new System.Windows.Forms.ContextMenu();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.DuplicateCategoryButton = new System.Windows.Forms.Button();
            this.RenameCategoryButton = new System.Windows.Forms.Button();
            this.DeleteCategoryButton = new System.Windows.Forms.Button();
            this.NewCategoryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoriesListView = new PpRStandardLib.Controls.FullListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ContextMenuListView
            // 
            this.ContextMenuListView.CheckBoxes = true;
            this.ContextMenuListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.ContextMenuListView.ExplorerTheme = false;
            this.ContextMenuListView.ExplorerThemeMultiSelect = false;
            this.ContextMenuListView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ContextMenuListView.FullRowSelect = true;
            this.ContextMenuListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ContextMenuListView.ItemContextMenuStrip = false;
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            listViewItem2.Checked = true;
            listViewItem2.StateImageIndex = 1;
            listViewItem3.Checked = true;
            listViewItem3.StateImageIndex = 1;
            listViewItem4.Checked = true;
            listViewItem4.StateImageIndex = 1;
            listViewItem5.Checked = true;
            listViewItem5.StateImageIndex = 1;
            this.ContextMenuListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.ContextMenuListView.LabelEdit = true;
            this.ContextMenuListView.Location = new System.Drawing.Point(459, 21);
            this.ContextMenuListView.LockColumnSize = false;
            this.ContextMenuListView.MultiSelect = false;
            this.ContextMenuListView.Name = "ContextMenuListView";
            this.ContextMenuListView.Size = new System.Drawing.Size(204, 321);
            this.ContextMenuListView.TabIndex = 87;
            this.ContextMenuListView.UseCompatibleStateImageBehavior = false;
            this.ContextMenuListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 200;
            // 
            // InstalledPluginsListView
            // 
            this.InstalledPluginsListView.CheckBoxes = true;
            this.InstalledPluginsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.InstalledPluginsListView.ExplorerTheme = false;
            this.InstalledPluginsListView.ExplorerThemeMultiSelect = false;
            this.InstalledPluginsListView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InstalledPluginsListView.FullRowSelect = true;
            this.InstalledPluginsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.InstalledPluginsListView.ItemContextMenuStrip = false;
            listViewItem6.StateImageIndex = 0;
            listViewItem7.Checked = true;
            listViewItem7.StateImageIndex = 1;
            listViewItem8.Checked = true;
            listViewItem8.StateImageIndex = 1;
            listViewItem9.Checked = true;
            listViewItem9.StateImageIndex = 1;
            listViewItem10.StateImageIndex = 0;
            this.InstalledPluginsListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.InstalledPluginsListView.Location = new System.Drawing.Point(250, 21);
            this.InstalledPluginsListView.LockColumnSize = false;
            this.InstalledPluginsListView.MultiSelect = false;
            this.InstalledPluginsListView.Name = "InstalledPluginsListView";
            this.InstalledPluginsListView.Size = new System.Drawing.Size(204, 321);
            this.InstalledPluginsListView.TabIndex = 85;
            this.InstalledPluginsListView.UseCompatibleStateImageBehavior = false;
            this.InstalledPluginsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 200;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button5.Location = new System.Drawing.Point(169, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 99;
            this.button5.Text = "Move ￪";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Include Items";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button2.Location = new System.Drawing.Point(169, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 100;
            this.button2.Text = "Move ￬";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button4.Location = new System.Drawing.Point(669, 49);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 98;
            this.button4.Text = "Move ￬";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button3.Location = new System.Drawing.Point(669, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 97;
            this.button3.Text = "Move ￪";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // RestoreDefaultButton
            // 
            this.RestoreDefaultButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RestoreDefaultButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RestoreDefaultButton.Location = new System.Drawing.Point(5, 355);
            this.RestoreDefaultButton.Name = "RestoreDefaultButton";
            this.RestoreDefaultButton.Size = new System.Drawing.Size(97, 23);
            this.RestoreDefaultButton.TabIndex = 96;
            this.RestoreDefaultButton.Text = "Restore Default";
            this.RestoreDefaultButton.UseVisualStyleBackColor = true;
            // 
            // DuplicateContext
            // 
            this.DuplicateContext.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "Name Only";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(669, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 2);
            this.label5.TabIndex = 91;
            this.label5.Text = "label5";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.Location = new System.Drawing.Point(669, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 92;
            this.button1.Text = "Rename";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(457, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 15);
            this.label4.TabIndex = 86;
            this.label4.Text = "Category\'s Context Menu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(247, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 84;
            this.label2.Text = "Installed Plugins:";
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button9.Location = new System.Drawing.Point(670, 355);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 95;
            this.button9.Text = "Cancel";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button10.Location = new System.Drawing.Point(589, 355);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 94;
            this.button10.Text = "Close";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.Location = new System.Drawing.Point(0, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(751, 2);
            this.label7.TabIndex = 93;
            this.label7.Text = "label7";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(670, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 2);
            this.label3.TabIndex = 88;
            this.label3.Text = "label3";
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button7.Location = new System.Drawing.Point(669, 110);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 90;
            this.button7.Text = "Del Sep";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button8.Location = new System.Drawing.Point(669, 81);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 89;
            this.button8.Text = "Add Sep";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // DuplicateCategoryButton
            // 
            this.DuplicateCategoryButton.Enabled = false;
            this.DuplicateCategoryButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DuplicateCategoryButton.Location = new System.Drawing.Point(88, 319);
            this.DuplicateCategoryButton.Name = "DuplicateCategoryButton";
            this.DuplicateCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.DuplicateCategoryButton.TabIndex = 83;
            this.DuplicateCategoryButton.Text = "Duplicate";
            this.DuplicateCategoryButton.UseVisualStyleBackColor = true;
            // 
            // RenameCategoryButton
            // 
            this.RenameCategoryButton.Enabled = false;
            this.RenameCategoryButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RenameCategoryButton.Location = new System.Drawing.Point(7, 319);
            this.RenameCategoryButton.Name = "RenameCategoryButton";
            this.RenameCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.RenameCategoryButton.TabIndex = 82;
            this.RenameCategoryButton.Text = "Rename";
            this.RenameCategoryButton.UseVisualStyleBackColor = true;
            // 
            // DeleteCategoryButton
            // 
            this.DeleteCategoryButton.Enabled = false;
            this.DeleteCategoryButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteCategoryButton.Location = new System.Drawing.Point(88, 290);
            this.DeleteCategoryButton.Name = "DeleteCategoryButton";
            this.DeleteCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteCategoryButton.TabIndex = 81;
            this.DeleteCategoryButton.Text = "Delete";
            this.DeleteCategoryButton.UseVisualStyleBackColor = true;
            // 
            // NewCategoryButton
            // 
            this.NewCategoryButton.Enabled = false;
            this.NewCategoryButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NewCategoryButton.Location = new System.Drawing.Point(7, 290);
            this.NewCategoryButton.Name = "NewCategoryButton";
            this.NewCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.NewCategoryButton.TabIndex = 80;
            this.NewCategoryButton.Text = "New";
            this.NewCategoryButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 79;
            this.label1.Text = "Categories:";
            // 
            // CategoriesListView
            // 
            this.CategoriesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.CategoriesListView.ExplorerTheme = false;
            this.CategoriesListView.ExplorerThemeMultiSelect = false;
            this.CategoriesListView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CategoriesListView.FullRowSelect = true;
            this.CategoriesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.CategoriesListView.ItemContextMenuStrip = false;
            this.CategoriesListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16});
            this.CategoriesListView.LabelEdit = true;
            this.CategoriesListView.Location = new System.Drawing.Point(7, 21);
            this.CategoriesListView.LockColumnSize = false;
            this.CategoriesListView.MultiSelect = false;
            this.CategoriesListView.Name = "CategoriesListView";
            this.CategoriesListView.Size = new System.Drawing.Size(156, 263);
            this.CategoriesListView.TabIndex = 102;
            this.CategoriesListView.UseCompatibleStateImageBehavior = false;
            this.CategoriesListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 152;
            // 
            // CategoryEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 384);
            this.Controls.Add(this.CategoriesListView);
            this.Controls.Add(this.ContextMenuListView);
            this.Controls.Add(this.InstalledPluginsListView);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.RestoreDefaultButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.DuplicateCategoryButton);
            this.Controls.Add(this.RenameCategoryButton);
            this.Controls.Add(this.DeleteCategoryButton);
            this.Controls.Add(this.NewCategoryButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CategoryEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Category Editor";
            this.Load += new System.EventHandler(this.CategoryEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PpRStandardLib.Controls.FullListView ContextMenuListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private PpRStandardLib.Controls.FullListView InstalledPluginsListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button RestoreDefaultButton;
        private System.Windows.Forms.ContextMenu DuplicateContext;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button DuplicateCategoryButton;
        private System.Windows.Forms.Button RenameCategoryButton;
        private System.Windows.Forms.Button DeleteCategoryButton;
        private System.Windows.Forms.Button NewCategoryButton;
        private System.Windows.Forms.Label label1;
        private PpRStandardLib.Controls.FullListView CategoriesListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;

    }
}