using System;
using System.Collections.Generic;
using System.Linq;

namespace SantasList
{
    class Program
    {
        static void Main()
        {
            List<string> kidList = Console.ReadLine()
                .Split("&")
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "Finished!")
            {
                string[] kidName = input.Split(" ");

                switch (kidName[0])
                {
                    case "Bad":
                        string kid = kidName[1];
                        if (!kidList.Contains(kid))
                        {
                            kidList.Insert(0, kid);
                        }
                        break;
                    case "Good":
                        kid = kidName[1];
                        if (kidList.Contains(kid))
                        {
                            kidList.Remove(kid);
                        }
                        break;
                    case "Rename":
                        kid = kidName[1];
                        if (kidList.Contains(kid))
                        {
                            int count = 0;
                            for (int i = 0; i < kidList.Count; i++)
                            {
                                if (kidList[i] == kid)
                                {
                                    count = i;
                                }
                            }

                            kidList.RemoveAt(count);
                            kidList.Insert(count, kidName[2]);
                        }
                        break;
                    case "Rearrange":
                        kid = kidName[1];
                        if (kidList.Contains(kid))
                        {
                            kidList.Remove(kid);
                            kidList.Insert(kidList.Count, kid);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", kidList));
        }
    }
}
