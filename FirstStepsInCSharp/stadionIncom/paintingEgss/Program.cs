using System;

namespace paintingEgss
{
    class Program
    {
        static void Main(string[] args)
        {
            string eggsSize = Console.ReadLine();
            string eggsColour = Console.ReadLine();
            int eggsBatch = int.Parse(Console.ReadLine());
            double money = 0;
            double sum = 0;

            if (eggsSize == "Large")
            {
                if (eggsColour == "Red")
                {
                    money += 16;
                }
                else if (eggsColour == "Green")
                {
                    money += 12;
                }
                else if (eggsColour == "Yellow")
                {
                    money += 9;
                }
            }
            else if (eggsSize == "Medium")
            {
                if (eggsColour == "Red")
                {
                    money += 13;
                }
                else if (eggsColour == "Green")
                {
                    money += 9;
                }
                else if (eggsColour == "Yellow")
                {
                    money += 7;
                }
            }
            else if (eggsSize == "Small")
            {
                if (eggsColour == "Red")
                {
                    money += 9;
                }
                else if (eggsColour == "Green")
                {
                    money += 8;
                }
                else if (eggsColour == "Yellow")
                {
                    money += 5;
                }
            }
            sum = (eggsBatch * money) * 0.65;
            Console.WriteLine($"{sum:f2} leva.");
        }
    }
}
