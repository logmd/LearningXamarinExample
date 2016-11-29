using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop.BusinessObjects
{
    public class Product
    {
        public int ProductNumber { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }

        public IEnumerable<string> Features { get; set; }

        public string ImageUrl { get; set; }
    }
}
