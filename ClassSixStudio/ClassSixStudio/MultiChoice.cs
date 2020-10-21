using System;
using System.Collections.Generic;

namespace ClassSixStudio
{
    public class MultiChoice : Question
    {
        List<string> answers = new List<string>(); //why is it prompting me to make my lists readonly?
        public int CorrectAnswer { get; set; }
        

        public MultiChoice(string text, string type, List<string> answers, int correctAnswer) : base(text, type)
        {
            this.answers = answers;
            CorrectAnswer = correctAnswer;
        }

        public override void Prompt()
        {
            Console.WriteLine($"{Text}:");

            int i = 0;
            foreach (string item in answers)
            {
                Console.WriteLine($"{i+1}. {answers[i]}");
                i++;
            }
        }

        public override void GetAnswer()
        {
            Console.WriteLine("\nPlease select from the above options by indicating the number of your selection:");

            int userAnswer = int.Parse(Console.ReadLine());

            if (userAnswer == CorrectAnswer)
            {
                Console.WriteLine("\nCorrect!\n");
                this.CorrectlyAnswered = true;
            }
            else
            {
                Console.WriteLine("\nIncorrect selection.\n");
                this.CorrectlyAnswered = false;
            }
            //could have created a while loop here that continued to prompt the user until userAnswer == correctAnswer
        }

    }
}
