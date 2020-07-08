using System;

namespace P03Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            int third = 0;
            int first = 0;
            int second = 1;

            for (int i = 1; i < number; i++)
            {
                third = first + second;
                first = second;
                second = third;
            }
            Console.WriteLine(second);
        }
    }
}
