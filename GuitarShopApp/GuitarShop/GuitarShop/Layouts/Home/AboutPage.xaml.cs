using System;
using System.Linq;
using Autofac;
using GuitarShop.IoC;
using GuitarShop.Layouts.Templates;
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

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            try
            {

                AppSetup setup = DependencyService.Get<AppSetup>();

                var service = setup.Container.Resolve<IProductService>();

                var result = await service.GetAllProducts(new GetAllProductsRequest());

                var product = result?.Products.First();

                productName.Text = product?.Name;
                productPrice.Text = product?.Price.ToString();
            }
            catch (Exception e)
            {
            }
        }
    }
}