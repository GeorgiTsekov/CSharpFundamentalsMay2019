using System;
using System.Linq;

namespace P10MultiplyEvensByOdds
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string stringOfNumbers = string.Empty;
            int sumEven = 0;
            int sumOdd = 0;

            while (number != 0)
            {
                int digit = Math.Abs(number % 10);
                number = number / 10;
                stringOfNumbers += digit + " ";
            }

            int[] arrayOfNumbers = stringOfNumbers
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] % 2 == 0)
                {
                    sumEven += arrayOfNumbers[i];
                }
                else
                {
                    sumOdd += arrayOfNumbers[i];
                }
            }

            int multiplyOfEvenAndOdds = GetMultiplyOfEvenAndOdds(sumEven,sumOdd);
            Console.WriteLine(multiplyOfEvenAndOdds);

        }

        private static int GetMultiplyOfEvenAndOdds(int sumEven, int sumOdd)
        {
            int multiply = sumOdd * sumEven;
            return multiply;
        }
    }
}
