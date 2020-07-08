using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace P04MorseCodeTranslator
{
    class Program
    {
        static void Main()
        {
            var codes = new Dictionary<string, char>();
            codes.Add(".-", 'A');
            codes.Add("-...", 'B');
            codes.Add("-.-.", 'C');
            codes.Add("-..", 'D');
            codes.Add(".", 'E');
            codes.Add("..-.", 'F');
            codes.Add("--.", 'G');
            codes.Add("....", 'H');
            codes.Add("..", 'I');
            codes.Add(".---", 'J');
            codes.Add("-.-", 'K');
            codes.Add(".-..", 'L');
            codes.Add("--", 'M');
            codes.Add("-.", 'N');
            codes.Add("---", 'O');
            codes.Add(".--.", 'P');
            codes.Add("--.-", 'Q');
            codes.Add(".-.", 'R');
            codes.Add("...", 'S');
            codes.Add("-", 'T');
            codes.Add("..-", 'U');
            codes.Add("...-", 'V');
            codes.Add(".--", 'W');
            codes.Add("-..-", 'X');
            codes.Add("-.--", 'Y');
            codes.Add("--..", 'Z');
            codes.Add(".----", '1');
            codes.Add("..---", '2');
            codes.Add("...--", '3');
            codes.Add("....-", '4');
            codes.Add(".....", '5');
            codes.Add("-....", '6');
            codes.Add("--...", '7');
            codes.Add("---..", '8');
            codes.Add("----.", '9');
            codes.Add("-----", '0');

            StringBuilder sb = new StringBuilder();

            string input = Console.ReadLine();

            string[] splitedInput = input.Split('|');

            foreach (var word in splitedInput)
            {
                string[] letters = word.Split();
                foreach (var letter in letters)
                {
                    if (codes.ContainsKey(letter))
                    {
                        sb.Append(codes[letter]);
                    }
                }
                sb.Append(" ");
            }

            Console.WriteLine(sb);
        }
    }
}
