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
            //Assert
            Assert.AreEqual(CommisSalle.GetInstance("",""), CommisSalle.GetInstance());
                
        }



        [TestMethod]
        public void Test_AmenerEau()
        {
            //Arrange
            Table table_test = new Table(4, 1, 1);
            Boolean Expected_Eau = true;
            CommisSalle commis = CommisSalle.GetInstance("", "");

            //Action
            commis.AmenerEau(table_test);

            //Assert
            Assert.AreEqual(Expected_Eau, table_test.GetHasEau());
        }

        [TestMethod]
        public void Test_AmenerPain()
        {
            //Arrange
            Table table_test = new Table(4, 1, 1);
            Boolean Expected_Pain = true;
            CommisSalle commis = CommisSalle.GetInstance("", "");

            //Action
            commis.AmenerPain(table_test);

            //Assert
            Assert.AreEqual(Expected_Pain, table_test.GetHasPain());
        }

        /*
        [TestMethod]
        public void Test_DresserTable()
        {
            //
        }*/
    }
}
