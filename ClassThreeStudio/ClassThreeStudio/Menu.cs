using System;
using System.Collections.Generic;

namespace ClassThreeStudio
{
    public class Menu
    {
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();

        // could add validation to this that checks if "food" is on the menu
        public void UpdateMenu (int option, MenuItem food)
        {
            if (option == 0)
            {
                MenuItems.Add(food);
            } else
            {
                MenuItems.Remove(food);
            }
        }

    }
}
