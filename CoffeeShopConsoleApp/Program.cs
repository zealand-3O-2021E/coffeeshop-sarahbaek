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

           List < Coffee > orderList = new List<Coffee>()
           {
                new Latte(1),
                new Cortado(1),
                new BlackCoffee(1),
                new FlatWhite(0)

           };


            foreach (var coffee in orderList)
            {
                Console.WriteLine("the Price of the coffee is = {0}, Strength= {1} ", coffee.price(), coffee.Strength());
                Console.WriteLine();
              
            }

            Console.WriteLine();

            List<Coffee> milkyCoffee = new List<Coffee>()
            {
                new Latte(0),
                new Cortado(0)

            };
           
            Console.WriteLine("Coffee with Milk");
            Console.WriteLine("---------------------------");
            foreach (Coffee coffee in milkyCoffee)
            {
                Console.WriteLine("the Price of the coffee is = {0}, Strength= {1} ", coffee.price(), coffee.Strength());
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
