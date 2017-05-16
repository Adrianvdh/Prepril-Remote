using System;
using System.Drawing;
using System.Windows.Forms;
using Configuration;

namespace PpRBuilder.Controls
{
    public class create_stub_SSLTLS : OptionsBaseControl
    //public partial class create_stub_SSLTLS : UserControl
    {
        public create_stub_SSLTLS(string configName) : base(configName)
        {
            InitializeComponent();
            
        }

        private void create_stub_SSLTLS_Load(object sender, EventArgs e)
        {

        }


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
            this.SuspendLayout();
            // 
            // create_stub_SSLTLS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "create_stub_SSLTLS";
            this.Size = new System.Drawing.Size(428, 324);
            this.Load += new System.EventHandler(this.create_stub_SSLTLS_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
