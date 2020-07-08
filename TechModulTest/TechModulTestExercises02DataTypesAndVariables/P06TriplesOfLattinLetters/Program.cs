using System;

namespace P06TriplesOfLattinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 97; i < count + 97; i++)
            {
                for (int j = 97; j < count + 97; j++)
                {
                    for (int k = 97; k < count + 97; k++)
                    {
                        char a = Convert.ToChar(i);
                        char b = Convert.ToChar(j);
                        char c = Convert.ToChar(k);
                        Console.WriteLine($"{a}{b}{c}");
                    }
                }
            }
        }
    }
}
