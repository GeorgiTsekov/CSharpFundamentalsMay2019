using System;

namespace football
{
    class Program
    {
        static void Main(string[] args)
        {
            //string resultOne = Console.ReadLine();
            //string resultTwo = Console.ReadLine();
            //string resultThree = Console.ReadLine();
            int win = 0;
            int lose = 0;
            int drawn = 0;

            for (int i = 1; i <= 3; i++)
            {
                string current = Console.ReadLine();
                int resultOne = current[0];
                int resultTwo = current[2];
                if (resultOne > resultTwo)
                {
                    win++;
                }
                if (resultOne < resultTwo)
                {
                    lose++;
                }
                if (resultOne == resultTwo)
                {
                    drawn++;
                }
            }
            Console.WriteLine($"Team won {win} games.");
            Console.WriteLine($"Team lost {lose} games.");
            Console.WriteLine($"Drawn games: {drawn}");

        }
    }
}
