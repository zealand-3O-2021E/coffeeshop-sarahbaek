using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class Expresso : Coffee, IBlendingCoffee
      
    {
        public Expresso(string name, int discount, int price): base(name, discount, price)
        {

        }
        public string Blending()
        {
            return "Mix unproceesed coffee and fine coffee";
        }

        public override string Strength()
        {
            return "weak strength";
        }
    }
}
