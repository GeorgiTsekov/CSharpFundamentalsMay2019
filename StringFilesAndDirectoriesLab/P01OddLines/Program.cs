using System;
using System.IO;

namespace P01OddLines
{
    class Program
    {
        static void Main()
        {
            string path = "files";
            string fileName = "input.txt";
            string filePath = Path.Combine(path, fileName);
            using (var reader = new StreamReader(filePath))
            {
                int count = 0;
                string line = reader.ReadLine();

                while (line != null)
                {
                    Console.WriteLine($"{++count}. {line}");
                    line = reader.ReadLine();
                }
            }
        }
    }
}
