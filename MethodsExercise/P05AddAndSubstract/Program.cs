using System;

namespace P05AddAndSubstract
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int sum = firstNumber + secondNumber - thirdNumber;
            Console.WriteLine(sum);
        }
    }
}
