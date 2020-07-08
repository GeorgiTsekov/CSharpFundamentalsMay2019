using System;
using System.Collections.Generic;
using System.Linq;

namespace P01Concert
{
    class Program
    {
        static void Main()
        {
            string input;

            Dictionary<string, int> dictBandTime = new Dictionary<string, int>();

            Dictionary<string, List<string>> dictBandMembers = new Dictionary<string, List<string>>();

            int totalTime = 0;

            while ((input = Console.ReadLine()) != "start of concert")
            {
                string[] splitedInput = input.Split(new[] { ", ","; " }, StringSplitOptions.RemoveEmptyEntries);

                switch (splitedInput[0])
                {
                    case "Add":
                        string bandName = splitedInput[1];
                        if (!dictBandMembers.ContainsKey(bandName))
                        {
                            dictBandMembers.Add(bandName, new List<string>());
                        }

                        for (int i = 2; i < splitedInput.Length; i++)
                        {
                            if (!dictBandMembers[bandName].Contains(splitedInput[i]))
                            {
                                dictBandMembers[bandName].Add(splitedInput[i]);
                            }
                        }
                        break;
                    case "Play":
                        bandName = splitedInput[1];
                        int bandTime = int.Parse(splitedInput[2]);
                        if (!dictBandTime.ContainsKey(bandName))
                        {
                            dictBandTime.Add(bandName, 0);
                        }

                        totalTime += bandTime;
                        dictBandTime[bandName] += bandTime;
                        break;
                }
            }

            string band = Console.ReadLine();
            dictBandTime = dictBandTime
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"Total time: {totalTime}");

            foreach (var bandName in dictBandTime)
            {
                Console.WriteLine($"{bandName.Key} -> {bandName.Value}");
            }

            if (dictBandMembers.ContainsKey(band))
            {
                Console.WriteLine(band);
                foreach (var bandMember in dictBandMembers[band])
                {
                    Console.WriteLine($"=> {bandMember}");
                }
            }
        }
    }
}
