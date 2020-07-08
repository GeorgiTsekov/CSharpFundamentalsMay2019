using System;
using System.Collections.Generic;
using System.Linq;

namespace P01Dictionary
{
    class Program
    {
        static void Main()
        {
            string[] definitions = Console.ReadLine().Split(" | ");

            Dictionary<string, List<string>> dictOfDefinitions = new Dictionary<string, List<string>>();

            foreach (var definition in definitions)
            {
                string[] words = definition.Split(": ");

                string nameOfDefinition = words[0];

                if (!dictOfDefinitions.ContainsKey(nameOfDefinition))
                {
                    dictOfDefinitions.Add(nameOfDefinition, new List<string>());
                }

                for (int i = 1; i < words.Length; i++)
                {
                    dictOfDefinitions[nameOfDefinition].Add(words[i]);
                }
            }

            string[] namesOfDefinitions = Console.ReadLine().Split(" | ");

            foreach (var name in namesOfDefinitions)
            {
                if (dictOfDefinitions.ContainsKey(name))
                {
                    Console.WriteLine(name);
                    var dictOrder = dictOfDefinitions[name].OrderByDescending(x => x.Length).ToList();
                    foreach (var definition in dictOrder)
                    {
                        Console.WriteLine($" -{definition}");
                    }
                }
            }

            string lastInput = Console.ReadLine();

            if (lastInput == "List")
            {
                dictOfDefinitions = dictOfDefinitions.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
                Console.WriteLine(string.Join(" ",dictOfDefinitions.Keys));
            }
            else
            {
                return;
            }
        }
    }
}
