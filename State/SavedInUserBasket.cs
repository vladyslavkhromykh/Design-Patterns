using System;

namespace State
{
    public sealed class SavedInUserBasket : ShopProduct.IState
    {
        private ShopProduct product;
        
        public SavedInUserBasket(ShopProduct product)
        {
            this.product = product;
        }
        
        public void GetInfo()
        {
            Console.WriteLine("Product is saved in your basket.");
        }

        public void Remove()
        {
            Console.WriteLine("Product is removed from your basket.");
        }

        public void Pay()
        {
            Console.WriteLine("Payment is being processed.");
            this.product.ChangeState(new PaidState(this.product));
        }
    }    
}
