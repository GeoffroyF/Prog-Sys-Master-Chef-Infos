using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Class.Test
{
    [TestClass]
    public class MaitreHotel_Test
    {
        [TestMethod]
        public void Test_GetInstance()
        {
            //Arrange
            MaitreHotel MH;
            MaitreHotel ExpectedMH;

            //Action
            ExpectedMH = MH.GetInstance("Dupont", "Lucas");
            MaitreHotel ActualMH = MH.GetInstance("Dupont", "Lucas");

            //Assert
            Assert.AreEqual(ExpectedCommis, ActualCommis);

        }

        [TestMethod]
        public void Test_AttribueTable()
        {
            //
        }

        [TestMethod]
        public void Test_AttribueTable()
        {
            //
        }
    }
}
