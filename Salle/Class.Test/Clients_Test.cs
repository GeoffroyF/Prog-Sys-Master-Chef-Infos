using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Class.Test
{
    [TestClass]
    public class Clients_Test
    {
        [TestMethod]
        public void Test_GetServi()
        {
            //Arrange
            Boolean Expected_Servi = false;
            String[] CMD = null;
            Clients Client_Test = new Clients(4, Expected_Servi, "", CMD);

            //Action
            Boolean Actual_Servi = Client_Test.GetServi();

            //Assert
            Assert.AreEqual(Actual_Servi, Expected_Servi);
        }

        [TestMethod]
        public void Test_SetServi()
        {
            //Arrange
            Boolean Expected_Servi = false;
            String[] CMD = null;
            Clients Client_Test = new Clients(4, true, "", CMD);

            //Action
            //Boolean Actual_Servi = 
            Client_Test.SetServi(Expected_Servi);

            //Assert
            Assert.AreEqual(Client_Test.GetServi(), Expected_Servi);
        }

        [TestMethod]
        public void Test_GetNBCLients()
        {
            //Arrange
            int Expected_NBclients = 4;
            String[] CMD = null;
            Clients Client_Test = new Clients(Expected_NBclients, false, "", CMD);

            //Action
            int Actual_NBClients = Client_Test.GetNBClients();

            //Assert
            Assert.AreEqual(Actual_NBClients, Expected_NBclients);
        }

        [TestMethod]
        public void Test_GetCommandes()
        {
            //Arrange
            String[] Expected_CMD = {"AA", "BB"};
            Clients Client_Test = new Clients(4, false, "", Expected_CMD);

            //Action
            String[] Actual_CMD = Client_Test.GetCommandes();

            //Assert
            Assert.AreEqual(Actual_CMD, Expected_CMD);
        }

        [TestMethod]
        public void Test_GetReservation()
        {
            //Arrange
            String[] CMD = { "AA", "BB" };
            Reservation Expected_Reservation = null; //default value
            Clients Client_Test = new Clients(4, false, "", CMD);

            //Action
            Reservation Actual_Resa = Client_Test.GetIsReservation();

            //Assert
            Assert.AreEqual(Actual_Resa, Expected_Reservation);
        }

        [TestMethod]
        public void Test_SetReservation()
        {
            //Arrange
            Table table = new Table(4, 4, 1);
            String[] CMD = { "AA", "BB" };
            Reservation Expected_Reservation = new Reservation (true,table,false); //default value
            Clients Client_Test = new Clients(4, false, "", CMD);

            //Action
            Client_Test.SetIsReservation(Expected_Reservation);

            //Assert
            Assert.AreEqual(Client_Test.GetIsReservation(), Expected_Reservation);
        }
    }
}
