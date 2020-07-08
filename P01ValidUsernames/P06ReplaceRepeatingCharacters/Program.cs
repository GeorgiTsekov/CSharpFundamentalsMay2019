using System;
using System.Text;

namespace P06ReplaceRepeatingCharacters
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            string newText = string.Empty;

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i-1] != text[i])
                {
                    sb.Append(text[i - 1]);
                }
            }

            sb.Append(text[text.Length - 1]);

            Console.WriteLine(sb);
        }
    }
}
