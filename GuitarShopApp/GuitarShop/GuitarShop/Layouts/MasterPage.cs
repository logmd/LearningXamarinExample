using System.Collections.Generic;
using GuitarShop.Layouts.Home;
using GuitarShop.Layouts.Navigation;
using Xamarin.Forms;

namespace GuitarShop.Layouts
{
    public class MasterPage : ContentPage
    {
        public ListView ListView => _listView;

        readonly ListView _listView;

        public MasterPage()
        {
            Title = "WTF";

            var masterPageItems = NavigationItems.GetNavigationItems;


            _listView = new ListView
            {
                ItemsSource = masterPageItems,
                ItemTemplate = new DataTemplate(() =>
                {
                    var imageCell = new ImageCell();
                    imageCell.SetBinding(TextCell.TextProperty, "Title");
                    imageCell.SetBinding(ImageCell.ImageSourceProperty, "IconSource");
                    return imageCell;
                }),
                VerticalOptions = LayoutOptions.FillAndExpand,
                SeparatorVisibility = SeparatorVisibility.None
            };

            Padding = new Thickness(0, 40, 0, 0);
            Icon = "hamburger.png";
            Title = "Personal Organiser";
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    _listView
                }
            };
        }
    }
}