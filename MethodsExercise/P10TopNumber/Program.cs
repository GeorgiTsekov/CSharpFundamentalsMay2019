using System;
using System.Linq;
using System.Collections.Generic;

namespace P10TopNumber
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintTopNumbers(n);
        }
        static void PrintTopNumbers(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                bool oddDigit = false;
                string num = i.ToString();
                int sumOfDigits = 0;
                for (int j = 0; j < num.Length; j++)
                {
                    int nextDig = int.Parse(num[j].ToString());
                    sumOfDigits += nextDig;
                    if (nextDig % 2 != 0) oddDigit = true;
                }
                if (sumOfDigits % 8 == 0 && oddDigit) Console.WriteLine(i);
            }
        }
    }
}
