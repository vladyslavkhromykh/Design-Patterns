namespace Builder
{
    public class PizzaDirector
    {
        private PizzaBuilder pizzaBuilder;
        
        public void SetPizzaBuider(PizzaBuilder pizzaBuilder)
        {
            this.pizzaBuilder = pizzaBuilder;
        }
        
        public PizzaDirector(PizzaBuilder pizzaBuilder)
        {
            SetPizzaBuider(pizzaBuilder);
        }
        
        public Pizza CreateMargaritaPizza()
        {
            var margaritaPizza =  pizzaBuilder.AddIngridient<Tomato>().AddIngridient<Cheese>().GetPizza();
            pizzaBuilder.Reset();
            
            return margaritaPizza;
        }

        public Pizza CreatePepperoniPizza()
        {
            var pepperoniPizza = pizzaBuilder.AddIngridient<Pepperoni>().AddIngridient<Cheese>().AddIngridient<Olives>().AddIngridient<Mushrooms>().GetPizza();
            pizzaBuilder.Reset();
            
            return pepperoniPizza;
        }
        
        public Pizza CreateChickenPizza()
        {
            var chickenPizza = pizzaBuilder.AddIngridient<Chicken>().AddIngridient<Cheese>().AddIngridient<Tomato>().AddIngridient<Mushrooms>().GetPizza();
            pizzaBuilder.Reset();
            
            return chickenPizza;
        }
    }
}