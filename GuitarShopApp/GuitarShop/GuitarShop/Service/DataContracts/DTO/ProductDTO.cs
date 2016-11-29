using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GuitarShop.Service.DataContracts.DTO
{
    public class ProductDTO
    {
        public int ProductNumber { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string ProductOverview { get; set; }

        public IEnumerable<string> Features { get; set; }

        public ImageSource Image { get; set; }
    }
}
