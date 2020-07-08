using System;

namespace P03ExtractFile
{
    class Program
    {
        static void Main()
        {
            string[] pathToFile = Console.ReadLine().Split(@"\");

            string[] fileNamAndExtension = pathToFile[pathToFile.Length - 1].Split('.');

            Console.WriteLine($"File name: {fileNamAndExtension[0]}");
            Console.WriteLine($"File extension: {fileNamAndExtension[1]}");
        }
    }
}
