using System;
using System.Collections.Generic;

namespace ClassSixStudio
{
    public class MultiChoice : Question
    {
        //should these be set in the parent class?
        public string Text { get; set; }
        public string Type { get; set; }
        List<string> answers = new List<string>(); //why is it prompting me to make my lists readonly?
        public int CorrectAnswer { get; set; }
        

        public MultiChoice(string text, string type, List<string> answers, int correctAnswer)
        {
            Text = text;
            Type = type;
            this.answers = answers;
            CorrectAnswer = correctAnswer;
        }

        public override void Prompt()
        {
            Console.WriteLine($"{Text}:\n");

            int i = 0;
            foreach (string item in answers)
            {
                Console.WriteLine($"{i}. {answers[i]}\n");
                i++;
                Console.WriteLine("Please select from the above options:");
            }

            int userAnswer = int.Parse(Console.ReadLine());

            if (userAnswer == CorrectAnswer)
            {
                Console.WriteLine("Correct!");
            } else
            {
                Console.WriteLine("Incorrect selection.");
            }
            //could have created a while loop here that continued to prompt the user until userAnswer == correctAnswer

        }

        public void CheckAnswer() //should this be it's own method?
        {
            //I could move the checking of the answer here
            //that would require that i establish a "userAnswer field outside the above method
        }
    }
}
