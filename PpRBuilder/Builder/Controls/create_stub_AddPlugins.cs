using System;
using System.Drawing;
using System.Windows.Forms;
using Configuration;

namespace PpRBuilder.Controls
{
    public class create_stub_AddPlugins : OptionsBaseControl
    //public partial class create_stub_AddPlugins : UserControl
    {
        public create_stub_AddPlugins(string configName) : base(configName)
        {
            InitializeComponent();
            VistaControls.VistaConstants.SetWindowTheme(InstalledPluginsListView.Handle, "explorer", null);
            VistaControls.VistaConstants.SendMessage(InstalledPluginsListView.Handle, VistaControls.VistaConstants.LVM_SETEXTENDEDLISTVIEWSTYLE, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER, VistaControls.VistaConstants.LVS_EX_DOUBLEBUFFER);
            comboBox1.SelectedIndex = 0;
        }

        private void AddPlugins_Load(object sender, EventArgs e)
        {

        }

        private void InstalledPluginsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(create_stub_AddPlugins));
            this.InstalledPluginsListView = new PpRStandardLib.Controls.FullListView();
            this.PluginNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AuthorColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VersionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InstallDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // InstalledPluginsListView
            // 
            this.InstalledPluginsListView.CheckBoxes = true;
            this.InstalledPluginsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PluginNameColumn,
            this.AuthorColumn,
            this.VersionColumn,
            this.SizeColumn,
            this.InstallDateColumn});
            resources.ApplyResources(this.InstalledPluginsListView, "InstalledPluginsListView");
            this.InstalledPluginsListView.ExplorerTheme = false;
            this.InstalledPluginsListView.ExplorerThemeMultiSelect = false;
            this.InstalledPluginsListView.FullRowSelect = true;
            this.InstalledPluginsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.InstalledPluginsListView.ItemContextMenuStrip = false;
            this.InstalledPluginsListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("InstalledPluginsListView.Items"))),
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("InstalledPluginsListView.Items1")))});
            this.InstalledPluginsListView.LockColumnSize = false;
            this.InstalledPluginsListView.Name = "InstalledPluginsListView";
            this.InstalledPluginsListView.UseCompatibleStateImageBehavior = false;
            this.InstalledPluginsListView.View = System.Windows.Forms.View.Details;
            // 
            // PluginNameColumn
            // 
            resources.ApplyResources(this.PluginNameColumn, "PluginNameColumn");
            // 
            // AuthorColumn
            // 
            resources.ApplyResources(this.AuthorColumn, "AuthorColumn");
            // 
            // VersionColumn
            // 
            resources.ApplyResources(this.VersionColumn, "VersionColumn");
            // 
            // SizeColumn
            // 
            resources.ApplyResources(this.SizeColumn, "SizeColumn");
            // 
            // InstallDateColumn
            // 
            resources.ApplyResources(this.InstallDateColumn, "InstallDateColumn");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.comboBox1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1")});
            this.comboBox1.Name = "comboBox1";
            // 
            // create_stub_AddPlugins
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InstalledPluginsListView);
            this.Controls.Add(this.panel2);
            this.Name = "create_stub_AddPlugins";
            this.Load += new System.EventHandler(this.AddPlugins_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PpRStandardLib.Controls.FullListView InstalledPluginsListView;
        private ColumnHeader PluginNameColumn;
        private ColumnHeader AuthorColumn;
        private ColumnHeader VersionColumn;
        private ColumnHeader InstallDateColumn;
        private ColumnHeader SizeColumn;
        private Panel panel2;
        private CheckBox checkBox2;
        private ComboBox comboBox1;    


    }
}
