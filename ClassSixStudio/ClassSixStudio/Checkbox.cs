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
            //do i need text and type in here?
        }

        public override void Prompt()
        {
            Console.WriteLine($"{Text}:\n");

            int i = 0;
            foreach (string item in possibleAnswers)
            {
                Console.WriteLine($"{i}. {item}");
                i++;
            }

            Console.WriteLine("Select one or more of the above options:");

            //need code that takes the users input, assocaites number input to strings in list, handles lower case, and compares to correctAnswers
        }
    }
}
