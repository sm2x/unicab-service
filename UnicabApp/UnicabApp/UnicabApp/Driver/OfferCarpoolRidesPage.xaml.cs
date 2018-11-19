using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnicabApp.Driver
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OfferCarpoolRidesPage : ContentPage
	{
		public OfferCarpoolRidesPage ()
		{
			InitializeComponent ();
		}

        private async void OfferCarpoolBtn_Clicked(object sender, EventArgs e)
        {
            string confirmBookingText = string.Format("Do you wish to confirm your carpool offer as follows:\n\nDriving From: {0}\nDriving To: {1}\nDeparting Date: {2:D}\nDeparting Time: {3}\nNo. of Seats: {4}\nLadies Only?: {5}\nAdditional Notes: {6}",
                DrivingFromPicker.SelectedItem,
                DrivingToPicker.SelectedItem,
                DepartingDatePicker.Date.ToString("ddd, d MMM yyyy"),
                DateTime.Today.Add(DepartingTimePicker.Time).ToString("h:mm tt"),
                NoOfSeatsPicker.SelectedItem,
                LadiesOnlyPicker.SelectedItem,
                AdditionalNotesEditor.Text);

            bool confirmBooking = await DisplayAlert("Offer Carpool", confirmBookingText, "Yes", "No");

            if (confirmBooking)
            {
                // add operations to carpool
                await DisplayAlert("Offer Carpool", "Your carpool offer is being processed. You will be notified once it is accepted by any of our passengers.", "OK");

            }
            else
            {
                await DisplayAlert("Offer Carpool", "You have not proceeded with your carpool offer.", "OK");
            }
        }
    }
}