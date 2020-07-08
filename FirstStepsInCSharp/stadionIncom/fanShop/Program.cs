using System;

namespace fanShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int budjet = int.Parse(Console.ReadLine());
            int itemsCounter = int.Parse(Console.ReadLine());
            string item = string.Empty;

            double spendedmoney = 0;

            for (int i = 1; i <= itemsCounter; i++)
            {
                item = Console.ReadLine();
                if (item == "hoodie")
                {
                    spendedmoney += 30;
                }
                if (item == "keychain")
                {
                    spendedmoney += 4;
                }
                if (item == "T-shirt")
                {
                    spendedmoney += 20;
                }
                if (item == "flag")
                {
                    spendedmoney += 15;
                }
                if (item == "sticker")
                {
                    spendedmoney += 1;
                }

            }
            double budjetDiff = Math.Abs(budjet - spendedmoney);
            if (budjet >= spendedmoney)
            {
                Console.WriteLine($"You bought {itemsCounter} items and left with {budjetDiff} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {budjetDiff} more lv.");
            }
        }
    }
}
