using System;
using System.Drawing;
using System.Windows.Forms;
using Configuration;
using PpRBuilder.Forms;

namespace PpRBuilder.Controls
{
    public class create_stub_AssemblyBinding : OptionsBaseControl
    //public partial class create_stub_AssemblyBinding : UserControl
    {
        public create_stub_AssemblyBinding(string configName) : base(configName)
        {
            InitializeComponent();
        }

        private void AddCertificateButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        private void AvailableCertificatesButton_Click(object sender, EventArgs e)
        {
            var Form = new AvailableCertificates();
            Form.ShowDialog(this);
            Form.Dispose();
        }

        private void SignAssemblyCertificateCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (SignAssemblyCertificateCheckBox.Checked)
            {
                label49.Enabled = true;
                label35.Enabled = true; 
                label66.Enabled = true;
                label65.Enabled = true;
                label64.Enabled = true;
                label63.Enabled = true;
                panel1.Enabled = true;
            }
            else
            {
                label49.Enabled = false;
                label35.Enabled = false;
                label66.Enabled = false;
                label65.Enabled = false;
                label64.Enabled = false;
                label63.Enabled = false;
                panel1.Enabled = false;
            }
        }
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox10;
        private Label label6;
        private TextBox textBox9;
        private Label label11;
        private Label label63;
        private Label label64;
        private Label label65;
        private Label label66;
        private Label label49;
        private Label label35;
        private TextBox textBox20;
        private Label label9;
        private Panel panel1;
        private Button AvailableCertificatesButton;
        private Button ClearButton;
        private Button AddCertificateButton;
        private CheckBox SignAssemblyCertificateCheckBox;
        private Label label8;
        private Label label10;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox3;
        private Label label3;

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
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AvailableCertificatesButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AddCertificateButton = new System.Windows.Forms.Button();
            this.SignAssemblyCertificateCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox11.Location = new System.Drawing.Point(205, 176);
            this.textBox11.MaxLength = 5;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(35, 23);
            this.textBox11.TabIndex = 201;
            this.textBox11.Text = "0";
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox12.Location = new System.Drawing.Point(164, 176);
            this.textBox12.MaxLength = 5;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(35, 23);
            this.textBox12.TabIndex = 200;
            this.textBox12.Text = "0";
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox13.Location = new System.Drawing.Point(123, 176);
            this.textBox13.MaxLength = 5;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(35, 23);
            this.textBox13.TabIndex = 199;
            this.textBox13.Text = "0";
            // 
            // textBox10
            // 
            this.textBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox10.Location = new System.Drawing.Point(81, 147);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(308, 23);
            this.textBox10.TabIndex = 197;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(5, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 196;
            this.label6.Text = "Trademark:";
            // 
            // textBox9
            // 
            this.textBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox9.Location = new System.Drawing.Point(81, 60);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(308, 23);
            this.textBox9.TabIndex = 195;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label11.Location = new System.Drawing.Point(5, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 15);
            this.label11.TabIndex = 194;
            this.label11.Text = "Company:";
            // 
            // label63
            // 
            this.label63.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label63.Enabled = false;
            this.label63.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label63.Location = new System.Drawing.Point(78, 268);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(311, 14);
            this.label63.TabIndex = 193;
            this.label63.Text = "(none)";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Enabled = false;
            this.label64.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label64.Location = new System.Drawing.Point(5, 268);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(67, 15);
            this.label64.TabIndex = 192;
            this.label64.Text = "Valid From:";
            // 
            // label65
            // 
            this.label65.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label65.Enabled = false;
            this.label65.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label65.Location = new System.Drawing.Point(78, 249);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(311, 14);
            this.label65.TabIndex = 191;
            this.label65.Text = "(none)";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Enabled = false;
            this.label66.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label66.Location = new System.Drawing.Point(5, 249);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(59, 15);
            this.label66.TabIndex = 190;
            this.label66.Text = "Issued By:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Enabled = false;
            this.label49.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label49.Location = new System.Drawing.Point(5, 230);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(60, 15);
            this.label49.TabIndex = 189;
            this.label49.Text = "Issued To:";
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label35.Enabled = false;
            this.label35.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label35.Location = new System.Drawing.Point(78, 230);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(311, 14);
            this.label35.TabIndex = 188;
            this.label35.Text = "(none)";
            // 
            // textBox20
            // 
            this.textBox20.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox20.Location = new System.Drawing.Point(81, 176);
            this.textBox20.MaxLength = 5;
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(35, 23);
            this.textBox20.TabIndex = 198;
            this.textBox20.Text = "1";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Location = new System.Drawing.Point(0, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(428, 2);
            this.label9.TabIndex = 187;
            this.label9.Text = "label9";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AvailableCertificatesButton);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.AddCertificateButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 30);
            this.panel1.TabIndex = 186;
            // 
            // AvailableCertificatesButton
            // 
            this.AvailableCertificatesButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AvailableCertificatesButton.Location = new System.Drawing.Point(184, 3);
            this.AvailableCertificatesButton.Name = "AvailableCertificatesButton";
            this.AvailableCertificatesButton.Size = new System.Drawing.Size(125, 23);
            this.AvailableCertificatesButton.TabIndex = 2;
            this.AvailableCertificatesButton.Text = "Available Certificates";
            this.AvailableCertificatesButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClearButton.Location = new System.Drawing.Point(103, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // AddCertificateButton
            // 
            this.AddCertificateButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddCertificateButton.Location = new System.Drawing.Point(3, 3);
            this.AddCertificateButton.Name = "AddCertificateButton";
            this.AddCertificateButton.Size = new System.Drawing.Size(94, 23);
            this.AddCertificateButton.TabIndex = 0;
            this.AddCertificateButton.Text = "Add Certificate";
            this.AddCertificateButton.UseVisualStyleBackColor = true;
            // 
            // SignAssemblyCertificateCheckBox
            // 
            this.SignAssemblyCertificateCheckBox.AutoSize = true;
            this.SignAssemblyCertificateCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SignAssemblyCertificateCheckBox.Location = new System.Drawing.Point(5, 207);
            this.SignAssemblyCertificateCheckBox.Name = "SignAssemblyCertificateCheckBox";
            this.SignAssemblyCertificateCheckBox.Size = new System.Drawing.Size(364, 19);
            this.SignAssemblyCertificateCheckBox.TabIndex = 185;
            this.SignAssemblyCertificateCheckBox.Text = "Sign Application with certificate (.exe Windows Executable Only)";
            this.SignAssemblyCertificateCheckBox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.Location = new System.Drawing.Point(2, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(422, 2);
            this.label8.TabIndex = 184;
            this.label8.Text = "label8";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label10.Location = new System.Drawing.Point(2, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(422, 2);
            this.label10.TabIndex = 183;
            this.label10.Text = "label10";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.Location = new System.Drawing.Point(81, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 23);
            this.textBox1.TabIndex = 175;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 174;
            this.label2.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(5, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 176;
            this.label1.Text = "Description:";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox4.Location = new System.Drawing.Point(81, 118);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(308, 23);
            this.textBox4.TabIndex = 181;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(5, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 180;
            this.label4.Text = "Copyright:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox2.Location = new System.Drawing.Point(81, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(308, 23);
            this.textBox2.TabIndex = 177;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(5, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 182;
            this.label5.Text = "Version:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox3.Location = new System.Drawing.Point(81, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(308, 23);
            this.textBox3.TabIndex = 179;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(5, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 178;
            this.label3.Text = "Product:";
            // 
            // create_stub_AssemblyBinding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label63);
            this.Controls.Add(this.label64);
            this.Controls.Add(this.label65);
            this.Controls.Add(this.label66);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SignAssemblyCertificateCheckBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "create_stub_AssemblyBinding";
            this.Size = new System.Drawing.Size(428, 324);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion




    }
}
