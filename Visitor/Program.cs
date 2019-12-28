using System;

namespace Visitor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Tobacco tobacco = new Tobacco(10.99);
            Alcohol alcohol = new Alcohol(10.99);
            Food food = new Food(10.99);
            
            TaxVisitor taxVisitor = new TaxVisitor();
            
            double tobaccoTax = tobacco.Accept(taxVisitor);
            double alcoholTax = alcohol.Accept(taxVisitor);
            double foodTax = food.Accept(taxVisitor);
            
            Console.WriteLine(string.Format($"Tobacco: price: {tobacco.Price}, tax: {tobaccoTax}"));
            Console.WriteLine(string.Format($"Alcohol: price: {alcohol.Price}, tax: {alcoholTax}"));
            Console.WriteLine(string.Format($"Food: price: {food.Price}, tax: {foodTax}"));
        }
    }
}