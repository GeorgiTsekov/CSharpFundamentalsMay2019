using System;
using System.Linq;
using System.Collections.Generic;

namespace P03LastStop
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split(" ");

                switch (command[0])
                {
                    case "Change":
                        int paintingNumber = int.Parse(command[1]);

                        int changedNumber = int.Parse(command[2]);

                        if (numbers.Contains(paintingNumber))
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] == paintingNumber)
                                {
                                    numbers.RemoveAt(i);
                                    numbers.Insert(i, changedNumber);
                                }
                            }
                        }

                        break;

                    case "Hide":
                        paintingNumber = int.Parse(command[1]);

                        if (numbers.Contains(paintingNumber))
                        {
                            numbers.Remove(paintingNumber);
                        }

                        break;

                    case "Switch":
                        paintingNumber = int.Parse(command[1]);

                        int paintingNumber2 = int.Parse(command[2]);

                        if (numbers.Contains(paintingNumber) && numbers.Contains(paintingNumber2))
                        {
                            int firstcount = 0;

                            int secondCount = 0;

                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] == paintingNumber)
                                {
                                    firstcount = i;
                                }

                                if (numbers[i] == paintingNumber2)
                                {
                                    secondCount = i;
                                }                               
                            }
                            numbers.RemoveAt(firstcount);
                            numbers.Insert(firstcount, paintingNumber2);
                            numbers.RemoveAt(secondCount);
                            numbers.Insert(secondCount, paintingNumber);
                        }

                        break;

                    case "Insert":
                        paintingNumber = int.Parse(command[2]);

                        int place = int.Parse(command[1]);

                        if (numbers.Count > place && place >= 0)
                        {
                            numbers.Insert(place + 1, paintingNumber);
                        }

                        break;

                    case "Reverse":
                        numbers.Reverse();

                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
