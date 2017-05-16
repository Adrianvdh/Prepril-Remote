using System;
using System.Drawing;
using System.Windows.Forms;
using Configuration;

namespace PpRBuilder.Controls
{
    public class create_stub_ProcessInjection : OptionsBaseControl
    //public partial class create_stub_ProcessInjection : UserControl
    {
        public create_stub_ProcessInjection(string configName) : base(configName)
        {
            InitializeComponent();
            VistaControls.VistaConstants.SetWindowTheme(ProcessInjectionLstView.Handle, "explorer", null);
            ProcessInjectionLstView.ContextMenu = contextMenu1;
        }
        private void ProcessInjection_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }


        private void ProcessInjectionLstView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            ListView listView = sender as ListView;
            e.Cancel = true;
            e.NewWidth = listView.Columns[e.ColumnIndex].Width;
        }
        private PpRStandardLib.Controls.FullListView ProcessInjectionLstView;
        private ColumnHeader ProcessNameColumn;
        private ColumnHeader PriorityColumn;
        private ContextMenu contextMenu1;
        private MenuItem menuItem2;
        private MenuItem menuItem4;
        private MenuItem menuItem1;
        private MenuItem menuItem3;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox2;
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "explorer.exe",
            "Primary"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "svchost.exe",
            "Fallback"}, -1);
            this.ProcessInjectionLstView = new PpRStandardLib.Controls.FullListView();
            this.ProcessNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriorityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcessInjectionLstView
            // 
            this.ProcessInjectionLstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProcessNameColumn,
            this.PriorityColumn});
            this.ProcessInjectionLstView.ExplorerTheme = true;
            this.ProcessInjectionLstView.ExplorerThemeMultiSelect = true;
            this.ProcessInjectionLstView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProcessInjectionLstView.FullRowSelect = true;
            this.ProcessInjectionLstView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ProcessInjectionLstView.ItemContextMenuStrip = true;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            this.ProcessInjectionLstView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.ProcessInjectionLstView.Location = new System.Drawing.Point(9, 66);
            this.ProcessInjectionLstView.LockColumnSize = true;
            this.ProcessInjectionLstView.MultiSelect = false;
            this.ProcessInjectionLstView.Name = "ProcessInjectionLstView";
            this.ProcessInjectionLstView.Size = new System.Drawing.Size(215, 250);
            this.ProcessInjectionLstView.TabIndex = 155;
            this.ProcessInjectionLstView.UseCompatibleStateImageBehavior = false;
            this.ProcessInjectionLstView.View = System.Windows.Forms.View.Details;
            // 
            // ProcessNameColumn
            // 
            this.ProcessNameColumn.Text = "Process Name";
            this.ProcessNameColumn.Width = 154;
            // 
            // PriorityColumn
            // 
            this.PriorityColumn.Text = "Priority";
            this.PriorityColumn.Width = 57;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem4,
            this.menuItem1,
            this.menuItem3});
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "Edit";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.Text = "-";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 2;
            this.menuItem1.Text = "Remove";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 3;
            this.menuItem3.Text = "Clear All";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.Location = new System.Drawing.Point(230, 66);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(190, 250);
            this.textBox1.TabIndex = 157;
            this.textBox1.Text = "Process Injection:\r\n-The Stub Server will try to inject into the process describe" +
    "d.\r\n-If it fails, the Stub Server will attempt to inject into a \'Fallback\' proce" +
    "ss.\r\n";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.Location = new System.Drawing.Point(286, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 61;
            this.button1.Text = "+/Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(185, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 60;
            this.label1.Text = "Priority:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Primary",
            "Fallback"});
            this.comboBox1.Location = new System.Drawing.Point(188, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 23);
            this.comboBox1.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 58;
            this.label4.Text = "Process Name:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox2.Location = new System.Drawing.Point(9, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 23);
            this.textBox2.TabIndex = 55;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.ProcessInjectionLstView);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 324);
            this.groupBox1.TabIndex = 158;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process Injection";
            // 
            // create_stub_ProcessInjection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "create_stub_ProcessInjection";
            this.Size = new System.Drawing.Size(428, 324);
            this.Load += new System.EventHandler(this.ProcessInjection_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

    }
}
