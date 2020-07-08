using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double metras = double.Parse(Console.ReadLine());
            double area = 7.61 * metras;
            double countdiscount = area * 0.18;
            double areadiscount = area - countdiscount;
            Console.WriteLine($"The final price is: {areadiscount:f2} lv.\nThe discount is: {countdiscount:f2} lv.");
        }
    }
}
