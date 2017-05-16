namespace PpRClientInterface.Forms
{
    partial class AboutTb
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.comLbl = new wyDay.Controls.LinkLabel2();
            this.licLbl = new wyDay.Controls.LinkLabel2();
            this.verLbl = new wyDay.Controls.LinkLabel2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.comLbl);
            this.panel1.Controls.Add(this.licLbl);
            this.panel1.Controls.Add(this.verLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 58);
            this.panel1.TabIndex = 0;
            // 
            // comLbl
            // 
            this.comLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.comLbl.HoverColor = System.Drawing.Color.Empty;
            this.comLbl.Location = new System.Drawing.Point(328, 20);
            this.comLbl.Name = "comLbl";
            this.comLbl.RegularColor = System.Drawing.Color.Empty;
            this.comLbl.Size = new System.Drawing.Size(77, 16);
            this.comLbl.TabIndex = 2;
            this.comLbl.Text = "Components";
            this.comLbl.Click += new System.EventHandler(this.comLbl_Click);
            // 
            // licLbl
            // 
            this.licLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.licLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.licLbl.HoverColor = System.Drawing.Color.Empty;
            this.licLbl.Location = new System.Drawing.Point(186, 20);
            this.licLbl.Name = "licLbl";
            this.licLbl.RegularColor = System.Drawing.Color.Empty;
            this.licLbl.Size = new System.Drawing.Size(48, 16);
            this.licLbl.TabIndex = 1;
            this.licLbl.Text = "Licence";
            this.licLbl.Click += new System.EventHandler(this.licLbl_Click);
            // 
            // verLbl
            // 
            this.verLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.verLbl.HoverColor = System.Drawing.Color.Empty;
            this.verLbl.Location = new System.Drawing.Point(35, 20);
            this.verLbl.Name = "verLbl";
            this.verLbl.RegularColor = System.Drawing.Color.Empty;
            this.verLbl.Size = new System.Drawing.Size(47, 16);
            this.verLbl.TabIndex = 0;
            this.verLbl.Text = "Version";
            this.verLbl.Click += new System.EventHandler(this.verLbl_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 245);
            this.panel2.TabIndex = 1;
            // 
            // AboutTb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 303);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutTb";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutTb_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private wyDay.Controls.LinkLabel2 verLbl;
        private wyDay.Controls.LinkLabel2 comLbl;
        private wyDay.Controls.LinkLabel2 licLbl;
        private System.Windows.Forms.Panel panel2;
    }
}