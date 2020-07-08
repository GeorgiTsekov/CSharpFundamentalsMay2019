using System;

namespace P02Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            string peapleType = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double price = 0;
            double totalPrice = 0;

            if (peapleType == "Students")
            {
                if (dayOfTheWeek == "Friday")
                {
                    price = 8.45;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = 9.80;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    price = 10.46;
                }
                totalPrice = price * numberOfStudents;

                if (numberOfStudents >= 30)
                {
                    totalPrice = totalPrice * 0.85;
                }
            }
            else if (peapleType == "Business")
            {
                if (dayOfTheWeek == "Friday")
                {
                    price = 10.90;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = 15.60;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    price = 16;
                }
                totalPrice = price * numberOfStudents;

                if (numberOfStudents >= 100)
                {
                    totalPrice = totalPrice - 10;
                }
            }
            else if (peapleType == "Regular")
            {

                if (dayOfTheWeek == "Friday")
                {
                    price = 15;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = 20;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    price = 22.50;
                }
                totalPrice = price * numberOfStudents;
                if (numberOfStudents >= 10 && numberOfStudents <= 20)
                {
                    totalPrice = totalPrice * 0.95;
                }
            }
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
