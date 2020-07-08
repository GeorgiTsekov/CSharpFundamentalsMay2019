using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double inch = double.Parse(Console.ReadLine());
            double sm = 2.54*inch;
            Console.WriteLine("{0:F2}",sm);
        }
    }
}
