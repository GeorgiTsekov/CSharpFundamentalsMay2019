using System;

namespace examPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int sectorsCounter = int.Parse(Console.ReadLine());
            int stadiumCapacity = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());

            double moneyIncome = stadiumCapacity * ticketPrice;
            double moneyForCharity = 0.125 * ((moneyIncome) - (0.75 * (moneyIncome / sectorsCounter)));

            Console.WriteLine($"Total income - {moneyIncome:f2} BGN");
            Console.WriteLine($"Money for charity - {moneyForCharity:f2} BGN");
        }
    }
}
