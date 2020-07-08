using System;
using System.Collections.Generic;
using System.Linq;

namespace P07OrderByAge
{
    class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] splitedInput = input
                    .Split(" ");

                string name = splitedInput[0];
                string id = splitedInput[1];
                int age = int.Parse(splitedInput[2]);

                Person person = new Person(name, id, age);

                people.Add(person);
            }

            people = people
                .OrderBy(x => x.Age)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, people));
        }
    }
}
