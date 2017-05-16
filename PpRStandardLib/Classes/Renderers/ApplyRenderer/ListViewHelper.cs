using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace ListViewHelper
{
    class ListViewHelper
    {

        #region columns context menu
        private Rectangle _headerRect;

        // This returns an array of ColumnHeaders in the order they are
        // displayed by the ListView.  
        //private static ColumnHeader[] GetOrderedHeaders(ListViewHelper lv)
        //{
            //ColumnHeader[] arr = new ColumnHeader[lv.Columns.Count];

            //foreach (ColumnHeader header in lv.Columns)
            //{
            //    arr[header.DisplayIndex] = header;
            //}

            //return arr;
        //}

        // Called when the user right-clicks anywhere in the ListView, including the
        // header bar.  It displays the appropriate context menu for the data row or
        // header that was right-clicked. 
        private void regularListViewMenu_Opening(object sender, CancelEventArgs e)
        {
            // This call indirectly calls EnumWindowCallBack which sets _headerRect
            // to the area occupied by the ListView's header bar.
            //            EnumChildWindows(ServicesListView.Handle, new EnumWinCallBack(EnumWindowCallBack), IntPtr.Zero);

            // If the mouse position is in the header bar, cancel the display
            // of the regular context menu and display the column header context menu instead.
            if (_headerRect.Contains(Control.MousePosition))
            {
                e.Cancel = true;

                // The xoffset is how far the mouse is from the left edge of the header.
                int xoffset = Control.MousePosition.X - _headerRect.Left;

                // Iterate through the column headers in the order they are displayed, adding up
                // their widths as we go.  When the sum exceeds the xoffset, we know the mouse
                // is on the current header. 
                int sum = 0;
                //                foreach (ColumnHeader header in GetOrderedHeaders(ServicesListView))
                {
                    //                    sum += header.Width;
                    if (sum > xoffset)
                    {
                        //                        HandleRightClickOnHeader(header);
                        //                        break;
                    }
                }
            }
            else
            {
                // Allow the regular context menu to be displayed.
                // We may want to update the menu here.
            }
        }

        // Called when the specified column header is right-clicked.
        private void HandleRightClickOnHeader(ColumnHeader header)
        {
            // We can do anything here, but most likely we want to 
            // display a context menu for the header.  This code
            // displays the same context menu for every header, but
            // changes the menu item text based on the header.
            // It sets the context menu tag to the specified header so the 
            // handler for whatever command the user clicks can know the column.
            //            ServicesColumsContext.Tag = header;
            //ServicesColumsContext.Show(Control.MousePosition);
        }


        // This should get called with the only child window of the ListView,
        // which should be the header bar.
        private bool EnumWindowCallBack(IntPtr hwnd, IntPtr lParam)
        {
            // Determine the rectangle of the ListView header bar and save it in _headerRect.
            RECT rct;

            if (!GetWindowRect(hwnd, out rct))
            {
                _headerRect = Rectangle.Empty;
            }
            else
            {
                _headerRect = new Rectangle(rct.Left, rct.Top, rct.Right - rct.Left, rct.Bottom - rct.Top);
            }

            return false; // Stop the enum
        }


        // Delegate that is called for each child window of the ListView.
        private delegate bool EnumWinCallBack(IntPtr hwnd, IntPtr lParam);

        // Calls EnumWinCallBack for each child window of hWndParent (i.e. the ListView).
        [DllImport("user32.Dll")]
        private static extern int EnumChildWindows(IntPtr hWndParent, EnumWinCallBack callBackFunc, IntPtr lParam);

        // Gets the bounding rectangle of the specified window (ListView header bar).
        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }
        #endregion


    }
}
