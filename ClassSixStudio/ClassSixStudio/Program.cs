using System;
using System.Collections.Generic;

namespace ClassSixStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Question> questions = new List<Question>(); //is this correct or should it be a list of "classes"

            //code to create question class instances
            List<string> multiAnswer = new List<string>();
            multiAnswer.Add("red");
            multiAnswer.Add("black");
            multiAnswer.Add("pink");
            multiAnswer.Add("yellow");

            List<string> correctAnswers = new List<string>();
            correctAnswers.Add("red");
            correctAnswers.Add("pink");
            correctAnswers.Add("yellow");

            MultiChoice question1 = new MultiChoice("Which color is the darkest?", "Multiple Choice", multiAnswer, 2);

            Checkbox question2 = new Checkbox("Which colors are present in a rainbow?", "Checkbox", correctAnswers, multiAnswer);

            TrueFalse question3 = new TrueFalse("Black is the absence of color?", "True/False", true);

            //add question child classes to a list of objects
            questions.Add(question1);
            questions.Add(question2);
            questions.Add(question3);

            //create method that prompts questions
            foreach (Question question in questions)
            {
                question.Prompt();
                question.GetAnswer();
            }

            //original attempt before i figured out how to loop through the Question class instanfes
            //question1.Prompt();
            //question1.GetAnswer();
            //question2.Prompt();
            //question2.GetAnswer();
            //question3.Prompt();
            //question3.GetAnswer();

            //method for grading
            int testScore = 0;

            foreach (Question question in questions)
            {
                if (question.CorrectlyAnswered == true)
                {
                    testScore++;
                }
            }

            //same thing as above but in a for loop format
            //for (int i = 0; i < questions.Count; i++)
            //{
            //    if (questions[i].CorrectlyAnswered == true)
            //    {
            //        testScore++;
            //    }
            //}

            //if i return the answer from the "prompt" method
            //i could move the logic for evaluating correct answers into this main file

            Console.WriteLine($"\nThank you for taking our quiz, your score was {testScore}/{questions.Count}.");
        }
    }
}
