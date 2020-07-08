using System;
using System.Linq;
using System.Collections.Generic;

namespace P04Students
{
    class Program
    {
        static void Main()
        {
            int countOfStudents = int.Parse(Console.ReadLine());

            List<Student> studentInList = new List<Student>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string input = Console.ReadLine();
                string[] splitedInput = input.Split(" ");

                string firstName = splitedInput[0];
                string secondName = splitedInput[1];
                double grade = double.Parse(splitedInput[2]);

                Student student = new Student(firstName, secondName, grade);

                studentInList.Add(student);
            }

            studentInList = studentInList
                .OrderByDescending(x => x.Grade)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, studentInList));
        }
    }
}
