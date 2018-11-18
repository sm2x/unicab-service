﻿using System;
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
	public partial class DriverMainPage : ContentPage
	{
		public DriverMainPage ()
		{
            InitializeComponent ();
		}

        private async void RegisterBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterNewDriverPage());
        }

        // Validation required
        private void LoginBtn_Clicked(object sender, EventArgs e)
        {
            // Login logic come here

            //if (loginUsernameEntry.Text == "pgr" && loginPasswordEntry.Text == "123")
            if (true)
            {
                DependencyService.Get<IToasts>().ShortToast("Login success");
                App.Current.MainPage = new Driver.DriverHomePage();
            }
            //else
            //{
            //    DependencyService.Get<IToasts>().ShortToast("Login failed, credentials incorrect");
            //}

        }

        private async void ForgotPasswordLabel_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgotDriverPasswordPage());
        }

        private void PassengerInterfaceBtn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new PassengerMainPage());
        }
    }
}