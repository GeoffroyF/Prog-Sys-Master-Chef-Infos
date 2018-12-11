using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class PersonnelCuisineTest
    {

        [TestMethod]
        public void TestSingletonPlongeur()
        {
            Assert.AreEqual(Plongeur.GetInstance("test", "test"), Plongeur.GetInstance(), "Plongeur is not a singleton");
        }

        [TestMethod]
        public void TestSingletonChefSucre()
        {
            Assert.AreEqual(ChefSucre.GetInstance("test", "test"), ChefSucre.GetInstance(), "ChefSucre is not a singleton");
        }

        [TestMethod]
        public void TestSingletonChefSale()
        {
            Assert.AreEqual(ChefSale.GetInstance("test", "test"), ChefSale.GetInstance(), "ChefSale is not a singleton");
        }

        [TestMethod]
        public void TestSingletonChefCuisine()
        {
            Assert.AreEqual(ChefCuisine.GetInstance("test", "test"), ChefCuisine.GetInstance(), "ChefCuisine is not a singleton");
        }
    }
}
