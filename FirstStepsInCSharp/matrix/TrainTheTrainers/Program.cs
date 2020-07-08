using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int judjesCount = int.Parse(Console.ReadLine());
            double averageAll = 0;
            int count = 0;
            double averageRatingPlus = 0;

            while (true)
            {
                string presentation = Console.ReadLine();

                if (presentation == "Finish")
                {
                    Console.WriteLine($"Student's final assessment is {averageAll/count:f2}.");
                    break;
                }
                double averageRating = 0;

                for (int i = 0; i < judjesCount; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    averageRating += grade;
                    averageRatingPlus = averageRating / judjesCount;
                }
                Console.WriteLine($"{presentation} - {averageRatingPlus:f2}.");
                averageAll += averageRatingPlus;
                count++;
                continue;
            }
        }
    }
}
