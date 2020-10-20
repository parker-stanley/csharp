using System;
using System.Collections.Generic;

namespace ClassSixStudio
{
    public class Checkbox : Question
    {
        public string Text { get; set; }
        public string Type { get; set; }
        List<string> correctAnswers = new List<string>(); //why is it prompting for readonly?
        List<string> possibleAnswers = new List<string>(); //why is it prompting for readonly?

        public Checkbox(string text, string type, List<string> correctAnswers, List<string> possibleAnswers)
        {
            Text = text;
            Type = type;
            this.correctAnswers = correctAnswers;
            this.possibleAnswers = possibleAnswers;
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
