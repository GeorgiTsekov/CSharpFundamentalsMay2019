using System;
using System.Linq;
using System.Collections.Generic;

namespace P04SnowWhite
{
    class Program
    {
        static void Main()
        {
            string input;

            Dictionary<string, Dictionary<string, int>> dictColorNamePhysic = new Dictionary<string, Dictionary<string, int>>();

            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] splitedInput = input.Split(new char[] { '<', ':', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string name = splitedInput[0];

                string color = splitedInput[1];

                int physic = int.Parse(splitedInput[2]);

                if (!dictColorNamePhysic.ContainsKey(color))
                {
                    dictColorNamePhysic.Add(color, new Dictionary<string, int>());
                }

                if (!dictColorNamePhysic[color].ContainsKey(name))
                {
                    dictColorNamePhysic[color].Add(name, 0);
                }

                if (dictColorNamePhysic[color][name] < physic)
                {
                    dictColorNamePhysic[color][name] = physic;
                }
            }

            dictColorNamePhysic = dictColorNamePhysic
                .OrderByDescending(x => x.Value.Values.Max())
                .ThenByDescending(x => x.Value.Keys.Count())
                .ToDictionary(x => x.Key, x => x.Value);

            Dictionary<string, int> newDict = new Dictionary<string, int>();

            foreach (var color in dictColorNamePhysic)
            {
                foreach (var name in color.Value)
                {
                    string colorAndName = "("+color.Key+") " + name.Key;
                    newDict.Add(colorAndName, name.Value);
                }
            }

            var result = newDict.OrderByDescending(x => x.Value);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");
            }
        }
    }
}
