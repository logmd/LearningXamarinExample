using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileService.Models
{
    public static class Inventory
    {
        public static IEnumerable<DataObjects.Feature> GetAllFeatures()
        {
            return new List<DataObjects.Feature>
                    {
                        new DataObjects.Feature { InventoryItemId = "1", Text = "Wizard-7 5pc Maple/Walnut neck w/KTS™ TITANIUM rods" },
                        new DataObjects.Feature { InventoryItemId = "1", Text = "American Basswood body" },
                        new DataObjects.Feature { InventoryItemId = "1", Text = "Jumbo frets w/Premium fret edge treatment"},
                        new DataObjects.Feature { InventoryItemId = "1", Text = "Rosewood fretboard w/Green dot inlay"},
                        new DataObjects.Feature { InventoryItemId = "1", Text = "Edge-Zero II bridge"},
                        new DataObjects.Feature { InventoryItemId = "1", Text = "Cosmo black hardware"},
                        new DataObjects.Feature { InventoryItemId = "1", Text = "DiMarzio® Blaze™ pus"},
                        new DataObjects.Feature { InventoryItemId = "1", Text = "Hardshell case included"},
                        new DataObjects.Feature { InventoryItemId = "2", Text = "Neck type:  Nitro Wizard 3pc Maple/Bubinga neck"},
                        new DataObjects.Feature { InventoryItemId = "2", Text = "Body:  Rosewood top/Layered Ash body"},
                        new DataObjects.Feature { InventoryItemId = "2", Text = "Fretboard:  Birdseye Maple fretboard"},
                        new DataObjects.Feature { InventoryItemId = "2", Text = "Fret:  Jumbo frets"},
                        new DataObjects.Feature { InventoryItemId = "2", Text = "Bridge:  Gibraltar Standard II bridge"},
                        new DataObjects.Feature { InventoryItemId = "2", Text = "Neck pickup:  DiMarzio® Fusion Edge (H) neck pickup"},
                        new DataObjects.Feature { InventoryItemId = "2", Text = "Bridge pickup:  DiMarzio® Fusion Edge (H) bridge pickup"},
                        new DataObjects.Feature { InventoryItemId = "2", Text = "Tuners:  Gotoh Locking"},
                        new DataObjects.Feature { InventoryItemId = "2", Text = "Hardware color:  Black"},
                        new DataObjects.Feature { InventoryItemId = "2", Text = "Factory tuning:  1D, 2A, 3F, 4C, 5G, 6D"},
            };
        }

        public static IEnumerable<DataObjects.InventoryItem> GetAllProducts()
        {
            return new List<DataObjects.InventoryItem>
            {
                new DataObjects.InventoryItem
                {
                    Id = "1",
                    Name = "Ibanez UV70P-BK Black",
                    Description = "Steve Vai is one of the revered few on that short list of players who have changed " +
                    "the way we all think about what a guitar can really do. His signature Ibanez guitars are no different: " +
                    "Iconic, Sublime, Awe-Inspiring, Outrageous. The Ibanez JEM/UV Series models are designed to break boundaries.",
                    Price = 1179.00M,
                    Quantity = 3,
                    ImageUrl = @"http://cdn.mos.musicradar.com/images/Guitarist/369/ibanez-uv70p-630-80.jpg"
                },
                new DataObjects.InventoryItem
                {
                    Id = "2",
                    Name = "Ibanez RGDIX6MRW-CBF",
                    Description = "The new RGD Iron Label series offers a new type of body construction, never before featured on a RGD model. " + 
                    "An Exotic wood top sits above a natural finish Ash body, capturing the highly sought-after 'layered body' look that is popular " + 
                    "with today's boutique guitar enthusiasts. The RGDIX6MRW features a Rosewood top and a stunning Birdseye Maple fretboard. The guitar " + 
                    "features the brand new DiMarzio Fusion Edge pickups, which were the result of a direct collaboration between DiMarzio and Ibanez. " + 
                    "They provide great clarity and a very smooth response, satisfying the current demands of players in today's progressive metal scene. " + 
                    "The 26.5\" scale length of the RGD line enables rich, thick tone when down-tuning, but still remains extremely playable for highly " + 
                    "technical riffs and runs.Extra - deep cutaways grant comfortable access to the neck's highest notes.",
                    Price = 579.00M,
                    Quantity = 7,
                    ImageUrl = @"http://www.rattleanddrum.com/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/i/b/ibanezrgdix6mrw.jpg"
                }
            };
        }
    }
}
