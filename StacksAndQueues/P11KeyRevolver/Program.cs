using System;
using System.Collections.Generic;
using System.Linq;

namespace P11KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            int[] bulletsCount = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] locksCount = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int intelligenceValue = int.Parse(Console.ReadLine());

            Stack<int> bulletsStack = new Stack<int>();

            Queue<int> locksQueue = new Queue<int>();

            foreach (var item in locksCount)
            {
                locksQueue.Enqueue(item);
            }

            foreach (var bullet in bulletsCount)
            {
                bulletsStack.Push(bullet);
            }

            int gunBarrel = gunBarrelSize;

            int bulletsUsed = 0;

            foreach (var bullet in bulletsStack)
            {
                if (bullet <= locksQueue.Peek())
                {
                    Console.WriteLine("Bang!");
                    locksQueue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                gunBarrel--;

                bulletsUsed++;

                if (gunBarrel == 0)
                {
                    if (bulletsStack.Count - bulletsUsed <= 0)
                    {
                        break;
                    }
                    Console.WriteLine("Reloading!");
                    gunBarrel = gunBarrelSize;
                }

                if (locksQueue.Count == 0)
                {
                    break;
                }

            }

            if (locksQueue.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
            }
            else
            {
                intelligenceValue -= bulletsUsed * bulletPrice;
                Console.WriteLine($"{bulletsStack.Count - bulletsUsed} bullets left. Earned ${intelligenceValue}");
            }
        }
    }
}
