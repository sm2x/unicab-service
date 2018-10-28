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

        private void PassengerLoginBtn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Passenger.MainPage();
        }

        private void DriverLoginBtn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Driver.MainPage();
        }

        private async void AboutBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Common.AboutPage());
        }
    }
}