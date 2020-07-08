using System;

namespace maxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = int.MinValue;

            while (n > 0)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > a)
                {
                    a = num;
                }
                n--;
            }
            Console.WriteLine($"{a}");
        }
    }
}
