using System;
using System.Linq;
using System.Collections.Generic;

namespace P04Orders
{
    class Program
    {
        static void Main()
        {
            string input;

            Dictionary<string, List<double>> counts = new Dictionary<string, List<double>>();

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] command = input.Split(" ");

                string name = command[0];

                double price = double.Parse(command[1]);

                int quantity = int.Parse(command[2]);

                if (!counts.ContainsKey(name))
                {
                    counts.Add(name, new List<double>() { price, quantity });
                }
                else
                {
                    counts[name][0] = price;
                    counts[name][1] += quantity;
                }
            }

            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0] * item.Value[1]):F2}");
            }
        }
    }
}
