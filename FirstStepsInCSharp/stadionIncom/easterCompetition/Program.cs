using System;

namespace easterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBreadCount = int.Parse(Console.ReadLine());
            int maxScore = 0;
            int scoreOfTheCook = 0;
            string winnersName = string.Empty;
            string nameOfTheCook = string.Empty;
            string name = string.Empty;

            for (int i = 1; i <= easterBreadCount; i++)
            { 
                while ((name = Console.ReadLine()) != "Stop")
                {
                    int score = int.Parse(Console.ReadLine());                
                    scoreOfTheCook += score;
                    nameOfTheCook = name;
                }
                Console.WriteLine($"{nameOfTheCook} has {scoreOfTheCook} points.");
                if (maxScore < scoreOfTheCook)
                {
                    maxScore = scoreOfTheCook;
                    Console.WriteLine($"{nameOfTheCook} is the new number 1!");
                    winnersName = nameOfTheCook;
                }
            }
            Console.WriteLine($"{winnersName} won competition with {maxScore} points!");
        }
    }
}
