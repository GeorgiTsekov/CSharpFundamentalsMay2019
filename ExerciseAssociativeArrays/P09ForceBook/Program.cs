using System;
using System.Linq;
using System.Collections.Generic;

namespace P09ForceBook
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {

                if (input.Contains(" | "))
                {
                    string[] command = input
                    .Split(" | ");

                    string side = command[0];

                    string member = command[1];

                    if (!dict.ContainsKey(side))
                    {
                        dict[side] = new List<string>();
                    }

                    bool memberExists = false;

                    foreach (var item in dict)
                    {
                        if (item.Value.Contains(member))
                        {
                            memberExists = true;
                            break;
                        }
                    }

                    if (!dict[side].Contains(member) && !memberExists)
                    {
                        dict[side].Add(member);
                    }
                }
                else if (input.Contains(" -> "))
                {
                    string[] newCommand = input
                    .Split(" -> ");

                    string newMember = newCommand[0];

                    string newSide = newCommand[1];

                    if (!dict.ContainsKey(newSide))
                    {
                        dict[newSide] = new List<string>();
                    }

                    if (!dict[newSide].Contains(newMember))
                    {
                        foreach (var item in dict)
                        {
                            if (item.Value.Contains(newMember))
                            {
                                item.Value.Remove(newMember);
                            }
                        }

                        dict[newSide].Add(newMember);
                        Console.WriteLine($"{newMember} joins the {newSide} side!");
                    }

                    if (!dict[newSide].Contains(newMember))
                    {
                        dict[newSide].Add(newMember);
                    }
                }
            }

            dict = dict
                .Where(x => x.Value.Count > 0)
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in dict)
            {
                item.Value.Sort();
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine($"! {item.Value[i]}");
                }
            }
        }
    }
}
