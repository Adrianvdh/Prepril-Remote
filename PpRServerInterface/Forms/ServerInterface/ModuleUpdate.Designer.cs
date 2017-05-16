namespace PpRServerInterface.Forms
{
    partial class ModuleUpdate
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
            this.TtlLbl = new System.Windows.Forms.Label();
            this.CnlBtn = new System.Windows.Forms.Button();
            this.PrcdBtn = new System.Windows.Forms.Button();
            this.DwnZIPChkbx = new System.Windows.Forms.RadioButton();
            this.DwnMSIChkbx = new System.Windows.Forms.RadioButton();
            this.RplcBinChkbx = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.newverLbl = new System.Windows.Forms.Label();
            this.instverLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ChngLgLnk = new wyDay.Controls.LinkLabel2();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TtlLbl
            // 
            this.TtlLbl.AutoSize = true;
            this.TtlLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TtlLbl.Location = new System.Drawing.Point(3, 3);
            this.TtlLbl.Name = "TtlLbl";
            this.TtlLbl.Size = new System.Drawing.Size(279, 30);
            this.TtlLbl.TabIndex = 15;
            this.TtlLbl.Text = "A new version of Prepril Server Interface is available!\r\nThe details are as follo" +
    "ws:";
            // 
            // CnlBtn
            // 
            this.CnlBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CnlBtn.DialogResult = System.Windows.Forms.DialogResult.No;
            this.CnlBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CnlBtn.Location = new System.Drawing.Point(258, 221);
            this.CnlBtn.Name = "CnlBtn";
            this.CnlBtn.Size = new System.Drawing.Size(75, 23);
            this.CnlBtn.TabIndex = 13;
            this.CnlBtn.Text = "Cancel";
            this.CnlBtn.UseVisualStyleBackColor = true;
            this.CnlBtn.Click += new System.EventHandler(this.CnlBtn_Click);
            // 
            // PrcdBtn
            // 
            this.PrcdBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PrcdBtn.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.PrcdBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PrcdBtn.Location = new System.Drawing.Point(177, 221);
            this.PrcdBtn.Name = "PrcdBtn";
            this.PrcdBtn.Size = new System.Drawing.Size(75, 23);
            this.PrcdBtn.TabIndex = 12;
            this.PrcdBtn.Text = "Proceed";
            this.PrcdBtn.UseVisualStyleBackColor = true;
            this.PrcdBtn.Click += new System.EventHandler(this.PrcdBtn_Click);
            // 
            // DwnZIPChkbx
            // 
            this.DwnZIPChkbx.AutoSize = true;
            this.DwnZIPChkbx.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.DwnZIPChkbx.Location = new System.Drawing.Point(3, 83);
            this.DwnZIPChkbx.Name = "DwnZIPChkbx";
            this.DwnZIPChkbx.Size = new System.Drawing.Size(318, 34);
            this.DwnZIPChkbx.TabIndex = 5;
            this.DwnZIPChkbx.Text = "Download ZIP Archive.\r\nThis option requires you to deploy the binaries yourself.";
            this.DwnZIPChkbx.UseVisualStyleBackColor = true;
            // 
            // DwnMSIChkbx
            // 
            this.DwnMSIChkbx.AutoSize = true;
            this.DwnMSIChkbx.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.DwnMSIChkbx.Location = new System.Drawing.Point(3, 43);
            this.DwnMSIChkbx.Name = "DwnMSIChkbx";
            this.DwnMSIChkbx.Size = new System.Drawing.Size(232, 34);
            this.DwnMSIChkbx.TabIndex = 4;
            this.DwnMSIChkbx.Text = "Download MSI Installer.\r\nThis option may require system reboot.";
            this.DwnMSIChkbx.UseVisualStyleBackColor = true;
            // 
            // RplcBinChkbx
            // 
            this.RplcBinChkbx.AutoSize = true;
            this.RplcBinChkbx.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RplcBinChkbx.Checked = true;
            this.RplcBinChkbx.Location = new System.Drawing.Point(3, 3);
            this.RplcBinChkbx.Name = "RplcBinChkbx";
            this.RplcBinChkbx.Size = new System.Drawing.Size(282, 34);
            this.RplcBinChkbx.TabIndex = 3;
            this.RplcBinChkbx.TabStop = true;
            this.RplcBinChkbx.Text = "Download and replace binaries (Recommended).\r\nQuick and easy to do.";
            this.RplcBinChkbx.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.DwnZIPChkbx, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DwnMSIChkbx, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.RplcBinChkbx, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 91);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(327, 121);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Available version:";
            // 
            // newverLbl
            // 
            this.newverLbl.AutoSize = true;
            this.newverLbl.Location = new System.Drawing.Point(108, 42);
            this.newverLbl.Name = "newverLbl";
            this.newverLbl.Size = new System.Drawing.Size(40, 15);
            this.newverLbl.TabIndex = 25;
            this.newverLbl.Text = "0.0.0.0";
            // 
            // instverLbl
            // 
            this.instverLbl.AutoSize = true;
            this.instverLbl.Location = new System.Drawing.Point(108, 66);
            this.instverLbl.Name = "instverLbl";
            this.instverLbl.Size = new System.Drawing.Size(40, 15);
            this.instverLbl.TabIndex = 27;
            this.instverLbl.Text = "0.0.0.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Installed version:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Location = new System.Drawing.Point(0, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(340, 2);
            this.label10.TabIndex = 32;
            this.label10.Text = "label10";
            // 
            // ChngLgLnk
            // 
            this.ChngLgLnk.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ChngLgLnk.HoverColor = System.Drawing.Color.Empty;
            this.ChngLgLnk.Location = new System.Drawing.Point(261, 41);
            this.ChngLgLnk.Name = "ChngLgLnk";
            this.ChngLgLnk.RegularColor = System.Drawing.Color.Empty;
            this.ChngLgLnk.Size = new System.Drawing.Size(72, 16);
            this.ChngLgLnk.TabIndex = 33;
            this.ChngLgLnk.Text = "Change Log";
            this.ChngLgLnk.Click += new System.EventHandler(this.ChngLgLnk_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(0, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 2);
            this.label1.TabIndex = 34;
            this.label1.Text = "label1";
            // 
            // ModuleUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 251);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChngLgLnk);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.instverLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.newverLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TtlLbl);
            this.Controls.Add(this.CnlBtn);
            this.Controls.Add(this.PrcdBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModuleUpdate";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Available...";
            this.Load += new System.EventHandler(this.ModuleUpdate_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TtlLbl;
        private System.Windows.Forms.Button CnlBtn;
        private System.Windows.Forms.Button PrcdBtn;
        private System.Windows.Forms.RadioButton DwnZIPChkbx;
        private System.Windows.Forms.RadioButton DwnMSIChkbx;
        private System.Windows.Forms.RadioButton RplcBinChkbx;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label newverLbl;
        private System.Windows.Forms.Label instverLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private wyDay.Controls.LinkLabel2 ChngLgLnk;
        private System.Windows.Forms.Label label1;


    }
}