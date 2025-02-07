﻿using System;
using System.Linq;

namespace P07EqualArrays
{
    class Program
    {
        static void Main()
        {
            int[] firstArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] secondArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (secondArray[i] != firstArray[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                else
                {
                    sum += firstArray[i];
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
