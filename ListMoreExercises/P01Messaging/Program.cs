using System;
using System.Linq;
using System.Collections.Generic;

namespace P01Messaging
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<char> messege = Console.ReadLine()
                .ToList();
                
            string newMessege = string.Empty;

            for (int i = 0; i < numbers.Count; i++)
            {
                int sumOfNumbers = 0;

                int number = numbers[i];

                while (number != 0)
                {
                    int lastNumber = number % 10;
                    number = number / 10;
                    sumOfNumbers += lastNumber;
                }
                while (sumOfNumbers >= messege.Count)
                {
                    sumOfNumbers -= messege.Count;
                }
                for (int j = 0; j < messege.Count; j++)
                {
                    if (sumOfNumbers == j)
                    {
                        newMessege += messege[j];
                        messege.RemoveAt(j);
                    }
                }
            }
            Console.WriteLine(newMessege);
        }
    }
}
