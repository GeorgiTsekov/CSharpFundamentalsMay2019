using System;
using System.Linq;
using System.Collections.Generic;

namespace P05LonguestIncreasedSubsequence
{
    class Program
    {
        static void Main()
        {
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] len = new int[sequence.Length];
            int[] prev = new int[sequence.Length];

            int maxLen = 0;
            int lastIndex = -1;

            for (int i = 0; i < sequence.Length; i++)
            {
                len[i] = 1;
                prev[i] = -1;
                for (int j = 0; j <= i - 1; j++)
                {
                    if (sequence[j] < sequence[i] && len[j] + 1 > len[i])
                    {
                        len[i] = len[j] + 1;
                        prev[i] = j;
                    }
                }
                if (len[i] > maxLen)
                {
                    maxLen = len[i];
                    lastIndex = i;
                }
            }
            int[] lis = new int[maxLen];
            int indexCurrent = maxLen - 1;

            while (lastIndex != -1)
            {
                lis[indexCurrent] = sequence[lastIndex];
                indexCurrent--;
                lastIndex = prev[lastIndex];
            }
            Console.WriteLine(string.Join(" ", lis));
        }
    }
}
