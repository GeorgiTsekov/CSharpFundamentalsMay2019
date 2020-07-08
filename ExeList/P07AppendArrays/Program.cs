using System;
using System.Linq;
using System.Collections.Generic;

namespace P07AppendArrays
{
    class Program
    {
        static void Main()
        {
            List<string> numbers = Console.ReadLine()
                .Split(new[]  { '|'}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            numbers.Reverse();

            for (int i = 0; i < numbers.Count; i++)
            {
                int[] newArray = numbers[i]
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < newArray.Length; j++)
                {
                    Console.Write($"{newArray[j]} ", StringSplitOptions.RemoveEmptyEntries);
                }
            }
            Console.WriteLine();
        }
    }
}
