using System;

namespace P10TopNumber
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            SumOfDigitIsDivisibleBy8(number);
        }

        private static void SumOfDigitIsDivisibleBy8(int number)
        {
            int divisibleBy8 = 0;
            for (int i = 16; i <= number; i++)
            {
                int sumOfDigitsDivisibleBy8 = 0;
                int bestNumber = 17;
                while (bestNumber >= 0)
                {
                    bestNumber = i;
                    int digitNumber = bestNumber % 10;
                    bestNumber = bestNumber / 10;
                    sumOfDigitsDivisibleBy8 += digitNumber;
                }
                if (sumOfDigitsDivisibleBy8 % 8 == 0)
                {
                    divisibleBy8 = i;
                    Console.WriteLine(divisibleBy8);
                }
            }
        }
    }
}
