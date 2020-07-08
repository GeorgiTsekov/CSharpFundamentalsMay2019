using System;

namespace P08FactorialDivision
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            double calculateFirst = CalculateFacturiel(firstNumber);
            double calculateSecond = CalculateFacturiel(secondNumber);
            double result = calculateFirst / calculateSecond;
            Console.WriteLine($"{result:f2}");
        }

        private static double CalculateFacturiel(int number)
        {
            double calculate = 1;
            for (int i = 1; i <= number; i++)
            {
                calculate *= i;
            }
            return calculate;
        }      
    }
}
