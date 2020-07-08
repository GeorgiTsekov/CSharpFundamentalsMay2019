using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02Desifering
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            string[] splitedSubstrings = Console.ReadLine().Split(" ");

            var match = Regex.Match(text, @"[^d-z{}\|#]+");

            if (match.Value != string.Empty)
            {
                Console.WriteLine("This is not the book you are looking for.");
                return;
            }

            string encryptedText = string.Empty;

            foreach (var character in text)
            {
                char newChar = (char)((int)character - 3);
                encryptedText += newChar;
            }

            if (encryptedText.Contains(splitedSubstrings[0]))
            {
                encryptedText = encryptedText.Replace(splitedSubstrings[0], splitedSubstrings[1]);
            }
            Console.WriteLine(encryptedText);
        }
    }
}
