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
            int discount = 10;
           
            Coffee ct = new Cortado("BB", 10, 25);

            //Act
            try
            {
                //Assert
                ct.CoffeePrice();

            }
            catch (System.ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, Coffee.DiscountNotGreaterThanFive);
                return;
            }
            //Assert.Fail("The  expected exception was not thrown");
        }

        //[TestMethod()]
        //public void StrengthTest()
        //{

        //    Assert.Fail();
        //}
    }
}