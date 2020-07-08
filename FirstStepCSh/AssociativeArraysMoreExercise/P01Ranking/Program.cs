using System;
using System.Linq;
using System.Collections.Generic;

namespace P01Ranking
{
    class Program
    {
        static void Main()
        {
            string input;

            Dictionary<string, string> dictLanguageAndPass = new Dictionary<string, string>();

            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] splitedInput = input.Split(":");

                string language = splitedInput[0];

                string password = splitedInput[1];

                dictLanguageAndPass.Add(language, password);
            }

            Dictionary<string, Dictionary<string, int>> dictNameLanguagePoints = new Dictionary<string, Dictionary<string, int>>();

            string newInput;

            while ((newInput = Console.ReadLine()) != "end of submissions")
            {
                string[] splitedNewInput = newInput.Split("=>");

                string language = splitedNewInput[0];

                string password = splitedNewInput[1];

                string name = splitedNewInput[2];

                int points = int.Parse(splitedNewInput[3]);

                if (dictLanguageAndPass.ContainsKey(language) && (dictLanguageAndPass.ContainsValue(password)))
                {
                    if (!dictNameLanguagePoints.ContainsKey(name))
                    {
                        dictNameLanguagePoints[name] = new Dictionary<string, int>();
                    }

                    if (dictNameLanguagePoints[name].ContainsKey(language))
                    {
                        if (dictNameLanguagePoints[name][language] < points)
                        {
                            dictNameLanguagePoints[name][language] = points;
                        }
                    }
                    else
                    {
                        dictNameLanguagePoints[name].Add(language, points);
                    }
                }
            }

            int bestPointsMember = 0;

            string bestMember = string.Empty;

            foreach (var item in dictNameLanguagePoints)
            {
                if (bestPointsMember < item.Value.Values.Sum())
                {
                    bestPointsMember = item.Value.Values.Sum();
                    bestMember = item.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestMember} with total {bestPointsMember} points.");

            Console.WriteLine("Ranking: ");

            var result = dictNameLanguagePoints
                .OrderBy(x => x.Key);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}");
                var sss = item.Value.OrderByDescending(x => x.Value);
                foreach (var kpd in sss)
                {
                    Console.WriteLine($"#  {kpd.Key} -> {kpd.Value}");
                }
            }
        }
    }
}
