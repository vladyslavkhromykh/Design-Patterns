namespace Visitor
{
    public class TaxVisitor : IVisitor
    {
        public double Visit(Tobacco tobacco)
        {
            return tobacco.Price * 0.2;
        }

        public double Visit(Alcohol alcohol)
        {
            return alcohol.Price * 0.3;
        }

        public double Visit(Food food)
        {
            return food.Price * 0.35;
        }
    }
}