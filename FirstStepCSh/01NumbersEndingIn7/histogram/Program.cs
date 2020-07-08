using System;

namespace histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double pOne = 0;
            double pTwo = 0;
            double pThree = 0;
            double pFor = 0;
            double pFive = 0;
           

            for (int i = 1; i <= n; i++)
            {
                int current = int.Parse(Console.ReadLine());

                if (current < 200)
                {
                    pOne++;
                }
                else if (current >= 200 && current <= 399)
                {
                    pTwo++;
                }
                else if (current >= 400 && current <= 599)
                {
                    pThree++;
                }
                else if (current >= 600 && current <= 799)
                {
                    pFor++;
                }
                else if(current >= 800)
                {
                    pFive++;
                }
            }
            double sumOne = pOne / n * 100;
            double sumTwo = pTwo / n * 100;
            double sumThree = pThree / n * 100;
            double sumFor = pFor / n * 100;
            double sumFive = pFive / n * 100;
            Console.WriteLine($"{sumOne:f2}%");
            Console.WriteLine($"{sumTwo:f2}%");
            Console.WriteLine($"{sumThree:f2}%");
            Console.WriteLine($"{sumFor:f2}%");
            Console.WriteLine($"{sumFive:f2}%");
        }
    }
}
