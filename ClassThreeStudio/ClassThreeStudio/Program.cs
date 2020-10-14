using System;
using System.Collections.Generic;

namespace ClassThreeStudio
{
    class Program
    {

        static void Main(string[] args)
        {
            //established pre-existing menu 
            MenuItem bruschetta = new MenuItem("Bruschetta", "Crispy baguette piece topped with tomato, balsamic, and basil", 5.00, "Appetizer");
            MenuItem friedChicken = new MenuItem("Fried Chicken", "Crispy and delicious", 10.00, "Entree");
            MenuItem chickenParm = new MenuItem("Chicken Parmesan", "Fettuccine noodles with a robust tomato sauce", 11.99, "Entree");
            MenuItem fettAlfredo = new MenuItem("Fettuccine Alfredo", "Fettuccine noodles in a creamy white sauce", 10.99, "Entree");
            MenuItem tiramisu = new MenuItem("Tiramisu", "Boozy and satisfying", 4.99, "Desert");

            Menu menu = new Menu();
            menu.UpdateMenu(0, bruschetta);
            menu.UpdateMenu(0, friedChicken);
            menu.UpdateMenu(0, chickenParm);
            menu.UpdateMenu(0, fettAlfredo);
            menu.UpdateMenu(0, tiramisu);

            //using a while loop to continue prompting the user until they choose to kill the program with ctrl+c
            while (true)
            {
                Console.WriteLine("\nWhat would you like to do?\n" +
                    "0 - view menu\n" +
                    "1 - view menu item\n" +
                    "2 - add menu item\n" +
                    "3 - remove menu item");
                int input = int.Parse(Console.ReadLine());

                if (input == 0)
                {

                    for (int i = 0; i < menu.MenuItems.Count; i++)
                    {
                        Console.WriteLine($"\n********\n" +
                            $"{menu.MenuItems[i].ToString()}\n" +
                            $"********\n");

                    } 
                } if (input == 1){

                    Console.WriteLine($"\nPlease select a menu item to view:");
                    for (int i = 0; i < menu.MenuItems.Count; i++)
                    {
                        Console.WriteLine($"{i} - {menu.MenuItems[i].Name}");
                    }
                    int secondSelection = int.Parse(Console.ReadLine());

                    Console.WriteLine($"\n********\n" +
                        $"{menu.MenuItems[secondSelection].ToString()}\n" +
                        $"********\n");

                } if (input == 2)
                {

                    Console.WriteLine("\nPlease enter menu item name:");
                    string nameInput = Console.ReadLine();
                    Console.WriteLine("Please enter menu item description:");
                    string descriptionInput = Console.ReadLine();
                    Console.WriteLine("Please enter menu item price:");
                    double priceInput = double.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter menu item menu category:");
                    //could provide the options and have the user select
                    string categoryInput = Console.ReadLine();

                    menu.UpdateMenu(0, (new MenuItem(nameInput, descriptionInput, priceInput, categoryInput)));

                    //is there a better way to do this? I didn't actually name the instance of the class so can't access it
                    //perhaps to create a new menuItem instance right away and use the setter

                } if (input == 3)
                {
                    Console.WriteLine("\nPlease select an item to remove:");
                    for (int i = 0; i < menu.MenuItems.Count; i++)
                    {
                        Console.WriteLine($"{i} - {menu.MenuItems[i].Name}");
                    }
                    int removeSelection = int.Parse(Console.ReadLine());

                    menu.UpdateMenu(1, menu.MenuItems[removeSelection]);
                }
                
            }

        }

    }
}
