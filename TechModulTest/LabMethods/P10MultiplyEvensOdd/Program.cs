using System;
using System.Linq;

namespace P10MultiplyEvensOdd
{
    class Program
    {
        static void Main()
        {
            int arrayOfNumbers = int.Parse(Console.ReadLine());

            int sumEven = 0;
            int sumOdd = 0;
            string sumOfAllNumbers = string.Empty;

            while (arrayOfNumbers != 0)
            {
                int lastNumber = Math.Abs(arrayOfNumbers % 10);
                arrayOfNumbers = arrayOfNumbers / 10;
                sumOfAllNumbers += lastNumber + " ";
            }

            int[] arraySumOfAllNumbers = sumOfAllNumbers.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < arraySumOfAllNumbers.Length; i++)
            {
                if (arraySumOfAllNumbers[i] % 2 == 0)
                {
                    sumEven += arraySumOfAllNumbers[i];
                }
                else
                {
                    sumOdd += arraySumOfAllNumbers[i];
                }
            }

            int multiplySum = GetMultiplyOfEvenAndOdds(sumEven, sumOdd);
            Console.WriteLine(multiplySum);
            
        }

        private static int GetMultiplyOfEvenAndOdds(int sumEven, int sumOdd)
        {
            int multiplySum = Math.Abs(sumEven * sumOdd);
            return multiplySum;
        }
    }
}
