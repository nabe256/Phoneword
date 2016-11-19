using System.Collections.Generic;
using Xamarin.Forms;

namespace Phoneword
{
	public partial class App : Application
	{
		public static List<string> PhoneNumbers { get; set; } = new List<string>();
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new PhonewordPage());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
