using PpRStandardLib.Controls;
namespace PpRStandardLib.Controls
{
    partial class StubsListView
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
            this.StubIDGroupListView = new PpRStandardLib.Controls.FullListView();
            this.ConnectionIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GroupColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // StubIDGroupListView
            // 
            this.StubIDGroupListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ConnectionIDColumn,
            this.GroupColumn});
            this.StubIDGroupListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StubIDGroupListView.ExplorerTheme = true;
            this.StubIDGroupListView.ExplorerThemeMultiSelect = true;
            this.StubIDGroupListView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StubIDGroupListView.FullRowSelect = true;
            this.StubIDGroupListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.StubIDGroupListView.ItemContextMenuStrip = true;
            this.StubIDGroupListView.Location = new System.Drawing.Point(0, 0);
            this.StubIDGroupListView.LockColumnSize = true;
            this.StubIDGroupListView.MultiSelect = false;
            this.StubIDGroupListView.Name = "StubIDGroupListView";
            this.StubIDGroupListView.Size = new System.Drawing.Size(240, 306);
            this.StubIDGroupListView.TabIndex = 68;
            this.StubIDGroupListView.UseCompatibleStateImageBehavior = false;
            this.StubIDGroupListView.View = System.Windows.Forms.View.Details;
            this.StubIDGroupListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.StubIDGroupListView_ColumnWidthChanging);
            // 
            // ConnectionIDColumn
            // 
            this.ConnectionIDColumn.Text = "Connection ID";
            this.ConnectionIDColumn.Width = 88;
            // 
            // GroupColumn
            // 
            this.GroupColumn.Text = "Group";
            this.GroupColumn.Width = 147;
            // 
            // StubsListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StubIDGroupListView);
            this.Name = "StubsListView";
            this.Size = new System.Drawing.Size(240, 306);
            this.Load += new System.EventHandler(this.ServicesListView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenu contextMenu1;
        private FullListView StubIDGroupListView;
        private System.Windows.Forms.ColumnHeader ConnectionIDColumn;
        private System.Windows.Forms.ColumnHeader GroupColumn;
    }
}
