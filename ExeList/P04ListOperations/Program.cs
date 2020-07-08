using System;
using System.Linq;
using System.Collections.Generic;

namespace P04ListOperations
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(x => int.Parse(x))
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] splitedInput = input
                    .Split(" ");
                string command = splitedInput[0];

                switch (command)
                {
                    case "Add":
                        int numberAdd = int.Parse(splitedInput[1]);
                        numbers.Add(numberAdd);
                        break;
                    case "Insert":
                        int numberInsert = int.Parse(splitedInput[1]);
                        int indexInsert = int.Parse(splitedInput[2]);
                        if (indexInsert >= numbers.Count || indexInsert < 0)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        numbers.Insert(indexInsert, numberInsert);
                        break;
                    case "Remove":
                        int indexRemove = int.Parse(splitedInput[1]);
                        if (indexRemove >= numbers.Count || indexRemove < 0)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        numbers.RemoveAt(indexRemove);
                        break;
                    case "Shift":
                        int shiftIndex = int.Parse(splitedInput[2]);

                        string direction = splitedInput[1];
                        if (direction == "left")
                        {
                            for (int i = 0; i < shiftIndex; i++)
                            {
                                numbers.Add(numbers[0]);
                                numbers.RemoveAt(0);
                            }
                        }
                        else if (direction == "right")
                        {
                            for (int i = 0; i < shiftIndex; i++)
                            {
                                numbers.Insert(0, numbers[numbers.Count - 1]);
                                numbers.RemoveAt(numbers.Count - 1);
                            }
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
