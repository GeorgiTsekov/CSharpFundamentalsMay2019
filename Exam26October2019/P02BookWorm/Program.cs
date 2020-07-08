using System;
using System.Collections.Generic;

namespace P02BookWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int n = int.Parse(Console.ReadLine());

            List<char> finalText = new List<char>(text);

            char[][] matrix = new char[n][];

            int row = -1;
            int col = -1;

            for (int i = 0; i < matrix.Length; i++)
            {
                char[] array = Console.ReadLine().ToCharArray();

                matrix[i] = new char[array.Length];
                for (int j = 0; j < array.Length; j++)
                {
                    matrix[i][j] = array[j];
                    if (array[j] == 'P')
                    {
                        row = i;
                        col = j;
                        matrix[i][j] = '-';
                    }
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "up":
                        row--;
                        if (row < 0)
                        {
                            row++;
                            if (finalText.Count > 0)
                            {
                                finalText.RemoveAt(finalText.Count - 1);
                            }
                        }
                        break;
                    case "down":
                        row++;
                        if (matrix.Length <= row)
                        {
                            row--;
                            if (finalText.Count > 0)
                            {
                                finalText.RemoveAt(finalText.Count - 1);
                            }
                        }
                        break;
                    case "left":
                        col--;
                        if (col < 0)
                        {
                            col++;
                            if (finalText.Count > 0)
                            {
                                finalText.RemoveAt(finalText.Count - 1);
                            }
                        }
                        break;
                    case "right":
                        col++;
                        if (matrix.Length <= col)
                        {
                            col--;
                            if (finalText.Count > 0)
                            {
                                finalText.RemoveAt(finalText.Count - 1);
                            }
                        }
                        break;
                    default:
                        break;
                }

                char character = matrix[row][col];
                if (char.IsLetter(character))
                {
                    finalText.Add(character);
                    matrix[row][col] = '-';
                }
            }
            matrix[row][col] = 'P';
            foreach (var character in finalText)
            {
                Console.Write(character);
            }
            Console.WriteLine();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
