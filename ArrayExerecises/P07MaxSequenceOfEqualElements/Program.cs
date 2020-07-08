using System;
using System.Linq;

namespace P07MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int counter = 0;
            string longuestSequence = string.Empty;
            string maxLonguestSequence = string.Empty;
            int maxCount = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i + 1 >= arr.Length)
                {
                    break;
                }
                if (arr[i] == arr[i + 1])
                {
                    if (counter < 1)
                    {
                        longuestSequence += arr[i] + " ";
                    }
                    longuestSequence += arr[i] + " ";
                    counter++;
                }
                else
                {
                    if (counter > maxCount)
                    {
                        maxCount = counter;
                        maxLonguestSequence = longuestSequence;
                    }
                    counter = 0;
                    longuestSequence = string.Empty;
                }
                if (counter > maxCount)
                {
                    maxLonguestSequence = longuestSequence;
                }
            }
            Console.WriteLine(maxLonguestSequence,StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
