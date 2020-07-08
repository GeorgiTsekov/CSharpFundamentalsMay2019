using System;
using System.Linq;

namespace P04ArrayRotation
{
    class Program
    {
        static void Main()
        {
            int[] originalArray = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int counter = 0;

            int numbersOfRotations = int.Parse(Console.ReadLine());

            int[] rotatedArray = new int[originalArray.Length];


            for (int i = 0; i < rotatedArray.Length; i++)
            {
                while (numbersOfRotations > originalArray.Length)
                {
                    numbersOfRotations -= originalArray.Length;
                }
                if (i + numbersOfRotations < rotatedArray.Length)
                {
                    rotatedArray[i] = originalArray[i + numbersOfRotations];
                }
                else
                {
                    rotatedArray[i] = originalArray[counter];
                    counter++;
                }            
            }
            Console.WriteLine(string.Join(" ", rotatedArray));
        }
    }
}
