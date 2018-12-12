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
            MaitreHotel Expected_MaitreHotel;

            //Action
            Expected_MaitreHotel = MaitreHotel.GetInstance("DUPONT", "Leon");

            //Assert
            Assert.AreEqual(Expected_MaitreHotel, MaitreHotel.GetInstance());
        }

        [TestMethod]
        public void Test_AttribueTable()
        {
            //Arrange

            //Instanciation Personnel
            MaitreHotel MH = MaitreHotel.GetInstance("", "");
            CommisSalle CS = CommisSalle.GetInstance("", "");
            ChefRang CR_1 = new ChefRang("CR", "1");
            ChefRang CR_2 = new ChefRang("CR", "2");
            ChefRang CR_3 = new ChefRang("CR", "3");
            ChefRang CR_4 = new ChefRang("CR", "4");
            Serveur SR_1 = new Serveur("SR", "1");
            Serveur SR_2 = new Serveur("SR", "2");
            Serveur SR_3 = new Serveur("SR", "3");
            Serveur SR_4 = new Serveur("SR", "4");

            //Instanciation Salle

            //Carre 1
            Table[] TB_Rang1 = new Table[2];
            Table Table_Rang1_1 = new Table(4, 0, 1); //Table 1 : 4 chaises, vide 
            Table Table_Rang1_2 = new Table(4, 4, 2); //Table 2 : 4 chaises, Occupée par 4 clients 
            TB_Rang1[0] = Table_Rang1_1;
            TB_Rang1[1] = Table_Rang1_2;
            Rang Rang1 = new Rang(SR_1, CR_1, TB_Rang1);
            Table[] TB_Rang2 = new Table[2];
            Table Table_Rang2_1 = new Table(4, 0, 3); //Table 3 : 4 chaises, vide 
            Table Table_Rang2_2 = new Table(4, 8, 4); //Table 4 : 8 chaises, Occupée par 8 clients
            TB_Rang2[0] = Table_Rang2_1;
            TB_Rang2[1] = Table_Rang2_2;
            Rang Rang2 = new Rang(SR_2, CR_2, TB_Rang2);
            Carre Carre1 = new Carre(Rang1, Rang2);
            //Carre 2
            Table[] TB_Rang3 = new Table[2];
            Table Expected_Table = new Table(5, 0, 5); //Table 5 : 5 chaises, vide  <  Expected_Table
            Table Table_Rang3_2 = new Table(4, 0, 6); //Table 6 : 4 chaises, vide 
            TB_Rang3[0] = Expected_Table;
            TB_Rang3[1] = Table_Rang3_2;
            Rang Rang3 = new Rang(SR_3, CR_3, TB_Rang3);
            Table[] TB_Rang4 = new Table[2];
            Table Table_Rang4_1 = new Table(4, 0, 7); //Table 7 : 4 chaises, vide 
            Table Table_Rang4_2 = new Table(4, 0, 8); //Table 8 : 4 chaises, vide 
            TB_Rang4[0] = Table_Rang4_1;
            TB_Rang4[1] = Table_Rang4_2;
            Rang Rang4 = new Rang(SR_4, CR_4, TB_Rang4);
            Carre Carre2 = new Carre(Rang3, Rang4);

            PresentoireSalle Presentoire = new PresentoireSalle();
            Salle Salle = Salle.GetInstance(Carre1, Carre2, MH, CS, Presentoire);

            //Instanciation Clients

            String[]  CMD = null;
            Clients Groupe_Clients_Test = new Clients(5, false, "", CMD);

            //Action
            Table Actual_table = MH.AttribueTable(Salle, Groupe_Clients_Test, false);


            //Assert
            Assert.AreEqual(Expected_Table, Actual_table);


        }

        
        /*[TestMethod]
        public void Test_AttribueTable()
        {
            //
        }*/
    }
}
