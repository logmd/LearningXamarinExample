using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop.Service.ThirdParty
{
    public static class Inventory
    {
        public static IEnumerable<InventoryItem> GetAllItems()
        {
            return new List<InventoryItem>
            {
                new InventoryItem
                {
                    Id = "1",
                    Name = "Ibanez UV70P-BK Black",
                    Description = "Steve Vai is one of the revered few on that short list of players who have changed " +
                    "the way we all think about what a guitar can really do. His signature Ibanez guitars are no different: " +
                    "Iconic, Sublime, Awe-Inspiring, Outrageous. The Ibanez JEM/UV Series models are designed to break boundaries.",
                    Price = 1179.00M,
                    Quantity = 3,
                    //Features = new List<string>
                    //{
                    //    "Wizard-7 5pc Maple/Walnut neck w/KTS™ TITANIUM rods",
                    //    "American Basswood body",
                    //    "Jumbo frets w/Premium fret edge treatment",
                    //    "Rosewood fretboard w/Green dot inlay",
                    //    "Edge-Zero II bridge",
                    //    "Cosmo black hardware",
                    //    "DiMarzio® Blaze™ pus",
                    //    "Hardshell case included"
                    //},
                    ImageUrl = @"http://cdn.mos.musicradar.com/images/Guitarist/369/ibanez-uv70p-630-80.jpg"
                },
                new InventoryItem
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
                    //Features = new List<string>
                    //{
                    //    "Neck type:  Nitro Wizard 3pc Maple/Bubinga neck",
                    //    "Body:  Rosewood top/Layered Ash body",
                    //    "Fretboard:  Birdseye Maple fretboard",
                    //    "Fret:  Jumbo frets",
                    //    "Bridge:  Gibraltar Standard II bridge",
                    //    "Neck pickup:  DiMarzio® Fusion Edge (H) neck pickup",
                    //    "Bridge pickup:  DiMarzio® Fusion Edge (H) bridge pickup",
                    //    "Tuners:  Gotoh Locking",
                    //    "Hardware color:  Black",
                    //    "Factory tuning:  1D, 2A, 3F, 4C, 5G, 6D"
                    //},
                    ImageUrl = @"http://www.rattleanddrum.com/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/i/b/ibanezrgdix6mrw.jpg"
                }
            };
        }
    }
}
