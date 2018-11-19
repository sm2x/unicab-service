using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using UnicabApp.Models;

namespace UnicabApp.Passenger
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RequestCabPage : ContentPage
	{
		public RequestCabPage ()
		{
			InitializeComponent ();
		}

        private async void BookCabBtn_Clicked(object sender, EventArgs e)
        {
            string confirmBookingText = string.Format("Do you wish to confirm your cab request as follows:\n\nPickup Location: {0}\nDropoff Location: {1}\nPickup Date: {2:D}\nPickup Time: {3}\nNo. of Passengers: {4}\nLadies Only?: {5}\nAdditional Notes: {6}",
                PickupLocationPicker.SelectedItem,
                DropoffLocationPicker.SelectedItem,
                PickupDatePicker.Date.ToString("ddd, d MMM yyyy"),
                DateTime.Today.Add(PickupTimePicker.Time).ToString("h:mm tt"),
                NoOfPassengersPicker.SelectedItem,
                LadiesOnlyPicker.SelectedItem,
                AdditionalNotesEditor.Text);

            bool confirmBooking = await DisplayAlert("Request Cab", confirmBookingText, "Yes", "No");

            if (confirmBooking)
            {
                // add operations to book a cab
                await DisplayAlert("Request Cab", "Your cab request is being processed. You will be notified once it is accepted by any of our drivers.", "OK");
                
            }
            else
            {
                await DisplayAlert("Request Cab", "You have not proceeded with your cab request.", "OK");
            }
        }

    }
}