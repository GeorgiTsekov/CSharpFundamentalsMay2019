﻿using System;

namespace LabIntroAndBasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());

            Console.Write($"Name: {name}, Age: {age}, Grade: {grade:F2}");
            Console.WriteLine();
        }
    }
}
