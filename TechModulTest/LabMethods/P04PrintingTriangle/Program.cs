using System;

namespace P04PrintingTriangle
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintTriangle(number);
            PrintReverseTriangle(number - 1);
        }

        private static void PrintTriangle(int maxNumber)
        {
            for (int row = 1; row <= maxNumber; row++)
            {
                PrintRowWithNumbers(row);
            }
        }  

        private static void PrintReverseTriangle(int maxNumber)
        {
            for (int row = maxNumber; row >= 1; row--)
            {
                PrintRowWithNumbers(row);
            }
        }

        private static void PrintRowWithNumbers(int maxNumber)
        {
            for (int number = 1; number <= maxNumber; number++)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

    }
}
