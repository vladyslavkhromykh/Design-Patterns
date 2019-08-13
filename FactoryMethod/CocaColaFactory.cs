
namespace FactoryMethod
{
    public class CocaColaFactory : ProductFactory
    {
        public override IProduct CreateProduct()
        {
            return new CocaCola();
        }
    }
}
