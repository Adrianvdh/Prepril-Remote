using System;
using System.Drawing;
using System.Windows.Forms;
using Configuration;

namespace PpRBuilder.Controls
{
    public class create_stub_Connections : OptionsBaseControl
    //public partial class create_stub_Connections : UserControl
    {
        public create_stub_Connections(string configName) : base(configName)
        {
            InitializeComponent();
            VistaControls.VistaConstants.SetWindowTheme(ConnectionsListView.Handle, "explorer", null);
            ConnectionsListView.ContextMenu = contextMenu2;
        }

        private void IPAddressButton_Click(object sender, EventArgs e)
        {
            contextMenu1.Show(IPAddressButton, new Point(1, IPAddressButton.Height - 1));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConnectionsListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            ListView listView = sender as ListView;
            e.Cancel = true;
            e.NewWidth = listView.Columns[e.ColumnIndex].Width;
        }
        private ColumnHeader IPAddressDNSColumn;
        private ColumnHeader IDColumn;
        private PpRStandardLib.Controls.FullListView ConnectionsListView;
        private ColumnHeader PortColumn;
        private TextBox textBox3;
        private Label label3;
        private Button button1;
        private TextBox textBox1;
        private Button IPAddressButton;
        private Label label2;
        private MenuItem menuItem7;
        private MenuItem menuItem6;
        private MenuItem menuItem9;
        private ContextMenu contextMenu2;
        private MenuItem menuItem8;
        private ContextMenu contextMenu1;
        private MenuItem menuItem1;
        private MenuItem menuItem2;
        private MenuItem menuItem3;
        private MenuItem menuItem4;
        private MenuItem menuItem5;
        private GroupBox groupBox1;
        private TextBox textBox2;

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
            "A0P",
            "127.0.0.1",
            "1135"}, -1);
            this.IPAddressDNSColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConnectionsListView = new PpRStandardLib.Controls.FullListView();
            this.PortColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IPAddressButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.contextMenu2 = new System.Windows.Forms.ContextMenu();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IPAddressDNSColumn
            // 
            this.IPAddressDNSColumn.Text = "IP Address/DNS";
            this.IPAddressDNSColumn.Width = 127;
            // 
            // IDColumn
            // 
            this.IDColumn.Text = "ID";
            this.IDColumn.Width = 38;
            // 
            // ConnectionsListView
            // 
            this.ConnectionsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ConnectionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDColumn,
            this.IPAddressDNSColumn,
            this.PortColumn});
            this.ConnectionsListView.ExplorerTheme = true;
            this.ConnectionsListView.ExplorerThemeMultiSelect = true;
            this.ConnectionsListView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConnectionsListView.FullRowSelect = true;
            this.ConnectionsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ConnectionsListView.ItemContextMenuStrip = true;
            this.ConnectionsListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ConnectionsListView.Location = new System.Drawing.Point(9, 66);
            this.ConnectionsListView.LockColumnSize = true;
            this.ConnectionsListView.MultiSelect = false;
            this.ConnectionsListView.Name = "ConnectionsListView";
            this.ConnectionsListView.Size = new System.Drawing.Size(215, 250);
            this.ConnectionsListView.TabIndex = 102;
            this.ConnectionsListView.UseCompatibleStateImageBehavior = false;
            this.ConnectionsListView.View = System.Windows.Forms.View.Details;
            // 
            // PortColumn
            // 
            this.PortColumn.Text = "Port";
            this.PortColumn.Width = 46;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox3.Location = new System.Drawing.Point(9, 37);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 23);
            this.textBox3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "IP Address/DNS:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.Location = new System.Drawing.Point(322, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "+/Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.Location = new System.Drawing.Point(252, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 23);
            this.textBox1.TabIndex = 5;
            // 
            // IPAddressButton
            // 
            this.IPAddressButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IPAddressButton.Location = new System.Drawing.Point(155, 37);
            this.IPAddressButton.Name = "IPAddressButton";
            this.IPAddressButton.Size = new System.Drawing.Size(91, 23);
            this.IPAddressButton.TabIndex = 3;
            this.IPAddressButton.Text = "Get IP Address";
            this.IPAddressButton.UseVisualStyleBackColor = true;
            this.IPAddressButton.Click += new System.EventHandler(this.IPAddressButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(249, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port:";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 3;
            this.menuItem7.Text = "Clear All";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 2;
            this.menuItem6.Text = "Remove";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 0;
            this.menuItem9.Text = "Edit";
            // 
            // contextMenu2
            // 
            this.contextMenu2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem9,
            this.menuItem8,
            this.menuItem6,
            this.menuItem7});
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 1;
            this.menuItem8.Text = "-";
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3,
            this.menuItem4,
            this.menuItem5});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Get Localhost IP Address";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "Get LAN IP Address";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "Get WAN IP Address";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 3;
            this.menuItem4.Text = "-";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 4;
            this.menuItem5.Text = "Resolve Host";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.ConnectionsListView);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.IPAddressButton);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 324);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connections";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(230, 66);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(190, 250);
            this.textBox2.TabIndex = 105;
            this.textBox2.Text = "Rules to follow:";
            // 
            // create_stub_Connections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "create_stub_Connections";
            this.Size = new System.Drawing.Size(428, 324);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion




    }
}
