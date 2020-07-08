using System;

namespace LabArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTheDay = int.Parse(Console.ReadLine());

            string[] array = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };
            if (numberOfTheDay >= 1 && numberOfTheDay <=7)
            {
                Console.WriteLine(array[numberOfTheDay - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
