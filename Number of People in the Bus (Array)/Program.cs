using System;

namespace Number_of_People_in_the_Bus
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int[,] people = { {10, 0}, {3, 5}, {5, 8} };
            Console.WriteLine(Number(people));
        }
        public static int Number(int[,] peopArrayInOut)
        {
            int peopleGetIntoBus = 0;
            int peopleGetOffTheBus = 0;
            for (int i = 0; i < peopArrayInOut.Length / 2; i++)
            {
                peopleGetIntoBus += peopArrayInOut[i, 0];
                peopleGetOffTheBus += peopArrayInOut[i, 1];
            }
            return peopleGetIntoBus - peopleGetOffTheBus;
        }
    }
}
