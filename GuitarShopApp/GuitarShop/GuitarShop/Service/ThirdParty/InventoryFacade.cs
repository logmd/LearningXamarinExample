using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarShop.BusinessObjects;

namespace GuitarShop.Service.ThirdParty
{
    public class InventoryFacade : IInventoryFacade
    {
        public IEnumerable<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProductByProductNumber(int productNumber)
        {
            throw new NotImplementedException();
        }
    }
}
