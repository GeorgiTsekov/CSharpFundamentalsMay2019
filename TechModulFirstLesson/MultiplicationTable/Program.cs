using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int counter = int.Parse(Console.ReadLine());
            int product = 0;

            if (counter <= 10)
            {
                for (int i = counter; i <= 10; i++)
                {
                    product = i * number;
                    Console.WriteLine($"{number} X {i} = {product}");
                }
            }
            else if (counter > 10)
            {
                product = number * counter;
                Console.WriteLine($"{number} X {counter} = {product}");
            }
            
        }
    }
}
