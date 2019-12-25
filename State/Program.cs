namespace State
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ShopProduct product = new ShopProduct();
            
            product.GetInfo();
            product.Pay();
            product.AddToBasket();
            
            product.GetInfo();
            product.Pay();
            
            product.GetInfo();
            product.Pay();
        }
    }
}