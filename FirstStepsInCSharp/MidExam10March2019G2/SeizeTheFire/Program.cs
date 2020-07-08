using System;
using System.Collections.Generic;
using System.Linq;

namespace SeizeTheFire
{
    class Program
    {
        static void Main()
        {
            string fireString = Console.ReadLine();

            int water = int.Parse(Console.ReadLine());

            string[] fireArray = fireString.Split("#");

            int totalFire = 0;

            string cellList = string.Empty;

            for (int i = 0; i < fireArray.Length; i++)
            {
                string[] fireCellsInArray = fireArray[i].Split(" ");
                switch (fireCellsInArray[0])
                {
                    case "High":
                        int valueOfCell = int.Parse(fireCellsInArray[2]);

                        if (valueOfCell >= 81 && valueOfCell <= 125 && water >= valueOfCell)
                        {
                            cellList += valueOfCell + " ";

                            totalFire += valueOfCell;

                            water -= valueOfCell;
                        }
                        break;
                    case "Medium":
                        valueOfCell = int.Parse(fireCellsInArray[2]);
                        if (valueOfCell >= 51 && valueOfCell <= 80 && water >= valueOfCell)
                        {
                            cellList += valueOfCell + " ";

                            totalFire += valueOfCell;

                            water -= valueOfCell;
                        }
                        break;
                    case "Low":
                        valueOfCell = int.Parse(fireCellsInArray[2]);
                        if (valueOfCell >= 1 && valueOfCell <= 50 && water >= valueOfCell)
                        {
                            cellList += valueOfCell + " ";

                            totalFire += valueOfCell;

                            water -= valueOfCell;
                        }
                        break;
                }
            }
            string[] cells = cellList.Split(" ",StringSplitOptions.RemoveEmptyEntries);    

            double effort = totalFire * 0.25;

            Console.WriteLine("Cells:");

            foreach (var item in cells)
            {
                Console.WriteLine($" - {item}");
            }
            Console.WriteLine($"Effort: {effort:F2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }
    }
}
