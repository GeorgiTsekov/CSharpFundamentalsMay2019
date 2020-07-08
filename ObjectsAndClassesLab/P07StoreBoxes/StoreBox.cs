
namespace P07StoreBoxes
{
    class StoreBox
    {
        public StoreBox(int serialNumber, string name, int quantity, decimal price, decimal finalPrice)
        {
            SerialNumber = serialNumber;
            Name = name;
            Quantity = quantity;
            Price = price;
            FinalPrice = finalPrice;
        }

        public int SerialNumber { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal FinalPrice { get; set; }
    }
}
