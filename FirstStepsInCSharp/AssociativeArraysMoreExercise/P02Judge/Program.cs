using System;
using System.Linq;
using System.Collections.Generic;

namespace P02Judge
{
    class Program
    {
        static void Main()
        {
            string input;

            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] splitedInput = input.Split(" -> ");

                string name = splitedInput[0];

                string modul = splitedInput[1];

                int points = int.Parse(splitedInput[2]);

                if (!dict.ContainsKey(modul))
                {
                    dict[modul] = new Dictionary<string, int>();
                }

                if (dict[modul].ContainsKey(name))
                {
                    if (dict[modul][name] < points)
                    {
                        dict[modul][name] = points;
                    }
                }
                else
                {
                    dict[modul].Add(name, points);
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count} participants");

                var sss = item.Value
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x=>x.Key);

                int counter = 0;
                foreach (var kdv in sss)
                {
                    counter++;
                    Console.WriteLine($"{counter}. {kdv.Key} <::> {kdv.Value}");
                }
            }

            Console.WriteLine("Individual standings:");

            Dictionary<string, int> newDict = new Dictionary<string, int>();

            string userName = string.Empty;

            foreach (var item in dict)
            {
                foreach (var kpd in item.Value)
                {
                    userName = kpd.Key;
                    if (!newDict.ContainsKey(userName))
                    {
                        newDict[userName] = 0;
                    }

                    newDict[userName] += kpd.Value;
                }
            }

            newDict = newDict
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            int count = 0;

            foreach (var item in newDict)
            {
                count++;

                Console.WriteLine($"{count}. {item.Key} -> {item.Value}");
            }
        }
    }
}
