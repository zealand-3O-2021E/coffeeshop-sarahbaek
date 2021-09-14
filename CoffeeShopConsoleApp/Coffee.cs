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
  

        public const string DiscountNotGreaterThanFive = "The discount should not be greater than 5 kr.";
        public const string DiscountNotLessThanZero = "The discount should not be less than 0kr.";
        

        private int _discount;
        private string _name;
        private int _price;
      

        public Coffee(string name, int discount, int price)
        {
            _name = name;
            _discount = discount;

            if (discount > 5)
            {
                throw new System.ArgumentOutOfRangeException("discount",DiscountNotGreaterThanFive);
            }
            if (discount < 0)
            {
                throw new System.ArgumentOutOfRangeException("discount", DiscountNotLessThanZero);
            }

            _price = price;
        }


        public int Discount { get => _discount; set => _discount = value; }
        public string Name { get => _name; set => _name = value; }
        public int Price { get => _price; set => _price = value; }

        public virtual int CoffeePrice()
        {
            Price = 40;
            return Price - Discount;
        }

        public abstract string Strength();
       
    }
}
