using System;

namespace SpringVacationTrip
{
    class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            double budjet = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double fuelPricePerKm = double.Parse(Console.ReadLine());
            double footPricePerPersonPerDay = double.Parse(Console.ReadLine());
            double roomPricePerPersonPerDay = double.Parse(Console.ReadLine());

            double moneyForHotel = days * people * roomPricePerPersonPerDay;

            double moneyForFood = days * people * footPricePerPersonPerDay;

            if (people > 10)
            {
                moneyForHotel = moneyForHotel * 0.75;
            }

            double currentExpenses = moneyForHotel + moneyForFood;

            for (int i = 1; i <= days; i++)
            {
                double travelledDistance = double.Parse(Console.ReadLine());

                double travellPrice = travelledDistance * fuelPricePerKm;

                currentExpenses += travellPrice;

                if (i % 3 == 0)
                {
                    currentExpenses *= 1.40;
                }
                if (i % 5 == 0)
                {
                    currentExpenses *= 1.40;
                }
                if (i % 7 == 0)
                {
                    currentExpenses -= currentExpenses / people;
                }

                if (budjet < currentExpenses)
                {
                    currentExpenses -= budjet;
                    Console.WriteLine($"Not enough money to continue the trip. You need {currentExpenses:F2}$ more.");
                    return;
                }
            }

            double result = budjet - currentExpenses;

            Console.WriteLine($"You have reached the destination. You have {result:F2}$ budget left.");
        }
    }
}
