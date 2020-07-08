using System;

namespace halfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxCurrent = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                sum += current;
                if (current > maxCurrent)
                {
                    maxCurrent = current;
                }
            }
            int diff = Math.Abs(sum - maxCurrent * 2);
            if (sum - maxCurrent == maxCurrent)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxCurrent}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
