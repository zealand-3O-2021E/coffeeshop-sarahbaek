using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeShopConsoleApp;

using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp.Tests
{
    [TestClass()]
    public class CoffeeTests
    {
        //[TestMethod()]
        //public void CoffeeTest()
        //{
        //    //Arrange
        //    Coffee coffee = new Coffee("BB", 2, 40);
        //    //Act

        //    //Assert

        //    Assert.Fail();
        //}


        [TestMethod()]
        public void CoffeePriceTest_CorrectDiscount_ShouldPass()
        {
            //Arrange
            int price = 40;
            int discount = 3;
            int expected = 37;


            Coffee cc = new Latte("BB", 3, 40);

            //Act
            cc.CoffeePrice();
            //Assert
            int actual = cc.CoffeePrice();
            Assert.AreEqual(expected, actual);

            //Assert.Fail("The  expected exception was not thrown");
        }


        [TestMethod()]
        public void CoffeePriceTest_DiscountOver5_ShouldThrowAnException()
        {
            //Arrange
            int price = 25;
            int discount = 6;
           
            //Act
            try
            {
                //Assert
                Coffee ct = new Cortado("BB", discount, price);

            }
            catch (System.ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, Coffee.DiscountNotGreaterThanFive);
                return;
            }
            Assert.Fail("The  expected exception was not thrown");
        }


        [TestMethod()]
        public void CoffeePriceTest_DiscountLessThanZero_ShouldThrowAnException()
        {
            //Arrange
            int price = 25;
            int discount = -2;



            //Act
            try
            {
                //Assert
                Coffee ct = new Cortado("BB", discount, price);

            }
            catch (System.ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, Coffee.DiscountNotLessThanZero);
                return;
            }
            Assert.Fail("The  expected exception was not thrown");
        }


      //  [TestMethod()]
      //  public void StrengthTest()
      //  {
      //      //Arrange
      //      Coffee cs = new Latte("LL", 2, 40);
      //      //Act
      //      cs.Strength();
      ////  https://docs.microsoft.com/en-us/visualstudio/test/unit-test-basics?view=vs-2017

      //      //Assert
      //      Assert.Fail();
      //  }
    }
}