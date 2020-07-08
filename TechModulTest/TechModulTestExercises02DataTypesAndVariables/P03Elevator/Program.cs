using System;

namespace P03Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double courses = Math.Ceiling(persons / capacity);
            Console.WriteLine(courses);
        }
    }
}
