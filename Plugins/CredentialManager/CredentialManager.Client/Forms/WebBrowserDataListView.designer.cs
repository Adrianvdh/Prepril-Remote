using PpRStandardLib.Controls;
namespace CredentialManager_Client
{
    partial class WebBrowserDataListView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.UserColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateTimeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.URLColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new FullListView();
            this.PasswordColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // UserColumn
            // 
            this.UserColumn.Text = "User Name";
            this.UserColumn.Width = 103;
            // 
            // DateTimeColumn
            // 
            this.DateTimeColumn.Text = "Visit Date & Time";
            this.DateTimeColumn.Width = 117;
            // 
            // URLColumn
            // 
            this.URLColumn.Text = "URL";
            this.URLColumn.Width = 157;
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.URLColumn,
            this.DateTimeColumn,
            this.UserColumn,
            this.PasswordColumn});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(484, 240);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // PasswordColumn
            // 
            this.PasswordColumn.Text = "Password";
            this.PasswordColumn.Width = 103;
            // 
            // WebBrowserDataListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Name = "WebBrowserDataListView";
            this.Size = new System.Drawing.Size(484, 240);
            this.Load += new System.EventHandler(this.WebBrowserDataListView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.ColumnHeader UserColumn;
        private System.Windows.Forms.ColumnHeader DateTimeColumn;
        private System.Windows.Forms.ColumnHeader URLColumn;
        private FullListView listView1;
        private System.Windows.Forms.ColumnHeader PasswordColumn;
    }
}
