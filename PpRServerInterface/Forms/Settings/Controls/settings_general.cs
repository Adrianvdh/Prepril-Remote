using System;
using System.Drawing;
using System.Windows.Forms;
using Configuration;

namespace Configuration.Controls
{
    public class settings_general : OptionsBaseControl
    //public class settings_general : UserControl
    {
        public settings_general(string configName) : base(configName)
        {
            InitializeComponent();
        }

        private void settings_general_Load(object sender, EventArgs e)
        {
            //comboBox1.SelectedIndex = 0;
        }

        private CheckBox checkBox2;
        private Label label1;
        private ComboBox comboBox1;
        private wyDay.Controls.LinkLabel2 linkLabel21;
        private Label label2;
        private CheckBox checkBox1;


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
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.linkLabel21 = new wyDay.Controls.LinkLabel2();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 74);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(128, 19);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Start with Windows";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Language:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // linkLabel21
            // 
            this.linkLabel21.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabel21.HoverColor = System.Drawing.Color.Empty;
            this.linkLabel21.Location = new System.Drawing.Point(177, 24);
            this.linkLabel21.Name = "linkLabel21";
            this.linkLabel21.RegularColor = System.Drawing.Color.Empty;
            this.linkLabel21.Size = new System.Drawing.Size(81, 16);
            this.linkLabel21.TabIndex = 4;
            this.linkLabel21.Text = "Get Latest List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Windows Integration";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 99);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 19);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Start Minimized";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // settings_general
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel21);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "settings_general";
            this.Size = new System.Drawing.Size(435, 325);
            this.Load += new System.EventHandler(this.settings_general_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion




    }
}
