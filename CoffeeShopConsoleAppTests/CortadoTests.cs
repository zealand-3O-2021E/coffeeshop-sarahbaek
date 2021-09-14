using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeShopConsoleApp;

using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp.Tests
{
    [TestClass()]
    public class CortadoTests
    {
        [TestMethod()]
        public void CortadoTest()
        {

        }



     

        [TestMethod()]
        [ExpectedException(typeof(System.Reflection.TargetParameterCountException))]
        [DataRow(-1)][DataRow(40)]
        [DataRow(50)]
        public void MlMilkTest_HowMuchMilk_NoNegativeorOver50mlMilkQuantities_ExceptionTest()
        {
            var cortadoCoffee = new Cortado("cortadoCoffee", 3, 10);
            int milkQuantity = cortadoCoffee.MlMilk();
            Assert.Fail();
        }



        [TestMethod()]
        public void CoffeePriceTest_Cortado_PassingTest()
        {
            //Arrange
            Cortado cortado;
            cortado = new Cortado("milkyCortado", 3, 10);
            //Act
            int priceCortado = cortado.CoffeePrice();
            //Assert
            Assert.AreEqual(7, priceCortado);
        }

   

        [TestMethod()]
        public void StrengthTest_cortadoCoffeeStrength_PassingTest()
        {
        var cortadoCoffee = new Cortado("cortadoCoffee", 3, 10);
            string corstadoStrength = cortadoCoffee.Strength();
            Assert.AreEqual("Medium", corstadoStrength);
        
        }
    }
}