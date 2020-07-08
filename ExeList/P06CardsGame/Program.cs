using System;
using System.Linq;
using System.Collections.Generic;

namespace P06CardsGame
{
    class Program
    {
        static void Main()
        {
            List<int> firstPlayerCards = Console.ReadLine()
                .Split(" ")
                .Select(x => int.Parse(x))
                .ToList();

            List<int> secondPlayerCards = Console.ReadLine()
                .Split(" ")
                .Select(x => int.Parse(x))
                .ToList();

            for (int i = 0; i < (firstPlayerCards.Count + secondPlayerCards.Count); i++)
            {
                if (firstPlayerCards.Count <= 0)
                {
                    int sumSecondPlayer = secondPlayerCards.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sumSecondPlayer}");
                    break;
                }

                if (secondPlayerCards.Count <= 0)
                {
                    int sumFirstPlayer = firstPlayerCards.Sum();
                    Console.WriteLine($"First player wins! Sum: {sumFirstPlayer}");
                    break;
                }

                if (firstPlayerCards[i] > secondPlayerCards[i])
                {
                    firstPlayerCards.Add(firstPlayerCards[i]);
                    firstPlayerCards.Add(secondPlayerCards[i]);
                    firstPlayerCards.RemoveAt(i);
                    secondPlayerCards.RemoveAt(i);
                }
                else if (firstPlayerCards[i] < secondPlayerCards[i])
                {
                    secondPlayerCards.Add(secondPlayerCards[i]);
                    secondPlayerCards.Add(firstPlayerCards[i]);
                    secondPlayerCards.RemoveAt(i);
                    firstPlayerCards.RemoveAt(i);
                }
                else if (firstPlayerCards[i] == secondPlayerCards[i])
                {
                    secondPlayerCards.RemoveAt(i);
                    firstPlayerCards.RemoveAt(i);
                }
                i = -1;
            }
        }
    }
}
