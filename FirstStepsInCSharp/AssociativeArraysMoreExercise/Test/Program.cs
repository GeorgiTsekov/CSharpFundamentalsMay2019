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

                if (!dictColorNamePhysic.ContainsKey(name))
                {
                    dictColorNamePhysic.Add(name, new Dictionary<string, int>());
                }

                if (!dictColorNamePhysic[name].ContainsKey(color))
                {
                    dictColorNamePhysic[name].Add(color, 0);
                }

                if (dictColorNamePhysic[name][color] < physic)
                {
                    dictColorNamePhysic[name][color] = physic;
                }
            }

            dictColorNamePhysic = dictColorNamePhysic
                .OrderByDescending(x => x.Value.Values.Max())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var name in dictColorNamePhysic)
            {
                foreach (var color in name.Value)
                {
                    Console.WriteLine($"({color.Key}) {name.Key} <-> {color.Value}");
                }
            }
        }
    }
}
