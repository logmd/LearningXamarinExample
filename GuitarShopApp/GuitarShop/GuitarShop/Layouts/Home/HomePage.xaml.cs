using System;
using GuitarShop.Layouts.Templates;
using Xamarin.Forms;

namespace GuitarShop.Layouts.Home
{
    public partial class HomePage : DetailedContentPage
    {
        public HomePage()
        {
            Title = "Home Page";
            InitializeComponent();

            //GuitarShopIcon.Source = ImageSource.FromUri(
            //    new Uri("http://cdn.mos.musicradar.com/images/Guitarist/369/ibanez-uv70p-630-80.jpg"));

            GuitarShopIcon.Source = ImageSource.FromResource("GuitarShop.Images.gslogo256.png");

        }
    }
}