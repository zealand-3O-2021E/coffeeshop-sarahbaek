using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
   public class Latte : Coffee, IMilk
    {
        public Latte(int discount): base(discount)
        {
         
        }
        public int MlMilk()
        {
            return 200;
        }

        public override int price()
        {
            return 40 - Discount;
        }

        public override string Strength()
        {
            Console.WriteLine("Coffee Latte");
            Console.WriteLine("___________________");
           return "Weak";
        }
    }
}
