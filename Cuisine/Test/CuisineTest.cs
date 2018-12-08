using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class CuisineTest
    {
        private Stock stock;
        private Machines machinesUn;
        private Machines machinesDeux;
        private Machines[] array;
        private Ustenciles ustenciles;
        private PassePlat passePlat;

        public CuisineTest() {
            stock = new Stock().GetInstance();
            machinesUn = new Machines("test1", 35);
            machinesDeux = new Machines("test3", 35);
            array = new Machines[2] { machinesDeux, machinesUn };
            ustenciles = new Ustenciles();
             passePlat = new PassePlat();
        }

        [TestMethod]
        public void TestSingletonCuisine()
        {
            Assert.AreEqual(Cuisine.GetInstance(stock, array, ustenciles, passePlat), Cuisine.GetInstance(), "The Kitchen is not a singleton");
        }
    }
}
