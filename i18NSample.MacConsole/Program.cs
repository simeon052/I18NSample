using System;

namespace i18NSample.MacConsole
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(i18NSample.Localized.LocalizedString.Get("LocalizedText1"));
			Console.WriteLine(i18NSample.Localized.LocalizedString.Get("LocalizedText2"));
			Console.WriteLine(i18NSample.Localized.LocalizedString.Get("LocalizedText1", new System.Globalization.CultureInfo("ja-JP")));
			Console.WriteLine(i18NSample.Localized.LocalizedString.Get("LocalizedText2", new System.Globalization.CultureInfo("ja-JP")));

			Console.WriteLine("Done!");
		}
	}
}
