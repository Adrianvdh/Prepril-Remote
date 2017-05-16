using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PpRStandardLib.Controls
{
    public partial class TextBoxExtended : Component
    {
        private TextBox textBox;
        private MenuItem UndoMenuItem;
        private MenuItem RedoMenuItem;
        private MenuItem ContextSeparator1;
        private MenuItem CutTextMenuItem;
        private MenuItem CopyTextMenuItem;
        private MenuItem PasteTextMenuItem;
        private MenuItem DeleteTextMenuItem;
        private MenuItem ContextSeparator2;
        private MenuItem SelectAllTextMenuItem;
        private MenuItem ContextSeparator3;
        private MenuItem UppercaseMenuItem;
        private MenuItem LowercaseMenuItem;
        private ContextMenu contextMenu;
    
        public TextBoxExtended()
        {

        }



        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.UndoMenuItem = new System.Windows.Forms.MenuItem();
            this.RedoMenuItem = new System.Windows.Forms.MenuItem();
            this.ContextSeparator1 = new System.Windows.Forms.MenuItem();
            this.CutTextMenuItem = new System.Windows.Forms.MenuItem();
            this.CopyTextMenuItem = new System.Windows.Forms.MenuItem();
            this.PasteTextMenuItem = new System.Windows.Forms.MenuItem();
            this.DeleteTextMenuItem = new System.Windows.Forms.MenuItem();
            this.ContextSeparator2 = new System.Windows.Forms.MenuItem();
            this.SelectAllTextMenuItem = new System.Windows.Forms.MenuItem();
            this.ContextSeparator3 = new System.Windows.Forms.MenuItem();
            this.UppercaseMenuItem = new System.Windows.Forms.MenuItem();
            this.LowercaseMenuItem = new System.Windows.Forms.MenuItem();
            this.contextMenu = new System.Windows.Forms.ContextMenu();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(0, 0);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 20);
            this.textBox.TabIndex = 0;
            // 
            // UndoMenuItem
            // 
            this.UndoMenuItem.Index = -1;
            this.UndoMenuItem.Text = "Undo";
            // 
            // RedoMenuItem
            // 
            this.RedoMenuItem.Index = -1;
            this.RedoMenuItem.Text = "Redo";
            // 
            // ContextSeparator1
            // 
            this.ContextSeparator1.Index = -1;
            this.ContextSeparator1.Text = "-";
            // 
            // CutTextMenuItem
            // 
            this.CutTextMenuItem.Index = -1;
            this.CutTextMenuItem.Text = "Cut";
            // 
            // CopyTextMenuItem
            // 
            this.CopyTextMenuItem.Index = -1;
            this.CopyTextMenuItem.Text = "Copy";
            // 
            // PasteTextMenuItem
            // 
            this.PasteTextMenuItem.Index = -1;
            this.PasteTextMenuItem.Text = "Paste";
            // 
            // DeleteTextMenuItem
            // 
            this.DeleteTextMenuItem.Index = -1;
            this.DeleteTextMenuItem.Text = "Delete";
            // 
            // ContextSeparator2
            // 
            this.ContextSeparator2.Index = -1;
            this.ContextSeparator2.Text = "-";
            // 
            // SelectAllTextMenuItem
            // 
            this.SelectAllTextMenuItem.Index = -1;
            this.SelectAllTextMenuItem.Text = "Select All";
            // 
            // ContextSeparator3
            // 
            this.ContextSeparator3.Index = -1;
            this.ContextSeparator3.Text = "-";
            // 
            // UppercaseMenuItem
            // 
            this.UppercaseMenuItem.Index = -1;
            this.UppercaseMenuItem.Text = "UPPERCASE";
            // 
            // LowercaseMenuItem
            // 
            this.LowercaseMenuItem.Index = -1;
            this.LowercaseMenuItem.Text = "lowercase";

        }


    }
}
