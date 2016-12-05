using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure.Mobile.Service;

namespace MobileService.DataObjects
{
    public class Feature : EntityData
    {
        public string InventoryItemId { get;set;}
        public string Text { get; set; }
    }
}