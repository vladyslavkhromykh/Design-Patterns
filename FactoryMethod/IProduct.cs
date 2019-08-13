namespace FactoryMethod
{
    public abstract class IProduct
    {
        public abstract decimal Price();
        public override string ToString()
        {
            return string.Format($"{GetType()}: {Price()}");
        }
    }
}
