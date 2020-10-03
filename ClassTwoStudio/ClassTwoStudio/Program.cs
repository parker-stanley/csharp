using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassTwoStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            string someString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            char[] charactersInString = someString.ToCharArray();
            Dictionary<char, double> characterCount = new Dictionary<char, double>();

            foreach (char letter in charactersInString)
            {
                if (!characterCount.ContainsKey(letter))
                {
                    characterCount.Add(letter, 1);
                } else
                {
                    characterCount[letter]++;
                }
            }

            Console.WriteLine(characterCount);
        }
    }
}
