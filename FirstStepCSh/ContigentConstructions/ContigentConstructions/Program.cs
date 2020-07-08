using System;

namespace ContigentConstructions
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int holidaysCount = int.Parse(Console.ReadLine());
            int weekendHomeTrips = int.Parse(Console.ReadLine());

            int weekendPerYear = 48;

            double gamesInWeekendsInSofia = (weekendPerYear - weekendHomeTrips) * 0.75;
            double gamesInWeekendsInHomeTown = weekendHomeTrips;
            double gamesInHolidays = holidaysCount * (2 / 3.0);

            double totalGamesCountPerYear = gamesInWeekendsInSofia + gamesInWeekendsInHomeTown + gamesInHolidays;

            if (yearType == "leap")
            {
                totalGamesCountPerYear *= 1.15;
            }

            totalGamesCountPerYear = Math.Floor(totalGamesCountPerYear);
            Console.WriteLine(totalGamesCountPerYear);
        }
    }
}
