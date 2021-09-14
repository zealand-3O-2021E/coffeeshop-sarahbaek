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
        [TestMethod()]
        public void CoffeeTest()
        {
         
        }


        [TestMethod()]
        public void CoffeePriceTest_CorrectDiscount_ShouldPass()
        {
            //Arrange
            //int price = 40;
            //int discount = 3;
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
        //[DataTestMethod]
        //[DataRow(-1)]
        //[DataRow(10)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CoffeePriceTest_DiscountOver5_ShouldThrowAnException()
        {
            //Arrange
            var cortadoDiscount = new Cortado("Cortado", 10, 20);
            //Act
            var cortadoPrice = cortadoDiscount.CoffeePrice();
            //return;

            Assert.Fail();

        }

  

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CoffeePriceTest_DiscountLessThanZero_ShouldThrowAnException()
        {
            //Arrange
            var cortadoDiscount = new Cortado("Cortado", -1, 25);
            //Act
            var cortadoPrice = cortadoDiscount.CoffeePrice();
            //return;

            Assert.Fail();

        }






        [TestMethod()]
        public void StrengthTest()
        {
            //Arrange
            var coffeeLatee = new Latte("LL", 2, 40);

            //Act
            var latteStrength = coffeeLatee.Strength();

            //Assert
            Assert.AreEqual("Weak", latteStrength);

            //Assert.Fail();
        }













































        //[TestMethod()]
        //[ExpectedException(typeof(ArgumentException))]
        //public void CoffeePriceTest_DiscountOver5_ShouldThrowAnException()
        //{
        //    //Arrange
        //    int price = 25;
        //    int discount = 6;

        //    //Act
        //    try
        //    {
        //        //Assert
        //        Coffee ct = new Cortado("BB", discount, price);

        //    }
        //    catch (System.ArgumentOutOfRangeException e)
        //    {
        //        StringAssert.Contains(e.Message, Coffee.DiscountNotGreaterThanFive);
        //        return;
        //    }
        //    Assert.Fail("The  expected exception was not thrown");
        //}

        //[TestMethod()]
        //public void CoffeePriceTest_DiscountLessThanZero_ShouldThrowAnException()
        //{
        //    //Arrange
        //    int price = 25;
        //    int discount = -2;



        //    //Act
        //    try
        //    {
        //        //Assert
        //        Coffee ct = new Cortado("BB", discount, price);

        //    }
        //    catch (System.ArgumentOutOfRangeException e)
        //    {
        //        StringAssert.Contains(e.Message, Coffee.DiscountNotLessThanZero);
        //        return;
        //    }
        //    Assert.Fail("The  expected exception was not thrown");
        //}

    }
}