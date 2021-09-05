using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");

           // a list of all the orders for coffe in the coffee shop

           List < Coffee > orderList = new List<Coffee>()
           {
                new Latte(),
                new Cortado(),
                new BlackCoffee()

           };


            foreach (var coffee in orderList)
            {
                Console.WriteLine("the Price of the coffee is = {0}, Strength= {1} ", coffee.price(), coffee.Strength());
                //Console.WriteLine("The proce of the coffe is = "coffee.price);
            }

            //Latte l1 = new Latte();
            //Cortado c1 = new Cortado();
            //BlackCoffee bc = new BlackCoffee();
            ////List<Coffee> cc = new Latte();

            Console.ReadLine();

        }
    }
}
