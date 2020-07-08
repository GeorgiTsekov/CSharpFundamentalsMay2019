using System;
using System.Linq;

namespace P02CommonElements
{
    class Program
    {
        static void Main()
        {
            string[] firstArray = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] secondArray = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < secondArray.Length; i++)
            {
                for (int j = 0; j < firstArray.Length; j++)
                {
                    if (firstArray.Contains(secondArray[i]))
                    {
                        Console.Write($"{secondArray[i]} ",StringSplitOptions.RemoveEmptyEntries);
                        break;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
