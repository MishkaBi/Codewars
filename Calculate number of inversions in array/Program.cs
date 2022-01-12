using System;

namespace Calculate_number_of_inversions_in_array
{
    class Program
    {
        public static int CountInversions(int[] array)
        {
            int counter = 0;
            for (int i = 0, q = 0; q < array.Length; q++)
            {
                for (int j = 0; j < array.Length - q; j++)
                {
                    if (array[i] > array[j])
                    {
                        int tmp = array[j];
                        array[j] = array[i];
                        array[i] = tmp;
                        counter++;
                        i++;
                    }
                    else if (array[i] == array[j])
                    {
                        i = j;
                    }
                    else if (array[i] < array[j])
                    {
                        i++;
                    }
                }
                i = 0;
            }
            return counter;
        }
        static void Main(string[] args)
        {
            int[] array = {1, 2, 1, 2, 3};

            Console.WriteLine(CountInversions(array));

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
