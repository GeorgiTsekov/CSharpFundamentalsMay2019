using System;

namespace coins1
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                double changeTarget = double.Parse(Console.ReadLine()) * 100;

                double currentChange = 0;
                int coinsCount = 0;

                while (currentChange < changeTarget)
                {
                    if (currentChange + 200 <= changeTarget)
                    {
                        currentChange += 200;
                        coinsCount++;
                    }
                    else if (currentChange + 100 <= changeTarget)
                    {
                        currentChange += 100;
                        coinsCount++;
                    }
                    else if (currentChange + 50 <= changeTarget)
                    {
                        currentChange += 50;
                        coinsCount++;
                    }
                    else if (currentChange + 20 <= changeTarget)
                    {
                        currentChange += 20;
                        coinsCount++;
                    }
                    else if (currentChange + 10 <= changeTarget)
                    {
                        currentChange += 10;
                        coinsCount++;
                    }
                    else if (currentChange + 5 <= changeTarget)
                    {
                        currentChange += 5;
                        coinsCount++;
                    }
                    else if (currentChange + 2 <= changeTarget)
                    {
                        currentChange += 2;
                        coinsCount++;
                    }
                    else if (currentChange + 1 <= changeTarget)
                    {
                        currentChange += 1;
                        coinsCount++;
                    }
                }

                Console.WriteLine(coinsCount);
                Console.WriteLine();

            }
            
        }
    }
}
