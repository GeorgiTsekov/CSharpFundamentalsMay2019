using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 != 0)
                {
                    sum = i + sum;
                    Console.WriteLine(i);
                }
                else
                {
                    number++;
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
