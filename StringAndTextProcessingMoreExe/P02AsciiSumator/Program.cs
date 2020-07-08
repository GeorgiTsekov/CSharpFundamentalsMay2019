using System;

namespace P02AsciiSumator
{
    class Program
    {
        static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            int firstNumber = firstChar;
            int secondNumber = secondChar;

            int sum = 0;

            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] > firstNumber && text[i] < secondNumber)
                {
                    sum += text[i];
                }
            }

            Console.WriteLine(sum);              
        }
    }
}
