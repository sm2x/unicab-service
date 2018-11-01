﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnicabApp.Passenger
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PassengerHomePage : MasterDetailPage
    {
        public PassengerHomePage()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            PassengerHomePageMenuItem item = e.SelectedItem as PassengerHomePageMenuItem;
            if (item == null)
                return;
            else if (item.Id == 99)
            {
                App.Current.MainPage = new NavigationPage(new Landing.MainPage());
                return;
            }

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}