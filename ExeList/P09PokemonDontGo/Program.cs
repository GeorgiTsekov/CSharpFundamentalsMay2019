using System;
using System.Collections.Generic;
using System.Linq;

namespace P09PokemonDontGo
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int result = 0;

            while (numbers.Count >= 0)
            {
                int index = int.Parse(Console.ReadLine());

                int newIndex = 0;

                if (index < numbers.Count && index >= 0)
                {
                    newIndex = numbers[index];

                    result += newIndex;

                    numbers.RemoveAt(index);

                    LessOrGraterIndex(numbers, newIndex);
                }
                else if (index >= numbers.Count)
                {
                    newIndex = numbers[numbers.Count - 1];

                    result += newIndex;

                    numbers.RemoveAt(numbers.Count - 1);

                    numbers.Insert(numbers.Count, numbers[0]);

                    LessOrGraterIndex(numbers, newIndex);
                }
                else if (index < 0)
                {
                    newIndex = numbers[0];

                    result += newIndex;

                    numbers.RemoveAt(0);
                    
                    numbers.Insert(0, numbers[numbers.Count - 1]);

                    LessOrGraterIndex(numbers, newIndex);
                }
                if (numbers.Count <= 0)
                {
                    break;
                }
            }

            Console.WriteLine(result);
        }

        private static void LessOrGraterIndex(List<int> numbers, int newIndex)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (newIndex >= numbers[i])
                {
                    numbers[i] += newIndex;
                }
                else
                {
                    numbers[i] -= newIndex;
                }
            }
        }
    }
}
