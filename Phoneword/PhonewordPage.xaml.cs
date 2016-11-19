using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Phoneword
{
	public partial class PhonewordPage : ContentPage
	{
		string translatedNumber;

		public PhonewordPage()
		{
			InitializeComponent();
		}

		void OnTranslate(object sender, EventArgs e)
		{
			translatedNumber = Phoneword.PhonewordTranslator.ToNumber(phoneNumberText.Text);
			if (!string.IsNullOrWhiteSpace(translatedNumber))
			{
				callButton.IsEnabled = true;
				callButton.Text = "Call " + translatedNumber;
			}
			else {
				callButton.IsEnabled = false;
				callButton.Text = "Call";
			}
		}

		async void OnCall(object sender, EventArgs e)
		{
			if (await this.DisplayAlert(
					"Dial a Number",
					"Would you like to call " + translatedNumber + "?",
					"Yes",
					"No"))
			{
				App.PhoneNumbers.Add(translatedNumber);
				callHistoryButton.IsEnabled = true;
				//var dialer = DependencyService.Get<IDialer>();
				//if (dialer != null)
				//	dialer.Dial(translatedNumber);
				Device.OpenUri(new Uri($"tel:{translatedNumber}"));
			}
		}

		async void OnCallHistory(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new CallHistoryPage());
		}
	}
}