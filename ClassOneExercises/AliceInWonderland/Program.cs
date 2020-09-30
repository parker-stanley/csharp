using System;

namespace AliceInWonderland
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to search for.");
            string userInput = Console.ReadLine();
            userInput.ToLower();
            bool foundWord = WordFinder.Search(userInput);
            if (foundWord == true)
            {
                Console.WriteLine(WordIndex.Index(userInput));
                Console.WriteLine(SentenceModifier.Modify(userInput));
            } else
            {
                Console.WriteLine(foundWord);
            }
        }
    }
}
