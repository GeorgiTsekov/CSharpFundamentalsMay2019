using System;

namespace P08BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfModels = int.Parse(Console.ReadLine());
            double biggestKeg = 0;
            string biggestModel = string.Empty;

            for (int i = 1; i <= countOfModels; i++)
            {
                string modelOfTheKeg = Console.ReadLine();
                double radiusOfTheKeg = double.Parse(Console.ReadLine());
                int heightOfTheKeg = int.Parse(Console.ReadLine());

                double volumeOfTheKeg = Math.PI * radiusOfTheKeg * radiusOfTheKeg * heightOfTheKeg;

                if (biggestKeg < volumeOfTheKeg)
                {
                    biggestKeg = volumeOfTheKeg;
                    biggestModel = modelOfTheKeg;
                }
            }
            Console.WriteLine(biggestModel);            
        }
    }
}
