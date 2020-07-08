using System;
using System.Linq;

namespace P08CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensed = new int[array.Length - 1];
            int sum = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                condensed[i] = array[i] + array[i + 1];
                array[i] = condensed[i];
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                condensed[i] = array[i] + array[i + 1];
                array[i] = condensed[i];
                sum += condensed[i];
            }
            Console.WriteLine(sum);
        }
    }
}
