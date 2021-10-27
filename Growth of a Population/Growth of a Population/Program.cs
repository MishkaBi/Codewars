using System;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            int p0 = 1500;
            double percent = 0.05;
            int aug = 100;
            int p = 5000;

            int n;
            for (n = 0; p0 < p; n++)
            {
                p0 = (int)(p0 + p0 * percent + aug);
            }
            Console.WriteLine(n);
        }
    }
}