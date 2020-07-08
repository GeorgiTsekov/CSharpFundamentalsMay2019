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
                            int indexOfPaintingNumber = numbers.IndexOf(paintingNumber);
                            numbers[indexOfPaintingNumber] = changedNumber;
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
                            int firstIndex = numbers.IndexOf(paintingNumber);
                            int secondIndex = numbers.IndexOf(paintingNumber2);

                            numbers[firstIndex] = paintingNumber2;
                            numbers[secondIndex] = paintingNumber;
                        }
                        break;
                    case "Insert":
                        paintingNumber = int.Parse(command[2]);

                        int place = int.Parse(command[1]);

                        if (numbers.Count >= place + 1 && place >= 0)
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
