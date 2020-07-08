using System;

namespace P03CharactersInRange
{
    class Program
    {
        static void Main()
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            string betweenFirstAndSecond = string.Empty;

            if (first < second)
            {
                for (int i = first + 1; i < second; i++)
                {
                    betweenFirstAndSecond += (char)i + " ";
                }
            }
            else
            {
                for (int i = second + 1; i < first; i++)
                {
                    betweenFirstAndSecond += (char)i + " ";
                }
            }           
            Console.WriteLine(betweenFirstAndSecond);
        }
    }
}
