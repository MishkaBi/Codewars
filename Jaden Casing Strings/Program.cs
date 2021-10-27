using System;

namespace Jaden_Casing_Strings
{
    public static class JadenCase
    {
        public static string ToJadenCase(this string phrase) // Робить кожне слово з великої літери
        {
            string[] words = phrase.Split(' ');
            string text = string.Empty;
            for (int i = 0; i < words.Length; i++)
            {
                char[] word = words[i].ToCharArray();
                char firstLetter = char.ToUpper(word[0]);
                text += Convert.ToString(firstLetter);

                for (int p = 1; p < word.Length; p++)
                {
                    text += word[p];
                }
                text += " ";
            }
            text = text.Trim();
            return text;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ToJadenCase("How can mirrors be real if our eyes aren't real"));
        }
    }
}