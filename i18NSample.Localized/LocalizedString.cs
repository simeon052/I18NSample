using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace i18NSample.Localized
{
	public class LocalizedString
	{
		public LocalizedString()
		{
		}

		public static string Get(string key, CultureInfo ci = null)
		{
			if (ci == null)
			{
				ci = CultureInfo.CurrentUICulture;
			}
			ResourceManager rm = new ResourceManager("i18NSample.Localized.I18NStrings", typeof(I18NStrings).GetTypeInfo().Assembly);
			return rm.GetString(key, ci);
		}
	}
}

