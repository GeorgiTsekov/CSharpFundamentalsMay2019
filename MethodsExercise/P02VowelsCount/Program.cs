using System;
using System.Linq;

namespace P02VowelsCount
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();

            PrintNumberOfVowels(input);
        }

        private static void PrintNumberOfVowels(string input)
        {

            int counter = 0;

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < input.Length; i++)
            {
                char currentSymbol = input[i];
                if (vowels.Contains(currentSymbol))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
