using System;
using System.Collections.Generic;
using System.Text;
using CoffeeShopConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolution
{
    [TestClass]
    public class CheckDiscount
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckExceptionBlackCoffee()
        {
            //Arrange
            int discount = 6;

            //Act
            Coffee bc = new BlackCoffee(discount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckExceptionCortado()
        {
            //Arrange
            int discount = 6;

            //Act
            Coffee c = new Cortado(discount);
        }

        [TestMethod]
        public void CheckExceptionEspresso()
        {
            //Arrange
            int discount = 6;

            //Act
            Coffee e = new Espresso("sdag");

            //Assert
            Assert.AreEqual(20, e.price());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckExceptionFlatWhite()
        {
            //Arrange
            int discount = 6;

            //Act
            Coffee fw = new FlatWhite(discount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckExceptionLatte()
        {
            //Arrange
            int discount = 6;

            //Act
            Coffee l = new Latte(discount);
        }  
    }
}
