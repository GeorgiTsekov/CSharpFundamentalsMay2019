using System;
using System.Collections.Generic;

namespace P07StoreBoxes
{
    class Program
    {
        static void Main()
        {
            string input;

            List<StoreBox> storeBoxes = new List<StoreBox>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] data = input.Split(" ");

                int serialNumber = int.Parse(data[0]);
                string name = data[1];
                int quantity = int.Parse(data[2]);
                decimal price = decimal.Parse(data[3]);

                decimal finalPrice = quantity * price;

                StoreBox storeBox = new StoreBox(serialNumber, name, quantity, price, finalPrice);

                storeBoxes.Add(storeBox);
            }

            List<StoreBox> newStoreBoxes = new List<StoreBox>();

            while (storeBoxes.Count != 0)
            {
                decimal maxNumber = int.MinValue;

                StoreBox firstStoreBox = null;

                for (int i = 0; i < storeBoxes.Count; i++)
                {
                    StoreBox storeBox = storeBoxes[i];

                    if (storeBox.FinalPrice > maxNumber)
                    {
                        maxNumber = storeBox.FinalPrice;
                        firstStoreBox = storeBox;
                    }
                }

                newStoreBoxes.Add(firstStoreBox);

                storeBoxes.Remove(firstStoreBox);
            }

            foreach (StoreBox storeBox in newStoreBoxes)
            {
                Console.WriteLine(storeBox.SerialNumber);
                Console.WriteLine($"-- {storeBox.Name} - ${storeBox.Price:F2}: {storeBox.Quantity}");
                Console.WriteLine($"-- ${storeBox.FinalPrice:F2}");
            }
        }
    }
}
