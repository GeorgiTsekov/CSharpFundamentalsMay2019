using System;
using System.Linq;
using System.Collections.Generic;

namespace P02ChangeList
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(x => int.Parse(x))
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] manipulateTheList = command
                    .Split(" ");

                if (manipulateTheList[0] == "Delete")
                {
                    int deleteNumber = int.Parse(manipulateTheList[1]);
                    numbers.RemoveAll(x => x == deleteNumber);
                }

                else if (manipulateTheList[0] == "Insert")
                {
                    int insertNumber = int.Parse(manipulateTheList[1]);
                    int insertPosition = int.Parse(manipulateTheList[2]);
                    numbers.Insert(insertPosition, insertNumber);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
