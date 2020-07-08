using System;
using System.Linq;
using System.Collections.Generic;

namespace P03MobaChallenger
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

            Dictionary<string, int> playerAndSkillDict = new Dictionary<string, int>();

            string input;

            while ((input = Console.ReadLine()) != "Season end")
            {
                if (input.Contains(" -> "))
                {
                    string[] splitedInput = input.Split(" -> ");

                    string player = splitedInput[0];

                    string position = splitedInput[1];

                    int points = int.Parse(splitedInput[2]);

                    if (!dict.ContainsKey(player))
                    {
                        dict[player] = new Dictionary<string, int>();
                    }

                    if (dict[player].ContainsKey(position))
                    {
                        if (dict[player][position] < points)
                        {
                            dict[player][position] = points;
                        }
                    }
                    else
                    {
                        dict[player].Add(position, points);
                    }
                    string name = string.Empty;

                    int bestPointsMember = 0;

                    string bestMember = string.Empty;

                    foreach (var item in dict)
                    {
                        bestPointsMember = item.Value.Values.Sum();

                        bestMember = item.Key;

                        playerAndSkillDict[bestMember] = bestPointsMember;
                    }
                }
                else if (input.Contains(" vs "))
                {
                    string[] splitInput = input.Split(" vs ");

                    string playerOne = splitInput[0];

                    string playerTwo = splitInput[1];

                    bool escape = false;

                    if (dict.ContainsKey(playerOne) 
                        && (dict.ContainsKey(playerTwo) 
                        && (playerAndSkillDict.ContainsKey(playerOne) 
                        && (playerAndSkillDict.ContainsKey(playerTwo)))))
                    {
                        foreach (var item in dict[playerOne])
                        {
                            foreach (var kpd in dict[playerTwo])
                            {
                                if (item.Key == kpd.Key)
                                {
                                    if (playerAndSkillDict[playerOne] > playerAndSkillDict[playerTwo])
                                    {
                                        playerAndSkillDict.Remove(playerTwo);
                                        dict.Remove(playerTwo);
                                        escape = true;
                                        break;
                                    }
                                    else if (playerAndSkillDict[playerOne] < playerAndSkillDict[playerTwo])
                                    {
                                        playerAndSkillDict.Remove(playerOne);
                                        dict.Remove(playerOne);
                                        escape = true;
                                        break;
                                    }
                                }
                            }
                            if (escape == true)
                            {
                                break;
                            }
                        }
                    }
                }
            }
            var result = playerAndSkillDict
                .OrderByDescending(x => x.Value)
                .ThenBy(x=>x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}: {item.Value} skill");
                dict[item.Key] = dict[item.Key]
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);
                foreach (var kpd in dict[item.Key])
                {
                    Console.WriteLine($"- {kpd.Key} <::> {kpd.Value}");
                }
            }
        }
    }
}
