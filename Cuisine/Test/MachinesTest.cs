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
            MachineUn = new Machines("Four", 35);
            MachineDeux = new Machines("Four", 35);
        }

        [TestMethod]
        public void TestPropioChange()
        {
            var tmp = MachineUn.GetProprio();
            MachineUn.SetProprio(Plongeur.GetInstance());
            Assert.AreNotEqual(tmp, MachineUn.GetProprio(), "The proprio didn't changed");
        }

        [TestMethod]
        public void TestPropioChangeToNull()
        {
            var tmp = MachineUn.GetProprio();
            MachineUn.SetProprio(null);
            Assert.AreEqual(null, MachineUn.GetProprio(), "The proprio is not null");
        }

        [TestMethod]
        public void TestIsRunningYes()
        {
            MachineUn.start(60);
            Assert.AreEqual(MachineUn.isRunning(), true, "The machine is not running");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Argument error")]
        public void TestIsRunningBug()
        {
            MachineUn.start(-10);
        }

        [TestMethod]
        public void TestIsRunningNo()
        {
            MachineUn.start(0);
            Assert.AreEqual(MachineUn.isRunning(), false, "the machine is running");
        }
    }
}
