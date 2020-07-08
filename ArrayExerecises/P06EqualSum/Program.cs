using System;
using System.Linq;

namespace P06EqualSum
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int leftSum = 0;
            int rightSum = array.Sum();

            for (int i = 0; i < array.Length; i++)
            {
                rightSum -= array[i];

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }

                leftSum += array[i];
            }
            Console.WriteLine("no");
        }
    }
}
