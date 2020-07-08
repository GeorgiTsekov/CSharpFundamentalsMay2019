using System;
using System.Linq;
using System.Collections.Generic;

namespace P01Train
{
    class Program
    {
        static void Main()
        {
            List<int> numberOfPassangers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacityOfEachWagon = int.Parse(Console.ReadLine());

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split();

                if (tokens[0] == "Add")
                {
                    int lastWagon = int.Parse(tokens[1]);
                    numberOfPassangers.Add(lastWagon);
                }

                else
                {
                    int fitThePassengers = int.Parse(command);
                    for (int i = 0; i < numberOfPassangers.Count; i++)
                    {
                        if (numberOfPassangers[i] + fitThePassengers <= maxCapacityOfEachWagon)
                        {
                            numberOfPassangers[i] += fitThePassengers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numberOfPassangers));
        }
    }
}
