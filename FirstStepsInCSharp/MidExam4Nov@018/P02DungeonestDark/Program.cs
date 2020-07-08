using System;
using System.Collections.Generic;
using System.Linq;

namespace P02DungeonestDark
{
    class Program
    {
        static void Main()
        {
            List<string> roomList = Console.ReadLine()
                .Split("|")
                .ToList();

            int health = 100;
            int coins = 0;

            for (int i = 0; i < roomList.Count; i++)
            {
                string[] currentRoom = roomList[i].Split(" ");
                switch (currentRoom[0])
                {
                    case "potion":
                        int secondIndex = int.Parse(currentRoom[1]);
                        health += secondIndex;

                        if (health > 100)
                        {
                            secondIndex = secondIndex - (health - 100);
                            health = 100;
                        }

                        Console.WriteLine($"You healed for {secondIndex} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                        break;
                    case "chest":
                        secondIndex = int.Parse(currentRoom[1]);
                        coins += secondIndex;

                        Console.WriteLine($"You found {secondIndex} coins.");
                        break;
                    default:
                        secondIndex = int.Parse(currentRoom[1]);
                        health -= secondIndex;
                        if (health > 0)
                        {
                            Console.WriteLine($"You slayed {currentRoom[0]}.");
                        }
                        else
                        {
                            Console.WriteLine($"You died! Killed by {currentRoom[0]}.");
                            Console.WriteLine($"Best room: {i + 1}");
                            return;
                        }
                        break;
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
