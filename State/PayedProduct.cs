using System;

namespace State
{
    public class PaidState : ShopProduct.IState
    {
        private ShopProduct product;
        
        public PaidState(ShopProduct product)
        {
            this.product = product;
        }
        
        public void GetInfo()
        {
            Console.WriteLine("Product is paid. It will arrive soon.");
        }

        public void Remove()
        {
            Console.WriteLine("There are no place to remove product from.");
        }

        public void Pay()
        {
            Console.WriteLine("We are not sure you wanna pay another time for the same product.");
        }
    }
}