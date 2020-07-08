using System;

namespace groupFase
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int matchesPlayed = int.Parse(Console.ReadLine());
            int goalsDiff = 0;
            int pointsCounter = 0;
            int totalGoalsDiff = 0;

            for (int i = 1; i <= matchesPlayed; i++)
            {
                int goalsIn = int.Parse(Console.ReadLine());
                int goalsOut = int.Parse(Console.ReadLine());
                goalsDiff = goalsIn - goalsOut;
                totalGoalsDiff += goalsDiff;
                if (goalsIn > goalsOut)
                {
                    pointsCounter += 3;
                }
                else if (goalsIn == goalsOut)
                {
                    pointsCounter += 1;
                }
            }
            if (totalGoalsDiff >= 0)
            {
                Console.WriteLine($"{teamName} has finished the group phase with {pointsCounter} points.");
                Console.WriteLine($"Goal difference: {totalGoalsDiff}.");
            }
            else if(totalGoalsDiff < 0)
            {
                Console.WriteLine($"{teamName} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {totalGoalsDiff}.");
            }
        }
    }
}
