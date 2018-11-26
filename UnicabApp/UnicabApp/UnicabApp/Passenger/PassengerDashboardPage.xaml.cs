using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicabApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnicabApp.Passenger
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PassengerDashboardPage : ContentPage
	{
        public ObservableCollection<UpcomingRide> Items { get; set; }

        public PassengerDashboardPage ()
		{
			InitializeComponent ();

            Items = new ObservableCollection<UpcomingRide>
            {
                new UpcomingRide
                {
                    PickupLocation = "USM",
                    DropoffLocation = "KL",
                    PickupDateTime = new DateTime(2018, 12, 1, 6, 0, 0),
                    NoOfSeats = 4,
                    LadiesOnly = false,
                    AdditionalNotes = "Carrying two luggages"

                },
                new UpcomingRide
                {
                    PickupLocation = "KL",
                    DropoffLocation = "USM",
                    PickupDateTime = new DateTime(2018, 12, 6, 13, 30, 0),
                    NoOfSeats = 4,
                    LadiesOnly = false,
                    AdditionalNotes = "Extra space for a luggage"

                },
                new UpcomingRide
                {
                    PickupLocation = "USM",
                    DropoffLocation = "Ipoh",
                    PickupDateTime = new DateTime(2018, 12, 9, 15, 10, 0),
                    NoOfSeats = 2,
                    LadiesOnly = false,
                    AdditionalNotes = "Carrying musical instruments"

                },
                new UpcomingRide
                {
                    PickupLocation = "Kampar",
                    DropoffLocation = "George Town",
                    PickupDateTime = new DateTime(2018, 12, 12, 10, 0, 0),
                    NoOfSeats = 4,
                    LadiesOnly = false,
                    AdditionalNotes = "Bring warm jacket"

                },
                new UpcomingRide
                {
                    PickupLocation = "USM",
                    DropoffLocation = "KL",
                    PickupDateTime = new DateTime(2018, 12, 23, 9, 30, 0),
                    NoOfSeats = 4,
                    LadiesOnly = false,
                    AdditionalNotes = "Christmas trip"

                }
            };

            DashboardListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await Navigation.PushAsync(new SelectedUpcomingRidePage(e.Item as UpcomingRide));

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        private void RequestCabFrameTapGesture_Tapped(object sender, EventArgs e)
        {
            PassengerHomePage PgrHomePage = (PassengerHomePage)App.Current.MainPage;
            PgrHomePage.Detail = new NavigationPage(new RequestCabPage());
            PgrHomePage.IsPresented = false;
        }

        private void AvailableCarpoolFrameTapGesture_Tapped(object sender, EventArgs e)
        {
            PassengerHomePage PgrHomePage = (PassengerHomePage)App.Current.MainPage;
            PgrHomePage.Detail = new NavigationPage(new AvailableCarpoolPage());
            PgrHomePage.IsPresented = false;
        }
    }
}