using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class StockTest
    {
        private Ingrediant ingrediantUn;
        private Ingrediant IngrediantDeux;
        private Ingrediant[] array;

        public StockTest()
        {
            ingrediantUn = new Ingrediant();
            IngrediantDeux = new Ingrediant();
            array = new Ingrediant[2] { ingrediantUn, IngrediantDeux };
        }

        [TestMethod]
        public void TestSingletonCuisine()
        {
            Assert.AreEqual(Stock.GetInstance(array, array, array), Stock.GetInstance(), "Stock is not a singleton");
        }
    }
}
