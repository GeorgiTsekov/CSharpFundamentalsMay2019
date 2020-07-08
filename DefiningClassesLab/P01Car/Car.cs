using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        private Engine engine;

        private Tire tires;

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year)
            : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(
            string make, 
            string model, 
            int year, 
            double fuelQuantity, 
            double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(
            string make,
            string model,
            int year,
            double fuelQuantity,
            double fuelConsumption,
            Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.engine = engine;
            this.tires = tires[4];
        }

        public void Drive(double distance)
        {
            bool canContinue = this.FuelQuantity - (this.FuelConsumption * distance) / 100 >= 0;
            if (canContinue)
            {
                this.FuelQuantity -= (this.FuelConsumption * distance) / 100;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Make: {this.Make}");
            sb.Append($"\nModel: {this.Model}");
            sb.Append($"\nYear: {this.Year}");
            sb.Append($"\nConsumtion: {this.FuelConsumption}");
            sb.Append($"\nFuel: {this.FuelQuantity:F2}L");
            return sb.ToString();
        }
    }
}
