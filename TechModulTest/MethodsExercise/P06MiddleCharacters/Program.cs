using System;

namespace P06MiddleCharacters
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            string midleChar = MidleCharOfString(str);
            Console.WriteLine(midleChar);
        }

        private static string MidleCharOfString(string str)
        {
            string midleChar = string.Empty;
            if (str.Length % 2 == 0)
            {
                for (int i = str.Length/2 - 1; i <= str.Length/2; i++)
                {
                    midleChar += str[i];
                }
            }
            else
            {
                for (int i = 0; i < str.Length/2; i++)
                {
                    midleChar = str[i + 1].ToString();
                }
            }
            return midleChar;
        }
    }
}
