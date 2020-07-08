using System;
using System.Linq;
using System.Collections.Generic;

namespace P08CompanyUsers
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(" -> ");

                string company = command[0];

                string employeeId = command[1];

                if (!dict.ContainsKey(company))
                {
                    dict[company] = new List<string>();
                }
                if (!dict[company].Contains(employeeId))
                {
                    dict[company].Add(employeeId);
                }
            }

            dict = dict
                .OrderBy(x => x.Key)
                .ThenBy(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}");
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine($"-- {item.Value[i]}");
                }
            }
        }
    }
}
