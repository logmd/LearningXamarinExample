using System.Collections.Generic;
using GuitarShop.Layouts.Home;
using GuitarShop.Layouts.Home.Browse;

namespace GuitarShop.Layouts.Navigation
{
    public static class NavigationItems
    {
        public static List<NavigationItem> GetNavigationItems =>
            new List<NavigationItem>
            {
                                new NavigationItem
                {
                    Title = "About",
                    IconSource = "contacts.png",
                    TargetType = typeof(AboutPage)
                },
                new NavigationItem
                {
                    Title = "Home",
                    IconSource = "contacts.png",
                    TargetType = typeof(HomePage)
                },
                new NavigationItem
                {
                    Title = "Cards UI Design",
                    IconSource = "contacts.png",
                    TargetType = typeof(CardDesignPage)
                },
                new NavigationItem
                {
                    Title = "Browse",
                    IconSource = "contacts.png",
                    TargetType = typeof(BrowsePage)
                },

            };
    }
}