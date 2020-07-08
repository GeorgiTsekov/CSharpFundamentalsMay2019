using System;

namespace P05Print
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstIndex = int.Parse(Console.ReadLine());
            int lastIndex = int.Parse(Console.ReadLine());

            for (int i = firstIndex; i <= lastIndex; i++)
            {
                char b = Convert.ToChar(i);
                Console.Write($"{b} ");
            }
        }
    }
}
