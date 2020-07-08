using System;

namespace P11MathOperation
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            char midleChar = char.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double result = Calculate(firstNumber, midleChar, secondNumber);
            Console.WriteLine(result);
        }

        private static double Calculate(int firstNumber, char midleChar, int secondNumber)
        {
            double result = 0;
            switch (midleChar)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '/':
                    result = firstNumber / secondNumber;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
