using System;
using System.Linq;

namespace P05TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int maxNumber = int.MinValue;
            int nextMaxNumber = int.MinValue;
            int position = 0;
            string[] array = new string[numbers.Length];

            while (position < numbers.Length)
            {
                for (int i = position; i < numbers.Length; i++)
                {
                    if (maxNumber < numbers[i])
                    {
                        position = i;
                        maxNumber = numbers[i];                        
                    }
                }
                array[numbers.Length] = maxNumber + " ";
                int counter = 0;
                for (int i = position; i < numbers.Length - position; i++)
                {
                    position = i;
                    maxNumber = numbers[i];
                }
                array[numbers.Length] = maxNumber + " ";
            }
            Console.WriteLine(string.Join("", array));
        }
    }
}
