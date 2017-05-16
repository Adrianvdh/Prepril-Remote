using System;
using System.Windows.Forms;
using CenterParentMsgBox;
using Configuration;

namespace Configuration.Controls
{
    public class settings_admin : OptionsBaseControl
    //public partial class settings_admin : UserControl
    {

        private int adminPort = 14517;

        private bool hasAdminPswd = false;
        private bool changeAdminPswd = false;
        private String adminPswd;
        public settings_admin(string configName) : base(configName)
        {
            InitializeComponent();

            PortTxt.Text = adminPort.ToString();

        }

        private void settings_admin_Load(object sender, EventArgs e)
        {

        }
        private void chkbxChngPswd_CheckedChanged(object sender, EventArgs e)
        {
            //Change password checkbox
            pswdtxt1.Enabled = !changeAdminPswd;
            pswdtxt2.Enabled = !changeAdminPswd;
            setPswdBtn.Enabled = !changeAdminPswd;

            changeAdminPswd = !changeAdminPswd;
        }

        private void setPswdBtn_Click(object sender, EventArgs e)
        {
            if (pswdtxt1.Equals(pswdtxt2))
            {
                MsgBox.Show("Your new password has been set!", "Password Set", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MsgBox.Show("These passwords don't match!\nPlease try again.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            
        }

        private Button setPswdBtn;
        private Label label1;
        private TextBox PortTxt;
        private Label label2;
        private Label label3;
        private CheckBox chkbxChngPswd;
        private TextBox pswdtxt2;
        private Label label7;
        private TextBox pswdtxt1;
        private Label label6;
        private Panel panel1;
        private Label label4;
        private Panel panel2;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label8;


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
            this.label1 = new System.Windows.Forms.Label();
            this.PortTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkbxChngPswd = new System.Windows.Forms.CheckBox();
            this.pswdtxt2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pswdtxt1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.setPswdBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listening Port:";
            // 
            // PortTxt
            // 
            this.PortTxt.Location = new System.Drawing.Point(92, 64);
            this.PortTxt.Name = "PortTxt";
            this.PortTxt.Size = new System.Drawing.Size(53, 23);
            this.PortTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Important";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(429, 40);
            this.label3.TabIndex = 1;
            this.label3.Text = "Admin settings can only be changed from local connections, otherwise this page wi" +
    "ll be ignored by the server.";
            // 
            // chkbxChngPswd
            // 
            this.chkbxChngPswd.AutoSize = true;
            this.chkbxChngPswd.Location = new System.Drawing.Point(6, 211);
            this.chkbxChngPswd.Name = "chkbxChngPswd";
            this.chkbxChngPswd.Size = new System.Drawing.Size(157, 19);
            this.chkbxChngPswd.TabIndex = 9;
            this.chkbxChngPswd.Text = "Change admin password";
            this.chkbxChngPswd.UseVisualStyleBackColor = true;
            this.chkbxChngPswd.CheckedChanged += new System.EventHandler(this.chkbxChngPswd_CheckedChanged);
            // 
            // pswdtxt2
            // 
            this.pswdtxt2.Enabled = false;
            this.pswdtxt2.Location = new System.Drawing.Point(162, 20);
            this.pswdtxt2.Name = "pswdtxt2";
            this.pswdtxt2.Size = new System.Drawing.Size(150, 23);
            this.pswdtxt2.TabIndex = 14;
            this.pswdtxt2.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Retype new password:";
            // 
            // pswdtxt1
            // 
            this.pswdtxt1.Enabled = false;
            this.pswdtxt1.Location = new System.Drawing.Point(6, 20);
            this.pswdtxt1.Name = "pswdtxt1";
            this.pswdtxt1.Size = new System.Drawing.Size(150, 23);
            this.pswdtxt1.TabIndex = 12;
            this.pswdtxt1.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "New password:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.setPswdBtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pswdtxt2);
            this.panel1.Controls.Add(this.pswdtxt1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(20, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 49);
            this.panel1.TabIndex = 10;
            // 
            // setPswdBtn
            // 
            this.setPswdBtn.Enabled = false;
            this.setPswdBtn.Location = new System.Drawing.Point(318, 19);
            this.setPswdBtn.Name = "setPswdBtn";
            this.setPswdBtn.Size = new System.Drawing.Size(75, 23);
            this.setPswdBtn.TabIndex = 16;
            this.setPswdBtn.Text = "Set";
            this.setPswdBtn.UseVisualStyleBackColor = true;
            this.setPswdBtn.Click += new System.EventHandler(this.setPswdBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(413, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "Minimum password lenght is 8 characters. Leave empty to remove password.\r\nPasswor" +
    "d is required for remote connections.";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(3, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 112);
            this.panel2.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(217, 38);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox5.Size = new System.Drawing.Size(205, 67);
            this.textBox5.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(217, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 35);
            this.label8.TabIndex = 7;
            this.label8.Text = "IP addresses which are allowed to connect:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 38);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(205, 67);
            this.textBox4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 35);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bind the following IP addresses:";
            // 
            // settings_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkbxChngPswd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PortTxt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "settings_admin";
            this.Size = new System.Drawing.Size(435, 325);
            this.Load += new System.EventHandler(this.settings_admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        

        

        

    }
}
