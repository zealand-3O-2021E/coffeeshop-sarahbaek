using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class FlatWhite : Coffee
    {
        public FlatWhite(string name,int discount): base(name, discount)
        {

        }
        public override string Strength()
        {
            Console.WriteLine("Flat White");
            Console.WriteLine("___________________");
            return "Weak";
        }
    }
}
