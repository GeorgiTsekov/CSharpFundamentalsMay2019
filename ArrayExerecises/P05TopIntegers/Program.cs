using System;
using System.Linq;

namespace P05TopIntegers
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int counter = 0;

            string topArray = string.Empty;

            while (counter < array.Length)
            {
                int topInteger = int.MinValue;

                for (int i = counter; i < array.Length; i++)
                {
                    if (array[i] >= topInteger)
                    {
                        topInteger = array[i];
                        counter = i + 1;
                    }
                }
                topArray += topInteger + " ";
            }
            Console.WriteLine(topArray, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
