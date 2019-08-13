using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    public class Program
    {
        private const string MENU = 
            @"Menu list:
    1. Burger
    2. Coca Cola
    3. French Fries";

        private static void Main(string[] args)
        {
            var burgerFactory = new BurgerFactory();
            var cocaColaFactory = new CocaColaFactory();
            var frenchFriesFactory = new FrenchFriesFactory();

            Console.WriteLine("Hello! We are happy to see you in our virtual restaurant!");
            Console.WriteLine("Select what you prefer to eat.");
            Console.WriteLine();

            List<IProduct> userOrder = new List<IProduct>();
            string userResponse = string.Empty;
            int userResponseParsed = 0;

            Console.WriteLine(MENU);

            while (userResponse != "F")
            {
                userResponse = Console.ReadLine();
                Console.WriteLine();
                int.TryParse(userResponse, out userResponseParsed);
                switch (userResponseParsed)
                {
                    case 1:
                        var burger = burgerFactory.CreateProduct();
                        userOrder.Add(burger);
                        Console.WriteLine($"{burger} was added to order.");
                        Console.WriteLine();
                        break;
                    case 2:
                        var cocaCola = cocaColaFactory.CreateProduct();
                        userOrder.Add(cocaCola);
                        Console.WriteLine($"{cocaCola} was added to order.");
                        Console.WriteLine();
                        break;
                    case 3:
                        var frenchFries = frenchFriesFactory.CreateProduct();
                        userOrder.Add(frenchFries);
                        Console.WriteLine($"{frenchFries} was added to order.");
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("You request can not be resolved via menu. Try again.");
                        Console.WriteLine();
                        break;
                }

                Console.WriteLine(MENU);
                Console.WriteLine("If you want to finish your order, enter F");
            }

            Console.WriteLine();
            Console.WriteLine("Your order is:");
            decimal totalPrice = 0.0m;
            for (int i = 0; i < userOrder.Count; i++)
            {
                Console.WriteLine($"{i}: {userOrder[i]}");
                totalPrice += userOrder[i].Price();
            }
            Console.WriteLine("Total price: " + totalPrice);
        }
    }
}
