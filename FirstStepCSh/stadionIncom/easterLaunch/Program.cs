using System;

namespace easterLaunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestsCount = int.Parse(Console.ReadLine());
            double couvertPriceForOnePerson = double.Parse(Console.ReadLine());
            double budjetOfDesi = double.Parse(Console.ReadLine());

            double couvertAfterDiscount = 0;
            if (guestsCount < 10)
            {
                couvertAfterDiscount = couvertPriceForOnePerson;
            }
            else if (guestsCount >= 10 && guestsCount <= 15)
            {
                couvertAfterDiscount = couvertPriceForOnePerson * 0.85;
            }
            else if (guestsCount > 15 && guestsCount <= 20)
            {
                couvertAfterDiscount = couvertPriceForOnePerson * 0.80;
            }
            else if (guestsCount > 20)
            {
                couvertAfterDiscount = couvertPriceForOnePerson * 0.75;
            }

            double cake = budjetOfDesi * 0.10;
            double sumForParty = guestsCount * couvertAfterDiscount + cake;
            double diff = Math.Abs(sumForParty - budjetOfDesi);
            if (sumForParty > budjetOfDesi)
            {
                Console.WriteLine($"No party! {diff:f2} leva needed.");
            }
            else
            {
                Console.WriteLine($"It is party time! {diff:f2} leva left.");
            }
        }
    }
}
