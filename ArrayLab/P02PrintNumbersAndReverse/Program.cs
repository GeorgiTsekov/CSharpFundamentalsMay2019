using System;

namespace P02PrintNumbersAndReverse
{
    class Program
    {
        static void Main()
        {
            int countOfNumbers = int.Parse(Console.ReadLine());

            int[] numbers = new int[countOfNumbers];
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }
            Array.Reverse(numbers);
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
