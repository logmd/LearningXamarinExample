using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileService.DataObjects
{
    public class InventoryItem : EntityData
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }

        public IEnumerable<Feature> Features { get; set; }

        public string ImageUrl { get; set; }
    }
}