namespace FactoryMethod
{
    public class CocaCola : IProduct
    {
        public override decimal Price()
        {
            return 4.99m;
        }
    }
}
