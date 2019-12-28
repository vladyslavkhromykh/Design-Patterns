namespace Visitor
{
    public class Tobacco : IProduct, IVisitable
    {
        public double Price { get; }
        public Tobacco(double price)
        {
            Price = price;
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}