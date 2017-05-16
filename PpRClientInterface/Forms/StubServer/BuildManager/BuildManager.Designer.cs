using PpRClientInterface.Controls;
namespace PpRClientInterface.Forms
{
    partial class BuildManager
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("00000-0000-000-0000");
            this.BuildSubmissionsListView = new PpRStandardLib.Controls.FullListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BuildSubmissionsListView
            // 
            this.BuildSubmissionsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuildSubmissionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.BuildSubmissionsListView.ExplorerTheme = true;
            this.BuildSubmissionsListView.ExplorerThemeMultiSelect = true;
            this.BuildSubmissionsListView.FullRowSelect = true;
            this.BuildSubmissionsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.BuildSubmissionsListView.ItemContextMenuStrip = true;
            this.BuildSubmissionsListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.BuildSubmissionsListView.Location = new System.Drawing.Point(7, 43);
            this.BuildSubmissionsListView.LockColumnSize = true;
            this.BuildSubmissionsListView.MultiSelect = false;
            this.BuildSubmissionsListView.Name = "BuildSubmissionsListView";
            this.BuildSubmissionsListView.Size = new System.Drawing.Size(545, 183);
            this.BuildSubmissionsListView.TabIndex = 9;
            this.BuildSubmissionsListView.UseCompatibleStateImageBehavior = false;
            this.BuildSubmissionsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Build ID";
            this.columnHeader5.Width = 139;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Password";
            this.columnHeader6.Width = 152;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Compiled Date";
            this.columnHeader7.Width = 139;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "CRC-32";
            this.columnHeader8.Width = 82;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(7, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 115);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // BuildManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BuildSubmissionsListView);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuildManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Build Manager";
            this.Load += new System.EventHandler(this.StubServerBuilds_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PpRStandardLib.Controls.FullListView BuildSubmissionsListView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;

    }
}