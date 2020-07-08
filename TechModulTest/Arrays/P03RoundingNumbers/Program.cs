using System;
using System.Linq;

namespace P03RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arrey = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] roundedNums = new int[arrey.Length];
            for (int i = 0; i < arrey.Length; i++)
            {
                roundedNums = Math.Round(arrey[i])
            }
        }
    }
}
