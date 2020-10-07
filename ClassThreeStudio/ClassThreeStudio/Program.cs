using System;

namespace ClassThreeStudio
{
    class Program
    {

        static void Main(string[] args)
        {
            MenuItem friedChicken = new MenuItem("Fried Chicken", "Crispy and delicious", 10.00, "Main", true, "October 6th");
            Console.WriteLine(friedChicken);
        }

    }
}
