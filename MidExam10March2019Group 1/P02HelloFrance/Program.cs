using System;
using System.Linq;
using System.Collections.Generic;

namespace P02HelloFrance
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string[] numbers = input.Split("|");

            double budget = double.Parse(Console.ReadLine());

            double firstBudget = budget;

            List<double> percentNumbers = new List<double>();

            for (int i = 0; i < numbers.Length; i++)
            {
                string[] number = numbers[i].Split("->");
                for (int j = 1; j < number.Length; j++)
                {
                    switch (number[0])
                    {
                        case "Clothes":
                            double clothePrice = double.Parse(number[1]);
                            if (clothePrice <= 50.00)
                            {
                                if (budget >= clothePrice)
                                {
                                    budget -= clothePrice;
                                    percentNumbers.Add(clothePrice);
                                }
                            }
                            break;
                        case "Shoes":
                            double shoesPrice = double.Parse(number[1]);
                            if (shoesPrice <= 35.00)
                            {
                                if (budget >= shoesPrice)
                                {
                                    budget -= shoesPrice;
                                    percentNumbers.Add(shoesPrice);
                                }
                            }
                            break;
                        case "Accessories":
                            double accessoriesPrice = double.Parse(number[1]);
                            if (accessoriesPrice <= 20.50)
                            {
                                if (budget >= accessoriesPrice)
                                {
                                    budget -= accessoriesPrice;
                                    percentNumbers.Add(accessoriesPrice);
                                }
                            }
                            break;
                    }
                }
            }
            double sum = 0;

            List<double> lastNumbers = new List<double>();

            for (int i = 0; i < percentNumbers.Count; i++)
            {
                double percentNumber = percentNumbers[i] * 1.4;
                sum += percentNumber;
                lastNumbers.Insert(i, percentNumber);
            }

            sum += budget;
            double profit = sum - firstBudget;


            if (sum >= 150)
            {
                foreach (double item in lastNumbers)
                {
                    Console.Write($"{item:F2} ");
                }
                Console.WriteLine();
                Console.WriteLine($"Profit: {profit:F2}");
                Console.WriteLine("Hello, France!");
            }

            else
            {
                foreach (double item in lastNumbers)
                {
                    Console.Write($"{item:F2} ");
                }
                Console.WriteLine();
                Console.WriteLine($"Profit: {profit:F2}");
                Console.WriteLine("Time to go.");   
            }
        }
    }
}
