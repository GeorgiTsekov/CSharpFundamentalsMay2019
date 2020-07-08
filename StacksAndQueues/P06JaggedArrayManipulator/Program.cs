using System;
using System.Linq;

namespace P06JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jaggedArray = new double[rows][];

            for (int i = 0; i < rows; i++)
            {
                jaggedArray[i] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray(); 
            }

            Analyze(jaggedArray);

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "Add":
                        int row = int.Parse(command[1]);
                        int col = int.Parse(command[2]);
                        int value = int.Parse(command[3]);
                        if (
                            row >= 0
                            && col >= 0
                            && jaggedArray.Length > row
                            && jaggedArray[row].Length > col                          
                            )
                        {
                            jaggedArray[row][col] += value;
                        }
                        break;
                    case "Subtract":
                        row = int.Parse(command[1]);
                        col = int.Parse(command[2]);
                        value = int.Parse(command[3]);
                        if (
                            row >= 0
                            && col >= 0
                            && jaggedArray.Length > row
                            && jaggedArray[row].Length > col
                            )
                        {
                            jaggedArray[row][col] -= value;
                        }
                        break;
                }
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[i]));
            }
        }

        private static void Analyze(double[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length - 1; i++)
            {
                if (jaggedArray[i].Length == jaggedArray[i + 1].Length)
                {
                    for (int j = 0; j < jaggedArray[i].Length; j++)
                    {
                        jaggedArray[i][j] *= 2;
                        jaggedArray[i + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < jaggedArray[i].Length; j++)
                    {
                        jaggedArray[i][j] /= 2;
                    }

                    for (int j = 0; j < jaggedArray[i + 1].Length; j++)
                    {
                        jaggedArray[i + 1][j] /= 2;
                    }
                }
            }
        }
    }
}
