using System;

namespace P03CharactersInRange
{
    class Program
    {
        static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            PrintSingleLineOfCharacters(firstChar, secondChar);
        }

        private static void PrintSingleLineOfCharacters(char firstChar, char secondChar)
        {
            string singleLineOfCharacters = string.Empty;
            if (firstChar < secondChar)
            {
                for (char i = (char)(firstChar + 1); i < secondChar; i++)
                {
                    singleLineOfCharacters += i + " ";
                }
            }
            else if (secondChar < firstChar)
            {
                for (int i = secondChar + 1; i < firstChar; i++)
                {
                    singleLineOfCharacters += (char)i + " ";
                }
            }
            Console.WriteLine(singleLineOfCharacters);
        }
    }
}
