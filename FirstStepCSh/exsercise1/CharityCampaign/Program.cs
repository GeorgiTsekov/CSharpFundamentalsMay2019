using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int confecioners = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int wafers = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());
            double campaign = days * confecioners * (cakes * 45 + wafers * 5.80 + pancakes * 3.20) * 0.875;
            Console.WriteLine($"{campaign:f2}");
        }
    }
}
