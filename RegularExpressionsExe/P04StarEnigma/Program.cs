using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace P04StarEnigma
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<string> planetsA = new List<string>();
            List<string> planetsD = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string encryptedMessages = Console.ReadLine();

                string decryptedMessages = string.Empty;

                var starNumbersRegex = Regex.Matches(encryptedMessages, @"[STARstar]");

                int countOfStars = starNumbersRegex.Count;

                foreach (var item in encryptedMessages)
                {
                    char newItem = (char)(item - countOfStars);
                    decryptedMessages += newItem;
                }
                var starRegex = Regex.Matches(decryptedMessages, @"@(?<planet>[A-Za-z]+)[^@:!\->]*:(?<population>\d+)[^@:!\->]*!(?<AorD>[A]|[D]+)![^@:!\->]*->(?<soldiers>\d+)[^@:!\->]*");

                foreach (Match item in starRegex)
                {
                    string planet = item.Groups["planet"].ToString();
                    string attackOrDef = item.Groups["AorD"].ToString();

                    if (attackOrDef == "A")
                    {
                        planetsA.Add(planet);
                    }
                    if (attackOrDef == "D")
                    {
                        planetsD.Add(planet);
                    }
                }
            }
            planetsA.Sort();

            planetsD.Sort();

            if (planetsA.Count > 0)
            {
                Console.WriteLine($"Attacked planets: {planetsA.Count}");
                foreach (var item in planetsA)
                {
                    Console.WriteLine($"-> {item}");
                }
            }
            else
            {
                Console.WriteLine($"Attacked planets: {planetsA.Count}");
            }

            if (planetsD.Count > 0)
            {
                Console.WriteLine($"Destroyed planets: {planetsD.Count}");
                foreach (var item in planetsD)
                {
                    Console.WriteLine($"-> {item}");
                }
            }
            else
            {
                Console.WriteLine($"Destroyed planets: {planetsD.Count}");
            }
        }
    }
}
