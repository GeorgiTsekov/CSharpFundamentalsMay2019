using System;

namespace steps
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;

            while (steps < 10000)
            {
                string command = (Console.ReadLine());
                if (command == "Going home")
                {
                    steps += int.Parse(Console.ReadLine());
                    if (steps >= 10000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                    }
                    else
                    {
                        int difference = 10000 - steps;
                        Console.WriteLine($"{difference} more steps to reach goal.");
                    }
                    break;
                }
                else
                {
                    steps += int.Parse(command);
                    if (steps >= 10000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                    }
                }
            }
        }
    }
}
