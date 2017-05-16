using System;
using System.Windows.Forms;
using Configuration;

namespace Configuration.Controls
{
    public class settings_advanced : OptionsBaseControl
    //public partial class settings_advanced : UserControl
    {
        public settings_advanced(string configName) : base(configName)
        {
            InitializeComponent();
        }
        private void settings_advanced_Load(object sender, EventArgs e)
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
            this.SuspendLayout();
            // 
            // settings_advanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "settings_advanced";
            this.Size = new System.Drawing.Size(435, 325);
            this.Load += new System.EventHandler(this.settings_advanced_Load);
            this.ResumeLayout(false);

        }
        #endregion



    }
}
