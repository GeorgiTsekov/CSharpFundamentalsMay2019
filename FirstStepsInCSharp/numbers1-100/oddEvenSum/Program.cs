using System;

namespace oddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int odd = 0;
            int even = 0;


            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    even += current;
                }
                else
                {
                    odd += current;
                }
            }
            if (even == odd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {even}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(even - odd)}");
            }
        }
    }
}
