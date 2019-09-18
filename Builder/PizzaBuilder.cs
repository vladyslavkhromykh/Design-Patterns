namespace Builder
{
    public class PizzaBuilder
    {
        private Pizza cookingPizza;

        public PizzaBuilder AddIngridient<T>() where T : IPizzaIngridient, new ()
        {
            if (cookingPizza == null)
            {
                cookingPizza = new Pizza();
            }
            
            cookingPizza.ingridients.Add(new T());
            return this;
        }

        public Pizza GetPizza()
        {
            return cookingPizza;
        }

        public void Reset()
        {
            cookingPizza = null;
        }
    }
}