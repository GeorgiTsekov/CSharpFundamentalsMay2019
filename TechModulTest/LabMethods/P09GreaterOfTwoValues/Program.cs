using System;

namespace P09GreaterOfTwoValues
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int firstInt = int.Parse(Console.ReadLine());
                int secondInt = int.Parse(Console.ReadLine());
                int result = GetMaxInt(firstInt, secondInt);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                char result = GetMaxChar(firstChar, secondChar);
                Console.WriteLine(result);
            }
            else if (type == "string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                string result = GetMaxString(firstString, secondString);
                Console.WriteLine(result);
            }

        }

        private static int GetMaxInt(int firstInt, int secondInt)
        {
            int result = 0;
            if (firstInt > secondInt)
            {
                result = firstInt;
            }
            else
            {
                result = secondInt;
            }
            return result;
        }

        private static char GetMaxChar(char firstChar, char secondChar)
        {
            char result = char.MinValue;
            if (firstChar > secondChar)
            {
                result = firstChar;
            }
            else
            {
                result = secondChar;
            }
            return result;
        }

        private static string GetMaxString(string firstString, string secondString)
        {
            string result = string.Empty;
            if (firstString.Length > secondString.Length)
            {
                result = firstString;
            }
            else
            {
                result = secondString;
            }
            return result;
        }

    }
}
