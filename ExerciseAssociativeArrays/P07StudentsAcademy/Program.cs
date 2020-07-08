using System;
using System.Linq;
using System.Collections.Generic;

namespace P07StudentsAcademy
{
    class Program
    {
        static void Main()
        {
            int rowsByGrades = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> dict = new Dictionary<string, List<double>>();

            for (int i = 0; i < rowsByGrades; i++)
            {
                string name = Console.ReadLine();

                double grade = double.Parse(Console.ReadLine());

                if (!dict.ContainsKey(name))
                {
                    dict[name] = new List<double>();
                }

                dict[name].Add(grade);
            }

            dict = dict.Where(x => x.Value.Average() >= 4.50)
                .OrderByDescending(x => x.Value.Average())
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine(string.Join(Environment.NewLine, dict.Select(x=>$"{x.Key} -> {x.Value.Average():F2}")));         
        }
    }
}
