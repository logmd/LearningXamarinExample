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
    public class InventoryFacade : IInventoryFacade
    {
        public IInventoryService _service;

        public InventoryFacade(IInventoryService service)
        {
            _service = service;
        }

        public Product GetProductByProductNumber(int productNumber)
        {
            var item = _service.GetById(productNumber);

            return new Product
            {
                ProductNumber = item.IventoryId,
                ProductName = item.Name,
                Price = item.Price,
                Quantity = item.Quantity,
                Description = item.Description,
                Features = item.Features,
                ImageUrl = item.ImageUrl
            };
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _service.GetAll()
                .Select(i => new Product
                {
                    ProductNumber = i.IventoryId,
                    ProductName = i.Name,
                    Price = i.Price,
                    Quantity = i.Quantity,
                    Description = i.Description,
                    Features = i.Features,
                    ImageUrl = i.ImageUrl
                });
        }
    }
}
