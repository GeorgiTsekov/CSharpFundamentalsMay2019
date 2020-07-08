using System;

namespace P01SignOfIntegerAndNumbers
{
    class Program
    {
        static void Main()
        {
            PrintTheSignOfIntegerNumbers();
        }

        private static void PrintTheSignOfIntegerNumbers()
        {
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("The number 0 is zero.");
            }
            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else
            {
                Console.WriteLine($"The number {number} is negative.");
            }
        }
    }
}
