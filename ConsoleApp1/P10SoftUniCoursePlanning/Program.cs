using System;
using System.Collections.Generic;
using System.Linq;

namespace P10SoftUniCoursePlanning
{
    class Program
    {
        static void Main()
        {
            List<string> arrayOfLessons = Console.ReadLine()
                .Split(new[] {", "},StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;
            while ((input = Console.ReadLine())!= "course start")
            {
                List<string> command = input
                .Split(new[] { ":" }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

                switch (command[0])
                {
                    case "Add":
                        if (!arrayOfLessons.Contains(command[1]))
                        {
                            arrayOfLessons.Add(command[1]);
                        }
                        break;
                    case "Insert":
                        int index = int.Parse(command[2]);
                        if (!arrayOfLessons.Contains(command[1]))
                        {
                            arrayOfLessons.Insert(index, command[1]);
                        }
                        break;
                    case "Remove":
                        if (arrayOfLessons.Contains(command[1]))
                        {
                            arrayOfLessons.Remove(command[1]);
                        }
                        if(arrayOfLessons.Contains(command[1] + "-Exercise"))
                        {
                            arrayOfLessons.Remove(command[1] + "-Exercise");
                        }
                        break;
                    case "Swap":
                        if (arrayOfLessons.Contains(command[1]) 
                            && arrayOfLessons.Contains(command[2]))
                        {
                            int firstCount = 0;
                            int secondCount = 0;
                            for (int i = 0; i < arrayOfLessons.Count; i++)
                            {
                                if (command[1] == arrayOfLessons[i])
                                {
                                    firstCount = i;
                                }
                                if (command[2] == arrayOfLessons[i])
                                {
                                    secondCount = i;
                                }
                            }

                            arrayOfLessons.RemoveAt(firstCount);
                            arrayOfLessons.Insert(firstCount, command[2]);  
                            
                            arrayOfLessons.RemoveAt(secondCount);
                            arrayOfLessons.Insert(secondCount, command[1]);

                            if (arrayOfLessons.Contains(command[1] + "-Exercise"))
                            {
                                arrayOfLessons.RemoveAt(firstCount + 1);
                                arrayOfLessons.Insert(secondCount + 1, command[1] + "-Exercise");
                            }
                            if (arrayOfLessons.Contains(command[2] + "-Exercise"))
                            {
                                arrayOfLessons.RemoveAt(secondCount + 1);
                                arrayOfLessons.Insert(firstCount + 1, command[2] + "-Exercise");
                            }
                        }
                        break;
                    case "Exercise":
                        if (!arrayOfLessons.Contains(command[1]))
                        {
                            arrayOfLessons.Add(command[1]);
                            arrayOfLessons.Add(command[1] + "-Exercise");
                        }
                        else if (arrayOfLessons.Contains(command[1])
                            && !arrayOfLessons.Contains(command[1] + "-Exercise"))
                        {
                            for (int i = 0; i < arrayOfLessons.Count; i++)
                            {
                                if (arrayOfLessons[i] == command[1])
                                {
                                    arrayOfLessons.Insert(i + 1, command[1] + "-Exercise");
                                }
                            }
                        }
                        break;
                }
            }
            for (int i = 0; i < arrayOfLessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{arrayOfLessons[i]}");
            }
        }
    }
}
