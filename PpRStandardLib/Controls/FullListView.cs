using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PpRStandardLib.Controls
{
	public partial class FullListView : ListView
	{

        #region Remove dotted line
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		private const int WM_CHANGEUISTATE = 0x127;
		private const int UIS_SET = 1;
		private const int UISF_HIDEFOCUS = 0x1;

		public FullListView()
		{
			//this.View = View.Details;
			this.FullRowSelect = true;

			// removes the ugly dotted line around focused item
        SendMessage(this.Handle, WM_CHANGEUISTATE, MakeLong(UIS_SET, UISF_HIDEFOCUS), 0);
		}

		private int MakeLong(int wLow, int wHigh)
		{
			int low = (int)IntLoWord(wLow);
			short high = IntLoWord(wHigh);
			int product = 0x10000 * (int)high;
			int mkLong = (int)(low | product);
			return mkLong;
		}

		private short IntLoWord(int word)
		{
			return (short)(word & short.MaxValue);
		}
        #endregion

        #region Properties
		[Category("Explorer Theme"), Description("Renders Windows Explorer theme.")]
		public bool ExplorerTheme
		{
            get { return locked; }
            set
            {
                locked = value;
            }
		}
		
        [Category("Explorer Theme MultiSelect"), Description("Renders MultiSelect to the Windows Explorer theme.")]
        public bool ExplorerThemeMultiSelect
        {
            get { return locked; }
            set
            {
                locked = value;
            }
        }

        [Category("ItemContextMenu"), Description("")]
        public bool ItemContextMenuStrip
        {
            get { return locked; }
            set
            {
                locked = value;
            }
        }

        #region LockColumnSize
        private HeaderControl hdrCtrl = null;
        private bool locked = false;
        /// <summary>
        /// Property to turn on and off the ability to size the column headers.
        /// </summary>
        [Category("Behavior"), Description("Prevent sizing of column headers.")]
        public bool LockColumnSize
        {
            get { return locked; }
            set
            {
                locked = value;
            }
        }
        #endregion
        #endregion

        #region Lock Column
        /// <summary>
		/// Notify message header structure.
		/// </summary>
		[StructLayout(LayoutKind.Sequential)]
			private struct NMHDR
		{
			public IntPtr hwndFrom;
			public int idFrom;
			public int code;
		} //NMHDR

		/// <summary>
		/// Class used to capture window messages for the header of the list view
		/// control.  
		/// </summary>
		private class HeaderControl : NativeWindow
		{
            private FullListView parentListView = null;

			[DllImport("User32.dll",CharSet = CharSet.Auto,SetLastError=true)]
			public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

            public HeaderControl(FullListView m)
			{
				parentListView = m;
				//Get the header control handle
				IntPtr header = SendMessage(m.Handle, 
					(0x1000+31), IntPtr.Zero, IntPtr.Zero);
				this.AssignHandle(header);                
			} //constructor HeaderControl()

			protected override void WndProc(ref Message message)
			{
				const int WM_LBUTTONDBLCLK = 0x0203;
				const int WM_SETCURSOR = 0x0020;
				bool callBase = true;

				switch ( message.Msg )
				{
				case WM_LBUTTONDBLCLK:                    
				case WM_SETCURSOR:
					if(parentListView.LockColumnSize)
					{
						//Don't change cursor to sizing cursor.  Also ignore
						//double click, which sizes the column to fit the data.
						message.Result = (IntPtr)1;	//Return TRUE from message handler
						callBase = false;		//Don't call the base class.
					} //if
					break;
				} //switch

				if(callBase)
				{
					// pass messages on to the base control for processing
					base.WndProc( ref message ) ;
				} //if
			} //WndProc()
		} //class HeaderControl


		/// <summary>
		/// When the control is created capture the messages for the header. 
		/// </summary>
		protected override void OnCreateControl()
		{
			//First actually create the control.
			base.OnCreateControl();

			//Now create the HeaderControl class to handle the customization of
			//the header messages.
			hdrCtrl = new HeaderControl(this);
		} //OnCreateControl()

		/// <summary>
		/// Capture CTRL+ to prevent resize of all columns.
		/// </summary>
		/// <param name="e"></param>
		protected override void OnKeyDown(KeyEventArgs e)
		{
			if(e.KeyValue==107 && e.Modifiers==Keys.Control && locked)
			{
				e.Handled = true;
			}
			else
			{
				base.OnKeyDown (e);
			} //if
		} //OnKeyDown()


		
		/// <summary>
		/// Capture messages for the list view control.
		/// </summary>
		/// <param name="message"></param>
		protected override void WndProc( ref Message message )
		{
			const int WM_NOTIFY = 0x004E;
			const int HDN_FIRST = (0-300);
			const int HDN_BEGINTRACKA = (HDN_FIRST-6);
			const int HDN_BEGINTRACKW = (HDN_FIRST-26);
			bool callBase = true;

			switch ( message.Msg )
			{
			case WM_NOTIFY:
				NMHDR nmhdr = (NMHDR)message.GetLParam(typeof(NMHDR));
				switch(nmhdr.code)
				{
				case HDN_BEGINTRACKA:  //Process both ANSI and
				case HDN_BEGINTRACKW:  //UNICODE versions of the message.
					if(locked)
					{
						//Discard the begin tracking to prevent dragging of the 
						//column headers.
						message.Result = (IntPtr)1;
						callBase = false;
					} //if
					break ;
				} //switch
				break;
			} //switch

			if(callBase)
			{
				// pass messages on to the base control for processing
				base.WndProc( ref message ) ;
			} //if
		} //WndProc()


        #endregion
    }
}
