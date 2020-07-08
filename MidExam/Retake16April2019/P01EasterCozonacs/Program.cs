using System;

namespace P01EasterCozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            double floorPrice = double.Parse(Console.ReadLine());

            double packOfEggsPrice = floorPrice * 0.75;
            double milkPrice = 1.25 * floorPrice;

            double cozonakPrice = packOfEggsPrice + floorPrice + (milkPrice * 0.25);

            int eggs = 0;

            int cozonaks = 0;

            int counter = 0;

            while (budjet > 0)
            {
                budjet -= cozonakPrice;
                if (budjet < 0)
                {
                    break;
                }
                cozonaks++;
                eggs = eggs + 3;
                counter++;
                if (counter == 3)
                {
                    counter = 0;
                    eggs -= (cozonaks - 2);
                }
            }
            budjet += cozonakPrice;

            Console.WriteLine($"You made {cozonaks} cozonacs! Now you have {eggs} eggs and {budjet:F2}BGN left.");
        }
    }
}
