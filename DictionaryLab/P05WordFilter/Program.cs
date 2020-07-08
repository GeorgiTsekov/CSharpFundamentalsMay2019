using System;
using System.Linq;
using System.Collections.Generic;

namespace P05WordFilter
{
    class Program
    {
        static void Main()
        {
            List<string> words = Console.ReadLine()
                .Split(" ")
                .Where(x => x.Length % 2 == 0)
                .ToList();

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
