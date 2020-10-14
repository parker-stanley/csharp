using System;
namespace ClassThreeStudio
{
    public class MenuItem
    {

        //setting of getters and setters, this also creates private fields by using shorthand 
        public string Name { get; }
        public string Description { get; }
        public double Price { get; set; }
        public string Category { get; }
        public string NewItem { get; }
        public System.DateTime DateUpdated { get; }

        //constructor for menu item
        public MenuItem(string name, string description, double price, string category)
        {
            Name = name;
            Description = description;
            Price = price;
            Category = category;
            NewItem = this.IsNew();
            DateUpdated = MenuItem.UpdateDate();
        }

        //should this be static?
        private string IsNew()
        {
            return ("New item!");
        }

        //should this be static?
        public static System.DateTime UpdateDate()
        {
            return DateTime.Now;
        }

        public override string ToString()
        {
            return ($"{Name} - ${Price}\n{Description}\n{Category}\n{NewItem}\nDate updated: {DateUpdated}");
        }

    }
}
