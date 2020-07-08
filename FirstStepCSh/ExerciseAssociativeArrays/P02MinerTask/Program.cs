using System;
using System.Linq;
using System.Collections.Generic;

namespace P02MinerTask
{
    class Program
    {
        static void Main()
        {
            string input;

            Dictionary<string, int> counts = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                    if (!counts.ContainsKey(input))
                    {
                        counts.Add(input, 0);
                    }

                    counts[input] += quantity;
            }

            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
