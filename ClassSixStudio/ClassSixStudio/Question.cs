using System;

namespace ClassSixStudio
{
    public abstract class Question
    {

        public Question()
        {
        }

        public abstract void Prompt();

        //should I have a ToString override method that prints the question?

        //should I add a method for checking the answer and printing correct/incorrect?
    }
}
