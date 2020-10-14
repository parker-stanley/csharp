using System;
using System.Collections.Generic;

namespace ClassThreeStudio
{
    class Program
    {

        static void Main(string[] args)
        {
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

            //Console.WriteLine("Would you like to add or remove menu items?\n 0 - add\n 1 - remove");
            //int input = int.Parse(Console.ReadLine());

            Console.WriteLine("Would you like to see the whole menu or one item?\n 0 - whole menu \n 1 - single item");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 0)
            {
                for (int i = 0; i < menu.MenuItems.Count; i++)
                {
                    Console.WriteLine($"********\n" +
                        $"{menu.MenuItems[i].ToString()}\n" +
                        $"********");
                }
            } else
            {
                Console.WriteLine($"Please select a menu item to view:");
                for (int i = 0; i < menu.MenuItems.Count; i++)
                {
                    Console.WriteLine($"{i} - {menu.MenuItems[i].Name}");
                }
                int secondSelection = int.Parse(Console.ReadLine());

                Console.WriteLine($"********\n" +
                    $"{menu.MenuItems[secondSelection].ToString()}\n" +
                    $"********");

            }

        }

    }
}
