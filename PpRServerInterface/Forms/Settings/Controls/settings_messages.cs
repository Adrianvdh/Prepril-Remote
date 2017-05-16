using System;
using System.Windows.Forms;
using Configuration;

namespace Configuration.Controls
{
    public class settings_messages : OptionsBaseControl
    //public partial class settings_messages : UserControl
    {
        public settings_messages(string configName) : base(configName)
        {
            InitializeComponent();
        }

        private TextBox textBox1;
        private Label label1;
        private Label label2;


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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 54);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(343, 158);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Custome welcome message:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(22, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 59);
            this.label2.TabIndex = 2;
            this.label2.Text = "Format specifiers:\r\n";
            // 
            // settings_messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "settings_messages";
            this.Size = new System.Drawing.Size(435, 325);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

    }
}
