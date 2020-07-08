

namespace P02RandomizeWords
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<string> words = Console.ReadLine()
                .Split(" ")
                .ToList();

            Random random = new Random();           

            for (int i = 0; i < words.Count; i++)
            {
                int randomIndex = random.Next(0, words.Count);
                string randomElement = words[randomIndex];
                string element = words[i];
                words[randomIndex] = element;
                words[i] = randomElement;
            }
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
