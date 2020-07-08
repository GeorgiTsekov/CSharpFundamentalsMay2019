using System;
using System.Linq;
using System.Collections.Generic;

namespace P03LegendaryFarming
{
    class Program
    {
        static void Main()
        {
            var dict = new Dictionary<string, int>();

            dict.Add("shards", 0);

            dict.Add("fragments", 0);

            dict.Add("motes", 0);

            var junk = new Dictionary<string, int>();

            while (true)
            {
                bool haveWinner = false;

                string[] input = Console.ReadLine()
                .ToLower()
                .Split(" ");

                for (int i = 0; i < input.Length; i += 2)
                {
                    string material = input[i + 1];

                    int quantity = int.Parse(input[i]);

                    if (dict.ContainsKey(material))
                    {
                        dict[material] += quantity;

                        if (dict[material] >= 250)
                        {
                            if (material == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }
                            else if (material == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }
                            else if (material == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            haveWinner = true;

                            dict[material] -= 250;

                            break;
                        }
                    }
                    else
                    {
                        if (junk.ContainsKey(material))
                        {
                            junk[material] += quantity;
                        }
                        else
                        {
                            junk.Add(material, quantity);
                        }
                    }
                }

                if (haveWinner == true)
                {
                    break;
                }
            }
            
            var result = dict.OrderByDescending(x => x.Value).ThenBy(x=>x.Key);

            var junkResult = junk.OrderBy(x => x.Key);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junkResult)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
