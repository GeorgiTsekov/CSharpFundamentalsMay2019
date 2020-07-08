using System;
using System.Text.RegularExpressions;

namespace P01ArrivingInKathmandu
{
    class Program
    {
        static void Main()
        {
            string input;
            
            while ((input = Console.ReadLine()) != "Last note")
            {
                var matches = Regex.Match(input, @"^([[A-Za-z\d!@#$?]*[!@#$?]+[A-Za-z\d]+[[A-Za-z\d!@#$?]*[!@#$?]+[[A-Za-z\d!@#$?]*)=(\d+)<<(.+)");

                if (matches.Value == string.Empty)
                {
                    Console.WriteLine("Nothing found!");
                    continue;
                }
                string name = matches.Groups[1].Value;
                int lenght = int.Parse(matches.Groups[2].Value);
                string geohashcode = matches.Groups[3].Value;

                string nameOfMountain = string.Empty;

                if (geohashcode.Length == lenght)
                {
                    foreach (var character in name)
                    {
                        if (char.IsLetterOrDigit(character))
                        {
                            nameOfMountain += character;
                        }
                    }

                    Console.WriteLine($"Coordinates found! {nameOfMountain} -> {geohashcode}");
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }
            }
        }
    }
}
