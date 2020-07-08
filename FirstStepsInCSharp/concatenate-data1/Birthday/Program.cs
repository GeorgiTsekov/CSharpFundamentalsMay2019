using System;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double v = a * b * c * 0.001 * (1 - percent/100);
            Console.WriteLine($"{v:f3}");
        }
    }
}
