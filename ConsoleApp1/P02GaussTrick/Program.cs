using System;
using System.Linq;
using System.Collections.Generic;

namespace P02GaussTrick
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> newNumber = new List<int>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                newNumber.Add(numbers[i] + numbers[numbers.Count - 1 - i]);
            }
            if (numbers.Count % 2 == 1)
            {
                newNumber.Add(numbers[numbers.Count / 2]);
            }
            Console.WriteLine(string.Join(" ", newNumber));
        }
    }
}
