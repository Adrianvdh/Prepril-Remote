using PpRClientInterface.Controls;
namespace PpRClientInterface.Forms
{
    partial class UserDataAutoSync
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "001001",
            "Laptop",
            "23:49:53"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 9F));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "001005",
            "Desktop",
            "19:32:12"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.UserAccountsListView = new PpRStandardLib.Controls.FullListView();
            this.uAccountIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uDescriptionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uTimeConnectedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label13 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SelectDataButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SetPrimaryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserAccountsListView
            // 
            this.UserAccountsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.UserAccountsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserAccountsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.uAccountIDColumn,
            this.uDescriptionColumn,
            this.uTimeConnectedColumn});
            this.UserAccountsListView.ExplorerTheme = false;
            this.UserAccountsListView.ExplorerThemeMultiSelect = false;
            this.UserAccountsListView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UserAccountsListView.FullRowSelect = true;
            this.UserAccountsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.UserAccountsListView.ItemContextMenuStrip = false;
            listViewItem1.StateImageIndex = 0;
            this.UserAccountsListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.UserAccountsListView.Location = new System.Drawing.Point(6, 6);
            this.UserAccountsListView.LockColumnSize = false;
            this.UserAccountsListView.MinimumSize = new System.Drawing.Size(4, 65);
            this.UserAccountsListView.MultiSelect = false;
            this.UserAccountsListView.Name = "UserAccountsListView";
            this.UserAccountsListView.ShowItemToolTips = true;
            this.UserAccountsListView.Size = new System.Drawing.Size(364, 165);
            this.UserAccountsListView.TabIndex = 67;
            this.UserAccountsListView.UseCompatibleStateImageBehavior = false;
            this.UserAccountsListView.View = System.Windows.Forms.View.Details;
            // 
            // uAccountIDColumn
            // 
            this.uAccountIDColumn.Text = "Account ID";
            this.uAccountIDColumn.Width = 71;
            // 
            // uDescriptionColumn
            // 
            this.uDescriptionColumn.Text = "Description";
            this.uDescriptionColumn.Width = 220;
            // 
            // uTimeConnectedColumn
            // 
            this.uTimeConnectedColumn.Text = "Connected";
            this.uTimeConnectedColumn.Width = 71;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label13.Location = new System.Drawing.Point(6, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(443, 2);
            this.label13.TabIndex = 66;
            this.label13.Text = "label13";
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseButton.Location = new System.Drawing.Point(374, 180);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 65;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // SelectDataButton
            // 
            this.SelectDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectDataButton.Enabled = false;
            this.SelectDataButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SelectDataButton.Location = new System.Drawing.Point(375, 34);
            this.SelectDataButton.Name = "SelectDataButton";
            this.SelectDataButton.Size = new System.Drawing.Size(75, 23);
            this.SelectDataButton.TabIndex = 64;
            this.SelectDataButton.Text = "Select Data";
            this.SelectDataButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClearButton.Location = new System.Drawing.Point(375, 147);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 63;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.Enabled = false;
            this.RemoveButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RemoveButton.Location = new System.Drawing.Point(375, 63);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 62;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // SetPrimaryButton
            // 
            this.SetPrimaryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SetPrimaryButton.Enabled = false;
            this.SetPrimaryButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SetPrimaryButton.Location = new System.Drawing.Point(375, 5);
            this.SetPrimaryButton.Name = "SetPrimaryButton";
            this.SetPrimaryButton.Size = new System.Drawing.Size(75, 23);
            this.SetPrimaryButton.TabIndex = 61;
            this.SetPrimaryButton.Text = "Set Primary";
            this.SetPrimaryButton.UseVisualStyleBackColor = true;
            // 
            // UserDataAutoSync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 207);
            this.Controls.Add(this.UserAccountsListView);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SelectDataButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.SetPrimaryButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserDataAutoSync";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Data AutoSync";
            this.Load += new System.EventHandler(this.udAutoSync_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PpRStandardLib.Controls.FullListView UserAccountsListView;
        private System.Windows.Forms.ColumnHeader uAccountIDColumn;
        private System.Windows.Forms.ColumnHeader uDescriptionColumn;
        private System.Windows.Forms.ColumnHeader uTimeConnectedColumn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SelectDataButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button SetPrimaryButton;


    }
}