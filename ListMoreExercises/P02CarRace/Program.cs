using System;
using System.Collections.Generic;
using System.Linq;

namespace P02CarRace
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            double sumLeft = 0;
            double sumRight = 0;

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                if (i < (numbers.Count / 2))
                {
                    if (numbers[i] == 0)
                    {
                        sumLeft *= 0.8;
                    }
                    else
                    {
                        sumLeft += numbers[i];
                    }
                }
            }
            for (int i = numbers.Count - 1; i >= numbers.Count / 2; i--)
            {
                if (i > (numbers.Count / 2))
                {
                    if (numbers[i] == 0)
                    {
                        sumRight *= 0.8;
                    }
                    else
                    {
                        sumRight += numbers[i];
                    }
                }
            }
            if (sumRight > sumLeft)
            {
                Console.WriteLine($"The winner is left with total time: {sumLeft}");
            }
            else if (sumLeft > sumRight)
            {
                Console.WriteLine($"The winner is right with total time: {sumRight}");
            }
        }
    }
}
