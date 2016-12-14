using System.Collections.Generic;
using Microsoft.Azure.Mobile.Server;

namespace MobileAppService.DataObjects
{
    public class InventoryItem : EntityData
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }

        //public IEnumerable<Feature> Features { get; set; }

        public string ImageUrl { get; set; }
    }
}