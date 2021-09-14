using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeShopConsoleApp;

using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp.Tests
{
    [TestClass()]
    public class LatteTests
    {
        [TestMethod()]
        public void LatteTest()
        {
      
        }


        [TestMethod()]
        [ExpectedException(typeof(System.Reflection.TargetParameterCountException))]
        [DataRow(-1)]
        [DataRow(200)]
        [DataRow(300)]
        public void MlMilkLTest_HowMuchMilk_NoNegativeorOver50mlMilkQuantities_ExceptionTest()
        {
            var cortadoCoffee = new Cortado("latteCoffee", 3, 10);
            int milkQuantity = cortadoCoffee.MlMilk();
            Assert.Fail(); //Expecting it to fail as there are numbers that are above and below the limit.
        }




        [TestMethod()]
        public void CoffeePriceTest()
        {
            var lattePrice = new Latte("xx", 3, 30);
            int price = lattePrice.CoffeePrice();
            Assert.AreEqual(27, price);
    
        }

        //[TestMethod()]
        //public void StrengthTest()
        //{
        //    Assert.Fail();
        //}

        [TestMethod()]
        public void StrengthTest_latteCoffeeStrength_PassingTest()
        {
            var latteCoffee = new Latte("latteCoffee", 3, 10);
            string latteStrength = latteCoffee.Strength();
            Assert.AreEqual("Weak", latteStrength);

        }
    }
}