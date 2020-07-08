using System;

namespace P05AddAndSubstract
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            SumOfFirstTwoNumbersMinusThirdNumber(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(SumOfFirstTwoNumbersMinusThirdNumber(firstNumber, secondNumber, thirdNumber));
        }

        private static int SumOfFirstTwoNumbersMinusThirdNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            return firstNumber + secondNumber - thirdNumber;
        }
    }
}
