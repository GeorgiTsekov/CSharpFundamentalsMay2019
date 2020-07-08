using System;
using System.Linq;
using System.Collections.Generic;

namespace P05TeamWorkProjects
{
    class Program
    {
        static void Main()
        {
            int teamCounter = int.Parse(Console.ReadLine());

            List<Project> projects = new List<Project>();

            List<string> sameProjects = new List<string>();

            List<string> sameCreator = new List<string>();
 
            for (int i = 0; i < teamCounter; i++)
            {
                string[] teamCreatorAndName = Console.ReadLine().Split("-");

                string creator = teamCreatorAndName[0];
                string teamName = teamCreatorAndName[1];

                Project project = new Project();

                if (sameCreator.Contains(creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else if (!sameProjects.Contains(teamName) && !sameCreator.Contains(creator))
                {
                    sameCreator.Add(creator);
                    sameProjects.Add(teamName);
                    projects.Add(project);
                }
                else if(sameProjects.Contains(teamName) && !sameCreator.Contains(creator))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
            }

            string input;

            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] command = input.Split("->");
                
                string teamName = command[1];
                string member = command[0];

                Project project = new Project();

                if (sameProjects.Contains(teamName))
                {
                    projects.Add(project);
                }
                else
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
            
            }

            Console.WriteLine(string.Join(Environment.NewLine, projects));
        }
    }
}
