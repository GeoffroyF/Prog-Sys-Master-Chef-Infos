﻿using System;
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
        public void TestPropioChange()
        {
            var tmp = MachineUn.GetProprio();
            MachineUn.SetProprio(new Plongeur().GetInstance());
            Assert.AreNotEqual(tmp, MachineUn.GetProprio());
        }

        [TestMethod]
        public void TestPropioChangeToNull()
        {
            var tmp = MachineUn.GetProprio();
            MachineUn.SetProprio(null);
            Assert.AreNotEqual(null, MachineUn.GetProprio());
        }

        [TestMethod]
        public void TestPropioChangeToNull()
        {
            var tmp = MachineUn.GetProprio();
            MachineUn.SetProprio(null);
            Assert.AreNotEqual(null, MachineUn.GetProprio());
        }

        [TestMethod]
        public void TestPropioIsRunning()
        {
        }

        [TestMethod]
        public void TestPropioIsRunningYes()
        {
            MachineUn.start(10);
            Assert.AreEqual(MachineUn.isRunning(), true);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Erreur de paramettre")]
        public void TestPropioIsRunningBug()
        {
            MachineUn.start(-10);
        }

        [TestMethod]
        public void TestPropioIsRunningNo()
        {
            MachineUn.start(0);
            Assert.AreEqual(MachineUn.isRunning(), false);
        }
    }
}
