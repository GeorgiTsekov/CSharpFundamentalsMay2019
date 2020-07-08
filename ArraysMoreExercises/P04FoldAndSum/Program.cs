using System;
using System.Linq;

namespace P04FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] firstArrayReversed = new int[array.Length / 2];
            int[] lastArrayReversed = new int[array.Length / 2];
            int[] rightMiddleArrayReversed = new int[array.Length];

            string firstNumbers = string.Empty;
            string lastNumbers = string.Empty;

            int[] resultArray = new int[array.Length];

            for (int i = 0; i < firstArrayReversed.Length / 2; i++)
            {
                firstArrayReversed[i] = array[i];
            }
            Array.Reverse(firstArrayReversed);

            Array.Reverse(array);

            for (int i = 0; i < lastArrayReversed.Length / 2; i++)
            {
                lastArrayReversed[i] = array[i];
            }

            foreach (var first in firstArrayReversed)
            {
                firstNumbers += first + " ";
            }
            foreach (var second in lastArrayReversed)
            {
                firstNumbers += second + " ";
            }

            Array.Reverse(array);

            for (int i = rightMiddleArrayReversed.Length / 4; i < rightMiddleArrayReversed.Length * 3 / 4; i++)
            {
                rightMiddleArrayReversed[i] = array[i];
            }

            int[] upArray = firstNumbers
                .Split(new char[] { ' ', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] downArray = lastNumbers
                .Split(new char[] { ' ', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = rightMiddleArrayReversed[i] + upArray[i];
                if (resultArray[i] != 0)
                {
                    Console.Write($"{resultArray[i]} ");
                }
            }


        }
    }
}
