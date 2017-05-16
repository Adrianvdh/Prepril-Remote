namespace PpRStandardLib.Controls
{
    partial class ProcessesListView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "DDOS",
            "Target: moodle.schooltech.co.za",
            "116",
            "Running",
            "00:09:31",
            "Adrian",
            "04:57:51 PM"}, "Application.ico");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessesListView));
            this.TasksListView = new PpRStandardLib.Controls.FullListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DurationColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OwnerColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // TasksListView
            // 
            this.TasksListView.AllowColumnReorder = true;
            this.TasksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.DescriptionColumn,
            this.PIDColumn,
            this.StatusColumn,
            this.DurationColumn,
            this.OwnerColumn,
            this.AddedColumn});
            this.TasksListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TasksListView.ExplorerTheme = false;
            this.TasksListView.ExplorerThemeMultiSelect = false;
            this.TasksListView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TasksListView.FullRowSelect = true;
            this.TasksListView.ItemContextMenuStrip = false;
            listViewItem1.StateImageIndex = 0;
            this.TasksListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.TasksListView.LargeImageList = this.imageList1;
            this.TasksListView.Location = new System.Drawing.Point(0, 0);
            this.TasksListView.LockColumnSize = false;
            this.TasksListView.Name = "TasksListView";
            this.TasksListView.Size = new System.Drawing.Size(799, 321);
            this.TasksListView.SmallImageList = this.imageList1;
            this.TasksListView.TabIndex = 5;
            this.TasksListView.UseCompatibleStateImageBehavior = false;
            this.TasksListView.View = System.Windows.Forms.View.Details;
            this.TasksListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.TasksListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProcListView_MouseUp);
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 197;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.Text = "Description";
            this.DescriptionColumn.Width = 248;
            // 
            // PIDColumn
            // 
            this.PIDColumn.Text = "PID";
            this.PIDColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PIDColumn.Width = 54;
            // 
            // StatusColumn
            // 
            this.StatusColumn.Text = "Status";
            // 
            // DurationColumn
            // 
            this.DurationColumn.Text = "Duration";
            // 
            // OwnerColumn
            // 
            this.OwnerColumn.DisplayIndex = 6;
            this.OwnerColumn.Text = "Owner";
            this.OwnerColumn.Width = 72;
            // 
            // AddedColumn
            // 
            this.AddedColumn.DisplayIndex = 5;
            this.AddedColumn.Text = "Added";
            this.AddedColumn.Width = 77;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Application.ico");
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem4,
            this.menuItem5,
            this.menuItem10,
            this.menuItem9,
            this.menuItem8,
            this.menuItem6,
            this.menuItem7});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Terminate";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.Text = "Suspend";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 2;
            this.menuItem5.Text = "Resume";
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 3;
            this.menuItem10.Text = "-";
            // 
            // menuItem9
            // 
            this.menuItem9.DefaultItem = true;
            this.menuItem9.Index = 4;
            this.menuItem9.Text = "Properties";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 5;
            this.menuItem8.Text = "-";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 6;
            this.menuItem6.Text = "Copy (Column)";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 7;
            this.menuItem7.Text = "Copy";
            // 
            // ProcessesListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TasksListView);
            this.Name = "ProcessesListView";
            this.Size = new System.Drawing.Size(799, 321);
            this.Load += new System.EventHandler(this.ProcossesListView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PpRStandardLib.Controls.FullListView TasksListView;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader DescriptionColumn;
        private System.Windows.Forms.ColumnHeader StatusColumn;
        private System.Windows.Forms.ColumnHeader DurationColumn;
        private System.Windows.Forms.ColumnHeader AddedColumn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader OwnerColumn;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.ColumnHeader PIDColumn;
    }
}
