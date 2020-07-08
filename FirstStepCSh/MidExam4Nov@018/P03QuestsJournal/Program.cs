using System;
using System.Collections.Generic;
using System.Linq;

namespace P03QuestsJournal
{
    class Program
    {
        static void Main()
        {
            List<string> adventurerPath = Console.ReadLine()
                .Split(", ")
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "Retire!")
            {
                string[] command = input.Split(" - ");

                switch (command[0])
                {
                    case "Start":
                        string quest = command[1];
                        if (!adventurerPath.Contains(quest))
                        {
                            adventurerPath.Add(quest);
                        }
                        break;
                    case "Complete":
                        quest = command[1];
                        if (adventurerPath.Contains(quest))
                        {
                            adventurerPath.Remove(quest);
                        }
                        break;
                    case "Side Quest":
                        string[] sideQuestArray = command[1].Split(":");
                        quest = sideQuestArray[0];
                        string sideQuest = sideQuestArray[1];
                        if (adventurerPath.Contains(quest))
                        {
                            int index = adventurerPath.IndexOf(quest);
                            adventurerPath.Insert(index + 1, sideQuest);
                        }
                        break;
                    case "Renew":
                        quest = command[1];
                        if (adventurerPath.Contains(quest))
                        {
                            adventurerPath.Remove(quest);
                            adventurerPath.Add(quest);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", adventurerPath));
        }
    }
}
