using System;

namespace gameInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int matchesCount = int.Parse(Console.ReadLine());
            double minutesCounter = 0;
            int additionalTime = 0;
            int penalties = 0;

            for (int i = 1; i <= matchesCount; i++)
            {
                int matchTime = int.Parse(Console.ReadLine());
                minutesCounter += matchTime;

                if (matchTime > 90 && matchTime <= 120)
                {
                    additionalTime++;                   
                }
                else if (matchTime > 120)
                {
                    penalties++;
                }
            }
            double averageMinutes = minutesCounter / matchesCount;
            Console.WriteLine($"{teamName} has played {minutesCounter} minutes. Average minutes per game: {averageMinutes:f2}");
            Console.WriteLine($"Games with penalties: {penalties}");
            Console.WriteLine($"Games with additional time: {additionalTime}");
        }
    }
}
