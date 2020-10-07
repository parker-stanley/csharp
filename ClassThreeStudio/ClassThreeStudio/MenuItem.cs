using System;
namespace ClassThreeStudio
{
    public class MenuItem
    {
        /*
        My original design had the fields declared, then the constructor, then the getter and setters.
        With the shorthand we don't need the fields declared.
        With the shorthand in the constructor we use uppercase on the field name instead of lowercase.
        With the shorthand the "this." is not needed in the constructor as well.
        */

        //setting of getters and setters, this also creates private fields by using shorthand 
        public string Name { get; }
        public string Description { get; }
        public double Price { get; set; }
        public string Category { get; }
        public bool IsNew { get; }
        public string DateUpdated { get; } //this could be refactored to actually get today's date

        //constructor for menu item
        public MenuItem(string name, string description, double price, string category, bool isNew, string dateUpdated)
        {
            Name = name;
            Description = description;
            Price = price;
            Category = category;
            IsNew = isNew;
            DateUpdated = dateUpdated;
        }

    }
}
