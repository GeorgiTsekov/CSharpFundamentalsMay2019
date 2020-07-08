using System;
using System.Collections.Generic;
using System.Linq;

namespace P09ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> listOfNumbers = new List<int>();

            for (int i = 1; i <= number; i++)
            {
                bool isDivider = true;
                foreach (var item in numbers)
                {
                    if (i % item != 0)
                    {
                        isDivider = false;
                    }
                }
                if (isDivider)
                {
                    listOfNumbers.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", listOfNumbers));
        }
    }
}
