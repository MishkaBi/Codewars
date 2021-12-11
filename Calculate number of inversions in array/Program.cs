using System;

namespace Calculate_number_of_inversions_in_array
{
    class Program
    {
        public static int CountInversions(int[] array)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int tmp = array[j];
                        array[j] = array[i];
                        array[i] = tmp;
                        counter++;
                    }
                }
            }
            return counter;
        }
        static void Main(string[] args)
        {
            int[] array = { 4, 3, 2, 1};

            Console.WriteLine(CountInversions(array)); // 6
        }
    }
}
