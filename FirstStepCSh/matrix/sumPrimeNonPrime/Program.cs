using System;

namespace sumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            int primeNumber = 0;
            int noPrimeNumber = 0;

            while ((command = Console.ReadLine()) != "stop")
            {
                if (int.Parse(command) < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                else
                {
                    if ((int.Parse(command) % 2 == 0)&&(int.Parse(command) != 2) || (int.Parse(command) % 3 == 0)&&(int.Parse(command) != 3) || (int.Parse(command) % 5 == 0)&&(int.Parse(command) != 5) || (int.Parse(command) % 7 == 0)&&(int.Parse(command) != 7))
                    {
                        noPrimeNumber += int.Parse(command);
                    }
                    else
                    {
                        primeNumber += int.Parse(command);
                    }
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeNumber}");
            Console.WriteLine($"Sum of all non prime numbers is: {noPrimeNumber}");

        }
    }
}
