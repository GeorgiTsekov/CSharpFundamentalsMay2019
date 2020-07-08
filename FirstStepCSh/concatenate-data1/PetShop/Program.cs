using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int animals = int.Parse(Console.ReadLine());
            double money = 2.5 * dogs + 4 * animals;
            Console.WriteLine($"{money:f2} lv.");
        }
    }
}
