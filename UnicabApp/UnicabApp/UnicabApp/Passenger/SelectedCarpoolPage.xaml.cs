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
	public partial class SelectedCarpoolPage : ContentPage
	{
		public SelectedCarpoolPage (CarpoolOffer selectedOffer)
		{
			InitializeComponent ();

            DrivingFromLabel.Text = selectedOffer.DrivingFrom;
            DrivingToLabel.Text = selectedOffer.DrivingTo;
            DepartingDateLabel.Text = selectedOffer.DepartingDateTime.ToLongDateString();
            DepartingTimeLabel.Text = selectedOffer.DepartingDateTime.ToShortTimeString();
            NoOfSeatsLabel.Text = selectedOffer.NoOfSeats.ToString();
            LadiesOnlyLabel.Text = (selectedOffer.LadiesOnly) ? "Yes" : "No";
            AdditionalNotesLabel.Text = selectedOffer.AdditionalNotes;

		}

        private async void AcceptCarpoolBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}