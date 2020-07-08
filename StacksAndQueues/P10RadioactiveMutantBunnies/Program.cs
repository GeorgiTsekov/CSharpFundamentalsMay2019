using System;
using System.Collections.Generic;
using System.Linq;

namespace P10RadioactiveMutantBunnies
{
    class Program
    {
        static char[,] matrix;
        static int playerRow;
        static int playerCol;
        static bool isDead;

        static void Main(string[] args)
        {
            isDead = false;

            int[] rowsCols = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int totalRow = rowsCols[0];
            int totalCol = rowsCols[1];

            matrix = new char[totalRow, totalCol];

            PopulateMatrix();

            string directions = Console.ReadLine();

            foreach (var currentDirection in directions)
            {
                switch (currentDirection)
                {
                    case 'U':
                        Move(-1, 0);
                        break;
                    case 'L':
                        Move(0, -1);
                        break;
                    case 'D':
                        Move(1, 0);
                        break;
                    case 'R':
                        Move(0, 1);
                        break;
                    default:
                        break;
                }

                Spread();

                if (isDead)
                {
                    Print();
                    Console.WriteLine($"dead: {playerRow} {playerCol}");

                    Environment.Exit(0);
                }
            }
        }

        private static void Spread()
        {
            List<int> indexes = new List<int>();
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] == 'B')
                    {
                        indexes.Add(i);
                        indexes.Add(j);
                    }
                }
            }

            for (int i = 0; i < indexes.Count; i += 2)
            {
                int bunnyRow = indexes[i];
                int bunnyCol = indexes[i + 1];

                //Right
                if (IsInside(bunnyRow, bunnyCol + 1))
                {
                    if (matrix[bunnyRow, bunnyCol + 1] == 'P')
                    {
                        isDead = true;
                    }

                    matrix[bunnyRow, bunnyCol + 1] = 'B';
                }

                //Left
                if (IsInside(bunnyRow, bunnyCol - 1))
                {
                    if (matrix[bunnyRow, bunnyCol - 1] == 'P')
                    {
                        isDead = true;
                    }

                    matrix[bunnyRow, bunnyCol - 1] = 'B';
                }

                //Down
                if (IsInside(bunnyRow + 1, bunnyCol))
                {
                    if (matrix[bunnyRow + 1, bunnyCol] == 'P')
                    {
                        isDead = true;
                    }

                    matrix[bunnyRow + 1, bunnyCol] = 'B';
                }

                //Up
                if (IsInside(bunnyRow - 1, bunnyCol))
                {
                    if (matrix[bunnyRow - 1, bunnyCol] == 'P')
                    {
                        isDead = true;
                    }

                    matrix[bunnyRow - 1, bunnyCol] = 'B';
                }
            }
        }

        private static void Move(int row, int col)
        {
            if (!IsInside(playerRow + row, playerCol + col))
            {
                matrix[playerRow, playerCol] = '.';
                Spread();
                Print();
                Console.WriteLine($"won: {playerRow} {playerCol}");

                Environment.Exit(0);
            }

            if (matrix[playerRow + row, playerCol + col] == 'B')
            {
                Spread();
                Print();
                Console.WriteLine($"dead: {playerRow + row} {playerCol + col}");

                Environment.Exit(0);
            }

            matrix[playerRow, playerCol] = '.';

            playerRow += row;
            playerCol += col;

            matrix[playerRow, playerCol] = 'P';

        }

        private static void Print()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }

        private static bool IsInside(int row, int col)
        {
            return row >= 0
                && row < matrix.GetLength(0)
                && col >= 0
                && col < matrix.GetLength(1);
        }

        private static void PopulateMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] rows = Console.ReadLine().ToCharArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rows[j];

                    if (matrix[i,j] == 'P')
                    {
                        playerRow = i;
                        playerCol = j;
                    }
                }
            }
        }
    }
}
