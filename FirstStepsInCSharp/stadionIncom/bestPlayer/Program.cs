using System;

namespace bestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            int maxGoalsCounter = 0;
            string bestPlayer = string.Empty;

            while (playerName != "END")
            {
                int goalsCounter = int.Parse(Console.ReadLine());
                if (goalsCounter > maxGoalsCounter)
                {
                    maxGoalsCounter = goalsCounter;
                    bestPlayer = playerName;
                }
                if (goalsCounter >= 10)
                {
                    maxGoalsCounter = goalsCounter;
                    bestPlayer = playerName;
                    Console.WriteLine($"{bestPlayer} is the best player!");
                    Console.WriteLine($"He has scored {maxGoalsCounter} goals and made a hat-trick !!!");
                    return;
                }
                playerName = Console.ReadLine();
            }
            Console.WriteLine($"{bestPlayer} is the best player!");
            if (maxGoalsCounter >= 3)
            {
                Console.WriteLine($"He has scored {maxGoalsCounter} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {maxGoalsCounter} goals.");
            }
        }
    }
}
