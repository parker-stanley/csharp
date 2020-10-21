using System;

namespace ClassSixStudio
{
    public class TrueFalse : Question
    {
        public bool CorrectAnswer { get; set; }

        public TrueFalse(string text, string type, bool correctAnswer) : base(text, type)
        {
            CorrectAnswer = correctAnswer;
        }

        public override void Prompt()
        {
            Console.WriteLine($"True or false. {Text}");

        }

        public override void GetAnswer()
        {
            string userAnswer = Console.ReadLine().ToLower();
            bool userAnswerConverted;

            if (userAnswer == "true")
            {
                userAnswerConverted = true;
            }
            else
            {
                userAnswerConverted = false;
            }

            if (userAnswerConverted == CorrectAnswer)
            {
                Console.WriteLine("\nCorrect!\n");
                this.CorrectlyAnswered = true;
            }
            else
            {
                Console.WriteLine("\nIncorrect response.\n");
                this.CorrectlyAnswered = false;
            }
        }
    }
}
