using System;

namespace Greetings1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = Console.ReadLine();
            string lastname = Console.ReadLine();
            int ages = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", firstname, lastname, ages, town);
        }
    }
}
