using System;

namespace P07RepeatString
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            int numberOfRepeats = int.Parse(Console.ReadLine());
            string result = RepeatString(str, numberOfRepeats);
            Console.WriteLine(result);
        }
private static string RepeatString(string str, int numberOfRepeats)
        {
            string result = "";
            for (int i = 1; i <= numberOfRepeats; i++)
            {
                result += str;
            }
            return result;
        }
    }
}
