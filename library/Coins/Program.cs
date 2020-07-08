using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double changeTarget = double.Parse(Console.ReadLine())*100;
            double oneLev = 100;
            double twoLev = 200;
            double oneStotinka = 1;
            double twoStotinka = 2;
            double fiveStotinka = 5;
            double tenStotinka = 10;
            double twentyStotinka = 20;
            double fivtyStotinka = 50;
            double coinsCount = 0;
            double currentChange = 0;
            while (currentChange < changeTarget)
            {
                if (currentChange + 200 <= changeTarget)
                {
                    currentChange += 200;

                }
                else if (currentChange + 100 <= changeTarget)
                {
                    currentChange += 100;
                }
                else if (currentChange + 50 <= changeTarget)
                {
                    currentChange += 50;
                }
                else if (currentChange + 20 <= changeTarget)
                {
                    currentChange += 20;
                }
                else if (currentChange + 10 <= changeTarget)
                {
                    currentChange += 10;
                }
                else if (currentChange + 5 <= changeTarget)
                {
                    currentChange += 5;
                }
                else if (currentChange + 2 <= changeTarget)
                {
                    currentChange += 2;
                }
                else if (currentChange + 1 <= changeTarget)
                {
                    currentChange += 1;
                }
            }

        }
    }
}
