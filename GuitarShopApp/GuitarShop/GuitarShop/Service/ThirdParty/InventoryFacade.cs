﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarShop.BusinessObjects;
using Microsoft.WindowsAzure.MobileServices;

namespace GuitarShop.Service.ThirdParty
{
    public class InventoryFacade : IInventoryFacade
    {
        private MobileServiceClient _client;

        public InventoryFacade()
        {
            _client = new MobileServiceClient(@"http://localhost:54619/");
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            var table = _client.GetTable<InventoryItem>();

            var inventory = await table.ToListAsync();

            return inventory.Select(i => new Product
            {
                ProductNumber = Int32.Parse(i.Id),
                ProductName = i.Name,
                Price = i.Price,
                Quantity = i.Quantity,
                Description = i.Description,
                Features = i.Features,
                ImageUrl = i.ImageUrl
            });
        }

        public async Task<Product> GetProductByProductNumber(int productNumber)
        {
            var table = _client.GetTable<InventoryItem>();
            var id = productNumber.ToString();
            var query = table.Where(i => i.Id.Equals(id));

            var item = (await table.ReadAsync(query)).FirstOrDefault();

            return new Product
            {
                ProductNumber = Int32.Parse(item.Id),
                ProductName = item.Name,
                Price = item.Price,
                Quantity = item.Quantity,
                Description = item.Description,
                Features = item.Features,
                ImageUrl = item.ImageUrl
            };
        }
    }
}
