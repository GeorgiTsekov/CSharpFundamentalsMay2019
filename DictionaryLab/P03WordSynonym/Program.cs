using System;
using System.Linq;
using System.Collections.Generic;

namespace P03WordSynonym
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>(); 

            for (int i = 0; i < count; i++)
            {
                string word = Console.ReadLine();

                string synonym = Console.ReadLine();

                if (!synonyms.ContainsKey(word))
                {
                    synonyms.Add(word, new List<string>());
                }

                synonyms[word].Add(synonym);
            }

            foreach (var item in synonyms)
            {
                Console.Write($"{item.Key} - {string.Join(", ",item.Value)}");
                Console.WriteLine();
            }
        }
    }
}
