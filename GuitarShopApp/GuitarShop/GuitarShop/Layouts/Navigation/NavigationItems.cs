using System.Collections.Generic;
using GuitarShop.Layouts.Home;

namespace GuitarShop.Layouts.Navigation
{
    public static class NavigationItems
    {
        public static List<NavigationItem> GetNavigationItems =>
            new List<NavigationItem>
            {
                new NavigationItem
                {
                    Title = "Home",
                    IconSource = "contacts.png",
                    TargetType = typeof(HomePage)
                },
                new NavigationItem
                {
                    Title = "About",
                    IconSource = "contacts.png",
                    TargetType = typeof(AboutPage)
                }
            };
    }
}