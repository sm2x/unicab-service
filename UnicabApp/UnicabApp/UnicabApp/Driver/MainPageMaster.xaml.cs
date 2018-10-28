﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnicabApp.Driver
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageMaster : ContentPage
    {
        public ListView ListView;

        public MainPageMaster()
        {
            InitializeComponent();

            BindingContext = new MainPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MainPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MainPageMenuItem> MenuItems { get; set; }
            
            public MainPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MainPageMenuItem>(new[]
                {
                    new MainPageMenuItem { Id = 0, Title = "Dashboard", TargetType = typeof(MainPageDetail), IconSource = null },
                    new MainPageMenuItem { Id = 1, Title = "Cab Requests", TargetType = typeof(MainPageDetail), IconSource = null },
                    new MainPageMenuItem { Id = 2, Title = "Carpool Requests", TargetType = typeof(MainPageDetail), IconSource = null },
                    new MainPageMenuItem { Id = 3, Title = "Rate Card", TargetType = typeof(MainPageDetail), IconSource = null },
                    new MainPageMenuItem { Id = 4, Title = "Earnings", TargetType = typeof(MainPageDetail), IconSource = null },
                    new MainPageMenuItem { Id = 5, Title = "Settings", TargetType = typeof(MainPageDetail), IconSource = null },
                    new MainPageMenuItem { Id = 6, Title = "Help", TargetType = typeof(MainPageDetail), IconSource = null },
                    new MainPageMenuItem { Id = 7, Title = "About", TargetType = typeof(MainPageDetail), IconSource = null },
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