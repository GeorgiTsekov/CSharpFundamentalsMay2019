using System;

namespace P01ChristmasSpirit
{
    class Program
    {
        static void Main()
        {
            int quantity = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int budget = 0;

            int christmasSpirit = 0;

            for (int i = 1; i <= days; i++)
            {

                if (i % 11 == 0)
                {
                    quantity += 2;
                }
                if (i % 2 == 0)
                {
                    budget += 2 * quantity;
                    christmasSpirit += 5;
                }
                if (i % 3 == 0)
                {
                    budget += 8 * quantity;
                    christmasSpirit += 13;
                }
                if (i % 5 == 0)
                {
                    budget += 15 * quantity;
                    christmasSpirit += 17;
                }
                if (i % 10 == 0)
                {
                    budget += 23;
                    christmasSpirit -= 20;
                }
                if (i % 15 == 0)
                {
                    christmasSpirit += 30;
                }
            }
            if (days % 10 == 0)
            {
                christmasSpirit -= 30;
            }

            Console.WriteLine($"Total cost: {budget}");
            Console.WriteLine($"Total spirit: {christmasSpirit}");
        }
    }
}
