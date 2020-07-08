using System;

namespace ArraysExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());
            int sum = 0;

            int[] arrayOfPeople = new int[numberOfWagons];
            for (int i = 0; i < arrayOfPeople.Length; i++)
            {
                int peopleInWagon = int.Parse(Console.ReadLine());

                arrayOfPeople[i] = peopleInWagon;
                sum += arrayOfPeople[i];
            }
            foreach (var wagon in arrayOfPeople)
            {
                Console.Write($"{wagon} ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
