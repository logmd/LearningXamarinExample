﻿using Microsoft.Azure.Mobile.Server;

namespace MobileService.DataObjects
{
    public class Feature : EntityData
    {
        public string InventoryItemId { get; set; }
        public string Text { get; set; }
    }
}