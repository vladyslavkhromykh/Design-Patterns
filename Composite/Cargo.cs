namespace Composite
{
    public class Cargo : IProduct
    {
        private string name;
        private double price;

        public Cargo(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public double GetPrice()
        {
            return this.price;
        }
    }
}