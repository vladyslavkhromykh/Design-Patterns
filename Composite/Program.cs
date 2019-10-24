using System;

namespace Composite
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var supply = new CargoContainer("stuff");
            var foodContainer = new CargoContainer("food");
            var clothesContainer = new CargoContainer("clothes");
            
            supply.Add(foodContainer);
            supply.Add(clothesContainer);
            
            foodContainer.Add(new Cargo("coca-cola", 9.99));
            foodContainer.Add(new Cargo("meat", 19.99));
            foodContainer.Add(new Cargo("fruits", 5.99));
            
            clothesContainer.Add(new Cargo("pants", 29.99));
            clothesContainer.Add(new Cargo("t-shirts", 13.99));
            
            Console.WriteLine(supply.GetPrice());
        }
    }
}