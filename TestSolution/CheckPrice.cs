using CoffeeShopConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestSolution
{
    [TestClass]
    public class CheckPrice
    {
        [TestMethod]
        public void CheckPriceBlackCoffee()
        {
            //Arrange
            BlackCoffee bc = new BlackCoffee();
            int expected = 20;

            //Act
            int actual = bc.price();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckPriceCortado()
        {
            //Arrange
            Coffee c = new Cortado();
            int expected = 25;

            //Act
            int actual = c.price();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckPriceEspresso()
        {
            //Arrange
            Coffee e = new Espresso("AnyBlend");
            int expected = 20;

            //Act
            int actual = e.price();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckPriceFlatWhite()
        {
            //Arrange
            Coffee fw = new FlatWhite();
            int expected = 35;

            //Act
            int actual = fw.price();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckPriceLatte()
        {
            //Arrange
            Coffee l = new Latte();
            int expected = 40;

            //Act
            int actual = l.price();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
