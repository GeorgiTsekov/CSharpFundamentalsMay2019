using System;
using System.Linq;

namespace P04ReverseArrayOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            int newLenght = 0;
            string bestSum = string.Empty; ;

            for (int i = 0; i < numbers.Length; i++)
            {
                int counterMin = 0;
                int counterMax = 0;

                string biggestSum = string.Empty;

                int biggestNumber = int.MinValue;
                int smallestNumber = int.MaxValue;

                for (int j = i; j < numbers.Length; j++)
                {
                    if (j == numbers.Length - 1)
                    {
                        if (numbers[j] > biggestNumber)
                        {
                            biggestNumber = numbers[j];
                            counterMin++;
                            biggestSum += biggestNumber + " ";
                        }
                        break;
                    }
                    if ((numbers[j] > biggestNumber))
                    {
                        biggestNumber = numbers[j];
                        counterMin++;
                        biggestSum += biggestNumber + " ";
                    }
                    if ((numbers[j] > numbers[j + 1]) && (numbers[j + 1] < biggestNumber))
                    {
                        numbers[j] = numbers[j + 1];
                        if ((numbers[j] > biggestNumber))
                        {
                            biggestNumber = numbers[j];
                            counterMin++;
                            biggestSum += biggestNumber + " ";
                        }
                    }
                }
                if (counterMin > newLenght)
                {
                    newLenght = counterMin;
                    bestSum = biggestSum;                 
                }
            }
            Console.WriteLine($"{bestSum}", StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
