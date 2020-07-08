using System;
using System.Linq;

namespace P03ZigZagArrays
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] array = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                for (int j = 0; j < array.Length; j++)
                {
                    if (i % 2 == 0)
                    {
                        firstArray[i] = array[0];
                        secondArray[i] = array[1];
                    }
                    else
                    {
                        firstArray[i] = array[1];
                        secondArray[i] = array[0];
                    }

                }
            }
            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
