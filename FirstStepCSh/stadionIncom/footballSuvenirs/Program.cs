using System;

namespace footballSuvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string souvenirs = Console.ReadLine();
            int souvenirsCounter = int.Parse(Console.ReadLine());
            double souvenirsPrice = 0;

            if ((country != "Argentina") && (country != "Brazil") && (country != "Croatia") && (country != "Denmark"))
            {
                Console.WriteLine("Invalid country!");
                return;
            }
            else
            {
                if ((souvenirs != "flags") && (souvenirs != "caps") && (souvenirs != "posters") && (souvenirs != "stickers"))
                {
                    Console.WriteLine("Invalid stock!");
                    return;
                }
                else if (country == "Argentina")
                {
                    if (souvenirs == "flags")
                    {
                        souvenirsPrice = 3.25 * souvenirsCounter;
                    }
                    if (souvenirs == "caps")
                    {
                        souvenirsPrice = 7.20 * souvenirsCounter;
                    }
                    if (souvenirs == "posters")
                    {
                        souvenirsPrice = 5.10 * souvenirsCounter;
                    }
                    if (souvenirs == "stickers")
                    {
                        souvenirsPrice = 1.25 * souvenirsCounter;
                    }
                }
                if (country == "Brazil")
                {
                    if (souvenirs == "flags")
                    {
                        souvenirsPrice = 4.20 * souvenirsCounter;
                    }
                    if (souvenirs == "caps")
                    {
                        souvenirsPrice = 8.50 * souvenirsCounter;
                    }
                    if (souvenirs == "posters")
                    {
                        souvenirsPrice = 5.35 * souvenirsCounter;
                    }
                    if (souvenirs == "stickers")
                    {
                        souvenirsPrice = 1.20 * souvenirsCounter;
                    }
                }
                if (country == "Croatia")
                {
                    if (souvenirs == "flags")
                    {
                        souvenirsPrice = 2.75 * souvenirsCounter;
                    }
                    if (souvenirs == "caps")
                    {
                        souvenirsPrice = 6.90 * souvenirsCounter;
                    }
                    if (souvenirs == "posters")
                    {
                        souvenirsPrice = 4.95 * souvenirsCounter;
                    }
                    if (souvenirs == "stickers")
                    {
                        souvenirsPrice = 1.10 * souvenirsCounter;
                    }
                }
                if (country == "Denmark")
                {
                    if (souvenirs == "flags")
                    {
                        souvenirsPrice = 3.10 * souvenirsCounter;
                    }
                    if (souvenirs == "caps")
                    {
                        souvenirsPrice = 6.50 * souvenirsCounter;
                    }
                    if (souvenirs == "posters")
                    {
                        souvenirsPrice = 4.80 * souvenirsCounter;
                    }
                    if (souvenirs == "stickers")
                    {
                        souvenirsPrice = 0.90 * souvenirsCounter;
                    }                   
                }
                Console.WriteLine($"Pepi bought {souvenirsCounter} {souvenirs} of {country} for {souvenirsPrice:f2} lv.");
            }

        }
    }
}
