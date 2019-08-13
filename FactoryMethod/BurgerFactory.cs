
namespace FactoryMethod
{
    public class BurgerFactory : ProductFactory
    {
        public override IProduct CreateProduct()
        {
            return new Burger();
        }
    }
}
