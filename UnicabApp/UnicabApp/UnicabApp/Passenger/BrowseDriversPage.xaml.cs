using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using UnicabApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnicabApp.Passenger
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BrowseDriversPage : ContentPage
    {
        public ObservableCollection<DriverAccount> Items { get; set; }

        public BrowseDriversPage()
        {
            InitializeComponent();

            //Items = new ObservableCollection<string>
            //{
            //    "Item 1",
            //    "Item 2",
            //    "Item 3",
            //    "Item 4",
            //    "Item 5"
            //};

            Items = new ObservableCollection<DriverAccount>
            {
                new DriverAccount
                {
                    EmailAddress = "abangwifi@student.usm.my",
                    FirstName = "Abang",
                    LastName = "Wifi",
                    CarPlateNo = "BFE9720",
                    CarMake = "Proton",
                    CarModel = "Preve"

                },
                new DriverAccount
                {
                    EmailAddress = "suekei@student.usm.my",
                    FirstName = "Sue",
                    LastName = "Kei",
                    CarPlateNo = "DEF1232",
                    CarMake = "Perodua",
                    CarModel = "MyVi"

                },
                new DriverAccount
                {
                    EmailAddress = "syahrulnizam@student.usm.my",
                    FirstName = "Syahrul",
                    LastName = "Nizam",
                    CarPlateNo = "PDG5543",
                    CarMake = "Honda",
                    CarModel = "City"

                }
            };
			
			BrowseDriversListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await Navigation.PushAsync(new SelectedDriverPage((DriverAccount)e.Item));

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
