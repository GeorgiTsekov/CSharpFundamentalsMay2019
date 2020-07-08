using System;

namespace salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string current = (Console.ReadLine());
                if (current == "Facebook")
                {
                    salary -= 150;
                }
                if (current == "Instagram")
                {
                    salary -= 100;
                }
                if (current == "Reddit")
                {
                    salary -= 50;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return; 
                }
            }
            Console.WriteLine(salary);
        }
    }
}
