using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripprice = double.Parse(Console.ReadLine());
            int puzzlescount = int.Parse(Console.ReadLine());
            int puppetscount = int.Parse(Console.ReadLine());
            int bearscount = int.Parse(Console.ReadLine());
            int minionscount = int.Parse(Console.ReadLine());
            int truckscount = int.Parse(Console.ReadLine());
            double sum = (puzzlescount * 2.60 + puppetscount * 3 + bearscount * 4.10 + minionscount * 8.20 + truckscount * 2)*0.9;
            int toyscount = puzzlescount + puppetscount + bearscount + minionscount + truckscount;
            if(toyscount >= 50)
            {
                double discount = sum * 0.25;
                sum -= discount;
            }
            if(tripprice > sum)
            {
                double neededmoney = tripprice - sum;
                Console.WriteLine($"Not enough money! {neededmoney:f2} lv needed.");
            }
            else
            {
                double bonusmoney = sum - tripprice;
                Console.WriteLine($"Yes! {bonusmoney:f2} lv left.");
            }

            
        }
    }
}
