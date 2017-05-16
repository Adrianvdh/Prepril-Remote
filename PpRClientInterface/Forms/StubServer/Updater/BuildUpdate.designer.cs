using PpRClientInterface.Controls;
namespace PpRClientInterface.Forms
{
    partial class BuildUpdate
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("00000-0000-000-0000");
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ProvideURLRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BuildSubmissionsListView = new PpRStandardLib.Controls.FullListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectFileRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button2.Location = new System.Drawing.Point(462, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.Location = new System.Drawing.Point(381, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button12.Location = new System.Drawing.Point(333, 64);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(29, 23);
            this.button12.TabIndex = 33;
            this.button12.Text = "...";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4.Location = new System.Drawing.Point(6, 65);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(321, 23);
            this.textBox4.TabIndex = 32;
            // 
            // ProvideURLRadioButton
            // 
            this.ProvideURLRadioButton.AutoSize = true;
            this.ProvideURLRadioButton.Location = new System.Drawing.Point(6, 42);
            this.ProvideURLRadioButton.Name = "ProvideURLRadioButton";
            this.ProvideURLRadioButton.Size = new System.Drawing.Size(114, 19);
            this.ProvideURLRadioButton.TabIndex = 1;
            this.ProvideURLRadioButton.Text = "Provide URL Link";
            this.ProvideURLRadioButton.UseVisualStyleBackColor = true;
            this.ProvideURLRadioButton.CheckedChanged += new System.EventHandler(this.ProvideURLRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BuildSubmissionsListView);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.ProvideURLRadioButton);
            this.groupBox1.Controls.Add(this.SelectFileRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 286);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Method";
            // 
            // BuildSubmissionsListView
            // 
            this.BuildSubmissionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.BuildSubmissionsListView.ExplorerTheme = true;
            this.BuildSubmissionsListView.ExplorerThemeMultiSelect = true;
            this.BuildSubmissionsListView.FullRowSelect = true;
            this.BuildSubmissionsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.BuildSubmissionsListView.ItemContextMenuStrip = true;
            this.BuildSubmissionsListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.BuildSubmissionsListView.Location = new System.Drawing.Point(5, 93);
            this.BuildSubmissionsListView.LockColumnSize = true;
            this.BuildSubmissionsListView.MultiSelect = false;
            this.BuildSubmissionsListView.Name = "BuildSubmissionsListView";
            this.BuildSubmissionsListView.Size = new System.Drawing.Size(516, 143);
            this.BuildSubmissionsListView.TabIndex = 8;
            this.BuildSubmissionsListView.UseCompatibleStateImageBehavior = false;
            this.BuildSubmissionsListView.View = System.Windows.Forms.View.Details;
            this.BuildSubmissionsListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.BuildSubmissionsListView_ColumnWidthChanging);
            this.BuildSubmissionsListView.SelectedIndexChanged += new System.EventHandler(this.BuildSubmissionsListView_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Build ID";
            this.columnHeader5.Width = 139;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Password";
            this.columnHeader6.Width = 152;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Compiled Date";
            this.columnHeader7.Width = 139;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "CRC-32";
            this.columnHeader8.Width = 82;
            // 
            // SelectFileRadioButton
            // 
            this.SelectFileRadioButton.AutoSize = true;
            this.SelectFileRadioButton.Checked = true;
            this.SelectFileRadioButton.Location = new System.Drawing.Point(6, 19);
            this.SelectFileRadioButton.Name = "SelectFileRadioButton";
            this.SelectFileRadioButton.Size = new System.Drawing.Size(108, 19);
            this.SelectFileRadioButton.TabIndex = 0;
            this.SelectFileRadioButton.TabStop = true;
            this.SelectFileRadioButton.Text = "Select Local File";
            this.SelectFileRadioButton.UseVisualStyleBackColor = true;
            this.SelectFileRadioButton.CheckedChanged += new System.EventHandler(this.SelectFileRadioButton_CheckedChanged);
            // 
            // BuildUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 325);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuildUpdate";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Build Update";
            this.Load += new System.EventHandler(this.UpdateStubs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RadioButton ProvideURLRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SelectFileRadioButton;
        private PpRStandardLib.Controls.FullListView BuildSubmissionsListView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;

    }
}