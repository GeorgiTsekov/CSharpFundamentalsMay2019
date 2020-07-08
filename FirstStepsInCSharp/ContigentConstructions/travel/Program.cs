using System;

namespace travel
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double summerBg = budget * 0.30;
            double winterBg = budget * 0.70;
            double summerBalcan = budget * 0.40;
            double winterBalcan = budget * 0.80;
            double europenvm = budget * 0.90;

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    Console.WriteLine($"Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {summerBg:f2}");
                }
                else if (season == "winter")
                {
                    Console.WriteLine($"Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {winterBg:f2}");
                }
            }
            else if (budget > 1000)
            {
                Console.WriteLine($"Somewhere in Europe");
                Console.WriteLine($"Hotel - {europenvm:f2}");
            }
            else if ((budget <= 1000) && (budget > 100))
            {
                if (season == "summer")
                {
                    Console.WriteLine($"Somewhere in Balkans");
                    Console.WriteLine($"Camp - {summerBalcan:f2}");
                }
                else if (season == "winter")
                {
                    Console.WriteLine($"Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {winterBalcan:f2}");
                }
            }
        }
    }
}
