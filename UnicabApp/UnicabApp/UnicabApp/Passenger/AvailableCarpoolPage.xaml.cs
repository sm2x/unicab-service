using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using UnicabApp.Models;

namespace UnicabApp.Passenger
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AvailableCarpoolPage : ContentPage
    {
        public ObservableCollection<CarpoolOffer> Items { get; set; }

        public AvailableCarpoolPage()
        {
            InitializeComponent();

            Items = new ObservableCollection<CarpoolOffer>
            {
                new CarpoolOffer
                {
                    DrivingFrom = "USM",
                    DrivingTo = "KL",
                    DepartingDateTime = new DateTime(2018, 12, 1, 6, 0, 0),
                    NoOfSeats = 4,
                    LadiesOnly = false,
                    AdditionalNotes = "Carrying two luggages"
                                 
                },               
                new CarpoolOffer 
                {                
                    DrivingFrom = "KL",
                    DrivingTo = "USM",
                    DepartingDateTime = new DateTime(2018, 12, 6, 13, 30, 0),
                    NoOfSeats = 4,
                    LadiesOnly = false,
                    AdditionalNotes = "Extra space for a luggage"
                                 
                },               
                new CarpoolOffer 
                {                
                    DrivingFrom = "USM",
                    DrivingTo = "Ipoh",
                    DepartingDateTime = new DateTime(2018, 12, 9, 15, 10, 0),
                    NoOfSeats = 2,
                    LadiesOnly = false,
                    AdditionalNotes = "Carrying musical instruments"
                                 
                },               
                new CarpoolOffer 
                {                
                    DrivingFrom = "Kampar",
                    DrivingTo = "George Town",
                    DepartingDateTime = new DateTime(2018, 12, 12, 10, 0, 0),
                    NoOfSeats = 4,
                    LadiesOnly = false,
                    AdditionalNotes = "Bring warm jacket"
                                 
                },               
                new CarpoolOffer 
                {                
                    DrivingFrom = "USM",
                    DrivingTo = "KL",
                    DepartingDateTime = new DateTime(2018, 12, 23, 9, 30, 0),
                    NoOfSeats = 4,
                    LadiesOnly = false,
                    AdditionalNotes = "Christmas trip"

                }

            };
			
			AvailableCarpoolListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            CarpoolOffer selectedOffer = (CarpoolOffer)e.Item;

            //string offerTitle = string.Format("{0} > {1}", selectedOffer.DrivingFrom, selectedOffer.DrivingTo);
            //string offerContent = string.Format("Driving From: {0}\nDriving To: {1}\nPickup Date: {2:D}\nPickup Time: {2:t}\nNo.of Seats: {3}\nLadies Only?: {4}\nAdditional Notes: {5}",
            //    selectedOffer.DrivingFrom,
            //    selectedOffer.DrivingTo,
            //    selectedOffer.DepartingDateTime,
            //    selectedOffer.NoOfSeats,
            //    (selectedOffer.LadiesOnly) ? "Yes" : "No",
            //    selectedOffer.AdditionalNotes);

            //await DisplayAlert(offerTitle, offerContent, "OK");

            await Navigation.PushAsync(new SelectedCarpoolPage(selectedOffer));

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
