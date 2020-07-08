using System;
using System.Collections.Generic;
using System.Linq;

namespace P12CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsCapacity = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] filledBottles = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> cupsQueue = new Queue<int>();

            Stack<int> bottlesStack = new Stack<int>();

            foreach (var cup in cupsCapacity)
            {
                cupsQueue.Enqueue(cup);
            }

            foreach (var bottle in filledBottles)
            {
                bottlesStack.Push(bottle);
            }

            int wastedLittres = 0;

            for (int i = 0; i < filledBottles.Length; i++)
            {
                if (cupsQueue.Count == 0 || bottlesStack.Count == 0)
                {
                    break;
                }

                int diffCupBottle = bottlesStack.Pop() - cupsQueue.Dequeue();

                if (diffCupBottle >= 0)
                {
                    wastedLittres += diffCupBottle;
                }
                else
                {
                    cupsQueue = new Queue<int>(cupsQueue.Reverse());
                    cupsQueue.Enqueue(Math.Abs(diffCupBottle));
                    cupsQueue = new Queue<int>(cupsQueue.Reverse());
                }
            }

            if (cupsQueue.Count > 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cupsQueue)}");
            }
            else if(bottlesStack.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottlesStack)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedLittres}");
        }
    }
}
