using System;

using Xamarin.Forms;

namespace Phoneword
{
	public class Numbers : ContentPage
	{
		public string RawNumber { get; }
		public string TranslatedNumber { get; }
		public DateTime CallDate { get; }

		public Numbers(string rawNumber, string translatedNumber, DateTime callDate)
		{
			this.RawNumber = rawNumber;
			this.TranslatedNumber = translatedNumber;
			this.CallDate = callDate;
		}
	}
}

