using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you travelled?");
            string userInput = Console.ReadLine();
            int miles = int.Parse(userInput);

            Console.WriteLine("How many gallons of gas have you used?");
            string userInputTwo = Console.ReadLine();
            int gallons = int.Parse(userInputTwo);

            int mpg = miles / gallons;
            mpg.ToString();
            Console.WriteLine("Your trip fuel efficiency was " + mpg + " miles per gallon.");
        }
    }
}
