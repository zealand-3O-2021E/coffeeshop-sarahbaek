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
                new Latte("Latte", 1, 40),
                new Cortado("Cortado", 1, 25),
                new BlackCoffee("Black Coffee",1, 40),
                new FlatWhite("Flat white",0, 40),
                new Expresso("Expresso", 0, 40)
                

           };


            foreach (var coffee in orderList)
            {
                Console.WriteLine("Name= {0}, Strength= {1} , Price = {2}",coffee.Name, coffee.Strength(), coffee.CoffeePrice());
                Console.WriteLine();
              
            }

            Console.WriteLine();

            List<Coffee> milkyCoffee = new List<Coffee>()
            {
                new Latte("Latte", 0, 35),
                new Cortado("Cortado",0, 50)

            };
           
            Console.WriteLine("Coffee with Milk");
            Console.WriteLine("---------------------------");
            foreach (Coffee coffee in milkyCoffee)
            {
                Console.WriteLine("the Price of the coffee is = {0}, Strength= {1} , discount = {2}", coffee.CoffeePrice(), coffee.Strength(), coffee.Discount);
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
