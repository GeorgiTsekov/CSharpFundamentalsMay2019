using System;

namespace P01Train
{
    class Program
    {
        static void Main()
        {
            int countOfWagons = int.Parse(Console.ReadLine());

            int[] countOfPeopleInWagons = new int[countOfWagons];

            int sumOfAllTrains = 0;

            for (int i = 0; i < countOfPeopleInWagons.Length; i++)
            {
                int countOfPeople = int.Parse(Console.ReadLine());
                countOfPeopleInWagons[i] = countOfPeople;
                sumOfAllTrains += countOfPeopleInWagons[i];
            }
            Console.WriteLine(string.Join(" ", countOfPeopleInWagons));
            Console.WriteLine(sumOfAllTrains);
        }
    }
}
