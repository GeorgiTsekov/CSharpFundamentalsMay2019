using System;
using System.Collections.Generic;
using System.Linq;

namespace P10PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "Party!")
            {
                string[] splitedCommand = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (splitedCommand[0] == "Remove")
                {
                    switch (splitedCommand[1])
                    {
                        case "StartsWith":
                            string words = splitedCommand[2];
                            names = names.Where(x => !x.StartsWith(words)).ToList();
                            break;
                        case "EndsWith":
                            words = splitedCommand[2];
                            names = names.Where(x => !x.EndsWith(words)).ToList();
                            break;
                        case "Length":
                            int length = int.Parse(splitedCommand[2]);
                            names = names.Where(x => x.Length != length).ToList();
                            break;
                        default:
                            break;
                    }
                }
                else if (splitedCommand[0] == "Double")
                {
                    switch (splitedCommand[1])
                    {
                        case "StartsWith":
                            string words = splitedCommand[2];
                            names.InsertRange(0, names.Where(x => x.StartsWith(words)).ToList());
                            break;
                        case "EndsWith":
                            words = splitedCommand[2];
                            names.InsertRange(0, names.Where(x => x.EndsWith(words)).ToList());
                            break;
                        case "Length":
                            int length = int.Parse(splitedCommand[2]);
                            names.InsertRange(0, names.Where(x => x.Length == length).ToList());
                            break;
                        default:
                            break;
                    }
                }
            }
            if (names.Count > 0)
            {
                for (int i = 0; i < names.Count - 1; i++)
                {
                    Console.Write($"{names[i]}, ");
                }
                Console.Write($"{names[names.Count - 1]} are going to the party!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            
        }
    }
}
