using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnicabApp.Landing
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}

        // On about button click
        private async void AboutBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Common.AboutPage());
        }

        private async void RegisterBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RegisterNewUserPage());
        }

        // Validation required
        private void LoginBtn_Clicked(object sender, EventArgs e)
        {
            var loginAsDriver = loginSwitch.IsToggled;
            if (loginAsDriver)
                App.Current.MainPage = new Driver.DriverHomePage();
            else
                App.Current.MainPage = new Passenger.PassengerHomePage();
        }

        private async void ForgotPasswordBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ForgotPasswordPage());
        }
    }
}