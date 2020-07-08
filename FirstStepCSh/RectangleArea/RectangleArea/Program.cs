using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задай число за страна а на правоъгълния триъгълник:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Задай число за страна б на правоъгълния триъгълник:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Лицето на правоъгълния триъгълник е:");
            Console.WriteLine(a * b);
        }
    }
}
