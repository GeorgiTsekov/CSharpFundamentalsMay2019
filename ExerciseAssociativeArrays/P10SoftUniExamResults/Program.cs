using System;
using System.Linq;
using System.Collections.Generic;

namespace P10SoftUniExamResults
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> namesdict = new Dictionary<string, int>();

            Dictionary<string, int> languagedict = new Dictionary<string, int>();

            string input;

            while ((input = Console.ReadLine())!= "exam finished")
            {
                string[] splitedInput = input.Split("-");

                string username = splitedInput[0];

                if (splitedInput.Length == 3)
                {
                    string language = splitedInput[1];

                    int points = int.Parse(splitedInput[2]);

                    if (!namesdict.ContainsKey(username))
                    {
                        namesdict[username] = points;
                    }

                    if (!languagedict.ContainsKey(language))
                    {
                        languagedict[language] = 0;
                    }

                    if (namesdict[username] < points)
                    {
                        namesdict[username] = points;
                    }

                    languagedict[language] += 1;

                }
                else if (splitedInput.Length == 2)
                {
                    if (namesdict.ContainsKey(username))
                    {
                        namesdict.Remove(username);
                    }
                }
            }

            namesdict = namesdict
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Results:");

            foreach (var item in namesdict)
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }

            Console.WriteLine("Submissions:");

            languagedict = languagedict
                .OrderBy(x => x.Value)
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in languagedict)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
