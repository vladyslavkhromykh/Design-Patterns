using System;

namespace State
{
    public class DefaultState : ShopProduct.IState
    {
        private ShopProduct product;
        
        public DefaultState(ShopProduct product)
        {
            this.product = product;
        }

        
        public void GetInfo()
        {
            Console.WriteLine("Product is available. Do you wanna to add it to your basket?");
        }

        public void Remove()
        {
            Console.WriteLine("Product is removed from database...");
        }

        public void Pay()
        {
            Console.WriteLine("Before pay for product, you should add it to your basket.");
        }
    }
}