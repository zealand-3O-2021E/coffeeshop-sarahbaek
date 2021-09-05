using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
   public class Latte : Coffee
    {
        public override int price()
        {
            return 40;
        }

        public override string Strength()
        {
           return "Weak";
        }
    }
}
