using System;

namespace P05Orders
{
    class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();
            int numberOfProducts = int.Parse(Console.ReadLine());
            double result = 0;
            switch (product)
            {
                case "coffee":
                    result = 1.50 * numberOfProducts;
                    break;
                case "water":
                    result = 1.00 * numberOfProducts;
                    break;
                case "coke":
                    result = 1.40 * numberOfProducts;
                    break;
                case "snacks":
                    result = 2.00 * numberOfProducts;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}
