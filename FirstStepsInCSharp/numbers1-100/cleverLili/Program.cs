using System;

namespace cleverLili
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMashinePrice = double.Parse(Console.ReadLine());
            int singleToyPrice = int.Parse(Console.ReadLine());

            int toysCounter = 0;
            int moneyGift = 10;
            int totalMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    totalMoney += moneyGift;
                    totalMoney-= 1;
                    moneyGift += 10;
                }
                else
                {
                    toysCounter++;
                }
            }
            int toysIncome = toysCounter * singleToyPrice;
            int sumTotalMoney = totalMoney + toysIncome;
            double moneyLeft = Math.Abs(sumTotalMoney - washingMashinePrice);
            

            if (sumTotalMoney >= washingMashinePrice)
            {
                Console.WriteLine($"Yes! {moneyLeft:f2}");
            }
            else
            {          
                Console.WriteLine($"No! {moneyLeft:f2}");
            }
        }
    }
}
