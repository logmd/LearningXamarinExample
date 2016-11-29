using Autofac;
using GuitarApp.Infrastructure.UnitOfWork;
using GuitarShop.BusinessObjects;
using GuitarShop.DAL;
using GuitarShop.Service;
using GuitarShop.Service.ServiceContract;
using GuitarShop.Service.ThirdParty;
using Xamarin.Forms;

namespace GuitarShop.IoC
{
    public class AppSetup
    {
        public IContainer Container { get; private set; }

        public void CreateContainer()
        {
            ContainerBuilder cb = new ContainerBuilder();
            RegisterDepenencies(cb);
            Container = cb.Build();
        }

        protected virtual void RegisterDepenencies(ContainerBuilder cb)
        {
            // Services
            cb.RegisterType<ProductService>().As<IProductService>().SingleInstance();
            cb.RegisterType<UnitOfWork>().As<IUnitOfWork>().SingleInstance().WithParameter("sqlLite",DependencyService.Get<ISQLite>());

            cb.RegisterType<InventoryFacade>().As<IInventoryFacade>().SingleInstance();
            cb.RegisterType<InventoryService>().As<IInventoryService>().SingleInstance();
            cb.RegisterType<ProductFavouriteRepository>().As<IRepository<Favourite, int>>().SingleInstance();
        }
    }
}