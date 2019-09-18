using System.Collections.Generic;

namespace Builder
{
    public class Pizza
    {
        public List<IPizzaIngridient> ingridients { get; private set; }

        public Pizza()
        {
            ingridients = new List<IPizzaIngridient>();
        }
    }
}