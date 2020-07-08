using System;
using System.Linq;

namespace P04MatrixShuffling
{
    class Program
    {
        static void Main()
        {
            int[] rowsCols = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[rowsCols[0],rowsCols[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] rows = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rows[j];
                }
            }

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] splitedInput = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (splitedInput[0] == "swap")
                {
                    int finalResult;
                    bool output;
                    output = int.TryParse(splitedInput[1], out finalResult);
                    output = int.TryParse(splitedInput[2], out finalResult);
                    output = int.TryParse(splitedInput[3], out finalResult);
                    output = int.TryParse(splitedInput[4], out finalResult);
                    if (output == false)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    int indexI1 = int.Parse(splitedInput[1]);
                    int indexJ1 = int.Parse(splitedInput[2]);
                    int indexI2 = int.Parse(splitedInput[3]);
                    int indexJ2 = int.Parse(splitedInput[4]);
                    if (indexI1 < 0
                        || indexJ1 < 0
                        || indexI2 < 0
                        || indexJ2 < 0 
                        || matrix.GetLength(0) <= indexI1 
                        || matrix.GetLength(1) <= indexJ1 
                        || matrix.GetLength(0) <= indexI2 
                        || matrix.GetLength(1) <= indexJ2
                        )
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    else
                    {
                        string firstIndex = matrix[indexI1, indexJ1];
                        string lastIndex = matrix[indexI2, indexJ2];
                        matrix[indexI1, indexJ1] = lastIndex;
                        matrix[indexI2, indexJ2] = firstIndex;
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write($"{matrix[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
