using System;

namespace P09PalindromeIntegers
{
    class Program
    {
        static void Main()
        {
            ReadIntegersUntillEnd();
        }

        private static void ReadIntegersUntillEnd()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                string firstHalfNumber = string.Empty;
                string secondHalfNumber = string.Empty;
                for (int i = 0; i < input.Length / 2; i++)
                {
                    firstHalfNumber += input[i];
                }
                for (int i = input.Length - 1; i > (input.Length - 1) / 2; i--)
                {
                    secondHalfNumber += input[i];
                }
                if (firstHalfNumber == secondHalfNumber)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
