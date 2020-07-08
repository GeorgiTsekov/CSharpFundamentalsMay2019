using System;
using System.Text;

namespace P04CaesarCipher
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            foreach (var item in text)
            {
                char newItem = (char)(item + 3);

                sb.Append(newItem);
            }

            Console.WriteLine(sb);
        }
    }
}
