using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop.Service.ThirdParty
{
    public interface IInventoryService
    {
        InventoryItem GetById(string id);

        IEnumerable<InventoryItem> GetAll();
    }
}
