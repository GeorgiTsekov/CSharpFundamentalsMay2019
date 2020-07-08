using System;

namespace exsercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());
            double room = (L * W) * 0.9 - A * A;
            double dancers = Math.Floor(room / 0.7040);
            Console.WriteLine(dancers);
        }
    }
}
