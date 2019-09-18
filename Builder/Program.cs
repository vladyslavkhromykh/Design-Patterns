using System;

namespace Builder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Have a nice dinner with our delicious pizza!");
            PizzaBuilder pizzaBuilder = new PizzaBuilder();
            PizzaDirector director = new PizzaDirector(pizzaBuilder);

            Pizza margaritaPizza = director.CreateMargaritaPizza();
            Pizza pepperoniPizza = director.CreatePepperoniPizza();
            Pizza chickenPizza = director.CreateChickenPizza();
        }
    }
}