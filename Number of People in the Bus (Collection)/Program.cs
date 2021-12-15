using System;
using System.Collections.Generic;

namespace Number_of_People_in_the_Bus__Collection_
{
    class Program
    {
        public static int Number1(List<int[]> peopleListInOut)
        {
            int peopleGetIntoBus = 0;
            int peopleGetOffTheBus = 0;
            for (int i = 0; i < peopleListInOut.Count; i++)
            {
                peopleGetIntoBus += peopleListInOut[i][0];
                peopleGetOffTheBus += peopleListInOut[i][1];
            }
            return peopleGetIntoBus - peopleGetOffTheBus;
        }

        public static int Number2(List<int[]> peopleListInOut)
        {
            for (int i = 1; i < peopleListInOut.Count; i++)
            {
                peopleListInOut[0][0] += peopleListInOut[i][0];
                peopleListInOut[0][1] += peopleListInOut[i][1];
            }
            return peopleListInOut[0][0] - peopleListInOut[0][1];
        }

        static void Main(string[] args)
        {
            List<int[]> peopleList = new List<int[]> { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } };

            Console.WriteLine(Number1(peopleList));
            Console.WriteLine(Number2(peopleList));

        }
    }
}
