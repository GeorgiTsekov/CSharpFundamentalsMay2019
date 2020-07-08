using System;

namespace LeftRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sumOne = 0;
            int sumTwo = 0;

            for (int i = 0; i < n; i++)
            {
                int currentOne = int.Parse(Console.ReadLine());
                sumOne = currentOne + sumOne;
            }
            for (int i = 0; i < n; i++)
            {
                int currentTwo = int.Parse(Console.ReadLine());
                sumTwo = currentTwo + sumTwo;
            }
            if (sumOne == sumTwo)
            {
                Console.WriteLine($"Yes, sum = {sumOne}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumTwo - sumOne)}");
            }
        }
    }
}
