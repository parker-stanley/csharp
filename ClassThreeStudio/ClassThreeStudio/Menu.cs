using System;
using System.Collections.Generic;

namespace ClassThreeStudio
{
    public class Menu
    {
        //fields initialized using the long hand
        private string menuCategory;
        private object menuItem;

        //constructor uses "this" because fields were declared using long hand
        private getMenuItem (string menuCategory, List<string> menuItems)
        {
            this.menuCategory = menuCategory;
            this.menuItem = menuItems;
        }

        //getters and setters required for long hand
        public string MenuCategory { get; }
        public object menuItem { get;  }

    }
}
