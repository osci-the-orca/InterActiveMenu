using System;

namespace InterActiveMenu
{
    internal class MenuItem
    {
        public string menuItemName;
        public Action method;
        public MenuItem(string menuItemName, Action method)
        {
            this.menuItemName = menuItemName;
            this.method = method;
        }
    }
}