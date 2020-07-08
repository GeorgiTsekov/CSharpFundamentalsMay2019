using System;
using System.Collections.Generic;
using System.Linq;

namespace P03Substring
{
    class Program
    {
        static void Main()
        {
            string first = Console.ReadLine();

            first = first.ToLower();

            string second = Console.ReadLine();

            for (int i = 0; i < second.Length; i++)
            {
                second = second.Replace(first, string.Empty);
            }

            Console.WriteLine(second);
        }
    }
}
