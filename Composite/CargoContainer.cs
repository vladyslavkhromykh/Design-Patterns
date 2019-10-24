using System.Collections.Generic;

namespace Composite
{
    public class CargoContainer : IProduct
    {
        private string name;
        private List<IProduct> cargos;

        public CargoContainer(string name)
        {
            this.name = name;
            this.cargos = new List<IProduct>();
        }

        public void Add(IProduct cargo)
        {
            this.cargos.Add(cargo);
        }
        
        
        public double GetPrice()
        {
            double price = 0.0;
            foreach (var cargo in cargos)
            {
                price += cargo.GetPrice();
            }

            return price;
        }
    }
}