using System;
using System.Drawing;
using System.Windows.Forms;
using Configuration;

namespace PpRBuilder.Controls
{
    public class create_stub_Redistribution : OptionsBaseControl
    //public partial class create_stub_Redistribution : UserControl
    {
        public create_stub_Redistribution(string configName) : base(configName)
        {
            InitializeComponent();
        }

        private void Distribution_Load(object sender, EventArgs e)
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxTip = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTip)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 50;
            this.toolTip1.ShowAlways = true;
            // 
            // pictureBoxTip
            // 
            this.pictureBoxTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxTip.Image = global::PpRBuilder.Properties.Resources.information;
            this.pictureBoxTip.Location = new System.Drawing.Point(408, 5);
            this.pictureBoxTip.MaximumSize = new System.Drawing.Size(16, 16);
            this.pictureBoxTip.MinimumSize = new System.Drawing.Size(16, 16);
            this.pictureBoxTip.Name = "pictureBoxTip";
            this.pictureBoxTip.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxTip.TabIndex = 146;
            this.pictureBoxTip.TabStop = false;
            // 
            // create_stub_Redistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxTip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "create_stub_Redistribution";
            this.Size = new System.Drawing.Size(428, 324);
            this.Load += new System.EventHandler(this.Distribution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBoxTip;
    }
}
