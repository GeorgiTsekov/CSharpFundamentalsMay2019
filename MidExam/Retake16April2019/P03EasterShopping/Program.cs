using System;
using System.Linq;
using System.Collections.Generic;

namespace P03EasterShopping
{
    class Program
    {
        static void Main()
        {
            List<string> shopNameList = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "Include":
                        shopNameList.Add(command[1]);
                        break;

                    case "Visit":
                        int index = int.Parse(command[2]);
                        if (index <= shopNameList.Count)
                        {
                            if (command[1] == "first")
                            {
                                for (int j = 0; j < index; j++)
                                {
                                    shopNameList.RemoveAt(0);
                                }
                            }
                            else if (command[1] == "last")
                            {
                                for (int j = 0; j < index; j++)
                                {
                                    shopNameList.RemoveAt(shopNameList.Count - 1);
                                }
                            }
                        }
                        break;
                    case "Prefer":
                        int firstIndex = int.Parse(command[1]);

                        int secondIndex = int.Parse(command[2]);

                        if (shopNameList.Count > firstIndex
                            && firstIndex >= 0
                            && shopNameList.Count > secondIndex
                            && secondIndex >= 0)
                        {
                            string firstString = shopNameList[firstIndex];
                            string secondString = shopNameList[secondIndex];
                            
                            shopNameList.RemoveAt(firstIndex);
                            shopNameList.Insert(firstIndex, secondString);
                            shopNameList.RemoveAt(secondIndex);
                            shopNameList.Insert(secondIndex, firstString);
                        }
                        break;
                    case "Place":
                        int shopIndex = int.Parse(command[2]);
                        if (shopIndex >= 0 && shopIndex < shopNameList.Count)
                        {
                            shopNameList.Insert(shopIndex + 1, command[1]);
                        }
                        break;
                }
            }
            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ", shopNameList));
        }
    }
}
