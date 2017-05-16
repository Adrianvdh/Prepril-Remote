using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Configuration;
using Configuration.Controls;

namespace PpRServerInterface.Forms
{
    public partial class ServerSetup : Form
    {
        public ServerSetup()
        {
            InitializeComponent();

        }

        private void ServerSetup_Load(object sender, EventArgs e)
        {


        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.m_mainPanel = new System.Windows.Forms.Panel();
            this.m_okBtn = new System.Windows.Forms.Button();
            this.m_cancelBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.roundCornerPanel1 = new CSharpCustomPanelControl.RoundCornerPanel();
            this.SuspendLayout();
            // 
            // m_mainPanel
            // 
            this.m_mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_mainPanel.Location = new System.Drawing.Point(151, 7);
            this.m_mainPanel.Name = "m_mainPanel";
            this.m_mainPanel.Size = new System.Drawing.Size(415, 336);
            this.m_mainPanel.TabIndex = 83;
            // 
            // m_okBtn
            // 
            this.m_okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_okBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.m_okBtn.Location = new System.Drawing.Point(330, 357);
            this.m_okBtn.Name = "m_okBtn";
            this.m_okBtn.Size = new System.Drawing.Size(75, 23);
            this.m_okBtn.TabIndex = 85;
            this.m_okBtn.Text = "Previous";
            this.m_okBtn.UseVisualStyleBackColor = true;
            // 
            // m_cancelBtn
            // 
            this.m_cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_cancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.m_cancelBtn.Location = new System.Drawing.Point(411, 357);
            this.m_cancelBtn.Name = "m_cancelBtn";
            this.m_cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.m_cancelBtn.TabIndex = 86;
            this.m_cancelBtn.Text = "Next";
            this.m_cancelBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(0, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(573, 2);
            this.label3.TabIndex = 89;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(492, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 91;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // roundCornerPanel1
            // 
            this.roundCornerPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.roundCornerPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundCornerPanel1.Curvature = 1;
            this.roundCornerPanel1.Location = new System.Drawing.Point(7, 7);
            this.roundCornerPanel1.Name = "roundCornerPanel1";
            this.roundCornerPanel1.Size = new System.Drawing.Size(138, 336);
            this.roundCornerPanel1.TabIndex = 92;
            // 
            // ServerSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 386);
            this.Controls.Add(this.roundCornerPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_okBtn);
            this.Controls.Add(this.m_cancelBtn);
            this.Controls.Add(this.m_mainPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServerSetup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Server Setup";
            this.ResumeLayout(false);

        }
        #endregion

        private System.ComponentModel.Container components = null;

        private System.Windows.Forms.Button m_okBtn;
        private System.Windows.Forms.Button m_cancelBtn;
        private Panel m_mainPanel;
        private System.Windows.Forms.Label label3;
        private CSharpCustomPanelControl.RoundCornerPanel roundCornerPanel1;
        private Button button1;

    }
}
