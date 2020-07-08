using System;

namespace P05Orders
{
    class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();
            int countOfProducts = int.Parse(Console.ReadLine());
            PrintTheBill(product, countOfProducts);
        }

        private static void PrintTheBill(string product, int countOfProducts)
        {
            double result = 0;
            switch (product)
            {
                case "coffee":
                    result = countOfProducts * 1.50;
                    break;
                case "water":
                    result = countOfProducts * 1.00;
                    break;
                case "coke":
                    result = countOfProducts * 1.40;
                    break;
                case "snacks":
                    result = countOfProducts * 2.00;
                    break;
            }
            Console.WriteLine($"{result:F2}");
        }
    }
}
