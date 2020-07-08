using System;

namespace ticketCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCombination = int.Parse(Console.ReadLine());

            int combinationConter = 0;

            for (int i = 'B'; i <= 'L'; i++)
            {
                for (int j = 'f'; j >= 'a'; j--)
                {
                    for (int k = 'A'; k <= 'C'; k++)
                    {
                        for (int l = 1; l <= 10; l++)
                        {
                            for (int s = 10; s >= 1; s--)
                            {
                                if (i % 2 == 0)
                                {
                                    combinationConter++;
                                }
                                if (numberOfCombination == combinationConter)
                                {
                                    int sum = i + j + k + l + s;
                                    Console.WriteLine($"Ticket combination: {(char)i}{(char)j}{(char)k}{l}{s}");
                                    Console.WriteLine($"Prize: {sum} lv.");
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
