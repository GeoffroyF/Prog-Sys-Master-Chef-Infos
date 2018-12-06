using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class ArmoireTest
    {
        private readonly Armoire ArmoireUn;
        private readonly Armoire ArmoireDeux;

        public ArmoireTest()
        {
            ArmoireUn = new Armoire();
            ArmoireDeux = new Armoire();
        }

        [TestMethod]
        public void TestSingletonCuisine()
        {
            Assert.AreEqual(ArmoireUn.GetInstance(), ArmoireDeux.GetInstance(), "L'Armoire n'est pas un singleton");
        }

        // Test pour les assiettes
        [TestMethod]
        public void TestAssiettesPlus()
        {
            var tmp = Armoire.GetAssiettes();
            Armoire.SetAssiettes(5);
            Assert.Equals(Armoire.GetAssiettes(), tmp + 5);
        }

        [TestMethod]
        public void TestAssiettesMoin()
        {
            var tmp = Armoire.GetAssiettes();
            Armoire.SetAssiettes(-5);
            Assert.Equals(Armoire.GetAssiettes(), tmp - 5);
        }

        // Test pour les couverts
        [TestMethod]
        public void TestCouvertsPlus()
        {
            var tmp = Armoire.GetCouverts();
            Armoire.SetCouverts(5);
            Assert.Equals(Armoire.GetCouverts(), tmp + 5);
        }

        [TestMethod]
        public void TestCouvertsMoin()
        {
            var tmp = Armoire.GetCouverts();
            Armoire.SetCouverts(-5);
            Assert.Equals(Armoire.GetCouverts(), tmp + 5);
        }

        // Test pour les verres
        [TestMethod]
        public void TestVerresPlus()
        {
            var tmp = Armoire.GetVerres();
            Armoire.SetVerres(5);
            Assert.Equals(Armoire.GetVerres(), tmp + 5);
        }

        [TestMethod]
        public void TestVerresMoin()
        {
            var tmp = Armoire.GetVerres();
            Armoire.SetVerres(-5);
            Assert.Equals(Armoire.GetVerres(), tmp + 5);
        }

        // Test pour les JeuCafe
        [TestMethod]
        public void TestJeuCafePlus()
        {
            var tmp = Armoire.GetJeuCafe();
            Armoire.SetJeuCafe(5);
            Assert.Equals(Armoire.GetJeuCafe(), tmp + 5);
        }

        [TestMethod]
        public void TestJeuCafeMoin()
        {
            var tmp = Armoire.GetJeuCafe();
            Armoire.SetJeuCafe(-5);
            Assert.Equals(Armoire.GetJeuCafe(), tmp + 5);
        }

        // Test pour les Serviettes
        [TestMethod]
        public void TestServiettesPlus()
        {
            var tmp = Armoire.GetServiettes();
            Armoire.SetServiettes(5);
            Assert.Equals(Armoire.GetServiettes(), tmp + 5);
        }

        [TestMethod]
        public void TestServiettesMoin()
        {
            var tmp = Armoire.GetServiettes();
            Armoire.SetServiettes(-5);
            Assert.Equals(Armoire.GetServiettes(), tmp + 5);
        }

        // Test pour les Napes
        [TestMethod]
        public void TestNapesPlus()
        {
            var tmp = Armoire.GetNapes();
            Armoire.SetNapes(5);
            Assert.Equals(Armoire.GetNapes(), tmp + 5);
        }

        [TestMethod]
        public void TestNapesMoin()
        {
            var tmp = Armoire.GetNapes();
            Armoire.SetNapes(-5);
            Assert.Equals(Armoire.GetVerres(), tmp + 5);
        }
    }
}
