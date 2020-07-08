using System;
using System.Linq;
using System.Collections.Generic;

namespace P05BombNumbers
{
    class Program
    {
        static void Main()
        {
            List<int> sequenceOfNumbers = Console.ReadLine()
                .Split(" ")
                .Select(x => int.Parse(x))
                .ToList();

            List<int> specialBombNumbers = Console.ReadLine()
                .Split(" ")
                .Select(x => int.Parse(x))
                .ToList();

            int bomb = specialBombNumbers[0];
            int rangeOfBomb = specialBombNumbers[1];
            for (int i = 0; i < sequenceOfNumbers.Count; i++)
            {
                if (sequenceOfNumbers[i] == bomb)
                {
                    int counter = i;
                    for (int j = 0; j < rangeOfBomb; j++)
                    {
                        if ((counter - rangeOfBomb) >= 0)
                        {
                            sequenceOfNumbers.RemoveAt(counter - rangeOfBomb);
                        }
                        else
                        {
                            counter++;
                        }

                        if ((counter + rangeOfBomb - 1 - j * 2) < sequenceOfNumbers.Count)
                        {
                            sequenceOfNumbers.RemoveAt(counter + rangeOfBomb - 1 - j * 2);
                        }
                    }

                    if (sequenceOfNumbers.Contains(bomb))
                    {
                        sequenceOfNumbers.Remove(bomb);
                        i = -1;
                    }                    
                }
            }
            int sum = sequenceOfNumbers.Sum();

            Console.WriteLine(sum);
        }
    }
}
