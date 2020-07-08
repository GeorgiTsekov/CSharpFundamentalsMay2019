using System;

namespace travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            double savedMoney = 0;

            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());

                while (budget > savedMoney)
                {
                    double incomeMoney = double.Parse(Console.ReadLine());
                    savedMoney += incomeMoney;                 
                    if (budget <= savedMoney)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        savedMoney = 0;
                        destination = Console.ReadLine();
                        break;
                    }
                }
            }
        }
    }
}
