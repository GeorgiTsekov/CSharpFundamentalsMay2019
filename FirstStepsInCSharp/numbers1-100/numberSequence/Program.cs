using System;

namespace numberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                if (current < minNumber)
                {
                    minNumber = current;
                }
                if (current > maxNumber)
                {
                    maxNumber = current;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
