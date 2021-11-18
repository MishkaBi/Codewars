using System;

namespace All_Star_Code_Challenge_15
{
    class Program
    {
        public static string[] RotateString(string text)
        {
            char[] letters = text.ToCharArray();
            string allWords = string.Empty;
            for (int i = 0, initialSymbol = 1; i < letters.Length; i++, initialSymbol++)
            {
                for (int j = 0, s = initialSymbol; j < letters.Length; j++)
                {
                    if (s >= letters.Length)
                    {
                        s = 0;
                    }
                    allWords += letters[s];
                    s++;
                }
                if (i< letters.Length - 1)
                {
                    allWords += " ";
                }
            }
            string[] result = allWords.Split(" ");
            for (int w = 0; w < result.Length; w++)
            {
                Console.Write(result[w] + " ");
            }
            return result;
        }
        static void Main(string[] args)
        {
            string word = "Hello";
            Console.WriteLine(RotateString(word));
        }
    }
}
