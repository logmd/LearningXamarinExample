using GuitarShop.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GuitarShop.Service.ThirdParty
{
    public class MockInventoryFacade : IInventoryFacade
    {
        public IInventoryService _service;

        public MockInventoryFacade(IInventoryService service)
        {
            _service = service;
        }

        public Task<Product> GetProductByProductNumber(int productNumber)
        {
            var item = _service.GetById(productNumber);

            return Task.FromResult(new Product
            {
                ProductNumber = Int32.Parse(item.Id),
                ProductName = item.Name,
                Price = item.Price,
                Quantity = item.Quantity,
                Description = item.Description,
                Features = item.Features,
                ImageUrl = item.ImageUrl
            });
        }

        public Task<IEnumerable<Product>> GetAllProducts()
        {
            return Task.FromResult(_service.GetAll()
                .Select(i => new Product
                {
                    ProductNumber = Int32.Parse(i.Id),
                    ProductName = i.Name,
                    Price = i.Price,
                    Quantity = i.Quantity,
                    Description = i.Description,
                    Features = i.Features,
                    ImageUrl = i.ImageUrl
                }));
        }
    }
}
