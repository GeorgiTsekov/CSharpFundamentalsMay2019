using System;

namespace tripToWorldCup
{
    class Program
    {
        static void Main(string[] args)
        {
            double airplanTicketGo = double.Parse(Console.ReadLine());
            double airplanTicketBack = double.Parse(Console.ReadLine());
            double ticketPriceForOneMatch = double.Parse(Console.ReadLine());
            int matchesCount = int.Parse(Console.ReadLine());
            int percentDiscount = int.Parse(Console.ReadLine());

            double airplanTicketsAfterDiscount = ((airplanTicketGo + airplanTicketBack) * 6) - ((airplanTicketGo + airplanTicketBack) * 6) * (percentDiscount * 0.01);

            double totalSum = airplanTicketsAfterDiscount + (matchesCount * ticketPriceForOneMatch * 6);

            Console.WriteLine($"Total sum: {totalSum:f2} lv.");
            Console.WriteLine($"Each friend has to pay {(totalSum / 6):f2} lv.");
        }
    }
}
