using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days ={
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Satarday",
                "Sunday" };
            int index = int.Parse(Console.ReadLine());
            if (index >= 1 && index <= 7)
            {
                Console.WriteLine(days[index - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
