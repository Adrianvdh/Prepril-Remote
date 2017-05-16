using System;
using System.Drawing;
using System.Windows.Forms;
using Configuration;
using PpRServerInterface.Forms;

namespace Configuration.Controls
{
    public class settings_SSL : OptionsBaseControl
    //public partial class settings_SSL : UserControl
    {
        public settings_SSL(string configName) : base(configName)
        {
            InitializeComponent();
            
        }

        private void chkbxEnblSSL_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void genCertBtn_Click(object sender, EventArgs e)
        {
            var Form = new CreateCertificate();
            Form.ShowDialog(this);
            Form.Dispose();
        }

        private CheckBox chkbxEnblSSL;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Button genCertBtn;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Label label2;
        private Panel panel1;


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
            this.chkbxEnblSSL = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.genCertBtn = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkbxEnblSSL
            // 
            this.chkbxEnblSSL.AutoSize = true;
            this.chkbxEnblSSL.Location = new System.Drawing.Point(3, 3);
            this.chkbxEnblSSL.Name = "chkbxEnblSSL";
            this.chkbxEnblSSL.Size = new System.Drawing.Size(82, 19);
            this.chkbxEnblSSL.TabIndex = 0;
            this.chkbxEnblSSL.Text = "Enable SSL";
            this.chkbxEnblSSL.UseVisualStyleBackColor = true;
            this.chkbxEnblSSL.CheckedChanged += new System.EventHandler(this.chkbxEnblSSL_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 23);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Certificate";
            // 
            // genCertBtn
            // 
            this.genCertBtn.Location = new System.Drawing.Point(290, 299);
            this.genCertBtn.Name = "genCertBtn";
            this.genCertBtn.Size = new System.Drawing.Size(142, 23);
            this.genCertBtn.TabIndex = 4;
            this.genCertBtn.Text = "Generate new certificate";
            this.genCertBtn.UseVisualStyleBackColor = true;
            this.genCertBtn.Click += new System.EventHandler(this.genCertBtn_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 123);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(82, 19);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 148);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(82, 19);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 173);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(82, 19);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 75);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Location = new System.Drawing.Point(3, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 267);
            this.panel1.TabIndex = 9;
            // 
            // settings_SSL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.genCertBtn);
            this.Controls.Add(this.chkbxEnblSSL);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "settings_SSL";
            this.Size = new System.Drawing.Size(435, 325);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        

        
    }
}
