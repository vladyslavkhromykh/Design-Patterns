
namespace FactoryMethod
{
    public class FrenchFriesFactory : ProductFactory
    {
        public override IProduct CreateProduct()
        {
            return new FrenchFries();
        }
    }
}
