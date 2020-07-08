using System;
using System.Collections.Generic;
using System.Linq;

namespace P08CondenseArrayToNumber
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] sumOfNumbers = new int[numbers.Length - 1];
            int count = numbers.Length;

            while (count > 0)
            {
                count--;
                for (int i = 0; i < count; i++)
                {                    
                    sumOfNumbers[i] = numbers[i] + numbers[i + 1];
                    numbers[i] = sumOfNumbers[i];
                }
            }            
            Console.WriteLine(string.Join(" ",numbers[0]));
        }
    }
}
