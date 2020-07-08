using System;

namespace footballKit
{
    class Program
    {
        static void Main(string[] args)
        {
            double tshirtPrice = double.Parse(Console.ReadLine());
            double sumForBall = double.Parse(Console.ReadLine());

            double shorts = tshirtPrice * 0.75;
            double socks = shorts * 0.20;
            double buttons = 2 * (tshirtPrice + shorts);
            double sumWithDiscount = (tshirtPrice + shorts + socks + buttons) * 0.85;

            if (sumWithDiscount >= sumForBall)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {sumWithDiscount:f2} lv.");
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {(sumForBall - sumWithDiscount):f2} lv. more.");
            }
        }
    }
}
