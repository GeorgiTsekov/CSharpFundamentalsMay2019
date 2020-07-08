using System;

namespace equalPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int lastSum = 0;
            int minDiff = 0;
            int maxDiff = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int currentOne = int.Parse(Console.ReadLine());
                int currentTwo = int.Parse(Console.ReadLine());
                int sum = currentOne + currentTwo;

                if (i == 0)
                {
                    lastSum = sum;
                }
                if (sum != lastSum)
                {
                    minDiff = Math.Abs(lastSum - sum);
                    if (minDiff > maxDiff)
                    {
                        maxDiff = minDiff;
                    }
                }
                lastSum = sum;
            }
            if (maxDiff != int.MinValue)
            {
                Console.WriteLine($"No, maxdiff={maxDiff}"); 
            }
            else
            {
                Console.WriteLine($"Yes, value={lastSum}");
            }
        }
    }
}
