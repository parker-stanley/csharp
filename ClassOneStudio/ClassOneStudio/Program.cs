using System;

namespace ClassOneStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius:");
            string userInput = Console.ReadLine();
            double number1 = 0;
            bool canConvert = double.TryParse(userInput, out number1);
            if (canConvert)
            {
                while (double.Parse(userInput) < 0)
                {
                    Console.WriteLine("Please enter a positive number:");
                    userInput = Console.ReadLine();
                }
                double radius = double.Parse(userInput);

                Console.WriteLine($"The area of a circle of radius {userInput} is: {Calculations.Area(radius)}");
                Console.WriteLine("The circumference of a circle of radius " + userInput + " is: " + Calculations.Circumference(radius));
                Console.WriteLine("The diameter of a circle of radius " + userInput + " is: " + Calculations.Diameter(radius));

                //MPG exercise
                Console.WriteLine("What is the miles per gallon for your car?");
                double mpg = double.Parse(Console.ReadLine());
                double gallons = Calculations.Circumference(radius) / mpg;
                Console.WriteLine($"Your car will use {gallons} of gas to travel around the circle.");
            } else
            {
                Console.WriteLine("Invalid entry, mission abort.");
            }

        }
    }
}
