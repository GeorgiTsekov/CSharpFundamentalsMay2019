using System;
using System.Linq;
using System.Collections.Generic;

namespace P05DragonArmy
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<int>>> dictOfDragons = new Dictionary<string, Dictionary<string, List<int>>>();

            Dictionary<string, List<double>> dictOfTypes = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] splitedDragonArray = Console.ReadLine().Split();
                
                string type = splitedDragonArray[0];
                string name = splitedDragonArray[1];
                int damage = 0;
                int health = 0;
                int armor = 0;
                if (splitedDragonArray[2] == "null")
                {
                    damage = 45;
                }
                else
                {
                    damage = int.Parse(splitedDragonArray[2]);
                }
                if (splitedDragonArray[3] == "null")
                {
                    health = 250;
                }
                else
                {
                    health = int.Parse(splitedDragonArray[3]);
                }
                if (splitedDragonArray[4] == "null")
                {
                    armor = 10;
                }
                else
                {
                    armor = int.Parse(splitedDragonArray[4]);
                }

                if (!dictOfDragons.ContainsKey(type))
                {
                    dictOfDragons.Add(type, new Dictionary<string, List<int>>());
                }
                if (!dictOfDragons[type].ContainsKey(name))
                {
                    dictOfDragons[type].Add(name, new List<int>());
                    dictOfDragons[type][name].Add(damage);
                    dictOfDragons[type][name].Add(health);
                    dictOfDragons[type][name].Add(armor);
                }
                else
                {
                    dictOfDragons[type][name][0] = damage;
                    dictOfDragons[type][name][1] = health;
                    dictOfDragons[type][name][2] = armor;
                }                                
            }

            foreach (var type in dictOfDragons)
            {
                if (!dictOfTypes.ContainsKey(type.Key))
                {
                    dictOfTypes.Add(type.Key, new List<double>());
                }
                foreach (var name in type.Value)
                {
                    if (dictOfTypes[type.Key].Count == 0)
                    {
                        dictOfTypes[type.Key].Add(name.Value[0]);
                        dictOfTypes[type.Key].Add(name.Value[1]);
                        dictOfTypes[type.Key].Add(name.Value[2]);
                        dictOfTypes[type.Key].Add(1);
                    }
                    else
                    {
                        dictOfTypes[type.Key][0] += name.Value[0];
                        dictOfTypes[type.Key][1] += name.Value[1];
                        dictOfTypes[type.Key][2] += name.Value[2];
                        dictOfTypes[type.Key][3] += 1;
                    }
                }
            }
            foreach (var type in dictOfTypes)
            {
                for (int i = 0; i < type.Value.Count; i++)
                {
                    type.Value[i] = type.Value[i] / type.Value[3];
                }
                type.Value.RemoveAt(3);
                Console.WriteLine($"{type.Key}::({type.Value[0]:F2}/{type.Value[1]:F2}/{type.Value[2]:F2})");
                if (dictOfDragons.ContainsKey(type.Key))
                {
                    foreach (var dragon in dictOfDragons[type.Key].OrderBy(x => x.Key))
                    {

                        Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                    }
                }
            }
        }
    }
}
