using System;

namespace easterEggsBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsCountFirst = int.Parse(Console.ReadLine());
            int eggsCountSecond = int.Parse(Console.ReadLine());
            string winner = Console.ReadLine();

            while (winner != "End of battle")
            {
                if (winner == "one")
                {
                    eggsCountSecond--;
                    if (eggsCountSecond <= 0)
                    {
                        Console.WriteLine($"Player two is out of eggs. Player one has {eggsCountFirst} eggs left.");
                        return;
                    }
                    winner = Console.ReadLine();
                }
                else if (winner == "two")
                {
                    eggsCountFirst--;
                    if (eggsCountFirst <= 0)
                    {
                        Console.WriteLine($"Player one is out of eggs. Player two has {eggsCountSecond} eggs left.");
                        return;
                    }
                    winner = Console.ReadLine();
                }
                
                
            }
            Console.WriteLine($"Player one has {eggsCountFirst} eggs left.");
            Console.WriteLine($"Player two has {eggsCountSecond} eggs left.");
        }
    }
}
