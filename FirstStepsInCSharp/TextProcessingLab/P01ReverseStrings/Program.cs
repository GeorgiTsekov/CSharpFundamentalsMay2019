using System;

namespace P01ReverseStrings
{
    class Program
    {
        static void Main()
        {
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string reversedInput = string.Empty;

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reversedInput += input[i];
                }

                Console.WriteLine($"{input} = {reversedInput}");
            }
        }
    }
}
