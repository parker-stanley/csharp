using System;
using System.Collections.Generic;

namespace ClassSixStudio
{
    public class Checkbox : Question
    {
        List<string> correctAnswers = new List<string>(); //why is it prompting for readonly?
        List<string> possibleAnswers = new List<string>(); //why is it prompting for readonly?

        public Checkbox(string text, string type, List<string> correctAnswers, List<string> possibleAnswers) : base(text, type)
        {
            this.correctAnswers = correctAnswers;
            this.possibleAnswers = possibleAnswers;
        }

        public override void Prompt()
        {
            Console.WriteLine($"{Text}:");

            int i = 0;
            foreach (string item in possibleAnswers)
            {
                Console.WriteLine($"{i+1}. {item}");
                i++;
            }
        }

        public override void GetAnswer()
        {
            Console.WriteLine("\nSelect one or more of the above options entering your selections separated by commas.");

            int userScore = 0;

            string userInput = Console.ReadLine().ToLower();
            string[] userInputs = userInput.Split(',');

            foreach (string answer in userInputs)
            {
                if (correctAnswers.Contains(answer))
                {
                    userScore++;
                }
            }

            if (userScore == correctAnswers.Count)
            {
                Console.WriteLine("\nCorrect!\n");
                this.CorrectlyAnswered = true;
            }
            else
            {
                Console.WriteLine("\nIncorrect selections.\n");
                this.CorrectlyAnswered = false;
            }
        }
    }
}
