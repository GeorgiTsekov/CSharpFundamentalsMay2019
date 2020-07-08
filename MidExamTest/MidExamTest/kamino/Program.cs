using System;
using System.Linq;
using System.Collections.Generic;

namespace MixedUpLIst
{
    class Program
    {
        static void Main()
        {
            List<int> firstNumbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> secondNumbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> numbers = new List<int>();

            int firstNumber = 0;

            int secondNumber = 0;

            if (firstNumbers.Count > secondNumbers.Count)
            {
                firstNumber = firstNumbers[firstNumbers.Count - 1];
                firstNumbers.RemoveAt(firstNumbers.Count - 1);
                secondNumber = firstNumbers[firstNumbers.Count - 1];
                firstNumbers.RemoveAt(firstNumbers.Count - 1);
            }
            else if (firstNumbers.Count < secondNumbers.Count)
            {
                firstNumber = secondNumbers[0];
                secondNumbers.RemoveAt(0);
                secondNumber = secondNumbers[0];
                secondNumbers.RemoveAt(0);
            }
            for (int i = 0; i < firstNumbers.Count; i++)
            {
                secondNumbers.Add(firstNumbers[i]);
            }
            if (firstNumber > secondNumber)
            {
                for (int i = 0; i < secondNumbers.Count; i++)
                {
                    if (secondNumbers[i] > secondNumber 
                        && secondNumbers[i] < firstNumber)
                    {
                        numbers.Add(secondNumbers[i]);
                    }
                }                           
            }
            else if (firstNumber < secondNumber)
            {
                for (int i = 0; i < secondNumbers.Count; i++)
                {
                    if (secondNumbers[i] < secondNumber
                        && secondNumbers[i] > firstNumber)
                    {
                        numbers.Add(secondNumbers[i]);
                    }
                }
            }

            numbers.Sort();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
