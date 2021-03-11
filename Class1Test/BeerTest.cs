using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OBG1;

namespace OBG1TEST
{
    [TestClass]
    public class BeerTest
    {
        // For init to initialize to test
        private Beer Beer { get; set; }

        // A init for testing Beer:
        [TestInitialize]
        public void Init()
        {
            Beer = new Beer("Heineken", 1, 10.95, 5);
        }

        // 4 tests for each prop
        [TestMethod]
        public void TestName()
        {
            Assert.AreEqual("Heineken", Beer.Name);
            Assert.ThrowsException<ArgumentException>(() => Beer.Name = "Ber");
        }

        [TestMethod]
        public void TestId()
        {
            Assert.AreEqual(1, Beer.ID);
        }

        [TestMethod]
        public void TestPrice()
        {
            Assert.AreEqual(10.95, Beer.Price);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Beer.Price = 0);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Beer.Price = -1);
        }

        [TestMethod]
        public void TestAdv()
        {
            Assert.AreEqual(5, Beer.Adv);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Beer.Adv = 101);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Beer.Adv = -1);
        }
    }
}
