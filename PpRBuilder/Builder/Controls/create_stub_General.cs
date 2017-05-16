using System;
using System.Windows.Forms;
using Configuration;

namespace PpRBuilder.Controls
{
    public class create_stub_General : OptionsBaseControl
    //public partial class create_stub_General : UserControl
    {
        public create_stub_General(string configName) : base(configName)
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }
        

        private void ConnectionSeccurityPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
            if (ConnectionSeccurityPasswordCheckBox.Checked)
            {
                textBox1.Enabled = true;
                checkBox1.Enabled = true; 
            }
            else
            { 
                textBox1.Enabled = false;
                checkBox1.Enabled = false;
            }
             
        }

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ConnectionSeccurityPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBox1.Location = new System.Drawing.Point(249, 44);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 19);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Hide Characters";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(10, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 23);
            this.textBox1.TabIndex = 9;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // ConnectionSeccurityPasswordCheckBox
            // 
            this.ConnectionSeccurityPasswordCheckBox.AutoSize = true;
            this.ConnectionSeccurityPasswordCheckBox.Location = new System.Drawing.Point(6, 17);
            this.ConnectionSeccurityPasswordCheckBox.Name = "ConnectionSeccurityPasswordCheckBox";
            this.ConnectionSeccurityPasswordCheckBox.Size = new System.Drawing.Size(182, 19);
            this.ConnectionSeccurityPasswordCheckBox.TabIndex = 11;
            this.ConnectionSeccurityPasswordCheckBox.Text = "Require connection password";
            this.ConnectionSeccurityPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ConnectionSeccurityPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ConnectionSeccurityPasswordCheckBox_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox2.Location = new System.Drawing.Point(10, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(331, 23);
            this.textBox2.TabIndex = 51;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "Mutex:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(23, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 60;
            this.label3.Text = "Build Type:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Distribution",
            "Module Update"});
            this.comboBox1.Location = new System.Drawing.Point(27, 215);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 23);
            this.comboBox1.TabIndex = 59;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBox2.Location = new System.Drawing.Point(168, 217);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(129, 19);
            this.checkBox2.TabIndex = 61;
            this.checkBox2.Text = "Submit to Server (*)";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBox3.Location = new System.Drawing.Point(7, 175);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(104, 19);
            this.checkBox3.TabIndex = 62;
            this.checkBox3.Text = "Add Password ";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 50;
            this.toolTip1.ShowAlways = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 63;
            this.button1.Text = "Random";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConnectionSeccurityPasswordCheckBox);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 75);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Password";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(0, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 69);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mutex:";
            // 
            // create_stub_General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "create_stub_General";
            this.Size = new System.Drawing.Size(428, 324);
            this.Load += new System.EventHandler(this.General_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void General_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox ConnectionSeccurityPasswordCheckBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ToolTip toolTip1;
        private Button button1;
        
    }
}
