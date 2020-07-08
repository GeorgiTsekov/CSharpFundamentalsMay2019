using System;
using System.Numerics;

namespace P03BigFactoriel
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            BigInteger factoriel = 1;

            for (int i = 2; i <= N; i++)
            {
                factoriel *= i;
            }
            Console.WriteLine(factoriel);
        }
    }
}
