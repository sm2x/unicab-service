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
    public partial class MainPagePassengerMaster : ContentPage
    {
        public ListView ListView;

        public MainPagePassengerMaster()
        {
            InitializeComponent();

            BindingContext = new MainPagePassengerMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MainPagePassengerMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MainPagePassengerMenuItem> MenuItems { get; set; }

            public MainPagePassengerMasterViewModel()
            {
                MenuItems = new ObservableCollection<MainPagePassengerMenuItem>(new[]
                {
                    new MainPagePassengerMenuItem { Id = 0, Title = "Page 1" },
                    new MainPagePassengerMenuItem { Id = 1, Title = "Page 2" },
                    new MainPagePassengerMenuItem { Id = 2, Title = "Page 3" },
                    new MainPagePassengerMenuItem { Id = 3, Title = "Page 4" },
                    new MainPagePassengerMenuItem { Id = 4, Title = "Page 5" },
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