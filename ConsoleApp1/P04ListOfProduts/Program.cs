using System;
using System.Collections.Generic;

namespace P04ListOfProduts
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> nameOfProducts = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string names = Console.ReadLine();
                nameOfProducts.Add(names);
            }
            nameOfProducts.Sort();
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}.{nameOfProducts[i]}");
            }
        }
    }
}
