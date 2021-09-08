using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class Cortado : Coffee, IMilk
    {
        public Cortado(string name, int discount, int price): base(name, discount, price)
        {
       
        }
        public int MlMilk()
        {
            return 40;
        }

        public override int CoffeePrice()
        {
            //Price = 25;
            return Price - Discount;
        }

        public override string Strength()
        {
            Console.WriteLine("Coffee Cortado");
            Console.WriteLine("___________________");
            return "Medium";
        }
    }
}
