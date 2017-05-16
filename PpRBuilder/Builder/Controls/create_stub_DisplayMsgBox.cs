using System;
using System.Drawing;
using System.Windows.Forms;
using Configuration;

namespace PpRBuilder.Controls
{
    public class create_stub_DisplayMsgBox : OptionsBaseControl
    //public partial class create_stub_DisplayMsgBox : UserControl
    {
        public create_stub_DisplayMsgBox(string configName) : base(configName)
        {
            InitializeComponent();
        }


        private void ShowMsgBoxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowMsgBoxCheckBox.Checked)
            {
                label1.Enabled = true;
                titleTxt.Enabled = true;
                label2.Enabled = true;
                bodyTxt.Enabled = true;

                iconGroup.Enabled = true;
                optionsGroup.Enabled = true;
            }
            else
            {
                label1.Enabled = false;
                titleTxt.Enabled = false;
                label2.Enabled = false;
                bodyTxt.Enabled = false;

                iconGroup.Enabled = false;
                optionsGroup.Enabled = false;
            }
        }
        private CheckBox ShowMsgBoxCheckBox;
        private CheckBox checkBox1;
        private Button button1;
        private RadioButton iconWarningRadioBt;
        private RadioButton iconInfoRadioBt;
        private RadioButton iconErrorRadioBt;
        private RadioButton iconQuestionRadioBt;
        private Label label2;
        private TextBox titleTxt;
        private Label label1;
        private TextBox bodyTxt;
        private GroupBox groupBox1;
        private GroupBox iconGroup;
        private GroupBox optionsGroup;


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
            this.ShowMsgBoxCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.iconWarningRadioBt = new System.Windows.Forms.RadioButton();
            this.iconInfoRadioBt = new System.Windows.Forms.RadioButton();
            this.iconErrorRadioBt = new System.Windows.Forms.RadioButton();
            this.iconQuestionRadioBt = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bodyTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconGroup = new System.Windows.Forms.GroupBox();
            this.optionsGroup = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.iconGroup.SuspendLayout();
            this.optionsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowMsgBoxCheckBox
            // 
            this.ShowMsgBoxCheckBox.AutoSize = true;
            this.ShowMsgBoxCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ShowMsgBoxCheckBox.Location = new System.Drawing.Point(9, 19);
            this.ShowMsgBoxCheckBox.Name = "ShowMsgBoxCheckBox";
            this.ShowMsgBoxCheckBox.Size = new System.Drawing.Size(289, 19);
            this.ShowMsgBoxCheckBox.TabIndex = 164;
            this.ShowMsgBoxCheckBox.Text = "Display a message box when the Stub Server starts";
            this.ShowMsgBoxCheckBox.UseVisualStyleBackColor = true;
            this.ShowMsgBoxCheckBox.CheckedChanged += new System.EventHandler(this.ShowMsgBoxCheckBox_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBox1.Location = new System.Drawing.Point(6, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(323, 19);
            this.checkBox1.TabIndex = 166;
            this.checkBox1.Text = "Display the message box everytime the Stub Server starts";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.Location = new System.Drawing.Point(347, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // iconWarningRadioBt
            // 
            this.iconWarningRadioBt.AutoSize = true;
            this.iconWarningRadioBt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iconWarningRadioBt.Location = new System.Drawing.Point(182, 19);
            this.iconWarningRadioBt.Name = "iconWarningRadioBt";
            this.iconWarningRadioBt.Size = new System.Drawing.Size(70, 19);
            this.iconWarningRadioBt.TabIndex = 5;
            this.iconWarningRadioBt.TabStop = true;
            this.iconWarningRadioBt.Text = "Warning";
            this.iconWarningRadioBt.UseVisualStyleBackColor = true;
            // 
            // iconInfoRadioBt
            // 
            this.iconInfoRadioBt.AutoSize = true;
            this.iconInfoRadioBt.Checked = true;
            this.iconInfoRadioBt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iconInfoRadioBt.Location = new System.Drawing.Point(9, 19);
            this.iconInfoRadioBt.Name = "iconInfoRadioBt";
            this.iconInfoRadioBt.Size = new System.Drawing.Size(88, 19);
            this.iconInfoRadioBt.TabIndex = 3;
            this.iconInfoRadioBt.TabStop = true;
            this.iconInfoRadioBt.Text = "Information";
            this.iconInfoRadioBt.UseVisualStyleBackColor = true;
            // 
            // iconErrorRadioBt
            // 
            this.iconErrorRadioBt.AutoSize = true;
            this.iconErrorRadioBt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iconErrorRadioBt.Location = new System.Drawing.Point(253, 19);
            this.iconErrorRadioBt.Name = "iconErrorRadioBt";
            this.iconErrorRadioBt.Size = new System.Drawing.Size(50, 19);
            this.iconErrorRadioBt.TabIndex = 6;
            this.iconErrorRadioBt.TabStop = true;
            this.iconErrorRadioBt.Text = "Error";
            this.iconErrorRadioBt.UseVisualStyleBackColor = true;
            // 
            // iconQuestionRadioBt
            // 
            this.iconQuestionRadioBt.AutoSize = true;
            this.iconQuestionRadioBt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iconQuestionRadioBt.Location = new System.Drawing.Point(103, 19);
            this.iconQuestionRadioBt.Name = "iconQuestionRadioBt";
            this.iconQuestionRadioBt.Size = new System.Drawing.Size(73, 19);
            this.iconQuestionRadioBt.TabIndex = 4;
            this.iconQuestionRadioBt.TabStop = true;
            this.iconQuestionRadioBt.Text = "Question";
            this.iconQuestionRadioBt.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 15);
            this.label2.TabIndex = 161;
            this.label2.Text = "Enter the message box\'s body:";
            // 
            // titleTxt
            // 
            this.titleTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTxt.Enabled = false;
            this.titleTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.titleTxt.Location = new System.Drawing.Point(9, 59);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(411, 23);
            this.titleTxt.TabIndex = 158;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 15);
            this.label1.TabIndex = 160;
            this.label1.Text = "Enter the message box\'s title:";
            // 
            // bodyTxt
            // 
            this.bodyTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bodyTxt.Enabled = false;
            this.bodyTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bodyTxt.Location = new System.Drawing.Point(9, 101);
            this.bodyTxt.Multiline = true;
            this.bodyTxt.Name = "bodyTxt";
            this.bodyTxt.Size = new System.Drawing.Size(411, 125);
            this.bodyTxt.TabIndex = 159;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ShowMsgBoxCheckBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bodyTxt);
            this.groupBox1.Controls.Add(this.titleTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 234);
            this.groupBox1.TabIndex = 168;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MessageBox";
            // 
            // iconGroup
            // 
            this.iconGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconGroup.Controls.Add(this.button1);
            this.iconGroup.Controls.Add(this.iconInfoRadioBt);
            this.iconGroup.Controls.Add(this.iconQuestionRadioBt);
            this.iconGroup.Controls.Add(this.iconWarningRadioBt);
            this.iconGroup.Controls.Add(this.iconErrorRadioBt);
            this.iconGroup.Enabled = false;
            this.iconGroup.Location = new System.Drawing.Point(0, 234);
            this.iconGroup.Name = "iconGroup";
            this.iconGroup.Size = new System.Drawing.Size(428, 46);
            this.iconGroup.TabIndex = 169;
            this.iconGroup.TabStop = false;
            this.iconGroup.Text = "Icon";
            // 
            // optionsGroup
            // 
            this.optionsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsGroup.Controls.Add(this.checkBox1);
            this.optionsGroup.Enabled = false;
            this.optionsGroup.Location = new System.Drawing.Point(0, 281);
            this.optionsGroup.Name = "optionsGroup";
            this.optionsGroup.Size = new System.Drawing.Size(428, 43);
            this.optionsGroup.TabIndex = 170;
            this.optionsGroup.TabStop = false;
            this.optionsGroup.Text = "Options";
            // 
            // create_stub_DisplayMsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.optionsGroup);
            this.Controls.Add(this.iconGroup);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "create_stub_DisplayMsgBox";
            this.Size = new System.Drawing.Size(428, 324);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.iconGroup.ResumeLayout(false);
            this.iconGroup.PerformLayout();
            this.optionsGroup.ResumeLayout(false);
            this.optionsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion



    }
}
