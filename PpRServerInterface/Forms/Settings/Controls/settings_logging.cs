using System;
using System.Windows.Forms;
using Configuration;

namespace Configuration.Controls
{
    public class settings_logging : OptionsBaseControl
    //public partial class settings_logging : UserControl
    {
        private bool LogtoFile = true;
        private bool LimitLogSize = false;
        private bool delAfterDays = false;

        private int logSizeKB = 150;
        private int delOldDays = 31;

        public settings_logging(string configName) : base(configName)
        {
            InitializeComponent();

            textBox3.Text = logSizeKB.ToString();
            textBox1.Text = delOldDays.ToString();

            //Enable logging checkbox
            chkbxEnblLg.Checked = true;

            //Use different log file radio button
            rdBtnDffLgFl.Checked = true;
        }

        private void settings_logging_Load(object sender, EventArgs e)
        {

        }

        private void chkbxEnblLg_CheckedChanged(object sender, EventArgs e)
        {
            //Enable logging to file checkbox
            pnlLmtSz.Enabled = LogtoFile;
            pnlLgFl.Enabled = LogtoFile;
            pnlLgStyl.Enabled = LogtoFile;

            LogtoFile = !LogtoFile;
        }

        private void chkbxLmtSz_CheckedChanged(object sender, EventArgs e)
        {
            //Limit log file size checkbox
            textBox3.Enabled = !LimitLogSize;
            label18.Enabled = !LimitLogSize;

            LimitLogSize = !LimitLogSize;
        }

        private void rdBtnLogSnglFl_CheckedChanged(object sender, EventArgs e)
        {
            //Log all to single file
            chkbxdelAftrDys.Enabled = false;
            textBox1.Enabled = false;
            label6.Enabled = false;
        }

        private void rdBtnDffLgFl_CheckedChanged(object sender, EventArgs e)
        {
            //Log to different file
            chkbxdelAftrDys.Enabled = true;
            
            textBox1.Enabled = delAfterDays;
            label6.Enabled = delAfterDays;
        }

        private void chkbxdelAftrDys_CheckedChanged(object sender, EventArgs e)
        {
            //Delete after certain days
            textBox1.Enabled = !delAfterDays;
            label6.Enabled = !delAfterDays;

            delAfterDays = !delAfterDays;
        }

        private CheckBox chkbxdelAftrDys;
        private Label label1;
        private Label label2;
        private RadioButton rdBtnLogSnglFl;
        private RadioButton rdBtnDffLgFl;
        private Label label4;
        private Label label6;
        private TextBox textBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel pnlLmtSz;
        private Panel pnlLgFl;
        private Panel pnlLgStyl;

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
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.chkbxLmtSz = new System.Windows.Forms.CheckBox();
            this.chkbxEnblLg = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdBtnLogSnglFl = new System.Windows.Forms.RadioButton();
            this.rdBtnDffLgFl = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlLmtSz = new System.Windows.Forms.Panel();
            this.pnlLgFl = new System.Windows.Forms.Panel();
            this.chkbxdelAftrDys = new System.Windows.Forms.CheckBox();
            this.pnlLgStyl = new System.Windows.Forms.Panel();
            this.pnlLmtSz.SuspendLayout();
            this.pnlLgFl.SuspendLayout();
            this.pnlLgStyl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 15);
            this.label11.TabIndex = 52;
            this.label11.Text = "&Error text colour:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 15);
            this.label10.TabIndex = 50;
            this.label10.Text = "&Success text colour:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 15);
            this.label9.TabIndex = 48;
            this.label9.Text = "&Message text colour:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 46;
            this.label3.Text = "&Title text colour:";
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button12.Location = new System.Drawing.Point(573, 132);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(29, 23);
            this.button12.TabIndex = 31;
            this.button12.Text = "...";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Enabled = false;
            this.label18.Location = new System.Drawing.Point(190, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 15);
            this.label18.TabIndex = 6;
            this.label18.Text = "KB";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(131, 0);
            this.textBox3.MaxLength = 6;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(53, 23);
            this.textBox3.TabIndex = 5;
            // 
            // chkbxLmtSz
            // 
            this.chkbxLmtSz.AutoSize = true;
            this.chkbxLmtSz.Location = new System.Drawing.Point(0, 2);
            this.chkbxLmtSz.Name = "chkbxLmtSz";
            this.chkbxLmtSz.Size = new System.Drawing.Size(128, 19);
            this.chkbxLmtSz.TabIndex = 4;
            this.chkbxLmtSz.Text = "Limit log file size to";
            this.chkbxLmtSz.UseVisualStyleBackColor = true;
            this.chkbxLmtSz.CheckedChanged += new System.EventHandler(this.chkbxLmtSz_CheckedChanged);
            // 
            // chkbxEnblLg
            // 
            this.chkbxEnblLg.AutoSize = true;
            this.chkbxEnblLg.Location = new System.Drawing.Point(9, 23);
            this.chkbxEnblLg.Name = "chkbxEnblLg";
            this.chkbxEnblLg.Size = new System.Drawing.Size(138, 19);
            this.chkbxEnblLg.TabIndex = 2;
            this.chkbxEnblLg.Text = "Enable logging to file";
            this.chkbxEnblLg.UseVisualStyleBackColor = true;
            this.chkbxEnblLg.CheckedChanged += new System.EventHandler(this.chkbxEnblLg_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "File allocations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Log text style";
            // 
            // rdBtnLogSnglFl
            // 
            this.rdBtnLogSnglFl.AutoSize = true;
            this.rdBtnLogSnglFl.Location = new System.Drawing.Point(1, 1);
            this.rdBtnLogSnglFl.Name = "rdBtnLogSnglFl";
            this.rdBtnLogSnglFl.Size = new System.Drawing.Size(223, 19);
            this.rdBtnLogSnglFl.TabIndex = 53;
            this.rdBtnLogSnglFl.TabStop = true;
            this.rdBtnLogSnglFl.Text = "Log all to single file (includes Header)";
            this.rdBtnLogSnglFl.UseVisualStyleBackColor = true;
            this.rdBtnLogSnglFl.CheckedChanged += new System.EventHandler(this.rdBtnLogSnglFl_CheckedChanged);
            // 
            // rdBtnDffLgFl
            // 
            this.rdBtnDffLgFl.AutoSize = true;
            this.rdBtnDffLgFl.Location = new System.Drawing.Point(1, 26);
            this.rdBtnDffLgFl.Name = "rdBtnDffLgFl";
            this.rdBtnDffLgFl.Size = new System.Drawing.Size(300, 19);
            this.rdBtnDffLgFl.TabIndex = 54;
            this.rdBtnDffLgFl.TabStop = true;
            this.rdBtnDffLgFl.Text = "Use a different log file each day (prs-2013-08-25.log)";
            this.rdBtnDffLgFl.UseVisualStyleBackColor = true;
            this.rdBtnDffLgFl.CheckedChanged += new System.EventHandler(this.rdBtnDffLgFl_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 55;
            this.label4.Text = "Log file";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(233, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 58;
            this.label6.Text = "days";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(174, 49);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 23);
            this.textBox1.TabIndex = 57;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(124, 1);
            this.panel1.MaximumSize = new System.Drawing.Size(50, 22);
            this.panel1.MinimumSize = new System.Drawing.Size(50, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 22);
            this.panel1.TabIndex = 59;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(124, 29);
            this.panel2.MaximumSize = new System.Drawing.Size(50, 22);
            this.panel2.MinimumSize = new System.Drawing.Size(50, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 22);
            this.panel2.TabIndex = 60;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lime;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(124, 58);
            this.panel3.MaximumSize = new System.Drawing.Size(50, 22);
            this.panel3.MinimumSize = new System.Drawing.Size(50, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(50, 22);
            this.panel3.TabIndex = 61;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(124, 86);
            this.panel4.MaximumSize = new System.Drawing.Size(50, 22);
            this.panel4.MinimumSize = new System.Drawing.Size(50, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 22);
            this.panel4.TabIndex = 62;
            // 
            // pnlLmtSz
            // 
            this.pnlLmtSz.Controls.Add(this.chkbxLmtSz);
            this.pnlLmtSz.Controls.Add(this.textBox3);
            this.pnlLmtSz.Controls.Add(this.label18);
            this.pnlLmtSz.Location = new System.Drawing.Point(9, 45);
            this.pnlLmtSz.Name = "pnlLmtSz";
            this.pnlLmtSz.Size = new System.Drawing.Size(223, 23);
            this.pnlLmtSz.TabIndex = 63;
            // 
            // pnlLgFl
            // 
            this.pnlLgFl.Controls.Add(this.chkbxdelAftrDys);
            this.pnlLgFl.Controls.Add(this.rdBtnLogSnglFl);
            this.pnlLgFl.Controls.Add(this.rdBtnDffLgFl);
            this.pnlLgFl.Controls.Add(this.textBox1);
            this.pnlLgFl.Controls.Add(this.label6);
            this.pnlLgFl.Location = new System.Drawing.Point(9, 97);
            this.pnlLgFl.Name = "pnlLgFl";
            this.pnlLgFl.Size = new System.Drawing.Size(302, 76);
            this.pnlLgFl.TabIndex = 64;
            // 
            // chkbxdelAftrDys
            // 
            this.chkbxdelAftrDys.AutoSize = true;
            this.chkbxdelAftrDys.Location = new System.Drawing.Point(20, 51);
            this.chkbxdelAftrDys.Name = "chkbxdelAftrDys";
            this.chkbxdelAftrDys.Size = new System.Drawing.Size(150, 19);
            this.chkbxdelAftrDys.TabIndex = 59;
            this.chkbxdelAftrDys.Text = "Delete old log files after";
            this.chkbxdelAftrDys.UseVisualStyleBackColor = true;
            this.chkbxdelAftrDys.CheckedChanged += new System.EventHandler(this.chkbxdelAftrDys_CheckedChanged);
            // 
            // pnlLgStyl
            // 
            this.pnlLgStyl.Controls.Add(this.label3);
            this.pnlLgStyl.Controls.Add(this.label9);
            this.pnlLgStyl.Controls.Add(this.label10);
            this.pnlLgStyl.Controls.Add(this.panel4);
            this.pnlLgStyl.Controls.Add(this.label11);
            this.pnlLgStyl.Controls.Add(this.panel3);
            this.pnlLgStyl.Controls.Add(this.panel1);
            this.pnlLgStyl.Controls.Add(this.panel2);
            this.pnlLgStyl.Location = new System.Drawing.Point(9, 200);
            this.pnlLgStyl.Name = "pnlLgStyl";
            this.pnlLgStyl.Size = new System.Drawing.Size(184, 110);
            this.pnlLgStyl.TabIndex = 65;
            // 
            // settings_logging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlLgStyl);
            this.Controls.Add(this.pnlLgFl);
            this.Controls.Add(this.pnlLmtSz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkbxEnblLg);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "settings_logging";
            this.Size = new System.Drawing.Size(435, 325);
            this.Load += new System.EventHandler(this.settings_logging_Load);
            this.pnlLmtSz.ResumeLayout(false);
            this.pnlLmtSz.PerformLayout();
            this.pnlLgFl.ResumeLayout(false);
            this.pnlLgFl.PerformLayout();
            this.pnlLgStyl.ResumeLayout(false);
            this.pnlLgStyl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Label label11;
        private Label label10;
        private Label label9;
        private Label label3;
        private Button button12;
        private Label label18;
        private TextBox textBox3;
        private CheckBox chkbxLmtSz;
        private CheckBox chkbxEnblLg;

        

        
        

        
        



    }
}
