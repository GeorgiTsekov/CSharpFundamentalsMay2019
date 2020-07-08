using System;

namespace BackIn30Min
{
    class Program
    {
        static void Main(string[] args)
        {
            int houres = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int minutesPlus = 0;

            minutes += 30;

            if (minutes > 59)
            {
                houres++;
                if (houres > 23)
                {
                    houres = 0;
                }
                minutesPlus = minutes % 60;
                if (minutesPlus < 10)
                {
                    Console.WriteLine($"{houres}:0{minutesPlus}");
                }
                else
                {
                    Console.WriteLine($"{houres}:{minutesPlus}");
                }
            }
            else
            {
                Console.WriteLine($"{houres}:{minutes}");
            }


        }
    }
}
