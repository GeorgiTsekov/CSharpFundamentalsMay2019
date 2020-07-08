using System;
using System.Linq;

namespace P03ZigZagArrey
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string firstAnswer = string.Empty;
            string secondAnswer = string.Empty;

            for (int i = 0; i < n; i++)
            {
                int[] doubleArrays = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    firstAnswer += doubleArrays[0] + " ";
                    secondAnswer += doubleArrays[1] + " ";
                }
                else
                {
                    firstAnswer += doubleArrays[1] + " ";
                    secondAnswer += doubleArrays[0] + " ";
                }
            }
            Console.WriteLine(string.Join("",firstAnswer));
            Console.WriteLine(string.Join("",secondAnswer));
        }
    }
}
