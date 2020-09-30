using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the rectangle's length?");
            string userInputTwo = Console.ReadLine();
            int length = int.Parse(userInputTwo);

            Console.WriteLine("What is the rectangle's width?");
            string userInput = Console.ReadLine();
            int width = int.Parse(userInput);

            int area = length * width;
            area.ToString();
            Console.WriteLine("The area of the rectangle is " + area);
        }
    }
}
