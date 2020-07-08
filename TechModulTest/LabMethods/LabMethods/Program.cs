using System;

namespace LabMethods
{
    class Program
    {
        static int number = int.Parse(Console.ReadLine());

        static void Main()
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number == 0)
            {
                Console.WriteLine($"The number 0 is zero.");
            }
            else
            {
                Console.WriteLine($"The number {number} is negative.");
            }
        }
    }
}
