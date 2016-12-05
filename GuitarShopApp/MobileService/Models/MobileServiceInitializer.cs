using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MobileService.DataObjects;

namespace MobileService.Models
{
    public class MobileServiceInitializer : DropCreateDatabaseIfModelChanges<MobileServiceContext>
    {
        protected override void Seed(MobileServiceContext context)
        {
            //List<TodoItem> todoItems = new List<TodoItem>
            //{
            //    new TodoItem { Id = Guid.NewGuid().ToString(), Text = "First item", Complete = false },
            //    new TodoItem { Id = Guid.NewGuid().ToString(), Text = "Second item", Complete = false },
            //};

            //foreach (TodoItem todoItem in todoItems)
            //{
            //    context.Set<TodoItem>().Add(todoItem);
            //}

            if (!context.InventoryItems.Any())
            {
                context.InventoryItems.AddRange(Inventory.GetAllProducts());
                context.SaveChanges();
            }

            if(!context.Features.Any())
            {
                context.Features.AddRange(Inventory.GetAllFeatures());
                context.SaveChanges();
            }

            base.Seed(context);
        }
    }

}