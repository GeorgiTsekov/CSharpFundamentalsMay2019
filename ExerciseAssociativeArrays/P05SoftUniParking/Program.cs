using System;
using System.Linq;
using System.Collections.Generic;

namespace P05SoftUniParking
{
    class Program
    {
        static void Main()
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            Dictionary<string, string> carRegister = new Dictionary<string, string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(" ");

                switch (command[0])
                {
                    case "register":

                        string name = command[1];

                        string plateNumber = command[2];

                        if (!carRegister.ContainsKey(name))
                        {
                            carRegister.Add(name, plateNumber);
                            Console.WriteLine($"{name} registered {plateNumber} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                        }
                        break;
                    case "unregister":

                        name = command[1];

                        if (carRegister.ContainsKey(name))
                        {
                            carRegister.Remove(name);
                            Console.WriteLine($"{name} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {name} not found");
                        }
                        break;
                }
            }

            foreach (var item in carRegister)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
