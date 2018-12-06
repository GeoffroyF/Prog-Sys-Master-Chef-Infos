using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Class.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_GetNombreChaises()
        {
            //Arrange
            Table TableTest = new Table(4, 4, false, false, false);
            int Expected = 4;

            //Action
            int Actual = TableTest.GetNombreChaises();

            //Assert
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void Test_SetNombreChaises()
        {
            //Arrange
            Table TableTest = new Table(4, 4, false, false, false);
            int Expected = 6;

            //Action
            TableTest.SetNombreChaises(Expected);

            //Assert
            Assert.AreEqual(Expected, TableTest.GetNombreChaises());
        }

        [TestMethod]
        public void Test_GetNombrePersonnes()
        {
            //Arrange
            Table TableTest = new Table(4, 4, false, false, false);
            int Expected = 4;

            //Action
            int Actual = TableTest.GetNombrePersonnes();

            //Assert
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void Test_SetNombrePersonnes()
        {
            //Arrange
            Table TableTest = new Table(4, 4, false, false, false);
            int Expected = 6;

            //Action
            TableTest.SetNombrePersonnes(Expected);

            //Assert
            Assert.AreEqual(Expected, TableTest.GetNombrePersonnes());
        }

        [TestMethod]
        public void Test_GetIsReserved()
        {
            //Arrange
            Table TableTest = new Table(4, 4, false, false, false);
            Boolean Expected = false;

            //Action
            Boolean Actual = TableTest.GetIsReserved();

            //Assert
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void Test_SetIsReserved()
        {
            //Arrange
            Table TableTest = new Table(4, 4, false, false, false);
            Boolean Expected = true;

            //Action
            TableTest.SetIsReserved(Expected);

            //Assert
            Assert.AreEqual(Expected, TableTest.GetIsReserved());
        }

        [TestMethod]
        public void Test_GetHasPain()
        {
            //Arrange
            Table TableTest = new Table(4, 4, false, false, false);
            Boolean Expected = false;

            //Action
            Boolean Actual = TableTest.GetHasPain();

            //Assert
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void Test_SetHasPain()
        {
            //Arrange
            Table TableTest = new Table(4, 4, false, false, false);
            Boolean Expected = true;

            //Action
            TableTest.SetHasPain(Expected);

            //Assert
            Assert.AreEqual(Expected, TableTest.GetHasPain());
        }

        [TestMethod]
        public void Test_GetHasEau()
        {
            //Arrange
            Table TableTest = new Table(4, 4, false, false, false);
            Boolean Expected = false;

            //Action
            Boolean Actual = TableTest.GetHasEau();

            //Assert
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void Test_SetHasEau()
        {
            //Arrange
            Table TableTest = new Table(4, 4, false, false, false);
            Boolean Expected = true;

            //Action
            TableTest.SetHasEau(Expected);

            //Assert
            Assert.AreEqual(Expected, TableTest.GetHasEau());
        }

        [TestMethod]
        public void Test_GetPlats()
        {
            //Arrange
            Table TableTest = new Table(4, 4, false, false, false);
            string[] Expected = { "Pates", "Pizza" };

            //Action
            string[] Actual = TableTest.GetPlats();

            //Assert
            Assert.AreEqual(Expected, Actual);
        }

        
        [TestMethod]
        public void Test_SetPlats()
        {
            //Arrange
            Table TableTest = new Table(4, 4, false, false, false);
            string[] Expected = { "Pates", "Pizza" };

            //Action
            TableTest.SetPlats(Expected);

            //Assert
            Assert.AreEqual(Expected, TableTest.GetPlats());
        }

    }
}
