using System;
using System.Linq;
using System.Collections.Generic;

namespace P02
{
    class Program
    {
        static void Main()
        {
            List<int> timeOfEachTask = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string input;


            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(" ");

                switch (command[0])
                {
                    case "Complete":
                        int index = int.Parse(command[1]);
                        if (timeOfEachTask.Count > index && index >= 0)
                        {
                            timeOfEachTask[index] = 0;
                        }
                        break;
                    case "Change":
                        index = int.Parse(command[1]);
                        int time = int.Parse(command[2]);
                        if (timeOfEachTask.Count > index && index >= 0)
                        {
                            timeOfEachTask[index] = time;
                        }
                        break;
                    case "Drop":
                        index = int.Parse(command[1]);
                        if (timeOfEachTask.Count > index && index >= 0)
                        {
                            timeOfEachTask[index] = -1;
                        }
                        break;
                    case "Count":
                        string newCommand = command[1];
                        if (newCommand == "Completed")
                        {
                            int completedCount = 0;

                            for (int i = 0; i < timeOfEachTask.Count; i++)
                            {
                                if (timeOfEachTask[i] == 0)
                                {
                                    completedCount++;
                                }
                            }
                            Console.WriteLine($"{completedCount}");
                        }
                        if (newCommand == "Incomplete")
                        {
                            int incompleteCount = 0;

                            for (int i = 0; i < timeOfEachTask.Count; i++)
                            {                              
                                if (timeOfEachTask[i] != 0 && timeOfEachTask[i] != -1)
                                {
                                    incompleteCount++;
                                }
                            }
                            Console.WriteLine($"{incompleteCount}");
                        }
                        if (newCommand == "Dropped")
                        {
                            int droppedCount = 0;

                            for (int i = 0; i < timeOfEachTask.Count; i++)
                            {
                                if (timeOfEachTask[i] == -1)
                                {
                                    droppedCount++;
                                }
                            }
                            Console.WriteLine($"{droppedCount}");
                        }
                        break;
                }
            }

            for (int i = 0; i < timeOfEachTask.Count; i++)
            {
                if (timeOfEachTask[i] < 1)
                {
                    timeOfEachTask.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine(string.Join(" ",timeOfEachTask));
        }
    }
}
