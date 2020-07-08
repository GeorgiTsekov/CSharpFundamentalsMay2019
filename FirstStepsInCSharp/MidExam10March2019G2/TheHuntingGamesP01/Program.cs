using System;

namespace TheHuntingGamesP01
{
    class Program
    {
        static void Main()
        {
            int daysOfAdventure = int.Parse(Console.ReadLine());
            int playersCount = int.Parse(Console.ReadLine());
            double groupsEnergy = double.Parse(Console.ReadLine());
            double waterPerDayPerPerson = double.Parse(Console.ReadLine());
            double foodPerDayPerPerson = double.Parse(Console.ReadLine());

            double totalWater = waterPerDayPerPerson * playersCount * daysOfAdventure;
            double totalFood = foodPerDayPerPerson * playersCount * daysOfAdventure;

            for (int i = 1; i <= daysOfAdventure; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());

                groupsEnergy -= energyLoss;

                if (groupsEnergy <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {totalFood:F2} food and {totalWater:F2} water.");
                    return;
                }
                
                if (i % 2 == 0)
                {
                    groupsEnergy *= 1.05;
                    totalWater *= 0.7;
                }

                if (i % 3 == 0)
                {
                    groupsEnergy *= 1.10;
                    totalFood -= (totalFood / playersCount);
                }
            }

            Console.WriteLine($"You are ready for the quest. You will be left with - {groupsEnergy:F2} energy!");
        }
    }
}
