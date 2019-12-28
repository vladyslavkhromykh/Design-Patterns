namespace Visitor
{
    public class Alcohol : IProduct, IVisitable
    {
        public double Price { get; }

        public Alcohol(double price)
        {
            Price = price;
        }
        
        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}