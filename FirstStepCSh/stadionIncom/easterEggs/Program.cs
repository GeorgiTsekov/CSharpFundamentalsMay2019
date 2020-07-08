using System;

namespace easterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int colouredEggsCount = int.Parse(Console.ReadLine());
            int redEggs = 0;
            int orangeEggs = 0;
            int blueEggs = 0;
            int greenEggs = 0;
            int maxEggs = 0;
            string colour = string.Empty;

            for (int i = 1; i <= colouredEggsCount; i++)
            {
                string eggColour = Console.ReadLine();

                if (eggColour == "red")
                {
                    redEggs++;
                }
                else if (eggColour == "orange")
                {
                    orangeEggs++;
                }
                else if (eggColour == "blue")
                {
                    blueEggs++;
                }
                else if (eggColour == "green")
                {
                    greenEggs++;
                }
            }
            if (redEggs > orangeEggs && redEggs > blueEggs && redEggs > greenEggs)
            {
                maxEggs = redEggs;
                colour = "red";
            }
            else if (orangeEggs > redEggs && orangeEggs > blueEggs && orangeEggs > greenEggs)
            {
                maxEggs = orangeEggs;
                colour = "orange";
            }
            else if (blueEggs > redEggs && blueEggs > orangeEggs && blueEggs > greenEggs)
            {
                maxEggs = blueEggs;
                colour = "blue";
            }
            else if (greenEggs > redEggs && greenEggs > blueEggs && greenEggs > orangeEggs)
            {
                maxEggs = greenEggs;
                colour = "green";
            }

            Console.WriteLine($"Red eggs: {redEggs}");
            Console.WriteLine($"Orange eggs: {orangeEggs}");
            Console.WriteLine($"Blue eggs: {blueEggs}");
            Console.WriteLine($"Green eggs: {greenEggs}");
            Console.WriteLine($"Max eggs: {maxEggs} -> {colour}");
        }
    }
}
