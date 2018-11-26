using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicabApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnicabApp.Driver
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SelectedRideHistoryPage : ContentPage
	{
		public SelectedRideHistoryPage (UpcomingRide upcomingRide)
		{
			InitializeComponent ();

            this.Title = string.Format("{0} {1} {2}", upcomingRide.PickupLocation, char.ConvertFromUtf32(0x2197), upcomingRide.DropoffLocation);

            StatusLabel.Text = "ON SCHEDULE";
            RideFromLabel.Text = upcomingRide.PickupLocation;
            RideToLabel.Text = upcomingRide.DropoffLocation;
            PickupDateLabel.Text = upcomingRide.PickupDateTime.ToLongDateString();
            PickupTimeLabel.Text = upcomingRide.PickupDateTime.ToShortTimeString();
            NoOfSeatsLabel.Text = upcomingRide.NoOfSeats.ToString();
            LadiesOnlyLabel.Text = (upcomingRide.LadiesOnly) ? "Yes" : "No";
            AdditionalNotesLabel.Text = upcomingRide.AdditionalNotes;
        }
        private async void CallPassengerBtn_Clicked(object sender, EventArgs e)
        {
            bool continueNextSteps = await DisplayAlert("Call Passenger", "Are you sure you wish to call this passenger? Tap 'Yes' to proceed, or 'No' to go back.", "Yes", "No");
            if (continueNextSteps)
            {
                await DisplayAlert("Call Passenger", "Not implemented yet, sorry.", "OK");
            }
            else
            {

            }
        }

        private async void MessagePassengerBtn_Clicked(object sender, EventArgs e)
        {
            bool continueNextSteps = await DisplayAlert("Message Passenger", "Are you sure you wish to message this passenger? Tap 'Yes' to proceed, or 'No' to go back.", "Yes", "No");
            if (continueNextSteps)
            {
                await DisplayAlert("Message Passenger", "Not implemented yet, sorry.", "OK");

            }
            else
            {

            }
        }

    }
}