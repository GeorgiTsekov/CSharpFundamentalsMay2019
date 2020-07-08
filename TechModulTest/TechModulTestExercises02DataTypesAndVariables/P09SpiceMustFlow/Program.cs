using System;

namespace P09SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYields = int.Parse(Console.ReadLine());
            int totalYields = 0;
            int days = 0;

            while (startingYields >= 100)
            {
                totalYields += startingYields - 26;
                startingYields -= 10;
                days++;
            }
            if (totalYields >= 26)
            {
                totalYields -= 26;
            }
            Console.WriteLine(days);
            Console.WriteLine(totalYields);
        }
    }
}
