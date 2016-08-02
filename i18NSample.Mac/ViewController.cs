using System;

using AppKit;
using Foundation;

namespace i18NSample.Mac
{
	public partial class ViewController : NSViewController
	{
		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Do any additional setup after loading the view.
			ltext1.StringValue = i18NSample.Localized.LocalizedString.Get("LocalizedText1");
			ltext2.StringValue = i18NSample.Localized.LocalizedString.Get("LocalizedText2");
			ltext3.StringValue = i18NSample.Localized.LocalizedString.Get("LocalizedText1", new System.Globalization.CultureInfo("ja-JP"));
			ltext4.StringValue = i18NSample.Localized.LocalizedString.Get("LocalizedText2", new System.Globalization.CultureInfo("ja-JP"));

		}

		public override NSObject RepresentedObject
		{
			get
			{
				return base.RepresentedObject;
			}
			set
			{
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}
	}
}
