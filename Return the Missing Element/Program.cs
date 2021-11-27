using System;

namespace Return_the_Missing_Element
{
    class Program
    {
        public static int GetMissingElement(int[] sourceArray)
        {
            for (int i = 0; i < sourceArray.Length; i++)
            {
                for (int j = 0; j < sourceArray.Length; j++)
                {
                    if (i == sourceArray[j])
                    {
                        break;
                    }
                    if (j == sourceArray.Length - 1)
                    {
                        return i;
                    }
                }
            }
            return 0;
        }

        static void Main(string[] args)
        {
            int[] ar = { 6, 8, 7, 5, 4, 3, 2, 1, 0 };
            Console.WriteLine(GetMissingElement(ar));
        }
    }
}
