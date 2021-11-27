using System;

namespace Elevator_Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {2, 15, 13, 2, 4, 4, 4, 5, 6 };
            Console.WriteLine(ElevatorDistance(array));
        }
        public static int ElevatorDistance(int[] array)
        {
            int distanceOfEachTrip = 0, result = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] - array[i + 1] < 0)
                {
                    distanceOfEachTrip = array[i] - array[i + 1];
                    distanceOfEachTrip *= -1;
                }
                else
                {
                    distanceOfEachTrip = array[i] - array[i + 1];
                }
                result += distanceOfEachTrip;
            }
            return result;
        }
    }
}
