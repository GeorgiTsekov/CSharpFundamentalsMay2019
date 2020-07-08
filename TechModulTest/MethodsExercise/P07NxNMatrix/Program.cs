using System;

namespace P07NxNMatrix
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintNumberXNumberMatrix(number);
        }

        private static void PrintNumberXNumberMatrix(int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j  = 0; j < number; j++)
                {
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }
        }
    }
}
