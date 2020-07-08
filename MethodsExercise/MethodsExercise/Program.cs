using System;

namespace P01SmallestOfThreeNumbers
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int smallerFromAB = GetSmallerNumber(a,b);
            int smallerFromABC = GetSmallerNumber(smallerFromAB, c);
            Console.WriteLine(smallerFromABC);
        }

        private static int GetSmallerNumber(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            return b;
        }
    }
}
