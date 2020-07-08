    using System;

    namespace cookieFactory
    {
        class Program
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                bool Eggs = false;
                bool Sugar = false;
                bool Flour = false;
                int countProducts = 0;

                for (int i = 0; i < n; i++)
                {
                    string product = Console.ReadLine();
                    while (product != "Bake!")
                    {
                        if (product == "eggs") Eggs = true;
                        if (product == "sugar") Sugar = true;
                        if (product == "flour") Flour = true;
                            
                        product = Console.ReadLine();
                    }
                    if (Flour && Eggs && Sugar)
                    {
                        countProducts++;
                        Console.WriteLine($"Baking batch number {countProducts}...");

                    Eggs = false;
                    Sugar = false;
                    Flour = false;
                }
                    else
                    {
                        i--;
                        Console.WriteLine($"The batter should contain flour, eggs and sugar!");
                    }
            }
            }
        }
    }
