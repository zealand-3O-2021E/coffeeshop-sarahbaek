﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class Cortado : Coffee
    {
        public override int price()
        {
            return 25;
        }

        public override string Strength()
        {
          return "Medium";
        }
    }
}
