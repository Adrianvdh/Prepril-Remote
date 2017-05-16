using System;
using System.Drawing;
using System.Windows.Forms;
using Configuration;

namespace PpRBuilder.Controls
{
    public class create_stub_BlackList : OptionsBaseControl
    //public partial class create_stub_BlackList : UserControl
    {
        public create_stub_BlackList(string configName) : base(configName)
        {
            InitializeComponent();
            VistaControls.VistaConstants.SetWindowTheme(ProcessesListView.Handle, "explorer", null);
            VistaControls.VistaConstants.SetWindowTheme(ServicesListView.Handle, "explorer", null);
            ProcessesListView.ContextMenu = contextMenu1;
            ServicesListView.ContextMenu = contextMenu1;

            comboBox1.SelectedIndex = 0;
        }

        private void BlackList_Load(object sender, EventArgs e)
        {

        }


        private void ProcessesListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            ListView listView = sender as ListView;
            e.Cancel = true;
            e.NewWidth = listView.Columns[e.ColumnIndex].Width;
        }
        private void ServicesListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            ListView listView = sender as ListView;
            e.Cancel = true;
            e.NewWidth = listView.Columns[e.ColumnIndex].Width;
        }

        private GroupBox groupBox1;



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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("chrome.exe");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("chrome.exe");
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ProcessesListView = new PpRStandardLib.Controls.FullListView();
            this.ProcessColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ServicesListView = new PpRStandardLib.Controls.FullListView();
            this.ServiceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 3;
            this.menuItem4.Text = "Clear All";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "Remove";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "-";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Edit";
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3,
            this.menuItem4});
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.Location = new System.Drawing.Point(286, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 66;
            this.button1.Text = "+/Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(185, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 65;
            this.label3.Text = "Type:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Process",
            "Service"});
            this.comboBox1.Location = new System.Drawing.Point(188, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 23);
            this.comboBox1.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 63;
            this.label4.Text = "Name:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox2.Location = new System.Drawing.Point(9, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 23);
            this.textBox2.TabIndex = 62;
            // 
            // ProcessesListView
            // 
            this.ProcessesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProcessColumn});
            this.ProcessesListView.ExplorerTheme = true;
            this.ProcessesListView.ExplorerThemeMultiSelect = true;
            this.ProcessesListView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProcessesListView.FullRowSelect = true;
            this.ProcessesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ProcessesListView.ItemContextMenuStrip = true;
            this.ProcessesListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ProcessesListView.Location = new System.Drawing.Point(9, 66);
            this.ProcessesListView.LockColumnSize = true;
            this.ProcessesListView.MultiSelect = false;
            this.ProcessesListView.Name = "ProcessesListView";
            this.ProcessesListView.Size = new System.Drawing.Size(201, 251);
            this.ProcessesListView.TabIndex = 47;
            this.ProcessesListView.UseCompatibleStateImageBehavior = false;
            this.ProcessesListView.View = System.Windows.Forms.View.Details;
            this.ProcessesListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ProcessesListView_ColumnWidthChanging);
            // 
            // ProcessColumn
            // 
            this.ProcessColumn.Text = "Process Name";
            this.ProcessColumn.Width = 197;
            // 
            // ServicesListView
            // 
            this.ServicesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ServiceColumn});
            this.ServicesListView.ExplorerTheme = true;
            this.ServicesListView.ExplorerThemeMultiSelect = true;
            this.ServicesListView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ServicesListView.FullRowSelect = true;
            this.ServicesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ServicesListView.ItemContextMenuStrip = true;
            this.ServicesListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.ServicesListView.Location = new System.Drawing.Point(217, 66);
            this.ServicesListView.LockColumnSize = true;
            this.ServicesListView.MultiSelect = false;
            this.ServicesListView.Name = "ServicesListView";
            this.ServicesListView.Size = new System.Drawing.Size(201, 251);
            this.ServicesListView.TabIndex = 52;
            this.ServicesListView.UseCompatibleStateImageBehavior = false;
            this.ServicesListView.View = System.Windows.Forms.View.Details;
            this.ServicesListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ServicesListView_ColumnWidthChanging);
            // 
            // ServiceColumn
            // 
            this.ServiceColumn.Text = "Service Name";
            this.ServiceColumn.Width = 197;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.ServicesListView);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.ProcessesListView);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 324);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Black List";
            // 
            // create_stub_BlackList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "create_stub_BlackList";
            this.Size = new System.Drawing.Size(428, 324);
            this.Load += new System.EventHandler(this.BlackList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private PpRStandardLib.Controls.FullListView ProcessesListView;
        private System.Windows.Forms.ColumnHeader ProcessColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private PpRStandardLib.Controls.FullListView ServicesListView;
        private System.Windows.Forms.ColumnHeader ServiceColumn;

 







    }
}
