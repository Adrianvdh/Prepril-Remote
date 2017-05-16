using PpRStandardLib.Controls;
namespace CredentialManager_Client
{
    partial class CredentialManager
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
            "John",
            "Enabled",
            "John123",
            "6223"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Paul",
            "Disabled"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CredentialManager));
            this.CredentialsListView = new FullListView();
            this.UserNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PasswordColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OriginalPasswordColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChangedPasswordColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.ChangeAccNameMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.ChangePssMenuItem = new System.Windows.Forms.MenuItem();
            this.RemovePssMenuItem = new System.Windows.Forms.MenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CredentialsListView
            // 
            this.CredentialsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CredentialsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserNameColumn,
            this.PasswordColumn,
            this.OriginalPasswordColumn,
            this.ChangedPasswordColumn});
            this.CredentialsListView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CredentialsListView.FullRowSelect = true;
            this.CredentialsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CredentialsListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.CredentialsListView.Location = new System.Drawing.Point(6, 6);
            this.CredentialsListView.MultiSelect = false;
            this.CredentialsListView.Name = "CredentialsListView";
            this.CredentialsListView.Size = new System.Drawing.Size(372, 151);
            this.CredentialsListView.TabIndex = 103;
            this.CredentialsListView.UseCompatibleStateImageBehavior = false;
            this.CredentialsListView.View = System.Windows.Forms.View.Details;
            // 
            // UserNameColumn
            // 
            this.UserNameColumn.Text = "User Name";
            this.UserNameColumn.Width = 82;
            // 
            // PasswordColumn
            // 
            this.PasswordColumn.Text = "Password";
            this.PasswordColumn.Width = 66;
            // 
            // OriginalPasswordColumn
            // 
            this.OriginalPasswordColumn.Text = "Original Password";
            this.OriginalPasswordColumn.Width = 107;
            // 
            // ChangedPasswordColumn
            // 
            this.ChangedPasswordColumn.Text = "Changed Password";
            this.ChangedPasswordColumn.Width = 113;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(3, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 102;
            this.label2.Text = "Fetching Credentials...";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(6, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 2);
            this.label1.TabIndex = 98;
            this.label1.Text = "label1";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button4.Location = new System.Drawing.Point(303, 260);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 97;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ChangeAccNameMenuItem,
            this.menuItem4,
            this.ChangePssMenuItem,
            this.RemovePssMenuItem});
            // 
            // ChangeAccNameMenuItem
            // 
            this.ChangeAccNameMenuItem.Index = 0;
            this.ChangeAccNameMenuItem.Text = "Change Account Name";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.Text = "-";
            // 
            // ChangePssMenuItem
            // 
            this.ChangePssMenuItem.Index = 2;
            this.ChangePssMenuItem.Text = "Change Password";
            // 
            // RemovePssMenuItem
            // 
            this.RemovePssMenuItem.Index = 3;
            this.RemovePssMenuItem.Text = "Remove Password";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button2.Location = new System.Drawing.Point(201, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 112;
            this.button2.Text = "Change";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox2.Location = new System.Drawing.Point(6, 218);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 23);
            this.textBox2.TabIndex = 111;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.Location = new System.Drawing.Point(3, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 15);
            this.label8.TabIndex = 110;
            this.label8.Text = "Comfirm Password:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.Location = new System.Drawing.Point(6, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 23);
            this.textBox1.TabIndex = 109;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.Location = new System.Drawing.Point(3, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 15);
            this.label9.TabIndex = 108;
            this.label9.Text = "New password:";
            // 
            // CredentialManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 288);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CredentialsListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CredentialManager";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credential Manager (Connection ID : 149901-08ZA1135)";
            this.Load += new System.EventHandler(this.PasswordReset_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FullListView CredentialsListView;
        private System.Windows.Forms.ColumnHeader UserNameColumn;
        private System.Windows.Forms.ColumnHeader PasswordColumn;
        private System.Windows.Forms.ColumnHeader OriginalPasswordColumn;
        private System.Windows.Forms.ColumnHeader ChangedPasswordColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem ChangePssMenuItem;
        private System.Windows.Forms.MenuItem RemovePssMenuItem;
        private System.Windows.Forms.MenuItem ChangeAccNameMenuItem;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;

    }
}