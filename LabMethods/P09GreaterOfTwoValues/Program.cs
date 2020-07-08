using System;
using System.Collections;

namespace P09GreaterOfTwoValues
{
    class Program
    {
        static void Main()
        {
            string typeOfValue = Console.ReadLine();
            PrintGreaterOfTwoValues(typeOfValue);
        }

        private static void PrintGreaterOfTwoValues(string typeOfValue)
        {
            switch (typeOfValue)
            {
                case "int":
                    int firstNumber = int.Parse(Console.ReadLine());
                    int secondNumber = int.Parse(Console.ReadLine());
                    if (firstNumber > secondNumber)
                    {
                        Console.WriteLine(firstNumber);
                    }
                    else
                    {
                        Console.WriteLine(secondNumber);
                    }
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    if (firstChar > secondChar)
                    {
                        Console.WriteLine(firstChar);
                    }
                    else
                    {
                        Console.WriteLine(secondChar);
                    }
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();

                    int result = firstString.CompareTo(secondString);
                    if (result > 0)
                    {
                        Console.WriteLine(firstString);
                    }
                    else if (result < 0)
                    {
                        Console.WriteLine(secondString);
                    }
                    break;
            }
        }
    }
}
