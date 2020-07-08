using System;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main()
        {
            var tires = new Tire[4]
            {
                new Tire(1, 2.5),
                new Tire(1, 2.1),
                new Tire(2, 0.5),
                new Tire(2, 2.3),
            };

            var engine = new Engine(560, 6300);

            Car firstCar = new Car();
            firstCar.Drive(1000);

            Car secondCar = new Car("Renaut", "Megan", 2000);
            Car thirdCar = new Car("Audi", "A6", 2004, 82.5, 6.7);

            var car = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);

            Console.WriteLine(firstCar.WhoAmI());
            Console.WriteLine(secondCar.WhoAmI());
            Console.WriteLine(thirdCar.WhoAmI());
        }
    }
}
