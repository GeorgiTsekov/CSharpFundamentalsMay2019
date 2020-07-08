using System;

namespace examPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int possibleBadGrades = int.Parse(Console.ReadLine());
            int badGradesCount = 0;
            double sumGrades = 0;
            int totalGradesCount = 0;
            string lastProblem = string.Empty;

            while (badGradesCount < possibleBadGrades)
            {
                string nameOfExercise = Console.ReadLine();
                if (nameOfExercise == "Enough")
                {
                    break;
                }

                int currentGrade = int.Parse(Console.ReadLine());

                lastProblem = nameOfExercise;
                totalGradesCount++;
                sumGrades += currentGrade;

                if (currentGrade <= 4)
                {
                    badGradesCount++;
                }
            }
            if (badGradesCount == possibleBadGrades)
            {
                Console.WriteLine($"You need a break, {badGradesCount} poor grades.");
            }
            else
            {
                double averageScore = sumGrades / (double)totalGradesCount;
                Console.WriteLine($"Average score: {averageScore:f2}");
                Console.WriteLine($"Number of problems: {totalGradesCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
