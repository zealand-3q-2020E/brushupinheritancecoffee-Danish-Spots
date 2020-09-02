using System;
using System.Collections.Generic;
using System.Text;
using CoffeeShopConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolution
{
    [TestClass]
    public class CheckStrength
    {
        [TestMethod]
        public void CheckStrengthBlackCoffee()
        {
            //Arrange
            Coffee bc = new BlackCoffee();
            string expected = "Strong";

            //Act
            string actual = bc.Strength();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckStrengthCortado()
        {
            //Arrange
            Coffee c = new Cortado();
            string expected = "Medium";

            //Act
            string actual = c.Strength();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckEspresso()
        {
            //Arrange
            Coffee e = new Espresso("Some Blend");
            string expected = "Strong";

            //Act
            string actual = e.Strength();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckFlatWhite()
        {
            //Arrange
            Coffee fw = new FlatWhite();
            string expected = "Medium";

            //Act
            string actual = fw.Strength();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckLatte()
        {
            //Arrange
            Coffee l = new Latte();
            string expected = "Weak";

            //Act
            string actual = l.Strength();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
