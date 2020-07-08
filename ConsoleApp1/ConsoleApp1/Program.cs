    using System;
    using System.Linq;
    using System.Collections.Generic;

    namespace P01SumAdjacentEqualNumbers
    {
        class Program
        {
            static void Main()
            {
                List<double> numbers = Console.ReadLine()
                    .Split()
                    .Select(double.Parse)
                    .ToList();

                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i - 1] == numbers[i])
                    {
                        numbers[i - 1] = (numbers[i - 1] + numbers[i]);
                        numbers.RemoveAt(i);
                        i = 0;
                    }

                }
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
