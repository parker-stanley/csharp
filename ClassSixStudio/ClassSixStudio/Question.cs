using System;

namespace ClassSixStudio
{
    public abstract class Question
    {
        public string Text { get; set; }
        public string Type { get; set; }
        public bool CorrectlyAnswered { get; set; }

        public Question(string text, string type)
        {
            Text = text;
            Type = type;
        }

        public abstract void Prompt();

        public abstract void GetAnswer();
    }
}
