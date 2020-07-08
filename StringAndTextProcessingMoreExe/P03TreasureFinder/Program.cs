using System;
using System.Linq;
using System.Text;

namespace P03TreasureFinder
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input;


            while ((input = Console.ReadLine()) != "find")
            {
                string newString = string.Empty;

                int counter = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    char newChar = (char)(input[i] - numbers[counter]);
                    newString += newChar;
                    counter++;
                    if (counter >= numbers.Length)
                    {
                        counter = 0;
                    }
                }

                string type = string.Empty;
                string coordinates = string.Empty;

                int firstIndexOfType = newString.IndexOf('&');
                int lastIndexOfType = newString.LastIndexOf('&');
                int firstIndexOfCoordinates = newString.IndexOf('<');
                int lastIndexOfCoordinates = newString.IndexOf('>');

                type = newString.Substring(firstIndexOfType + 1, lastIndexOfType - firstIndexOfType - 1);
                coordinates = newString.Substring(firstIndexOfCoordinates + 1, lastIndexOfCoordinates - firstIndexOfCoordinates - 1);

                if (type != string.Empty && coordinates != string.Empty)
                {
                    Console.WriteLine($"Found {type} at {coordinates}");
                }
            }
        }
    }
}
