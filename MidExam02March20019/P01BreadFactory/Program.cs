using System;
using System.Collections.Generic;

namespace P01BreadFactory
{
    class Program
    {
        static void Main()
        {
            string workingDayEvents = Console.ReadLine();

            int energy = 100;
            int coins = 100;

            string[] arrayOfEvents = workingDayEvents.Split("|");

            for (int i = 0; i < arrayOfEvents.Length; i++)
            {
                string[] events = arrayOfEvents[i].Split("-");

                switch (events[0])
                {
                    case "rest":
                        int number = int.Parse(events[1]);
                        int energyBefore = energy;
                        energy += number;
                        int gainedEnergy = number;
                        if (energy >= 100)
                        {
                            gainedEnergy = 100 - energyBefore;
                            energy = 100;
                        }
                        Console.WriteLine($"You gained {gainedEnergy} energy.");
                        Console.WriteLine($"Current energy: {energy}.");
                        break;
                    case "order":
                        number = int.Parse(events[1]);
                        energy -= 30;

                        if (energy >= 0)
                        {
                            coins += number;

                            Console.WriteLine($"You earned {number} coins.");
                        }
                        else
                        {
                            energy += 80;
                            Console.WriteLine("You had to rest!");
                        }
                        break;
                    default:
                        number = int.Parse(events[1]);
                        coins -= number;
                        if (coins > 0)
                        {
                            Console.WriteLine($"You bought {events[0]}.");
                        }
                        else
                        {
                            Console.WriteLine($"Closed! Cannot afford {events[0]}.");
                            return;
                        }
                        break;
                }
            }

            Console.WriteLine($"Day completed!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Energy: {energy}");
        }
    }
}
