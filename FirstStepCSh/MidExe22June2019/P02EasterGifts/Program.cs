using System;
using System.Linq;
using System.Collections.Generic;

namespace P02EasterGifts
{
    class Program
    {
        static void Main()
        {
            List<string> giftList = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "No Money")
            {
                string[] command = input
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "OutOfStock":
                        if (giftList.Contains(command[1]))
                        {
                            for (int i = 0; i < giftList.Count; i++)
                            {
                                if (giftList[i] == command[1])
                                {
                                    giftList.RemoveAt(i);
                                    giftList.Insert(i, "None");
                                }
                            }
                        }
                        break;
                    case "Required":
                        int index = int.Parse(command[2]);
                        if (giftList.Count > index && index >= 0)
                        {
                            giftList.RemoveAt(index);
                            giftList.Insert(index, command[1]);
                        }
                        break;
                    case "JustInCase":
                        if (giftList.Count > 0)
                        {
                            giftList.RemoveAt(giftList.Count - 1);
                            giftList.Add(command[1]);
                        }
                        break;
                }
            }
            if (giftList.Contains("None"))
            {
                while (giftList.Contains("None"))
                {
                    giftList.Remove("None");
                }
            }

            Console.WriteLine(string.Join(" ", giftList));
        }
    }
}
