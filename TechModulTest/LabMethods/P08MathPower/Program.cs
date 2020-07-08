using System;

namespace P08MathPower
{
    class Program
    {
        static void Main()
        {
            double number = int.Parse(Console.ReadLine());
            int mathPower = int.Parse(Console.ReadLine());
            double result = RaiseToPower(number, mathPower);
            Console.WriteLine(result);
        }

        private static double RaiseToPower(double number, int mathPower)
        {
            double result = 0d;
            result = Math.Pow(number, mathPower);
            return result;
        }
        
    }
}
