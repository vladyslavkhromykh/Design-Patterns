namespace FactoryMethod
{
    public class Burger : IProduct
    {
        public override decimal Price()
        {
            return 9.99m;
        }
    }
}
