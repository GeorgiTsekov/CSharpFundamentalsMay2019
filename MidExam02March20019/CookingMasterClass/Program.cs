using System;

namespace CookingMasterClass
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPackagePrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());

            int flourRest = students / 5;
            double apron = Math.Ceiling(students * 1.2);

            double neededBudget = students * eggPrice * 10 + apronPrice * apron + flourPackagePrice * (students - flourRest);

            double neededMoney = neededBudget - budget;

            if (neededBudget <= budget)
            {
                Console.WriteLine($"Items purchased for {neededBudget:F2}$.");
            }
            else
            {
                Console.WriteLine($"{neededMoney:F2}$ more needed.");
            }
            
        }
    }
}
