using System;

namespace P04PrintingTriangle
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintFirstTriangle(number);
            PrintSecondTriangle(number);
        }

        private static void PrintSecondTriangle(int number)
        {
            for (int row = number - 1; row >= 1; row--)
            {
                PrintLine(row);
            }
        }

        private static void PrintFirstTriangle(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                PrintLine(row);
            }
        }

        private static void PrintLine(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(col + " ");
            }
            Console.WriteLine();
        }
    }
}
