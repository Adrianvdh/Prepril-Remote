using System;
using System.Windows.Forms;
using Configuration;

namespace Configuration.Controls
{
    public class settings_logging : OptionsBaseControl
    //public partial class settings_logging : UserControl
    {
        public settings_logging(string configName) : base(configName)
        {
            InitializeComponent();
        }

        private void settings_logging_Load(object sender, EventArgs e)
        {

        }

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
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.groupBox15.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.label11);
            this.groupBox15.Controls.Add(this.button7);
            this.groupBox15.Controls.Add(this.label10);
            this.groupBox15.Controls.Add(this.button6);
            this.groupBox15.Controls.Add(this.label9);
            this.groupBox15.Controls.Add(this.button2);
            this.groupBox15.Controls.Add(this.label3);
            this.groupBox15.Controls.Add(this.button17);
            this.groupBox15.Location = new System.Drawing.Point(3, 107);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(475, 133);
            this.groupBox15.TabIndex = 3;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Log text style";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 15);
            this.label11.TabIndex = 52;
            this.label11.Text = "&Error text colour:";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Red;
            this.button7.Location = new System.Drawing.Point(127, 102);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(25, 23);
            this.button7.TabIndex = 51;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 15);
            this.label10.TabIndex = 50;
            this.label10.Text = "&Success text colour:";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SpringGreen;
            this.button6.Location = new System.Drawing.Point(127, 73);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(25, 23);
            this.button6.TabIndex = 49;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 15);
            this.label9.TabIndex = 48;
            this.label9.Text = "&Message text colour:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(127, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 47;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 46;
            this.label3.Text = "&Title text colour:";
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.DodgerBlue;
            this.button17.Location = new System.Drawing.Point(127, 15);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(25, 23);
            this.button17.TabIndex = 2;
            this.button17.UseVisualStyleBackColor = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button12);
            this.groupBox9.Controls.Add(this.label18);
            this.groupBox9.Controls.Add(this.textBox4);
            this.groupBox9.Controls.Add(this.textBox3);
            this.groupBox9.Controls.Add(this.checkBox12);
            this.groupBox9.Controls.Add(this.checkBox9);
            this.groupBox9.Location = new System.Drawing.Point(3, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(475, 98);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "File allocations";
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button12.Location = new System.Drawing.Point(426, 43);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(29, 23);
            this.button12.TabIndex = 31;
            this.button12.Text = "...";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4.Location = new System.Drawing.Point(6, 44);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(414, 23);
            this.textBox4.TabIndex = 30;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(192, 74);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 15);
            this.label18.TabIndex = 6;
            this.label18.Text = "KB";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(137, 71);
            this.textBox3.MaxLength = 6;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(53, 23);
            this.textBox3.TabIndex = 5;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(6, 73);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(131, 19);
            this.checkBox12.TabIndex = 4;
            this.checkBox12.Text = "Limit log file size to:";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(6, 19);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(138, 19);
            this.checkBox9.TabIndex = 2;
            this.checkBox9.Text = "Enable logging to file";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // settings_logging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox15);
            this.Controls.Add(this.groupBox9);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "settings_logging";
            this.Size = new System.Drawing.Size(513, 348);
            this.Load += new System.EventHandler(this.settings_logging_Load);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private GroupBox groupBox15;
        private Label label11;
        private Button button7;
        private Label label10;
        private Button button6;
        private Label label9;
        private Button button2;
        private Label label3;
        private Button button17;
        private GroupBox groupBox9;
        private Button button12;
        private Label label18;
        private TextBox textBox4;
        private TextBox textBox3;
        private CheckBox checkBox12;
        private CheckBox checkBox9;
        
        



    }
}
