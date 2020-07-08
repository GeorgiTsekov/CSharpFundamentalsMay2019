using System;
using System.Linq;
using System.Collections.Generic;

namespace P05SumEvenNumbers
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .ToList();

            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }
    }
}
