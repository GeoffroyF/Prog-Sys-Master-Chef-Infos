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
            var tmp = ArmoireUn.GetInstance().GetAssiettes();
            ArmoireUn.GetInstance().SetAssiettes(5);
            Assert.AreEqual(ArmoireUn.GetInstance().GetAssiettes(), tmp + 5);
        }

        [TestMethod]
        public void TestAssiettesMoin()
        {
            var tmp = ArmoireUn.GetInstance().GetAssiettes();
            ArmoireUn.GetInstance().SetAssiettes(-5);
            Assert.AreEqual(ArmoireUn.GetInstance().GetAssiettes(), tmp - 5);
        }

        // Test pour les couverts
        [TestMethod]
        public void TestCouvertsPlus()
        {
            var tmp = ArmoireUn.GetInstance().GetCouverts();
            ArmoireUn.GetInstance().SetCouverts(5);
            Assert.AreEqual(ArmoireUn.GetInstance().GetCouverts(), tmp + 5);
        }

        [TestMethod]
        public void TestCouvertsMoin()
        {
            var tmp = ArmoireUn.GetInstance().GetCouverts();
            ArmoireUn.GetInstance().SetCouverts(-5);
            Assert.AreEqual(ArmoireUn.GetInstance().GetCouverts(), tmp - 5);
        }

        // Test pour les verres
        [TestMethod]
        public void TestVerresPlus()
        {
            var tmp = ArmoireUn.GetInstance().GetVerres();
            ArmoireUn.GetInstance().SetVerres(5);
            Assert.AreEqual(ArmoireUn.GetInstance().GetVerres(), tmp + 5);
        }

        [TestMethod]
        public void TestVerresMoin()
        {
            var tmp = ArmoireUn.GetInstance().GetVerres();
            ArmoireUn.GetInstance().SetVerres(-5);
            Assert.AreEqual(ArmoireUn.GetInstance().GetVerres(), tmp - 5);
        }

        // Test pour les JeuCafe
        [TestMethod]
        public void TestJeuCafePlus()
        {
            var tmp = ArmoireUn.GetInstance().GetJeuCafe();
            ArmoireUn.GetInstance().SetJeuCafe(5);
            Assert.AreEqual(ArmoireUn.GetInstance().GetJeuCafe(), tmp + 5);
        }

        [TestMethod]
        public void TestJeuCafeMoin()
        {
            var tmp = ArmoireUn.GetInstance().GetJeuCafe();
            ArmoireUn.GetInstance().SetJeuCafe(-5);
            Assert.AreEqual(ArmoireUn.GetInstance().GetJeuCafe(), tmp - 5);
        }

        // Test pour les Serviettes
        [TestMethod]
        public void TestServiettesPlus()
        {
            var tmp = ArmoireUn.GetInstance().GetServiettes();
            ArmoireUn.GetInstance().SetServiettes(5);
            Assert.AreEqual(ArmoireUn.GetInstance().GetServiettes(), tmp + 5);
        }

        [TestMethod]
        public void TestServiettesMoin()
        {
            var tmp = ArmoireUn.GetInstance().GetServiettes();
            ArmoireUn.GetInstance().SetServiettes(-5);
            Assert.AreEqual(ArmoireUn.GetInstance().GetServiettes(), tmp - 5);
        }

        // Test pour les Napes
        [TestMethod]
        public void TestNapesPlus()
        {
            var tmp = ArmoireUn.GetInstance().GetNapes();
            ArmoireUn.GetInstance().SetNapes(5);
            Assert.AreEqual(ArmoireUn.GetInstance().GetNapes(), tmp + 5);
        }

        [TestMethod]
        public void TestNapesMoin()
        {
            var tmp = ArmoireUn.GetInstance().GetNapes();
            ArmoireUn.GetInstance().SetNapes(-5);
            Assert.AreEqual(ArmoireUn.GetInstance().GetNapes(), tmp - 5);
        }
    }
}
