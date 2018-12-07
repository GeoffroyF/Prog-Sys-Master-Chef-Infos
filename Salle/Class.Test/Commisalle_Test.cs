using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Class.Test
{
    [TestClass]
    public class Commisalle_Test
    {
        [TestMethod]
        public void Test_GetInstance()
        {
            //Arrange
            CommisSalle Commis;
            CommisSalle ExpectedCommis;

            //Action
            ExpectedCommis = Commis.GetInstance("Dupont", "Lucas");
            CommisSalle ActualCommis = Commis.GetInstance("Dupont", "Lucas");

            //Assert
            Assert.AreEqual(ExpectedCommis, ActualCommis);
                
        }

        [TestMethod]
        public void Test_Debarasse()
        { 
            //
        }

        [TestMethod]
        public void Test_AmenerEau()
        {
            //
        }

        [TestMethod]
        public void Test_AmenerPain()
        {
            //
        }

        [TestMethod]
        public void Test_DresserTable()
        {
            //
        }
    }
}
