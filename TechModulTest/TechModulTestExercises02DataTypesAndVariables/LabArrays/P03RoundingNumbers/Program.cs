using System;

namespace P03RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            string[] valuesAsString = values.Split();
            double[] numbers = new double[valuesAsString.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(valuesAsString[i]);
                double roundNumber = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numbers[i]} => {roundNumber}");
            }
        }
    }
}
