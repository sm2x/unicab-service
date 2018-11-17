using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicabApp.Services;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnicabApp.Landing
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
        private bool loginAsDriver = false;

        public MainPage ()
		{
			InitializeComponent ();
		}

        private async void RegisterBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RegisterNewUserPage());
        }

        // Validation required
        private void LoginBtn_Clicked(object sender, EventArgs e)
        {
            //var loginAsDriver = loginSwitch.IsToggled;
            if (loginAsDriver)
            {
                if (loginUsernameEntry.Text == "dvr" && loginPasswordEntry.Text == "123")
                {
                    DependencyService.Get<IToasts>().ShortToast("Login success");
                    App.Current.MainPage = new Driver.DriverHomePage();
                }
                else
                {
                    DependencyService.Get<IToasts>().ShortToast("Login failed, credentials incorrect");
                }
            }
            else
            {
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
                
        }

        private async void ForgotPasswordBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ForgotPasswordPage());
        }

        private void LoginPassengerBtn_Clicked(object sender, EventArgs e)
        {
            LoginPassengerBtn.BackgroundColor = Color.ForestGreen;
            LoginDriverBtn.BackgroundColor = Color.DimGray;
            loginAsDriver = false;
        }

        private void LoginDriverBtn_Clicked(object sender, EventArgs e)
        {
            LoginPassengerBtn.BackgroundColor = Color.DimGray;
            LoginDriverBtn.BackgroundColor = Color.ForestGreen;
            loginAsDriver = true;
        }
    }
}