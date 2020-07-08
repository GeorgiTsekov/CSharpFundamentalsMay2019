using System;

namespace AlchExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyprice = double.Parse(Console.ReadLine());
            double beers = double.Parse(Console.ReadLine());
            double wines = double.Parse(Console.ReadLine());
            double rakia = double.Parse(Console.ReadLine());
            double whiskey = double.Parse(Console.ReadLine());
            double rakiaprice = whiskeyprice / 2;
            double wineprice = rakiaprice * 0.6;
            double beerprice = rakiaprice * 0.2;
            double thebill = whiskey * whiskeyprice + rakia * rakiaprice + beers * beerprice + wines * wineprice;
            Console.WriteLine($"{thebill:f2}");

        }
    }
}
