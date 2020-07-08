using System;
using System.Collections.Generic;
using System.Linq;

namespace P05Students
{
    class Program
    {
        public static void Main()
        {
            string input;

            List<Student> students = new List<Student>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] data = input.Split(" ");

                string firstName = data[0];
                string lastName = data[1];
                string age = data[2];
                string homeTown = data[3];

                Student student = new Student();

                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.HomeTown = homeTown;

                students.Add(student);
            }

            string town = Console.ReadLine();

            foreach (Student student in students)
            {
                if (town == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}

