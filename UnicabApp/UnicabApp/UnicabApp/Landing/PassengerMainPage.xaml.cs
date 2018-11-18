using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicabApp.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnicabApp.Landing
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PassengerMainPage : ContentPage
	{
		public PassengerMainPage ()
		{
            InitializeComponent ();
		}

        private async void RegisterBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterNewPassengerPage());
        }

        // Validation required
        private void LoginBtn_Clicked(object sender, EventArgs e)
        {
            // Login logic come here
            
            if (loginUsernameEntry.Text == "pgr" && loginPasswordEntry.Text == "123")
            {
                DependencyService.Get<IToasts>().ShortToast("Login success");
                App.Current.MainPage = new Passenger.PassengerHomePage();
            }
            else
            {
                DependencyService.Get<IToasts>().ShortToast("Login failed, credentials incorrect");
            }

        }

        private async void ForgotPasswordLabel_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgotPassengerPasswordPage());
        }

        private void DriverInterfaceBtn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new DriverMainPage());
        }
    }
}