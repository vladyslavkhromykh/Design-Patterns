using System;

namespace State
{
    public sealed class ShopProduct
    {
        public interface IState
        {
            void GetInfo();
            void Remove();
            void Pay();
        }

        private IState state;

        public ShopProduct()
        {
            this.ChangeState(new DefaultState(this));
        }
        
        public void ChangeState(IState state)
        {
            this.state = state;
        }

        public void AddToBasket()
        {
            this.ChangeState(new SavedInUserBasket(this));
        }

        public void GetInfo()
        {
            this.state.GetInfo();
        }
        
        public void Pay()
        {
            this.state.Pay();
        }

        public void Remove()
        {
            this.state.Remove();
        }
    }
}