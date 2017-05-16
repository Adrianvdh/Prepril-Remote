namespace PpRStandardLib.Controls
{
    partial class splitContainer
    {
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
            this.roundCornerPanel2 = new CSharpCustomPanelControl.RoundCornerPanel();
            this.roundCornerPanel1 = new CSharpCustomPanelControl.RoundCornerPanel();
            this.SuspendLayout();
            // 
            // roundCornerPanel2
            // 
            this.roundCornerPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.roundCornerPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.roundCornerPanel2.BorderColor = System.Drawing.Color.Gray;
            this.roundCornerPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundCornerPanel2.Curvature = 1;
            this.roundCornerPanel2.Location = new System.Drawing.Point(239, 0);
            this.roundCornerPanel2.Name = "roundCornerPanel2";
            this.roundCornerPanel2.Size = new System.Drawing.Size(234, 315);
            this.roundCornerPanel2.TabIndex = 96;
            // 
            // roundCornerPanel1
            // 
            this.roundCornerPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.roundCornerPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.roundCornerPanel1.BorderColor = System.Drawing.Color.Gray;
            this.roundCornerPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundCornerPanel1.Curvature = 1;
            this.roundCornerPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundCornerPanel1.Name = "roundCornerPanel1";
            this.roundCornerPanel1.Size = new System.Drawing.Size(234, 315);
            this.roundCornerPanel1.TabIndex = 95;
            // 
            // splitContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roundCornerPanel2);
            this.Controls.Add(this.roundCornerPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "splitContainer";
            this.Size = new System.Drawing.Size(473, 315);
            this.Load += new System.EventHandler(this.splitContainer_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitContainer_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private CSharpCustomPanelControl.RoundCornerPanel roundCornerPanel1;
        private CSharpCustomPanelControl.RoundCornerPanel roundCornerPanel2;
    }
}
