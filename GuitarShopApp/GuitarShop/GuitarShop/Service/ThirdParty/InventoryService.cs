using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop.Service.ThirdParty
{
    public class InventoryService : IInventoryService
    {
        public IEnumerable<InventoryItem> GetAll()
        {
            return Inventory.GetAllItems();
        }

        public InventoryItem GetById(string id)
        {
            var idStr = id;
            return Inventory.GetAllItems().FirstOrDefault(item => item.Id.Equals(idStr));
        }
    }
}
