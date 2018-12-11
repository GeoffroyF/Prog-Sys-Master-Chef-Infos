using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class PassePlatTest
    {

        public PassePlatTest()
        {

        }

        [TestMethod]
        public void TestSingletonPassePlat()
        {
            Assert.AreEqual(PassePlat.GetInstance(), PassePlat.GetInstance(), "PassePlat is not a singleton");
        }
    }
}
