using GuitarShop.BusinessObjects;
using GuitarShop.Service.DataContracts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GuitarShop.Service.Extensions
{
    public static class ProductExtensions
    {
        public static ProductDTO ConvertToProductDTOFromProduct(this Product product)
        {
            return new ProductDTO
            {
                ProductNumber = product.ProductNumber,
                Name = product.ProductName,
                Price = product.Price,
                ProductOverview = product.Description,
                Features = product.Features,
                Image = ImageSource.FromUri(new Uri(product.ImageUrl))
            };
        }

        public static ListProductDTO ConvertToListProductDTOFromProduct(this Product product)
        {
            return new ListProductDTO
            {
                ProductNumber = product.ProductNumber,
                Name = product.ProductName,
                Price = product.Price,
                Quantity = product.Quantity,
                Image = ImageSource.FromUri(new Uri(product.ImageUrl))
            };
        }
    }
}
