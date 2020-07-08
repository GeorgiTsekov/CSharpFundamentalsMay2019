using System;

namespace exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBread = int.Parse(Console.ReadLine());
            int eggsCrusts = int.Parse(Console.ReadLine());
            int cookiesKg = int.Parse(Console.ReadLine());

            double sum = (easterBread * 3.20) + (eggsCrusts * 4.35) + (cookiesKg * 5.40) + (eggsCrusts * 12 * 0.15);

            Console.WriteLine($"{sum:f2}");
        }
    }
}
