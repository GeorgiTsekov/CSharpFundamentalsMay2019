using System;
using System.Linq;

namespace P05Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] len = new int[nums.Length];

            int[] prev = new int[nums.Length];

            int lowerNumber = int.MaxValue;

            for (int p = 0; p < nums.Length; p++)
            {
                if (nums[p] < lowerNumber)
                {
                    lowerNumber = nums[p];
                    len[p] = lowerNumber;
                }
                else if (nums[p] >= lowerNumber && )
                {

                }
            }
        }
    }
}
