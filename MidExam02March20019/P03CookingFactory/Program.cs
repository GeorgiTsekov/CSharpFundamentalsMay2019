using System;
using System.Collections.Generic;
using System.Linq;

namespace P03CookingFactory
{
    class Program
    {
        static void Main()
        {
            string input;

            double maxSum = double.MinValue;

            List<int> maxNumbers = new List<int>();

            while ((input = Console.ReadLine()) != "Bake It!")
            {
                List<int> numbers = input
                    .Split("#")
                    .Select(int.Parse)
                    .ToList();

                if (maxSum < numbers.Sum())
                {
                    maxSum = numbers.Sum();
                    maxNumbers = numbers;
                }
                else if (maxSum == numbers.Sum())
                {
                    double newSum = numbers.Sum();
                    if (maxSum / maxNumbers.Count < newSum / numbers.Count)
                    {
                        maxSum = newSum;
                        maxNumbers = numbers;
                    }
                }              
            }

            Console.WriteLine($"Best Batch quality: {maxSum}");
            Console.WriteLine(string.Join(" ", maxNumbers));
        }
    }
}
