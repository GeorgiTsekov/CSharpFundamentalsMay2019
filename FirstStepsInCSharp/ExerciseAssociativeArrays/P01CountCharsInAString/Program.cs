using System;
using System.Linq;
using System.Collections.Generic;

namespace P01CountCharsInAString
{
    class Program
    {
        static void Main()
        {
            char[] text = Console.ReadLine()
                .Where(x=>x != ' ')
                .ToArray();
            
            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (var item in text)
            {
                if (counts.ContainsKey(item))
                {
                    counts[item]++;
                }
                else
                {
                    counts.Add(item, 1);
                }
            }

            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
