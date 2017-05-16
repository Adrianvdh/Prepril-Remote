using PpRStandardLib.Controls;
namespace MsgBox_Client
{
    partial class SendMsgBox
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendMsgBox));
            this.label1 = new System.Windows.Forms.Label();
            this.BodyTxtbx = new System.Windows.Forms.TextBox();
            this.TitleTxtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iconInfoRadioBt = new System.Windows.Forms.RadioButton();
            this.iconErrorRadioBt = new System.Windows.Forms.RadioButton();
            this.iconQuestionRadioBt = new System.Windows.Forms.RadioButton();
            this.iconWarningRadioBt = new System.Windows.Forms.RadioButton();
            this.IconGroupBox = new System.Windows.Forms.GroupBox();
            this.ButtonsGroupBox = new System.Windows.Forms.GroupBox();
            this.BtYesNoCancelRadioBt = new System.Windows.Forms.RadioButton();
            this.BtYesNoRadioBt = new System.Windows.Forms.RadioButton();
            this.BtOKRadioBt = new System.Windows.Forms.RadioButton();
            this.SendBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.TextMenu = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.ResetMenu = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.MsgBoxAppearanceGroupBox = new System.Windows.Forms.GroupBox();
            this.CancelBtComboBox = new System.Windows.Forms.ComboBox();
            this.NoBtComboBox = new System.Windows.Forms.ComboBox();
            this.YesBtComboBox = new System.Windows.Forms.ComboBox();
            this.OKBtComboBox = new System.Windows.Forms.ComboBox();
            this.OkBtLabel = new System.Windows.Forms.Label();
            this.CancelBtLabel = new System.Windows.Forms.Label();
            this.YesBtLabel = new System.Windows.Forms.Label();
            this.NoBtLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PreviewBtn = new System.Windows.Forms.Button();
            this.msgProPanel = new PpRStandardLib.Controls.ProjectPanel();
            this.IconGroupBox.SuspendLayout();
            this.ButtonsGroupBox.SuspendLayout();
            this.MsgBoxAppearanceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(4, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the message title to send to the Stubs(s):";
            // 
            // BodyTxtbx
            // 
            this.BodyTxtbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BodyTxtbx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BodyTxtbx.Location = new System.Drawing.Point(7, 101);
            this.BodyTxtbx.Multiline = true;
            this.BodyTxtbx.Name = "BodyTxtbx";
            this.BodyTxtbx.Size = new System.Drawing.Size(308, 181);
            this.BodyTxtbx.TabIndex = 3;
            // 
            // TitleTxtbx
            // 
            this.TitleTxtbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTxtbx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TitleTxtbx.Location = new System.Drawing.Point(7, 57);
            this.TitleTxtbx.Name = "TitleTxtbx";
            this.TitleTxtbx.Size = new System.Drawing.Size(308, 23);
            this.TitleTxtbx.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(4, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter the message body to send to the Stubs(s):";
            // 
            // iconInfoRadioBt
            // 
            this.iconInfoRadioBt.AutoSize = true;
            this.iconInfoRadioBt.Checked = true;
            this.iconInfoRadioBt.Location = new System.Drawing.Point(7, 19);
            this.iconInfoRadioBt.Name = "iconInfoRadioBt";
            this.iconInfoRadioBt.Size = new System.Drawing.Size(88, 19);
            this.iconInfoRadioBt.TabIndex = 0;
            this.iconInfoRadioBt.TabStop = true;
            this.iconInfoRadioBt.Text = "Information";
            this.iconInfoRadioBt.UseVisualStyleBackColor = true;
            this.iconInfoRadioBt.CheckedChanged += new System.EventHandler(this.iconInfoRadioBt_CheckedChanged);
            // 
            // iconErrorRadioBt
            // 
            this.iconErrorRadioBt.AutoSize = true;
            this.iconErrorRadioBt.Location = new System.Drawing.Point(7, 42);
            this.iconErrorRadioBt.Name = "iconErrorRadioBt";
            this.iconErrorRadioBt.Size = new System.Drawing.Size(50, 19);
            this.iconErrorRadioBt.TabIndex = 3;
            this.iconErrorRadioBt.TabStop = true;
            this.iconErrorRadioBt.Text = "Error";
            this.iconErrorRadioBt.UseVisualStyleBackColor = true;
            this.iconErrorRadioBt.CheckedChanged += new System.EventHandler(this.iconErrorRadioBt_CheckedChanged);
            // 
            // iconQuestionRadioBt
            // 
            this.iconQuestionRadioBt.AutoSize = true;
            this.iconQuestionRadioBt.Location = new System.Drawing.Point(101, 19);
            this.iconQuestionRadioBt.Name = "iconQuestionRadioBt";
            this.iconQuestionRadioBt.Size = new System.Drawing.Size(73, 19);
            this.iconQuestionRadioBt.TabIndex = 2;
            this.iconQuestionRadioBt.TabStop = true;
            this.iconQuestionRadioBt.Text = "Question";
            this.iconQuestionRadioBt.UseVisualStyleBackColor = true;
            this.iconQuestionRadioBt.CheckedChanged += new System.EventHandler(this.iconQuestionRadioBt_CheckedChanged);
            // 
            // iconWarningRadioBt
            // 
            this.iconWarningRadioBt.AutoSize = true;
            this.iconWarningRadioBt.Location = new System.Drawing.Point(180, 19);
            this.iconWarningRadioBt.Name = "iconWarningRadioBt";
            this.iconWarningRadioBt.Size = new System.Drawing.Size(70, 19);
            this.iconWarningRadioBt.TabIndex = 3;
            this.iconWarningRadioBt.TabStop = true;
            this.iconWarningRadioBt.Text = "Warning";
            this.iconWarningRadioBt.UseVisualStyleBackColor = true;
            this.iconWarningRadioBt.CheckedChanged += new System.EventHandler(this.iconWarningRadioBt_CheckedChanged);
            // 
            // IconGroupBox
            // 
            this.IconGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IconGroupBox.Controls.Add(this.iconWarningRadioBt);
            this.IconGroupBox.Controls.Add(this.iconInfoRadioBt);
            this.IconGroupBox.Controls.Add(this.iconQuestionRadioBt);
            this.IconGroupBox.Controls.Add(this.iconErrorRadioBt);
            this.IconGroupBox.Location = new System.Drawing.Point(6, 15);
            this.IconGroupBox.Name = "IconGroupBox";
            this.IconGroupBox.Size = new System.Drawing.Size(252, 67);
            this.IconGroupBox.TabIndex = 5;
            this.IconGroupBox.TabStop = false;
            this.IconGroupBox.Text = "Icon";
            // 
            // ButtonsGroupBox
            // 
            this.ButtonsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsGroupBox.Controls.Add(this.BtYesNoCancelRadioBt);
            this.ButtonsGroupBox.Controls.Add(this.BtYesNoRadioBt);
            this.ButtonsGroupBox.Controls.Add(this.BtOKRadioBt);
            this.ButtonsGroupBox.Location = new System.Drawing.Point(6, 82);
            this.ButtonsGroupBox.Name = "ButtonsGroupBox";
            this.ButtonsGroupBox.Size = new System.Drawing.Size(252, 45);
            this.ButtonsGroupBox.TabIndex = 6;
            this.ButtonsGroupBox.TabStop = false;
            this.ButtonsGroupBox.Text = "Buttons";
            // 
            // BtYesNoCancelRadioBt
            // 
            this.BtYesNoCancelRadioBt.AutoSize = true;
            this.BtYesNoCancelRadioBt.Location = new System.Drawing.Point(121, 19);
            this.BtYesNoCancelRadioBt.Name = "BtYesNoCancelRadioBt";
            this.BtYesNoCancelRadioBt.Size = new System.Drawing.Size(105, 19);
            this.BtYesNoCancelRadioBt.TabIndex = 2;
            this.BtYesNoCancelRadioBt.Text = "Yes/No/Cancel";
            this.BtYesNoCancelRadioBt.UseVisualStyleBackColor = true;
            this.BtYesNoCancelRadioBt.CheckedChanged += new System.EventHandler(this.BtYesNoCancelRadioBt_CheckedChanged);
            // 
            // BtYesNoRadioBt
            // 
            this.BtYesNoRadioBt.AutoSize = true;
            this.BtYesNoRadioBt.Location = new System.Drawing.Point(53, 19);
            this.BtYesNoRadioBt.Name = "BtYesNoRadioBt";
            this.BtYesNoRadioBt.Size = new System.Drawing.Size(64, 19);
            this.BtYesNoRadioBt.TabIndex = 1;
            this.BtYesNoRadioBt.Text = "Yes/No";
            this.BtYesNoRadioBt.UseVisualStyleBackColor = true;
            this.BtYesNoRadioBt.CheckedChanged += new System.EventHandler(this.BtYesNoRadioBt_CheckedChanged);
            // 
            // BtOKRadioBt
            // 
            this.BtOKRadioBt.AutoSize = true;
            this.BtOKRadioBt.Checked = true;
            this.BtOKRadioBt.Location = new System.Drawing.Point(7, 19);
            this.BtOKRadioBt.Name = "BtOKRadioBt";
            this.BtOKRadioBt.Size = new System.Drawing.Size(41, 19);
            this.BtOKRadioBt.TabIndex = 0;
            this.BtOKRadioBt.TabStop = true;
            this.BtOKRadioBt.Text = "OK";
            this.BtOKRadioBt.UseVisualStyleBackColor = true;
            this.BtOKRadioBt.CheckedChanged += new System.EventHandler(this.BtOKRadioBt_CheckedChanged);
            // 
            // SendBtn
            // 
            this.SendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SendBtn.Location = new System.Drawing.Point(429, 295);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(75, 23);
            this.SendBtn.TabIndex = 17;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CancelBtn.Location = new System.Drawing.Point(510, 295);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 18;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.TextMenu,
            this.ResetMenu});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem5,
            this.menuItem4,
            this.menuItem6,
            this.menuItem7});
            this.menuItem1.Text = "File";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 0;
            this.menuItem5.Text = "Export Project";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.Text = "Import Project";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 2;
            this.menuItem6.Text = "-";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 3;
            this.menuItem7.Text = "Exit";
            // 
            // TextMenu
            // 
            this.TextMenu.Index = 1;
            this.TextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem3});
            this.TextMenu.Text = "Mode";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.RadioCheck = true;
            this.menuItem2.Text = "Save";
            // 
            // menuItem3
            // 
            this.menuItem3.Checked = true;
            this.menuItem3.Index = 1;
            this.menuItem3.RadioCheck = true;
            this.menuItem3.Text = "Load";
            // 
            // ResetMenu
            // 
            this.ResetMenu.Index = 2;
            this.ResetMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem13,
            this.menuItem14});
            this.ResetMenu.Text = "Saved";
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 0;
            this.menuItem13.Text = "Delete Save";
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 1;
            this.menuItem14.Text = "Delete All";
            // 
            // MsgBoxAppearanceGroupBox
            // 
            this.MsgBoxAppearanceGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MsgBoxAppearanceGroupBox.Controls.Add(this.CancelBtComboBox);
            this.MsgBoxAppearanceGroupBox.Controls.Add(this.NoBtComboBox);
            this.MsgBoxAppearanceGroupBox.Controls.Add(this.YesBtComboBox);
            this.MsgBoxAppearanceGroupBox.Controls.Add(this.OKBtComboBox);
            this.MsgBoxAppearanceGroupBox.Controls.Add(this.OkBtLabel);
            this.MsgBoxAppearanceGroupBox.Controls.Add(this.CancelBtLabel);
            this.MsgBoxAppearanceGroupBox.Controls.Add(this.YesBtLabel);
            this.MsgBoxAppearanceGroupBox.Controls.Add(this.NoBtLabel);
            this.MsgBoxAppearanceGroupBox.Controls.Add(this.IconGroupBox);
            this.MsgBoxAppearanceGroupBox.Controls.Add(this.ButtonsGroupBox);
            this.MsgBoxAppearanceGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MsgBoxAppearanceGroupBox.Location = new System.Drawing.Point(321, 39);
            this.MsgBoxAppearanceGroupBox.Name = "MsgBoxAppearanceGroupBox";
            this.MsgBoxAppearanceGroupBox.Size = new System.Drawing.Size(264, 243);
            this.MsgBoxAppearanceGroupBox.TabIndex = 4;
            this.MsgBoxAppearanceGroupBox.TabStop = false;
            this.MsgBoxAppearanceGroupBox.Text = "MsgBox Appearance";
            // 
            // CancelBtComboBox
            // 
            this.CancelBtComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CancelBtComboBox.Enabled = false;
            this.CancelBtComboBox.FormattingEnabled = true;
            this.CancelBtComboBox.Items.AddRange(new object[] {
            "Nothing",
            "Execute Command",
            "Execute Script",
            "Lock",
            "Log Off",
            "Sleep",
            "Hibernate",
            "Restart",
            "Shutdown",
            "Cause BSOD"});
            this.CancelBtComboBox.Location = new System.Drawing.Point(104, 211);
            this.CancelBtComboBox.Name = "CancelBtComboBox";
            this.CancelBtComboBox.Size = new System.Drawing.Size(154, 23);
            this.CancelBtComboBox.TabIndex = 14;
            // 
            // NoBtComboBox
            // 
            this.NoBtComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoBtComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NoBtComboBox.Enabled = false;
            this.NoBtComboBox.FormattingEnabled = true;
            this.NoBtComboBox.Items.AddRange(new object[] {
            "Nothing",
            "Execute Command",
            "Execute Script",
            "Lock",
            "Log Off",
            "Sleep",
            "Hibernate",
            "Restart",
            "Shutdown",
            "Cause BSOD"});
            this.NoBtComboBox.Location = new System.Drawing.Point(104, 185);
            this.NoBtComboBox.Name = "NoBtComboBox";
            this.NoBtComboBox.Size = new System.Drawing.Size(154, 23);
            this.NoBtComboBox.TabIndex = 12;
            // 
            // YesBtComboBox
            // 
            this.YesBtComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YesBtComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YesBtComboBox.Enabled = false;
            this.YesBtComboBox.FormattingEnabled = true;
            this.YesBtComboBox.Items.AddRange(new object[] {
            "Nothing",
            "Execute Command",
            "Execute Script",
            "Lock",
            "Log Off",
            "Sleep",
            "Hibernate",
            "Restart",
            "Shutdown",
            "Cause BSOD"});
            this.YesBtComboBox.Location = new System.Drawing.Point(104, 159);
            this.YesBtComboBox.Name = "YesBtComboBox";
            this.YesBtComboBox.Size = new System.Drawing.Size(154, 23);
            this.YesBtComboBox.TabIndex = 10;
            // 
            // OKBtComboBox
            // 
            this.OKBtComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OKBtComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OKBtComboBox.FormattingEnabled = true;
            this.OKBtComboBox.Items.AddRange(new object[] {
            "Nothing",
            "Execute Command",
            "Execute Script",
            "Lock",
            "Log Off",
            "Sleep",
            "Hibernate",
            "Restart",
            "Shutdown",
            "Cause BSOD"});
            this.OKBtComboBox.Location = new System.Drawing.Point(104, 133);
            this.OKBtComboBox.Name = "OKBtComboBox";
            this.OKBtComboBox.Size = new System.Drawing.Size(154, 23);
            this.OKBtComboBox.TabIndex = 8;
            // 
            // OkBtLabel
            // 
            this.OkBtLabel.AutoSize = true;
            this.OkBtLabel.Location = new System.Drawing.Point(3, 136);
            this.OkBtLabel.Name = "OkBtLabel";
            this.OkBtLabel.Size = new System.Drawing.Size(75, 15);
            this.OkBtLabel.TabIndex = 7;
            this.OkBtLabel.Text = "\"OK\" Button:";
            // 
            // CancelBtLabel
            // 
            this.CancelBtLabel.AutoSize = true;
            this.CancelBtLabel.Enabled = false;
            this.CancelBtLabel.Location = new System.Drawing.Point(3, 214);
            this.CancelBtLabel.Name = "CancelBtLabel";
            this.CancelBtLabel.Size = new System.Drawing.Size(95, 15);
            this.CancelBtLabel.TabIndex = 13;
            this.CancelBtLabel.Text = "\"Cancel\" Button:";
            // 
            // YesBtLabel
            // 
            this.YesBtLabel.AutoSize = true;
            this.YesBtLabel.Enabled = false;
            this.YesBtLabel.Location = new System.Drawing.Point(3, 162);
            this.YesBtLabel.Name = "YesBtLabel";
            this.YesBtLabel.Size = new System.Drawing.Size(77, 15);
            this.YesBtLabel.TabIndex = 9;
            this.YesBtLabel.Text = "\"Yes\" Button:";
            // 
            // NoBtLabel
            // 
            this.NoBtLabel.AutoSize = true;
            this.NoBtLabel.Enabled = false;
            this.NoBtLabel.Location = new System.Drawing.Point(3, 188);
            this.NoBtLabel.Name = "NoBtLabel";
            this.NoBtLabel.Size = new System.Drawing.Size(75, 15);
            this.NoBtLabel.TabIndex = 11;
            this.NoBtLabel.Text = "\"No\" Button:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(0, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(592, 2);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            // 
            // PreviewBtn
            // 
            this.PreviewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PreviewBtn.Location = new System.Drawing.Point(348, 295);
            this.PreviewBtn.Name = "PreviewBtn";
            this.PreviewBtn.Size = new System.Drawing.Size(75, 23);
            this.PreviewBtn.TabIndex = 16;
            this.PreviewBtn.Text = "Preview";
            this.PreviewBtn.UseVisualStyleBackColor = true;
            this.PreviewBtn.Click += new System.EventHandler(this.PreviewBtn_Click);
            // 
            // msgProPanel
            // 
            this.msgProPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.msgProPanel.Location = new System.Drawing.Point(0, 0);
            this.msgProPanel.MinimumSize = new System.Drawing.Size(400, 37);
            this.msgProPanel.Name = "msgProPanel";
            this.msgProPanel.Size = new System.Drawing.Size(591, 37);
            this.msgProPanel.TabIndex = 33;
            // 
            // SendMsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 324);
            this.Controls.Add(this.msgProPanel);
            this.Controls.Add(this.PreviewBtn);
            this.Controls.Add(this.MsgBoxAppearanceGroupBox);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TitleTxtbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BodyTxtbx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(509, 269);
            this.Name = "SendMsgBox";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Message Box (Connection ID : 149901-08ZA1135)";
            this.Load += new System.EventHandler(this.StubMsgBox_Load);
            this.IconGroupBox.ResumeLayout(false);
            this.IconGroupBox.PerformLayout();
            this.ButtonsGroupBox.ResumeLayout(false);
            this.ButtonsGroupBox.PerformLayout();
            this.MsgBoxAppearanceGroupBox.ResumeLayout(false);
            this.MsgBoxAppearanceGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BodyTxtbx;
        private System.Windows.Forms.TextBox TitleTxtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton iconInfoRadioBt;
        private System.Windows.Forms.RadioButton iconErrorRadioBt;
        private System.Windows.Forms.RadioButton iconQuestionRadioBt;
        private System.Windows.Forms.RadioButton iconWarningRadioBt;
        private System.Windows.Forms.GroupBox IconGroupBox;
        private System.Windows.Forms.GroupBox ButtonsGroupBox;
        private System.Windows.Forms.RadioButton BtYesNoCancelRadioBt;
        private System.Windows.Forms.RadioButton BtYesNoRadioBt;
        private System.Windows.Forms.RadioButton BtOKRadioBt;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem TextMenu;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.GroupBox MsgBoxAppearanceGroupBox;
        private System.Windows.Forms.MenuItem ResetMenu;
        private System.Windows.Forms.MenuItem menuItem13;
        private System.Windows.Forms.MenuItem menuItem14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CancelBtComboBox;
        private System.Windows.Forms.ComboBox NoBtComboBox;
        private System.Windows.Forms.ComboBox YesBtComboBox;
        private System.Windows.Forms.ComboBox OKBtComboBox;
        private System.Windows.Forms.Label OkBtLabel;
        private System.Windows.Forms.Label CancelBtLabel;
        private System.Windows.Forms.Label YesBtLabel;
        private System.Windows.Forms.Label NoBtLabel;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.Button PreviewBtn;
        private ProjectPanel msgProPanel;
    }
}