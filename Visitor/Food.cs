namespace Visitor
{
    public class Food : IProduct, IVisitable
    {
        public double Price { get; }

        public Food(double price)
        {
            Price = price;
        }
        
        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}