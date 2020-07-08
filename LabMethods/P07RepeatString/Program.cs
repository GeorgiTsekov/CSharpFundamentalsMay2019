using System;

namespace P07RepeatString
{
    class Program
    {
        static void Main()
        {
            string inputString = Console.ReadLine();
            int countOfRepeats = int.Parse(Console.ReadLine());

            string result = GetRepeatTheInputString(inputString, countOfRepeats);
            Console.WriteLine(result);
        }

        private static string GetRepeatTheInputString(string inputString, int countOfRepeats)
        {
            string result = string.Empty;
            for (int i = 0; i < countOfRepeats; i++)
            {
                result += inputString;
            }
            return result;
        }
    }
}
