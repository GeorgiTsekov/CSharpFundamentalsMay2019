using System;
using System.Collections.Generic;
using System.Linq;

namespace P03PresentDelivery
{
    class Program
    {
        static void Main()
        {
            List<int> housesList = Console.ReadLine()
                .Split("@")
                .Select(int.Parse)
                .ToList();

            string input;

            int counter = 0;

            while ((input = Console.ReadLine()) != "Merry Xmas!")
            {
                string[] jumps = input.Split(" ");

                int jumpIndex = int.Parse(jumps[1]);

                counter += jumpIndex;

                while (counter >= housesList.Count)
                {
                    counter -= housesList.Count;
                }

                if (counter < housesList.Count && housesList[counter] >= 2)
                {
                    housesList[counter] -= 2;
                    if (housesList[counter] < 2)
                    {
                        housesList[counter] = 0;
                    }
                }
                else if (housesList[counter] == 0)
                {
                    Console.WriteLine($"House {counter} will have a Merry Christmas.");
                }
                if (housesList.Sum() == 0)
                {
                    Console.WriteLine($"Santa's last position was {counter}.");
                    Console.WriteLine("Mission was successful.");
                    return;
                }
            }
            int housesCount = 0;

            foreach (var item in housesList)
            {
                if (item != 0)
                {
                    housesCount++;
                }
            }

            Console.WriteLine($"Santa's last position was {counter}.");
            Console.WriteLine($"Santa has failed {housesCount} houses.");
        }
    }
}
