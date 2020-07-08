using System;
using System.Collections.Generic;
using System.Linq;

namespace P02PracticeSessions
{
    class Program
    {
        static void Main()
        {
            string input;

            Dictionary<string, List<string>> dictRoadAndRacers = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "END")
            {
                string[] splitedInput = input.Split("->");

                switch (splitedInput[0])
                {
                    case "Add":
                        string road = splitedInput[1];
                        string racer = splitedInput[2];
                        if (!dictRoadAndRacers.ContainsKey(road))
                        {
                            dictRoadAndRacers.Add(road, new List<string>());
                        }

                        dictRoadAndRacers[road].Add(racer);
                        break;
                    case "Move":
                        road = splitedInput[1];
                        racer = splitedInput[2];
                        string nextRoad = splitedInput[3];
                        if (dictRoadAndRacers.ContainsKey(road) 
                            && dictRoadAndRacers[road].Contains(racer) 
                            && dictRoadAndRacers.ContainsKey(nextRoad))
                        {
                            dictRoadAndRacers[road].Remove(racer);

                            dictRoadAndRacers[nextRoad].Add(racer);
                        }
                        break;
                    case "Close":
                        road = splitedInput[1];
                        if (dictRoadAndRacers.ContainsKey(road))
                        {
                            dictRoadAndRacers.Remove(road);
                        }
                        break;
                }
            }

            dictRoadAndRacers = dictRoadAndRacers
                .OrderByDescending (x=>x.Value.Count())
                .ThenBy(x=>x.Key).ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Practice sessions:");
            foreach (var road in dictRoadAndRacers)
            {
                Console.WriteLine(road.Key);
                foreach (var racer in road.Value)
                {
                    Console.WriteLine($"++{racer}");
                }
            }
        }
    }
}
