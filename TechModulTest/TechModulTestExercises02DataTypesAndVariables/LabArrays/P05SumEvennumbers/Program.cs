using System;
using System.Linq;

namespace P05SumEvennumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] items = Console.ReadLine().Split().Select(int.Parse).ToArray();           
            int sum = 0;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] % 2 == 0)
                {
                    sum = sum + items[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
