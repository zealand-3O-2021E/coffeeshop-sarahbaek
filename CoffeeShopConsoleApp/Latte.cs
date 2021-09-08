using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
   public class Latte : Coffee, IMilk
    {
        public Latte(string name, int discount, int price): base(name, discount, price)
        {
         
        }
        public int MlMilk()
        {
            return 200;
        }

        public override int CoffeePrice()
        {
            //Price = 40;
            return Price - Discount;
        }

        public override string Strength()
        {
            Console.WriteLine("Coffee Latte");
            Console.WriteLine("___________________");
           return "Weak";
        }
    }
}
