using System;

namespace AliceInWonderland
{
    public class SentenceModifier
    {
        public static string Modify(string input)
        {
            string sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            int index = sentence.IndexOf(input);
            int length = input.Length;
            string firstPart = sentence.Substring(0, index);
            string secondPart = sentence.Substring(index + length +1);
            string newSentence = firstPart + secondPart;
            return newSentence;
        }
    }
}
