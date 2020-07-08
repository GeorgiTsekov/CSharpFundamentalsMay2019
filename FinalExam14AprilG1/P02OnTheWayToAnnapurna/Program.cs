using System;
using System.Collections.Generic;
using System.Linq;

namespace P02OnTheWayToAnnapurna
{
    class Program
    {
        static void Main()
        {
            string input;

            Dictionary<string, List<string>> dictStoreAndItems = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "END")
            {
                string[] splitedInput = input.Split("->");

                switch (splitedInput[0])
                {
                    case "Add":
                        string store = splitedInput[1];
                        string[] items = splitedInput[2].Split(",");
                        if (!dictStoreAndItems.ContainsKey(store))
                        {
                            dictStoreAndItems.Add(store, new List<string>());
                        }

                        foreach (var item in items)
                        {
                            dictStoreAndItems[store].Add(item);
                        }
                        break;
                    case "Remove":
                        store = splitedInput[1];
                        if (dictStoreAndItems.ContainsKey(store))
                        {
                            dictStoreAndItems.Remove(store);
                        }
                        break;
                }
            }

            dictStoreAndItems = dictStoreAndItems.OrderByDescending(x => x.Value.Count())
                .ThenByDescending(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Stores list:");
            foreach (var store in dictStoreAndItems)
            {
                Console.WriteLine(store.Key);
                foreach (var item in store.Value)
                {
                    Console.WriteLine($"<<{item}>>");
                }
            }
        }
    }
}
