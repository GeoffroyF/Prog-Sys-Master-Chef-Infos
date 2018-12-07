using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class MachineTest
    {
        private readonly Machines MachineUn;
        private readonly Machines MachineDeux;

        public MachineTest()
        {
            MachineUn = new Machines();
            MachineDeux = new Machines();
        }

        [TestMethod]
        public void TestSingletonCuisine()
        {
            Assert.AreEqual(MachineUn.GetInstance(), MachineDeux.GetInstance(), "La Cuisine n'est pas un singleton");
        }
    }
}
