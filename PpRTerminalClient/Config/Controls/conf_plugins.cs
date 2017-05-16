using System;
using System.Windows.Forms;
using Configuration;
using PpStandardLib.Controls;

namespace Configuration.Controls
{
    public class conf_plugins : OptionsBaseControl
    //public partial class conf_plugins : UserControl
    {

        private System.ComponentModel.Container components = null;

        public conf_plugins(string configName) : base(configName)
        {
            InitializeComponent();
        }
        private void conf_plugins_Load(object sender, EventArgs e)
        {

        }


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
            this.fullListView1 = new FullListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fullListView1
            // 
            this.fullListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.FileNameColumn});
            this.fullListView1.ExplorerTheme = false;
            this.fullListView1.ExplorerThemeMultiSelect = false;
            this.fullListView1.FullRowSelect = true;
            this.fullListView1.ItemContextMenuStrip = false;
            this.fullListView1.Location = new System.Drawing.Point(0, 0);
            this.fullListView1.LockColumnSize = false;
            this.fullListView1.Name = "fullListView1";
            this.fullListView1.Size = new System.Drawing.Size(322, 249);
            this.fullListView1.TabIndex = 0;
            this.fullListView1.UseCompatibleStateImageBehavior = false;
            this.fullListView1.View = System.Windows.Forms.View.Details;
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 158;
            // 
            // FileNameColumn
            // 
            this.FileNameColumn.Text = "File Name";
            this.FileNameColumn.Width = 129;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(0, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Options";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(81, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Disable";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(162, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // conf_plugins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fullListView1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "conf_plugins";
            this.Size = new System.Drawing.Size(322, 282);
            this.Load += new System.EventHandler(this.conf_plugins_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private FullListView fullListView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ColumnHeader FileNameColumn;
        private ColumnHeader NameColumn;
        
        
        


    }
}
