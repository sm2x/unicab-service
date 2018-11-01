using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnicabApp.Passenger
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PassengerHomePageMaster : ContentPage
    {
        public ListView ListView;

        public PassengerHomePageMaster()
        {
            InitializeComponent();

            BindingContext = new PassengerHomePageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class PassengerHomePageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<PassengerHomePageMenuItem> MenuItems { get; set; }
            
            public PassengerHomePageMasterViewModel()
            {
                MenuItems = new ObservableCollection<PassengerHomePageMenuItem>(new[]
                {
                    new PassengerHomePageMenuItem { Id = 0, Title = "Home", TargetType = typeof(PassengerDashboardPage) },
                    new PassengerHomePageMenuItem { Id = 1, Title = "Cab Bookings", TargetType = typeof(CabBookingPassengerPage) },
                    new PassengerHomePageMenuItem { Id = 2, Title = "Carpool Offers", TargetType = typeof(CarpoolOffersPassengerPage) },
                    new PassengerHomePageMenuItem { Id = 3, Title = "Profile", TargetType = typeof(PassengerProfilePage) },

                    new PassengerHomePageMenuItem { Id = 99, Title = "Log Out", TargetType = null },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}