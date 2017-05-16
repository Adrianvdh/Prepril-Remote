using System;
using System.Windows.Forms;
using Configuration;

namespace Configuration.Controls
{
    public class conf_template : OptionsBaseControl
    //public partial class conf_template : UserControl
    {
        private System.ComponentModel.Container components = null;
        public conf_template(string configName) : base(configName)
        {
            InitializeComponent();
        }


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
            // 
            // settings_general
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "conf_template";
            this.Size = new System.Drawing.Size(150, 150);
            this.ResumeLayout(false);

        }
        #endregion

    }
}
