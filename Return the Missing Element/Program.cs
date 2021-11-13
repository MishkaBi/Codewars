using System;

namespace Return_the_Missing_Element
{
    class Program
    {
        public static int GetMissingElement(int[] superImportantArray)
        {
            int result = 0;
            for (int i = 0; i < superImportantArray.Length; i++)
            {
                for (int j = 0; j < superImportantArray.Length; j++)
                {
                    if (i == superImportantArray[j])
                    {
                        break;
                    }
                    if (j == superImportantArray.Length - 1)
                    {
                        result = i;
                    }
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            int[] ar = { 9, 8, 7, 5, 4, 3, 2, 1, 0 };
            Console.WriteLine(GetMissingElement(ar));
        }
    }
}
