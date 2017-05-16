using System;
using System.Drawing;
using System.Windows.Forms;
using Configuration;

namespace PpRBuilder.Controls
{
    public class create_stub_Installation : OptionsBaseControl
    //public partial class create_stub_Installation : UserControl
    {
        public create_stub_Installation(string configName) : base(configName)
        {
            InitializeComponent();
        }

        private void Installation_Load(object sender, EventArgs e)
        {
            EnviromentDirComboBox.SelectedIndex = 0;

        }

        private void StartWithWinCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (StartWithWinCheckBox.Checked)
            { label4.Enabled = true; StartupKeyNameTextBox.Enabled = true; ActiveSetupCheckBox.Enabled = true; }
            else
            { label4.Enabled = false; StartupKeyNameTextBox.Enabled = false; ActiveSetupCheckBox.Enabled = false; }
        }

        private void ChangeCreationDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ChangeCreationDateCheckBox.Checked)
            { dateTimePicker1.Enabled = true; }
            else
            { dateTimePicker1.Enabled = false; }
        }

        private void InstallStubServerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (InstallStubServerCheckBox.Checked)
            {
                label1.Enabled = true; label2.Enabled = true; label3.Enabled = true;
                EnviromentDirComboBox.Enabled = true; FileNameDirTextBox.Enabled = true; BuildExtensionTextBox.Enabled = true;
                DeleteOriginalCheckBox.Enabled = true;
            }
            else
            {
                label1.Enabled = false; label2.Enabled = false; label3.Enabled = false;
                EnviromentDirComboBox.Enabled = false; FileNameDirTextBox.Enabled = false; BuildExtensionTextBox.Enabled = false;
                DeleteOriginalCheckBox.Enabled = false;
            }
        }
        private TextBox BuildExtensionTextBox;
        private ToolTip toolTip1;
        private CheckBox InstallStubServerCheckBox;
        private ToolTip toolTip2;
        private CheckBox ActiveSetupCheckBox;
        private CheckBox checkBox8;
        private CheckBox DeleteOriginalCheckBox;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox PersistentInstallationCheckBox;
        private DateTimePicker dateTimePicker1;
        private CheckBox ChangeCreationDateCheckBox;
        private CheckBox checkBox5;
        private Label label4;
        private TextBox StartupKeyNameTextBox;
        private Label label3;
        private Label label2;
        private TextBox FileNameDirTextBox;
        private Label label1;
        private ComboBox EnviromentDirComboBox;
        private CheckBox StartWithWinCheckBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox10;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(create_stub_Installation));
            this.BuildExtensionTextBox = new System.Windows.Forms.TextBox();
            this.InstallStubServerCheckBox = new System.Windows.Forms.CheckBox();
            this.ActiveSetupCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.DeleteOriginalCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.PersistentInstallationCheckBox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ChangeCreationDateCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StartupKeyNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FileNameDirTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EnviromentDirComboBox = new System.Windows.Forms.ComboBox();
            this.StartWithWinCheckBox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // BuildExtensionTextBox
            // 
            this.BuildExtensionTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.BuildExtensionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BuildExtensionTextBox.Enabled = false;
            this.BuildExtensionTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BuildExtensionTextBox.Location = new System.Drawing.Point(267, 58);
            this.BuildExtensionTextBox.Name = "BuildExtensionTextBox";
            this.BuildExtensionTextBox.ReadOnly = true;
            this.BuildExtensionTextBox.ShortcutsEnabled = false;
            this.BuildExtensionTextBox.Size = new System.Drawing.Size(32, 23);
            this.BuildExtensionTextBox.TabIndex = 207;
            this.BuildExtensionTextBox.TabStop = false;
            this.BuildExtensionTextBox.Text = ".exe";
            this.toolTip1.SetToolTip(this.BuildExtensionTextBox, "Extension of the file from the server after its creation.\r\nYou can change the ext" +
        "ension in the Build Finalization menu.");
            // 
            // InstallStubServerCheckBox
            // 
            this.InstallStubServerCheckBox.AutoSize = true;
            this.InstallStubServerCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InstallStubServerCheckBox.Location = new System.Drawing.Point(6, 18);
            this.InstallStubServerCheckBox.Name = "InstallStubServerCheckBox";
            this.InstallStubServerCheckBox.Size = new System.Drawing.Size(236, 19);
            this.InstallStubServerCheckBox.TabIndex = 203;
            this.InstallStubServerCheckBox.Text = "Install the Stub Server application file (*)";
            this.toolTip2.SetToolTip(this.InstallStubServerCheckBox, resources.GetString("InstallStubServerCheckBox.ToolTip"));
            this.InstallStubServerCheckBox.UseVisualStyleBackColor = true;
            // 
            // ActiveSetupCheckBox
            // 
            this.ActiveSetupCheckBox.AutoSize = true;
            this.ActiveSetupCheckBox.Enabled = false;
            this.ActiveSetupCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ActiveSetupCheckBox.Location = new System.Drawing.Point(305, 40);
            this.ActiveSetupCheckBox.Name = "ActiveSetupCheckBox";
            this.ActiveSetupCheckBox.Size = new System.Drawing.Size(108, 19);
            this.ActiveSetupCheckBox.TabIndex = 202;
            this.ActiveSetupCheckBox.Text = "Active Setup (*)";
            this.toolTip1.SetToolTip(this.ActiveSetupCheckBox, "The Stub Server will run before many AntiVirus programs, during each restart.");
            this.ActiveSetupCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBox8.Location = new System.Drawing.Point(150, 20);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(82, 19);
            this.checkBox8.TabIndex = 198;
            this.checkBox8.Text = "Read-Only";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // DeleteOriginalCheckBox
            // 
            this.DeleteOriginalCheckBox.AutoSize = true;
            this.DeleteOriginalCheckBox.Enabled = false;
            this.DeleteOriginalCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteOriginalCheckBox.Location = new System.Drawing.Point(305, 60);
            this.DeleteOriginalCheckBox.Name = "DeleteOriginalCheckBox";
            this.DeleteOriginalCheckBox.Size = new System.Drawing.Size(120, 19);
            this.DeleteOriginalCheckBox.TabIndex = 197;
            this.DeleteOriginalCheckBox.Text = "Delete Original (*)";
            this.toolTip1.SetToolTip(this.DeleteOriginalCheckBox, "After the Stub Server has installed it will delete the orginal file.");
            this.DeleteOriginalCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBox4.Location = new System.Drawing.Point(6, 20);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(64, 19);
            this.checkBox4.TabIndex = 194;
            this.checkBox4.Text = "System";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBox3.Location = new System.Drawing.Point(79, 20);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(65, 19);
            this.checkBox3.TabIndex = 193;
            this.checkBox3.Text = "Hidden";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // PersistentInstallationCheckBox
            // 
            this.PersistentInstallationCheckBox.AutoSize = true;
            this.PersistentInstallationCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PersistentInstallationCheckBox.Location = new System.Drawing.Point(6, 62);
            this.PersistentInstallationCheckBox.Name = "PersistentInstallationCheckBox";
            this.PersistentInstallationCheckBox.Size = new System.Drawing.Size(154, 19);
            this.PersistentInstallationCheckBox.TabIndex = 190;
            this.PersistentInstallationCheckBox.Text = "Persistent Installation (*)";
            this.toolTip1.SetToolTip(this.PersistentInstallationCheckBox, "If the startup registry key is removed it will come back.");
            this.PersistentInstallationCheckBox.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(199, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 23);
            this.dateTimePicker1.TabIndex = 189;
            this.dateTimePicker1.Value = new System.DateTime(2009, 3, 18, 13, 24, 0, 0);
            // 
            // ChangeCreationDateCheckBox
            // 
            this.ChangeCreationDateCheckBox.AutoSize = true;
            this.ChangeCreationDateCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ChangeCreationDateCheckBox.Location = new System.Drawing.Point(6, 41);
            this.ChangeCreationDateCheckBox.Name = "ChangeCreationDateCheckBox";
            this.ChangeCreationDateCheckBox.Size = new System.Drawing.Size(164, 19);
            this.ChangeCreationDateCheckBox.TabIndex = 188;
            this.ChangeCreationDateCheckBox.Text = "Change file creation date: ";
            this.ChangeCreationDateCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBox5.Location = new System.Drawing.Point(6, 20);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(190, 19);
            this.checkBox5.TabIndex = 187;
            this.checkBox5.Text = "Hide file after first execution (*)";
            this.toolTip1.SetToolTip(this.checkBox5, "The Stub Server will disapear when the application is running only.");
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(3, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 15);
            this.label4.TabIndex = 185;
            this.label4.Text = "Startup Reg Key Name:";
            // 
            // StartupKeyNameTextBox
            // 
            this.StartupKeyNameTextBox.Enabled = false;
            this.StartupKeyNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartupKeyNameTextBox.Location = new System.Drawing.Point(144, 38);
            this.StartupKeyNameTextBox.Name = "StartupKeyNameTextBox";
            this.StartupKeyNameTextBox.Size = new System.Drawing.Size(155, 23);
            this.StartupKeyNameTextBox.TabIndex = 184;
            this.StartupKeyNameTextBox.Text = "MicroUpdate";
            this.toolTip1.SetToolTip(this.StartupKeyNameTextBox, "Enter the startup registry key name.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(141, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 15);
            this.label3.TabIndex = 183;
            this.label3.Text = "Installation Folder/File Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(129, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 15);
            this.label2.TabIndex = 182;
            this.label2.Text = "\\";
            // 
            // FileNameDirTextBox
            // 
            this.FileNameDirTextBox.Enabled = false;
            this.FileNameDirTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FileNameDirTextBox.Location = new System.Drawing.Point(144, 58);
            this.FileNameDirTextBox.Name = "FileNameDirTextBox";
            this.FileNameDirTextBox.Size = new System.Drawing.Size(117, 23);
            this.FileNameDirTextBox.TabIndex = 181;
            this.FileNameDirTextBox.Text = "MSDCSC\\msdcsc";
            this.toolTip1.SetToolTip(this.FileNameDirTextBox, "Enter the rest of the directory, this includes an optional directory name\r\nand a " +
        "file name.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 180;
            this.label1.Text = "Installation Folder:";
            // 
            // EnviromentDirComboBox
            // 
            this.EnviromentDirComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EnviromentDirComboBox.Enabled = false;
            this.EnviromentDirComboBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EnviromentDirComboBox.FormattingEnabled = true;
            this.EnviromentDirComboBox.Items.AddRange(new object[] {
            "%HomeDrive%",
            "%AppData%",
            "%LocalAppData%",
            "%ProgramData%",
            "%ProgramFiles%",
            "%ProgramFiles%",
            "%WinDir%",
            "%UserProfile%",
            "%Public%",
            "%Temp%",
            "%Path%",
            "Startup Directory",
            "My Documents",
            "Custom Directory"});
            this.EnviromentDirComboBox.Location = new System.Drawing.Point(6, 58);
            this.EnviromentDirComboBox.Name = "EnviromentDirComboBox";
            this.EnviromentDirComboBox.Size = new System.Drawing.Size(120, 23);
            this.EnviromentDirComboBox.TabIndex = 179;
            this.toolTip1.SetToolTip(this.EnviromentDirComboBox, "Choose the shortcut directory where the stub will move itself.\r\nIf you select Cus" +
        "tom Directory enter a full directory for where the Stub Server will install.\r\n\r\n" +
        "Example: %Program Startup Directory%");
            // 
            // StartWithWinCheckBox
            // 
            this.StartWithWinCheckBox.AutoSize = true;
            this.StartWithWinCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartWithWinCheckBox.Location = new System.Drawing.Point(6, 19);
            this.StartWithWinCheckBox.Name = "StartWithWinCheckBox";
            this.StartWithWinCheckBox.Size = new System.Drawing.Size(247, 19);
            this.StartWithWinCheckBox.TabIndex = 178;
            this.StartWithWinCheckBox.Text = "Start the Stub Server when Windows starts";
            this.StartWithWinCheckBox.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 50;
            this.toolTip1.ShowAlways = true;
            // 
            // toolTip2
            // 
            this.toolTip2.AutoPopDelay = 12000;
            this.toolTip2.InitialDelay = 500;
            this.toolTip2.ReshowDelay = 50;
            this.toolTip2.ShowAlways = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.InstallStubServerCheckBox);
            this.groupBox1.Controls.Add(this.BuildExtensionTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.EnviromentDirComboBox);
            this.groupBox1.Controls.Add(this.FileNameDirTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DeleteOriginalCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 89);
            this.groupBox1.TabIndex = 208;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Installation Options";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StartWithWinCheckBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ActiveSetupCheckBox);
            this.groupBox2.Controls.Add(this.StartupKeyNameTextBox);
            this.groupBox2.Location = new System.Drawing.Point(0, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 69);
            this.groupBox2.TabIndex = 209;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Startup";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox5);
            this.groupBox3.Controls.Add(this.ChangeCreationDateCheckBox);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.PersistentInstallationCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(0, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(428, 86);
            this.groupBox3.TabIndex = 210;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox4);
            this.groupBox4.Controls.Add(this.checkBox3);
            this.groupBox4.Controls.Add(this.checkBox8);
            this.groupBox4.Location = new System.Drawing.Point(0, 244);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(428, 44);
            this.groupBox4.TabIndex = 211;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "File attributes";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox1);
            this.groupBox5.Controls.Add(this.checkBox2);
            this.groupBox5.Controls.Add(this.checkBox10);
            this.groupBox5.Location = new System.Drawing.Point(0, 288);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(428, 44);
            this.groupBox5.TabIndex = 212;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parent folder attributes";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBox1.Location = new System.Drawing.Point(6, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 19);
            this.checkBox1.TabIndex = 194;
            this.checkBox1.Text = "System";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBox2.Location = new System.Drawing.Point(79, 20);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(65, 19);
            this.checkBox2.TabIndex = 193;
            this.checkBox2.Text = "Hidden";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBox10.Location = new System.Drawing.Point(150, 20);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(82, 19);
            this.checkBox10.TabIndex = 198;
            this.checkBox10.Text = "Read-Only";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // create_stub_Installation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "create_stub_Installation";
            this.Size = new System.Drawing.Size(428, 324);
            this.Load += new System.EventHandler(this.Installation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion





    }
}
