using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using MobileService.DataObjects;
using MobileService.Models;

namespace MobileService.Controllers
{
    public class InventoryItemController : TableController<InventoryItem>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<InventoryItem>(context, Request, Services);
        }

        // GET tables/InventoryItem
        public IQueryable<InventoryItem> GetAllInventoryItem()
        {
            return Query(); 
        }

        // GET tables/InventoryItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<InventoryItem> GetInventoryItem(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/InventoryItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<InventoryItem> PatchInventoryItem(string id, Delta<InventoryItem> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/InventoryItem
        public async Task<IHttpActionResult> PostInventoryItem(InventoryItem item)
        {
            InventoryItem current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/InventoryItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteInventoryItem(string id)
        {
             return DeleteAsync(id);
        }

    }
}