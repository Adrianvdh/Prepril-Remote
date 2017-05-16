using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace EmbeddedCreations
{
	/// <summary>
	/// A customized list view that allows the column headers
	/// to be locked to prevent resizing.  The HeaderSizeLocked
	/// property turns on and off this functionality.  This property
	/// is active on the form designer.
	/// </summary>
    public class ColumnLockListView : FullListView
	{
		private HeaderControl hdrCtrl = null;
		private bool locked = false;

		/// <summary>
		/// Property to turn on and off the ability to size the column headers.
		/// </summary>
		[Category("Behavior"),Description("Prevent sizing of column headers.")]
		public bool LockColumnSize
		{
			get { return locked; }
			set
			{
				locked = value;
			}
		}

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
            private ColumnLockListView parentListView = null;

			[DllImport("User32.dll",CharSet = CharSet.Auto,SetLastError=true)]
			public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

            public HeaderControl(ColumnLockListView m)
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

    } //ColumnLockListView class
}
