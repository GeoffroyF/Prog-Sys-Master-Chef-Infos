using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class StockTest
    {
        private readonly Stock StockUn;
        private readonly Stock StockDeux;

        public StockTest()
        {
            StockUn = new Stock();
            StockDeux = new Stock();
        }

        [TestMethod]
        public void TestSingletonCuisine()
        {
            Assert.AreEqual(StockUn.GetInstance(), StockDeux.GetInstance(), "La Cuisine n'est pas un singleton");
        }
    }
}
