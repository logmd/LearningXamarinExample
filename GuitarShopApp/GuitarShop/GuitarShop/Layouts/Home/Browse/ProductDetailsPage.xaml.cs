using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarShop.Layouts.Templates;
using GuitarShop.Service.DataContracts.DTO;
using Xamarin.Forms;

namespace GuitarShop.Layouts.Home.Browse
{
    public partial class ProductDetailsPage : DetailedContentPage
    {
        private ListProductDTO Product { get; set; }

        public ProductDetailsPage(ListProductDTO product)
        {
            if (product == null) Product = new ListProductDTO();
            Product = product;

            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();


            ItemImage.Source = Product.Image;
            ItemName.Text = Product.Name;
            ItemFeatures.Text = Product.Features;

            VitorImage.Source = ImageSource.FromUri(new Uri(@"https://scontent.xx.fbcdn.net/v/t1.0-1/p100x100/13124967_10204730703742547_6652237023118423190_n.jpg?oh=9cf7bea3ca28aaf0abf770d9ddacb9a1&oe=58E0E1A9"));
            ShahedImage.Source = ImageSource.FromUri(new Uri(@"https://scontent.xx.fbcdn.net/v/t1.0-1/c27.0.160.160/p160x160/385964_10150899028755724_1846826829_n.jpg?oh=30173cc5fdd39fdf71680f998045300e&oe=58E0FD9A"));
        }
    }
}

