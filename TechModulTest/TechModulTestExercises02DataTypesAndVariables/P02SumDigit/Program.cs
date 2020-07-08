using System;

namespace P02SumDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (number > 0)
            {
                int lastNumber = number % 10;
                number = number / 10;
                sum += lastNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
