using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class BlackCoffee : Coffee
    {
        public BlackCoffee(string name, int discount, int price): base(name,discount,  price)
        {
         
        }

        public override string Strength()
        {
            Console.WriteLine("Black Coffee");
            Console.WriteLine("___________________");
            return "Strong";
        }
    }
}
