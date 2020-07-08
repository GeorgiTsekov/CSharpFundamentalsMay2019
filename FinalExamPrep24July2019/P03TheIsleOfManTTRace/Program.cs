using System;
using System.Text.RegularExpressions;

namespace P03TheIsleOfManTTRace
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                string text = Console.ReadLine();
                
                var matches = Regex.Match(text, @"([#$%*&]+)([A-Za-z]+)\1+=(\d+)!!(.+)");
                if (matches.Value == string.Empty)
                {
                    Console.WriteLine("Nothing found!");
                    continue;
                }
                int lenghtOfCode = int.Parse(matches.Groups[3].Value);
                string geohashCodeBefore = matches.Groups[4].Value;

                if (lenghtOfCode == geohashCodeBefore.Length)
                {
                    string nameRacer = matches.Groups[2].Value;
                    string geohashCodeAfter = string.Empty;
                    foreach (var character in geohashCodeBefore)
                    {
                        geohashCodeAfter += (char)(character + lenghtOfCode);
                    }
                    Console.WriteLine($"Coordinates found! {nameRacer} -> {geohashCodeAfter}");
                    break;
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                    continue;
                }
            }
            
        }
    }
}
