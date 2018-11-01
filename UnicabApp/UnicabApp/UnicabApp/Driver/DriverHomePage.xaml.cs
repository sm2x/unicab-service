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
    public partial class DriverHomePage : MasterDetailPage
    {
        public DriverHomePage()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DriverHomePageMenuItem item = e.SelectedItem as DriverHomePageMenuItem;
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