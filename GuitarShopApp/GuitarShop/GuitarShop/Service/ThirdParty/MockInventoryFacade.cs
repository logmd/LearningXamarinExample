using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuitarShop.BusinessObjects;

namespace GuitarShop.Service.ThirdParty
{
    public class MockInventoryFacade : IInventoryFacade
    {
        public IInventoryService Service;

        public MockInventoryFacade(IInventoryService service)
        {
            Service = service;
        }

        public Task<Product> GetProductById(string productId)
        {
            var item = Service.GetById(productId);

            return Task.FromResult(new Product
            {
                ProductNumber = int.Parse(item.Id),
                ProductName = item.Name,
                Price = item.Price,
                Quantity = item.Quantity,
                Description = item.Description,
                //Features = item.Features,
                ImageUrl = item.ImageUrl
            });
        }

        public Task<IEnumerable<Product>> GetAllProducts()
        {
            return Task.FromResult(Service.GetAll()
                .Select(i => new Product
                {
                    ProductNumber = int.Parse(i.Id),
                    ProductName = i.Name,
                    Price = i.Price,
                    Quantity = i.Quantity,
                    Description = i.Description,
                    //Features = i.Features,
                    ImageUrl = i.ImageUrl
                }));
        }
    }
}