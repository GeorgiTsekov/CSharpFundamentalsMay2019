using System;

namespace P01
{
    class Program
    {
        static void Main()
        {
            double sizeOfSide = double.Parse(Console.ReadLine());
            int numberOfSheets = int.Parse(Console.ReadLine());
            double singleSheetOfPaperCovers = double.Parse(Console.ReadLine());

            double sOfTheSheets = 0;

            double SOfTheBox = 6 * sizeOfSide * sizeOfSide;
            for (int i = 1; i <= numberOfSheets; i++)
            {
                if (i % 3 == 0)
                {
                    sOfTheSheets += singleSheetOfPaperCovers * 0.25;
                }
                else
                {
                    sOfTheSheets += singleSheetOfPaperCovers;
                }
            }

            double percentage = sOfTheSheets / SOfTheBox * 100;
            Console.WriteLine($"You can cover {percentage:F2}% of the box.");
        }
    }
}
