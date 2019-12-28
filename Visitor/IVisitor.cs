namespace Visitor
{
    public interface IVisitor
    {
        double Visit(Tobacco tobacco);
        double Visit(Alcohol alcohol);
        double Visit(Food food);
    }
}