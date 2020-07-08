using System;

namespace magicnNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int first = 1; first <= 9 ; first++)
            {
                for (int second = 1; second < 9; second++)
                {
                    for (int third = 1; third < 9; third++)
                    {
                        for (int fourth = 1; fourth < 9; fourth++)
                        {
                            for (int fifth = 1; fifth < 9; fifth++)
                            {
                                for (int sixth = 1; sixth < 9; sixth++)
                                {
                                    int sum = first * second * third * fourth * fifth * sixth;
                                    if (sum == n)
                                    {
                                        Console.Write($"{first}{second}{third}{fourth}{fifth}{sixth} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
