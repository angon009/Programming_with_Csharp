using System;

namespace Example_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Foods burgers = new Burgers();           
            Console.WriteLine($"{burgers.FoodName()}'s Price and Offer Discount : ");
            double price = burgers.FoodPrice =  double.Parse(Console.ReadLine());
            var burgerDiscount = double.Parse(Console.ReadLine());
            Console.WriteLine("Price : " + (price - burgers.FoodDiscount(burgerDiscount)));


            Foods sandwich = new Sandwich();
            Console.WriteLine($"{sandwich.FoodName()}'s Price and Offer Discount : ");
            price = sandwich.FoodPrice = double.Parse(Console.ReadLine());
            var sandwichDiscount = double.Parse(Console.ReadLine());
            Console.WriteLine("Price : " + (price - sandwich.FoodDiscount(sandwichDiscount)));


            Foods pizzas = new Pizzas();
            Console.WriteLine($"{pizzas.FoodName()}'s Price and Offer Discount : ");
            price = pizzas.FoodPrice = double.Parse(Console.ReadLine());
            var pizzaDiscount = double.Parse(Console.ReadLine());
            Console.WriteLine("Price : " + (price - pizzas.FoodDiscount(pizzaDiscount)));
        }
    }
}
