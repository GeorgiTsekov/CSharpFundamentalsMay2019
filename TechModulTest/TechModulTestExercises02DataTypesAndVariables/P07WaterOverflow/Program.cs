using System;

namespace P07WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= numberOfLines; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                if (sum <= 255)
                {
                    sum += liters;
                    if (sum > 255)
                    {
                        Console.WriteLine("Insufficient capacity!");
                        sum -= liters;
                    }
                }               
            }
            Console.WriteLine(sum);
        }
    }
}
