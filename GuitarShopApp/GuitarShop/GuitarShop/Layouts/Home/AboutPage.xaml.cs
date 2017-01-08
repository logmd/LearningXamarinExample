using System;
using System.Linq;
using Autofac;
using GuitarShop.IoC;
using GuitarShop.Layouts.Templates;
using GuitarShop.Service;
using GuitarShop.Service.DataContracts.Requests;
using GuitarShop.Service.ServiceContract;
using DependencyService = Xamarin.Forms.DependencyService;

namespace GuitarShop.Layouts.Home
{
    public partial class AboutPage : DetailedContentPage
    {
        
        public AboutPage()
        {
            InitializeComponent();

            Title = "About";
            
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            try
            {
                
                AppSetup setup = DependencyService.Get<AppSetup>();

                var service = setup.Container.Resolve<IProductService>();

                var getProductRequest = new GetProductDetailsRequest()
                {
                    ProductId = "89347eb9e4fe4cef92960eb1cfba9724"
                };

                var result = await service.GetProductDetails(getProductRequest);

                var product = result?.Product;

                productName.Text = product?.Name;
                productPrice.Text = product?.Price.ToString();
            }
            catch (Exception e)
            {
            }
        }
    }
}