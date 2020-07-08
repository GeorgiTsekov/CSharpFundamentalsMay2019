using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace P05MultiplyBigNumber
{
    class Program
    {
        static void Main()
        {
            string numbers = Console.ReadLine();

            int sum = 0;

            int digit = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int lastDigit = int.Parse(numbers[i].ToString());

                int firstSum = lastDigit * digit + sum;

                sb.Append(firstSum % 10);

                sum = firstSum / 10;                
            }

            if (sum != 0)
            {
                sb.Append(sum);
            }

            string result = string.Join("", sb.ToString().Reverse()).TrimStart('0');

            if (result == string.Empty)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
