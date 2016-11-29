using Autofac;
using GuitarShop.BusinessObjects;
using GuitarShop.DAL;
using GuitarShop.Infrastructure.UnitOfWork;
using GuitarShop.Service;
using GuitarShop.Service.ServiceContract;
using GuitarShop.Service.ThirdParty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop.IoC
{
    public class AppSetup
    {
        private IContainer _container;

        public IContainer Container => _container;

        public void CreateContainer()
        {
            ContainerBuilder cb = new ContainerBuilder();
            RegisterDepenencies(cb);
            _container = cb.Build();
        }

        protected virtual void RegisterDepenencies(ContainerBuilder cb)
        {
            // Services
            cb.RegisterType<ProductService>().As<IProductService>().SingleInstance();
            cb.RegisterType<UnitOfWork>().As<IUnitOfWork>().SingleInstance();
            
            cb.RegisterType<InventoryFacade>().As<IInventoryFacade>().SingleInstance();
            cb.RegisterType<InventoryService>().As<IInventoryService>().SingleInstance();
            cb.RegisterType<ProductFavouriteRepository>().As<IRepository<Favourite, int>>().SingleInstance();
        }
    }
}
