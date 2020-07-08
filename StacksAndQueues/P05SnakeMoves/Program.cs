using System;
using System.Linq;

namespace P05SnakeMoves
{
    class Program
    {
        static void Main()
        {
            int[] rowsAndCols = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string snake = Console.ReadLine();

            char[,] matrix = new char[rowsAndCols[0], rowsAndCols[1]];

            int snakeCounter = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = snake[snakeCounter++];

                    if (snakeCounter >= snake.Length)
                    {
                        snakeCounter = 0;
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"{matrix[i, j]}");
                    }
                }
                else
                {
                    for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                    {
                        Console.Write($"{matrix[i, j]}");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
