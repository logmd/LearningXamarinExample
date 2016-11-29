using System;
using GuitarShop.Layouts.Home;
using GuitarShop.Layouts.Navigation;
using Xamarin.Forms;

namespace GuitarShop.Layouts
{
    class MainPage:MasterDetailPage
    {
        readonly MasterPage _masterPage;

        public MainPage()
        {
            _masterPage = new MasterPage();
            Master = _masterPage;
            Detail = new NavigationPage(new HomePage()); //

            _masterPage.ListView.ItemSelected += OnItemSelected;

            if (Device.OS == TargetPlatform.Windows)
            {
                Master.Icon = "swap.png";
            }

        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as NavigationItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                _masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
