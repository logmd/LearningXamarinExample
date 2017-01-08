using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using GuitarShop.BusinessObjects;
using Microsoft.WindowsAzure.MobileServices;

namespace GuitarShop.Service.ThirdParty
{
    public class InventoryFacade : IInventoryFacade
    {
        private readonly MobileServiceClient _client;

        public InventoryFacade()
        {
            _client = new MobileServiceClient(@"http://192.168.0.114:5001/");
            var uri = _client.ApplicationUri;
            //_client.InvokeApiAsync()
            //var client = new MobileServiceClient("https://xxx.azurewebsites.net", new MyHandler());
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            var i =
                await
                    _client.InvokeApiAsync<InventoryItem>("InventoryItem", HttpMethod.Get,
                        new Dictionary<string, string>
                        {
                            {"ZUMO-API-VERSION", "2.0.0"}
                        });

            var p = new Product
            {
                ProductNumber = int.Parse(i.Id),
                ProductName = i.Name,
                Price = i.Price,
                Quantity = i.Quantity,
                Description = i.Description,
                //Features = i.Features,
                ImageUrl = i.ImageUrl
            };


            return new List<Product> {p};
            //var table = _client.GetTable<InventoryItem>();

            //var inventory = await table.ToListAsync();

            //return inventory.Select(i => new Product
            //{
            //    ProductNumber = Int32.Parse(i.Id),
            //    ProductName = i.Name,
            //    Price = i.Price,
            //    Quantity = i.Quantity,
            //    Description = i.Description,
            //    Features = i.Features,
            //    ImageUrl = i.ImageUrl
            //});
        }

        public async Task<Product> GetProductById(string productId)
        {
            var table = _client.GetTable<InventoryItem>();
            var id = productId;
            var query = table.Where(i => i.Id == id);

            var asyncQuery = table.ReadAsync(query);

            try
            {
                var result = await asyncQuery;

                var item = result.FirstOrDefault();

                return new Product
                {
                    ProductNumber = int.Parse(item.Id),
                    ProductName = item.Name,
                    Price = item.Price,
                    Quantity = item.Quantity,
                    Description = item.Description,
                    //Features = item.Features,
                    ImageUrl = item.ImageUrl
                };
            }
            catch (Exception ex)
            {
                return new Product();
            }
        }
    }
}