using System;

namespace divideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());

                if (current % 2 == 0)
                {
                    p1++;
                }
                if (current % 3 == 0)
                {
                    p2++;
                }
                if (current % 4 == 0)
                {
                    p3++;
                }
            }
            double p1Current = p1 / n * 100;
            double p2Current = p2 / n * 100;
            double p3Current = p3 / n * 100;

            Console.WriteLine($"{p1Current:f2}%");
            Console.WriteLine($"{p2Current:f2}%");
            Console.WriteLine($"{p3Current:f2}%");
        }
    }
}
