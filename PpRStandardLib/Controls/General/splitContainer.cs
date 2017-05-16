using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PpRStandardLib.Controls
{
    public partial class splitContainer : UserControl
    {
        public splitContainer()
        {
            InitializeComponent();
        }

        private void splitContainer_Load(object sender, EventArgs e)
        {

        }

        // Temp variable to store a previously focused control
        private Control focused = null;

        private void splitContainer_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the focused control before the splitter is focused
            focused = getFocused(this.Controls);
        }

        private Control getFocused(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                if (c.Focused)
                {
                    // Return the focused control
                    return c;
                }
                else if (c.ContainsFocus)
                {
                    // If the focus is contained inside a control's children
                    // return the child
                    return getFocused(c.Controls);
                }
            }
            // No control on the form has focus
            return null;
        }

        private void splitContainer_MouseUp(object sender, MouseEventArgs e)
        {
            // If a previous control had focus
            if (focused != null)
            {
                // Return focus and clear the temp variable for 
                // garbage collection
                focused.Focus();
                focused = null;
            }
        }



    }
}
