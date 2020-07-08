using System;

namespace while_cycle_excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string anysBook = Console.ReadLine();
            int capacity = int.Parse(Console.ReadLine());
            int checkBookscount = 0;
            bool bookfound = false;   

            while (checkBookscount < capacity)
            {
                string currentBookName = Console.ReadLine();
                if (currentBookName == anysBook)
                {
                    bookfound = true;
                    break;
                }
                checkBookscount++;
            }
            if (bookfound)
            {
                Console.WriteLine($"You checked {checkBookscount} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {checkBookscount} books.");
            }
        }
    }
}
