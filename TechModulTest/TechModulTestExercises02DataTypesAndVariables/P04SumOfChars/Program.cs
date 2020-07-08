using System;

namespace P04SumOfChars
{
    class Program
    {
        public static object Encoding { get; private set; }

        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= count; i++)
            {
                char symbols = char.Parse(Console.ReadLine());
                sum += symbols;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
