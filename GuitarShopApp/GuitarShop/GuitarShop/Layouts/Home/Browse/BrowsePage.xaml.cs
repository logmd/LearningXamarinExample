using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using GuitarShop.BusinessObjects;
using GuitarShop.IoC;
using GuitarShop.Layouts.Templates;
using GuitarShop.Service.DataContracts.DTO;
using GuitarShop.Service.DataContracts.Requests;
using GuitarShop.Service.ServiceContract;
using Xamarin.Forms;

namespace GuitarShop.Layouts.Home.Browse
{
    public partial class BrowsePage : DetailedContentPage
    {
        public BrowsePage()
        {
            
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            try
            {

                AppSetup setup = DependencyService.Get<AppSetup>();

                var service = setup.Container.Resolve<IProductService>();

                var getProductRequest = new GetAllProductsRequest();

                var result = await service.GetAllProducts(getProductRequest);

                var products = result?.Products;

                var listInView = AllProductsListView;

                var lview = new ListView();
                
                var source = new ObservableCollection<ListProductDTO>();

                foreach (var p in products)
                {
                    source.Add(p);
                }

                AllProductsListView.ItemsSource = source;

            }
            catch (Exception e)
            {
            }
        }
    }

    public class ProductViewModel
    {
        public string Name { get; set; }
    }
}
