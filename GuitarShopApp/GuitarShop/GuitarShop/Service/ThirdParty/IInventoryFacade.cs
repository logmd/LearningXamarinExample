using GuitarShop.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop.Service.ThirdParty
{
    public interface IInventoryFacade
    {
        Task<Product> GetProductByProductNumber(int productNumber);

        Task<IEnumerable<Product>> GetAllProducts();
    }
}
