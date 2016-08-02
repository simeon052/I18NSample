// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace i18NSample.Mac
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField ltext1 { get; set; }

		[Outlet]
		AppKit.NSTextField ltext2 { get; set; }

		[Outlet]
		AppKit.NSTextField ltext3 { get; set; }

		[Outlet]
		AppKit.NSTextField ltext4 { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ltext1 != null) {
				ltext1.Dispose ();
				ltext1 = null;
			}

			if (ltext2 != null) {
				ltext2.Dispose ();
				ltext2 = null;
			}

			if (ltext3 != null) {
				ltext3.Dispose ();
				ltext3 = null;
			}

			if (ltext4 != null) {
				ltext4.Dispose ();
				ltext4 = null;
			}
		}
	}
}
