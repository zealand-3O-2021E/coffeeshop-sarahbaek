using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");
            Console.WriteLine("---------------------------------");
            // a list of all the orders for coffe in the coffee shop

            List<Coffee> orderList = new List<Coffee>()
           {
                new Latte("Latte", 1),
                new Cortado("Cortado", 1),
                new BlackCoffee("Black Coffee",1),
                new FlatWhite("Flat white",0),
                new Expresso("Expresso", 0)
                

           };


            foreach (var coffee in orderList)
            {
                Console.WriteLine("Name= {0}, Strength= {1} , Price = {2}",coffee.Name, coffee.Strength(), coffee.price());
                Console.WriteLine();
              
            }

            Console.WriteLine();

            List<Coffee> milkyCoffee = new List<Coffee>()
            {
                new Latte("Latte", 0),
                new Cortado("Cortado",0)

            };
           
            Console.WriteLine("Coffee with Milk");
            Console.WriteLine("---------------------------");
            foreach (Coffee coffee in milkyCoffee)
            {
                Console.WriteLine("the Price of the coffee is = {0}, Strength= {1} , discount = {2}", coffee.price(), coffee.Strength(), coffee.Discount);
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
