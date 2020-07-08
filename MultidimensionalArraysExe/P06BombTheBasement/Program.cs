using System;
using System.Linq;

namespace P06BombTheBasement
{
    class Program
    {
        static void Main()
        {
            int[] dimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] matrix = new int[rows,cols];

            int[] bombParameters = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int bombRows = bombParameters[0];
            int bombCols = bombParameters[1];
            int bombRadius = bombParameters[2];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = 0;
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    bool isInRadius = Math.Pow(i - bombRows, 2) + Math.Pow(j - bombCols, 2)
                        <= Math.Pow(bombRadius, 2);
                    if (isInRadius)
                    {
                        matrix[i,j] = 1;
                    }
                }
            }
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int counter = 0;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i,j] == 1)
                    {
                        counter++;
                        matrix[i,j] = 0;
                    }
                }

                for (int i = 0; i < counter; i++)
                {
                    matrix[i,j] = 1;
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
