using System;

namespace beerAndChips
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameFan = Console.ReadLine();
            double budjet = double.Parse(Console.ReadLine());
            int beerCounter = int.Parse(Console.ReadLine());
            int chipsCounter = int.Parse(Console.ReadLine());

            double moneyForBeers = (1.20 * beerCounter);
            double moneyForOneChips = moneyForBeers * 0.45;
            double moneyForChips = Math.Ceiling(moneyForOneChips * chipsCounter);

            double allMoneyNeeded = moneyForBeers + moneyForChips;
            double moneyLeft = Math.Abs(budjet - allMoneyNeeded);

            if (budjet >= allMoneyNeeded)
            {
                Console.WriteLine($"{nameFan} bought a snack and has {moneyLeft:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"{nameFan} needs {moneyLeft:f2} more leva!");
            }
        }
    }
}
