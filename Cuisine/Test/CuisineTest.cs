using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class CuisineTest
    {
        private readonly Cuisine CuisineUn;
        private readonly Cuisine CuisineDeux;

        public CuisineTest() {
            CuisineUn = new Cuisine();
            CuisineDeux = new Cuisine();
        }

        [TestMethod]
        public void TestSingletonCuisine()
        {
            Assert.AreEqual(CuisineUn.GetInstance(), CuisineDeux.GetInstance(), "La Cuisine n'est pas un singleton");
        }
    }
}
