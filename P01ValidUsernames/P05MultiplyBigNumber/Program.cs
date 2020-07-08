using System;
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

            if (digit == 0)
            {
                Console.WriteLine(0);
                return;
            }
            
            string result = string.Empty;
            
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int firstSum = (numbers[i] - 48) * digit;

                if (firstSum > 9)
                {
                    sum += firstSum;

                    result += sum % 10;

                    sum = sum / 10;
                }
                else if (firstSum + sum > 9)
                {
                    sum += firstSum;
                
                    result += sum % 10;
                
                    sum = sum / 10;
                }
                else
                {
                    sum += firstSum;
                    result += sum;
                    sum = 0;
                }
            }
            if (sum > 0)
            {
                result += sum;
            }

            string lastResult = string.Empty;
            for (int i = result.Length - 1; i >= 0; i--)
            {
                lastResult += result[i];
            }
            
            Console.WriteLine(lastResult);
        }
    }
}
