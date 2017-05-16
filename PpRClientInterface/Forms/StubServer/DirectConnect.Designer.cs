using PpRStandardLib.Controls;
namespace PpRClientInterface.Forms
{
    partial class DirectConnect
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "DDOS",
            "116",
            "Running",
            "00:09:31",
            "Adrian",
            "04:57:51 PM"}, "us.png");
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryPanel1 = new PpRClientInterface.Controls.CategoryPanel(this.components);
            this.TsksLstVw = new PpRStandardLib.Controls.FullListView();
            this.columnHeader170 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader171 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DurationColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader172 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader173 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 358);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(590, 22);
            this.statusBar1.TabIndex = 1;
            this.statusBar1.Text = "statusBar1";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(0, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(590, 2);
            this.label2.TabIndex = 17;
            this.label2.Text = "label2";
            // 
            // categoryPanel1
            // 
            this.categoryPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoryPanel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryPanel1.Location = new System.Drawing.Point(0, 0);
            this.categoryPanel1.Name = "categoryPanel1";
            this.categoryPanel1.Size = new System.Drawing.Size(590, 30);
            this.categoryPanel1.TabIndex = 13;
            // 
            // TsksLstVw
            // 
            this.TsksLstVw.AllowColumnReorder = true;
            this.TsksLstVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader170,
            this.PIDColumn,
            this.columnHeader171,
            this.DurationColumn,
            this.columnHeader172,
            this.columnHeader173});
            this.TsksLstVw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TsksLstVw.ExplorerTheme = false;
            this.TsksLstVw.ExplorerThemeMultiSelect = false;
            this.TsksLstVw.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TsksLstVw.FullRowSelect = true;
            this.TsksLstVw.ItemContextMenuStrip = false;
            listViewItem1.StateImageIndex = 0;
            this.TsksLstVw.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.TsksLstVw.Location = new System.Drawing.Point(0, 32);
            this.TsksLstVw.LockColumnSize = false;
            this.TsksLstVw.Name = "TsksLstVw";
            this.TsksLstVw.Size = new System.Drawing.Size(590, 326);
            this.TsksLstVw.TabIndex = 18;
            this.TsksLstVw.UseCompatibleStateImageBehavior = false;
            this.TsksLstVw.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader170
            // 
            this.columnHeader170.Text = "Name";
            this.columnHeader170.Width = 170;
            // 
            // PIDColumn
            // 
            this.PIDColumn.Text = "PID";
            this.PIDColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PIDColumn.Width = 54;
            // 
            // columnHeader171
            // 
            this.columnHeader171.Text = "Status";
            this.columnHeader171.Width = 82;
            // 
            // DurationColumn
            // 
            this.DurationColumn.Text = "Duration";
            // 
            // columnHeader172
            // 
            this.columnHeader172.DisplayIndex = 5;
            this.columnHeader172.Text = "Owner";
            this.columnHeader172.Width = 105;
            // 
            // columnHeader173
            // 
            this.columnHeader173.DisplayIndex = 4;
            this.columnHeader173.Text = "Added";
            this.columnHeader173.Width = 77;
            // 
            // DirectConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 380);
            this.Controls.Add(this.TsksLstVw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoryPanel1);
            this.Controls.Add(this.statusBar1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "DirectConnect";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection ID : 149901-08ZA1135";
            this.Load += new System.EventHandler(this.DirectConnect_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusBar statusBar1;
        private Controls.CategoryPanel categoryPanel1;
        private System.Windows.Forms.Label label2;
        private FullListView TsksLstVw;
        private System.Windows.Forms.ColumnHeader columnHeader170;
        private System.Windows.Forms.ColumnHeader PIDColumn;
        private System.Windows.Forms.ColumnHeader columnHeader171;
        private System.Windows.Forms.ColumnHeader DurationColumn;
        private System.Windows.Forms.ColumnHeader columnHeader172;
        private System.Windows.Forms.ColumnHeader columnHeader173;

    }
}