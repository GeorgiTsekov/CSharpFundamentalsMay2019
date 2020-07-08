using System;
using System.Linq;

namespace P04ReverseArrayOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < items.Length / 2; i++)
            {
                var oldElement = items[i];
                items[i] = items[items.Length - 1 - i];
                items[items.Length - 1 - i] = oldElement;
            }
            Console.Write(string.Join(" ", items));
            Console.WriteLine();

            //Array.Reverse(items);

        }
    }
}
