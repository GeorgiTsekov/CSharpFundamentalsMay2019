using System;
using System.Text.RegularExpressions;

namespace P03
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                var match = Regex.Match(input, @"(\*|@)+([A-Z]{1}[a-z]{2,})\1: \[([A-Za-z]{1})\]\|\[([A-Za-z]{1})\]\|\[([A-Za-z]{1})\]\| *$");

                if (match.Value != string.Empty)
                {
                    string name = match.Groups[2].Value;
                    int firstNumber = (int)(char.Parse(match.Groups[3].Value));
                    int secondNumber = (int)(char.Parse(match.Groups[4].Value));
                    int thirdNumber = (int)(char.Parse(match.Groups[5].Value));
                    Console.WriteLine($"{name}: {firstNumber} {secondNumber} {thirdNumber}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
