using System;
using System.Linq;

namespace P04ReverseArrayOfString
{
    class Program
    {
        static void Main()
        {
            string[] arrays = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Array.Reverse(arrays);
            foreach (var item in arrays)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
