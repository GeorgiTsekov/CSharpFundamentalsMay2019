using System;
using System.Linq;
using System.Collections.Generic;

namespace P03
{
    class Program
    {
        static void Main()
        {
            List<string> frogList = Console.ReadLine()
                .Split(" ")
                .ToList();
            while (true)
            {
                string input = Console.ReadLine();

                string[] command = input.Split(" ");
                switch (command[0])
                {
                    case "Print":
                        if (command[1] == "Normal")
                        {
                            Console.Write("Frogs: ");
                            Console.WriteLine(string.Join(" ", frogList));
                            return;
                        }
                        else if (command[1] == "Reversed")
                        {
                            frogList.Reverse();
                            Console.Write("Frogs: ");
                            Console.WriteLine(string.Join(" ", frogList));
                            return;
                        }
                        break;
                    case "Join":
                        string name = command[1];
                        if (!frogList.Contains(name))
                        {
                            frogList.Add(name);
                        }
                        break;
                    case "Jump":
                        name = command[1];
                        int index = int.Parse(command[2]);
                        if (index >= 0 && index < frogList.Count)
                        {
                            frogList.Insert(index, name);
                        }
                        break;
                    case "Dive":
                        index = int.Parse(command[1]);
                        if (index >= 0 && index < frogList.Count)
                        {
                            frogList.RemoveAt(index);
                        }
                        break;
                    case "First":
                        index = int.Parse(command[1]);
                        if (index >= 0 && index < frogList.Count)
                        {
                            for (int i = 0; i < index; i++)
                            {
                                Console.Write($"{frogList[i]} ");
                            }
                            Console.WriteLine();
                        }
                        else if (index >= 0 && index >= frogList.Count)
                        {
                            Console.WriteLine(string.Join(" ", frogList));
                        }
                        break;
                    case "Last":
                        index = int.Parse(command[1]);
                        if (index >= 0 && index < frogList.Count)
                        {
                            List<string> lastFrogList = new List<string>();
                            for (int i = frogList.Count - 1; i >= frogList.Count - index; i--)
                            {
                                lastFrogList.Add(frogList[i]);
                            }
                            lastFrogList.Reverse();
                            Console.WriteLine(string.Join(" ", lastFrogList));
                        }
                        else if (index >= 0 && index >= frogList.Count)
                        {
                            Console.WriteLine(string.Join(" ", frogList));
                        }
                        break;
                }
            }
            
        }
    }
}
