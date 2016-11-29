using System;

namespace GuitarShop.Layouts.Navigation
{
    public class NavigationItem
    {
        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }
    }
}