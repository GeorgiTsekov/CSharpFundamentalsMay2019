using System;

namespace TechModulFirstLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int ages = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: {ages}, Grade: {grade:F2}");
        }
    }
}
