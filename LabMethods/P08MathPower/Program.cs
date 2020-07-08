using System;

namespace P08MathPower
{
    class Program
    {
        static void Main()
        {
            double number = int.Parse(Console.ReadLine());
            int givenPower = int.Parse(Console.ReadLine());

            double result = GetGivenMathPower(number, givenPower);
            Console.WriteLine(result);
        }

        private static double GetGivenMathPower(double number, int givenPower)
        {
            double result = 1;
            for (int i = 0; i < givenPower; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
