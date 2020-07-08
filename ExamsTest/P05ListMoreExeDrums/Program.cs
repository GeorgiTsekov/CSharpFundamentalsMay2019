using System;
using System.Linq;
using System.Collections.Generic;

namespace P05ListMoreExeDrums
{
    class Program
    {
        static void Main()
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();          

            List<int> drumItemSaver = new List<int>();

            foreach (int item in drumSet)
            {
                int number = item;
                drumItemSaver.Add(number);
            }

            string input;

            while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(input);
               
                for (int i = 0; i < drumSet.Count; i++)
                {
                    drumSet[i] -= hitPower;
                    if (drumSet[i] <= 0)
                    {
                        if (savings >= drumItemSaver[i] * 3)
                        {
                            savings -= drumItemSaver[i] * 3;
                            drumSet[i] = drumItemSaver[i];
                        }
                        else
                        {
                            drumSet.RemoveAt(i);
                            drumItemSaver.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", drumSet));
            Console.WriteLine($"Gabsy has {savings:F2}lv.");
        }
    }
}
