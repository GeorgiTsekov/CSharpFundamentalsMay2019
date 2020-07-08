using System;
using System.Collections.Generic;

namespace P03HouseParty
{
    class Program
    {
        static void Main()
        {
            int numberOfTheGuests = int.Parse(Console.ReadLine());

            List<string> guestsList = new List<string>();

            for (int i = 1; i <= numberOfTheGuests; i++)
            {
                string commmand = Console.ReadLine();

                string[] tokens = commmand.Split(" ");

                string name = tokens[0];

                if (!guestsList.Contains(name))
                {
                    if (tokens[2] == "not")
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }

                    else if (tokens[2] == "going!")
                    {
                        guestsList.Add(name);
                    }
                }

                else if (guestsList.Contains(name))
                {
                    if (tokens[2] == "not")
                    {
                        guestsList.Remove(name);
                    }

                    else if (tokens[2] == "going!")
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
            }

            foreach (var item in guestsList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
