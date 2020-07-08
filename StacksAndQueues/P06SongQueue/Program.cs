using System;
using System.Collections.Generic;
using System.Linq;

namespace P06SongQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> queueSongs = new Queue<string>();

            foreach (var song in songs)
            {
                queueSongs.Enqueue(song);
            }

            while (queueSongs.Count > 0)
            {
                string command = Console.ReadLine();

                string[] splitedCommand = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (splitedCommand[0])
                {
                    case "Play":
                        queueSongs.Dequeue();
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", queueSongs));
                        break;
                    case "Add":
                        string song = command.Substring(4);

                        if (!queueSongs.Contains(song))
                        {
                            queueSongs.Enqueue(song);
                        }
                        else
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        break;
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
