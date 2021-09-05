using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    /// <summary>
    /// A class that is used for coffe orders
    /// </summary>
   public abstract  class Coffee
    {
        /// <summary>
        /// returns the price of the coffee
        /// It's possible to override this method, beacuse it is virtual 
        /// </summary>
        /// <returns>20 dkr</returns>
        /// 
        private int _discount;

        public Coffee(int discount)
        {
            _discount = discount;

            if (discount > 5)
            {
                throw new Exception("The discount should not be greater than 5 kr.");
            }
        }

        public int Discount { get => _discount; set => _discount = value; }

  

        public virtual int price()
        {
            //if (Discount > 5)
            //{
            //    throw new Exception("The discount should be less than 5kr.");
            //}
            return 20 - Discount;
        }

        public abstract string Strength();
       
    }
}
