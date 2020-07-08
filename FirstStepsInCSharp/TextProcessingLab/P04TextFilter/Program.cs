using System;

namespace P04TextFilter
{
    class Program
    {
        static void Main()
        {
            string[] command = Console.ReadLine().Split(", ");

            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < command.Length; j++)
                {
                    if (text.Contains(command[j]))
                    {
                        text = text.Replace(command[j], new string('*', command[j].Length));
                    }
                }
            }

            Console.WriteLine(text);
        }
    }
}
