using System;
using System.Linq;
using System.Collections.Generic;

namespace P06Courses
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> counts = new Dictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] courseAndStudents = input.Split(" : ");

                string courseName = courseAndStudents[0];

                string studentName = courseAndStudents[1];

                if (!counts.ContainsKey(courseName))
                {
                    counts.Add(courseName, new List<string>() { studentName });
                }
                else
                {
                    counts[courseName].Add(studentName);
                }
            }
            var result = counts.OrderByDescending(x=>x.Value.Count);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                item.Value.Sort();
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine($"-- {item.Value[i]}");
                }
            }   
        }
    }
}
