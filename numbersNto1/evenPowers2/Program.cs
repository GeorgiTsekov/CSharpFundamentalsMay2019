using System;

namespace evenPowers2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double current = 0;

            for (int i = 0; i <= n; i += 2)
            {
                current = Math.Pow(2, i);
            Console.WriteLine(current);    

            }
        }
    }
}
