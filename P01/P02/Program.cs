using System;
using System.Linq;
using System.Collections.Generic;

namespace P02
{
    class Program
    {
        static void Main()
        {
            string input;

            Dictionary<string, List<int>> dictPeapleHealthEnergy = new Dictionary<string, List<int>>();

            Dictionary<string, List<int>> removedDict = new Dictionary<string, List<int>>();            

            while ((input = Console.ReadLine()) != "Results")
            {
                string[] splitedInput = input.Split(":");

                switch (splitedInput[0])
                {
                    case "Add":
                        string name = splitedInput[1];
                        int health = int.Parse(splitedInput[2]);
                        int energy = int.Parse(splitedInput[3]);
                        if (!dictPeapleHealthEnergy.ContainsKey(name))
                        {
                            dictPeapleHealthEnergy.Add(name, new List<int>());
                            dictPeapleHealthEnergy[name].Add(energy);
                            dictPeapleHealthEnergy[name].Add(health);
                        }
                        else
                        {
                            dictPeapleHealthEnergy[name][1] += health;
                        }
                        break;
                    case "Attack":
                        string attackerName = splitedInput[1];
                        string defenderName = splitedInput[2];
                        int damage = int.Parse(splitedInput[3]);
                        if (dictPeapleHealthEnergy.ContainsKey(attackerName) 
                            && dictPeapleHealthEnergy.ContainsKey(defenderName))
                        {
                            dictPeapleHealthEnergy[defenderName][1] -= damage;
                            dictPeapleHealthEnergy[attackerName][0] -= 1;

                            if (dictPeapleHealthEnergy[defenderName][1] <= 0)
                            {
                                dictPeapleHealthEnergy.Remove(defenderName);
                                Console.WriteLine($"{defenderName} was disqualified!");
                            }
                            if (dictPeapleHealthEnergy[attackerName][0] <= 0)
                            {
                                dictPeapleHealthEnergy.Remove(attackerName);
                                Console.WriteLine($"{attackerName} was disqualified!");
                            }
                        }
                        break;
                    case "Delete":
                        string username = splitedInput[1];
                        if (username == "All")
                        {
                            dictPeapleHealthEnergy = removedDict;
                        }
                        if (dictPeapleHealthEnergy.ContainsKey(username))
                        {
                            dictPeapleHealthEnergy.Remove(username);
                        }
                        break;
                }
            }
            var result = dictPeapleHealthEnergy.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key);

            Console.WriteLine($"People count: {dictPeapleHealthEnergy.Keys.Count}");
            foreach (var name in result)
            {
                Console.WriteLine($"{name.Key} - {name.Value[1]} - {name.Value[0]}");
            }                       
        }
    }
}
