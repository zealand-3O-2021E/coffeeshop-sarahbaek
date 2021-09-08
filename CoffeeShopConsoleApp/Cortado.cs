using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class Cortado : Coffee, IMilk
    {
        public Cortado(string name, int discount): base(name, discount)
        {
       
        }
        public int MlMilk()
        {
            return 40;
        }

        public override int price()
        {
            return 25 - Discount;
        }

        public override string Strength()
        {
            Console.WriteLine("Coffee Cortado");
            Console.WriteLine("___________________");
            return "Medium";
        }
    }
}
