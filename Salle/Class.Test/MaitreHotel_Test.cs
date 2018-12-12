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
            //Assert
            Assert.AreEqual(MaitreHotel.GetInstance("DUPONT", "Leon"), MaitreHotel.GetInstance());

        }

        /*[TestMethod]
        public void Test_AttribueTable()
        {
            //Arrange
            //instancier tout les objet necessaire à l'instanciation d'une salle
            //instancier un groupe de clients dont la taille oblige le Maitre d'hotel a lui attribuer une table autre que la 1ere
            //par ex les 3 premieres tables ont moins de 3 chaises pour un Groupe Client de 3 personnes
            //Essayer de mettre certaines table rempli pour verifi qu'il dirige bien les clients vers des tables vides
        }

        [TestMethod]
        public void Test_AttribueTable()
        {
            //
        }*/
    }
}
