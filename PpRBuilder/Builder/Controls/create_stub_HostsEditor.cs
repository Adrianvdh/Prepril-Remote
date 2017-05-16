using System;
using System.Drawing;
using System.Windows.Forms;
using Configuration;

namespace PpRBuilder.Controls
{
    public class create_stub_HostsEditor : OptionsBaseControl
    //public partial class create_stub_HostsEditor : UserControl
    {
        public create_stub_HostsEditor(string configName) : base(configName)
        {
            InitializeComponent();
            VistaControls.VistaConstants.SetWindowTheme(HostsEditorListView.Handle, "explorer", null);
            HostsEditorListView.ContextMenu = contextMenu1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HostsEditorListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            ListView listView = sender as ListView;
            e.Cancel = true;
            e.NewWidth = listView.Columns[e.ColumnIndex].Width;
        }
        private PpRStandardLib.Controls.FullListView HostsEditorListView;
        private ColumnHeader IPAddressColumn;
        private ColumnHeader DomainNameColumn;
        private CheckBox checkBox1;
        private ContextMenu contextMenu1;
        private MenuItem menuItem1;
        private MenuItem menuItem2;
        private MenuItem menuItem3;
        private MenuItem menuItem4;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox3;

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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "127.0.0.1",
            "www.domain.com"}, -1);
            this.HostsEditorListView = new PpRStandardLib.Controls.FullListView();
            this.IPAddressColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DomainNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HostsEditorListView
            // 
            this.HostsEditorListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IPAddressColumn,
            this.DomainNameColumn});
            this.HostsEditorListView.ExplorerTheme = false;
            this.HostsEditorListView.ExplorerThemeMultiSelect = false;
            this.HostsEditorListView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HostsEditorListView.FullRowSelect = true;
            this.HostsEditorListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.HostsEditorListView.ItemContextMenuStrip = false;
            listViewItem1.StateImageIndex = 0;
            this.HostsEditorListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.HostsEditorListView.Location = new System.Drawing.Point(9, 66);
            this.HostsEditorListView.LockColumnSize = false;
            this.HostsEditorListView.MultiSelect = false;
            this.HostsEditorListView.Name = "HostsEditorListView";
            this.HostsEditorListView.Size = new System.Drawing.Size(219, 227);
            this.HostsEditorListView.TabIndex = 43;
            this.HostsEditorListView.UseCompatibleStateImageBehavior = false;
            this.HostsEditorListView.View = System.Windows.Forms.View.Details;
            // 
            // IPAddressColumn
            // 
            this.IPAddressColumn.Text = "IP Address";
            this.IPAddressColumn.Width = 95;
            // 
            // DomainNameColumn
            // 
            this.DomainNameColumn.Text = "Domain Name";
            this.DomainNameColumn.Width = 120;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBox1.Location = new System.Drawing.Point(9, 299);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(379, 19);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Clear the whole previous Hosts file data before writing the new one";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3,
            this.menuItem4});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Edit";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "-";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "Remove";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 3;
            this.menuItem4.Text = "Clear All";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.Location = new System.Drawing.Point(291, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "+/Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(147, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Domain Name:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox2.Location = new System.Drawing.Point(150, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 23);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.Location = new System.Drawing.Point(9, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.HostsEditorListView);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 324);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hosts Editor";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(234, 66);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(186, 227);
            this.textBox3.TabIndex = 106;
            this.textBox3.Text = "Windows Hosts file:";
            // 
            // create_stub_HostsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "create_stub_HostsEditor";
            this.Size = new System.Drawing.Size(428, 324);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


    }
}
