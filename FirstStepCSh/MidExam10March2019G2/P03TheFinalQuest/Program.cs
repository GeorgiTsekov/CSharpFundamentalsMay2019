using System;
using System.Collections.Generic;
using System.Linq;

namespace P03TheFinalQuest
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            List<string> splitedText = text.Split(" ").ToList();

            string input;

            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] command = input.Split(" ");

                switch (command[0])
                {
                    case "Delete":
                        int index = int.Parse(command[1]);

                        if (index + 1 >= 0 && index + 1 < splitedText.Count)
                        {
                            splitedText.RemoveAt(index + 1);
                        }
                        break;
                    case "Swap":
                        if (splitedText.Contains(command[1]) && splitedText.Contains(command[2]))
                        {
                            int firstIndex = splitedText.IndexOf(command[1]);
                            int secondIndex = splitedText.IndexOf(command[2]);

                            splitedText[firstIndex] = command[2];
                            splitedText[secondIndex] = command[1];
                        }
                        break;
                    case "Put":
                        index = int.Parse(command[2]);

                        if (index - 1 >= 0 && index - 1 <= splitedText.Count)
                        {
                            splitedText.Insert(index - 1, command[1]);
                        }
                        break;
                    case "Sort":
                        splitedText.Sort();
                        splitedText.Reverse();
                        break;
                    case "Replace":
                        if (splitedText.Contains(command[2]))
                        {
                            int indexOfSecond = splitedText.IndexOf(command[2]);
                            splitedText[indexOfSecond] = command[1];                            
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", splitedText));
        }
    }
}
