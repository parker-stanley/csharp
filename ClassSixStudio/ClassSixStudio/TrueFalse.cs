using System;

namespace ClassSixStudio
{
    public class TrueFalse : Question
    {
        public bool CorrectAnswer { get; set; }

        public TrueFalse(string text, string type) : base(text, type)
        {
            Text = text;
            Type = type;
            //do these needs to be left in the constructor?
        }

        public override void Prompt()
        {
            Console.WriteLine($"True or false. {Text}");

            string userAnswer = Console.ReadLine().ToLower();
            bool userAnswerConverted;

            if (userAnswer == "true")
            {
                userAnswerConverted = true;
            } else
            {
                userAnswerConverted = false;
            }

            if (userAnswerConverted == CorrectAnswer)
            {
                Console.WriteLine("Correct!");
            } else
            {
                Console.WriteLine("Incorrect response.");
            }
        }
    }
}
