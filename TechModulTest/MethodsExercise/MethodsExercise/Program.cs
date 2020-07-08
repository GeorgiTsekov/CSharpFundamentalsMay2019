using System;

namespace MethodsExercise
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int smallestNumber = FindTheSmallestNumber(firstNumber,secondNumber,thirdNumber);
            Console.WriteLine(smallestNumber);
        }

        private static int FindTheSmallestNumber(int one, int two, int three)
        {
            int smallestNumber = int.MaxValue;
            if (one < smallestNumber)
            {
                smallestNumber = one;
            }
            if (two < smallestNumber)
            {
                smallestNumber = two;
            }
            if (three < smallestNumber)
            {
                smallestNumber = three;
            }
            return smallestNumber;
        }
    }
}
