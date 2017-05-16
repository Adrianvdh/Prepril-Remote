namespace PpRStandardLib.Controls
{
    partial class LogEventsListView
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
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.roundCornerPanel3 = new CSharpCustomPanelControl.RoundCornerPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.roundCornerPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3,
            this.menuItem1,
            this.menuItem4,
            this.menuItem5,
            this.menuItem6,
            this.menuItem2});
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.menuItem3.Text = "Cut";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.menuItem1.Text = "Copy";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Shortcut = System.Windows.Forms.Shortcut.Del;
            this.menuItem4.Text = "Delete";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 3;
            this.menuItem5.Text = "-";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 4;
            this.menuItem6.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftC;
            this.menuItem6.Text = "Clear All";
            // 
            // menuItem2
            // 
            this.menuItem2.Checked = true;
            this.menuItem2.Index = 5;
            this.menuItem2.Text = "Auto-scroll";
            // 
            // roundCornerPanel3
            // 
            this.roundCornerPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.roundCornerPanel3.BorderColor = System.Drawing.Color.Gray;
            this.roundCornerPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundCornerPanel3.Controls.Add(this.richTextBox1);
            this.roundCornerPanel3.Curvature = 1;
            this.roundCornerPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundCornerPanel3.Location = new System.Drawing.Point(0, 0);
            this.roundCornerPanel3.Name = "roundCornerPanel3";
            this.roundCornerPanel3.Size = new System.Drawing.Size(545, 313);
            this.roundCornerPanel3.TabIndex = 101;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.AutoWordSelection = true;
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Location = new System.Drawing.Point(1, 1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(542, 310);
            this.richTextBox1.TabIndex = 91;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            // 
            // LogEventsListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roundCornerPanel3);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "LogEventsListView";
            this.Size = new System.Drawing.Size(545, 313);
            this.Load += new System.EventHandler(this.LogEventsListView_Load);
            this.roundCornerPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem2;
        private CSharpCustomPanelControl.RoundCornerPanel roundCornerPanel3;
        private System.Windows.Forms.RichTextBox richTextBox1;

    }
}
