using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class ArmoireTest
    {

        [TestMethod]
        public void TestSingletonCuisine()
        {
            Assert.AreEqual(Armoire.GetInstance(5,5,5,5,5,5), Armoire.GetInstance(), "Armoire is not a singleton");
        }

        // Test for the plates
        [TestMethod]
        public void TestAssiettesPlus()
        {
            var tmp = Armoire.GetInstance().GetAssiettes();
            Armoire.GetInstance().SetAssiettes(5);
            Assert.AreEqual(Armoire.GetInstance().GetAssiettes(), tmp + 5, "Plates does not increment");
        }

        [TestMethod]
        public void TestAssiettesMoin()
        {
            var tmp = Armoire.GetInstance().GetAssiettes();
            Armoire.GetInstance().SetAssiettes(-5);
            Assert.AreEqual(Armoire.GetInstance().GetAssiettes(), tmp - 5, "Plates does not decrement");
        }

        // Test for the couverts
        [TestMethod]
        public void TestCouvertsPlus()
        {
            var tmp = Armoire.GetInstance().GetCouverts();
            Armoire.GetInstance().SetCouverts(5);
            Assert.AreEqual(Armoire.GetInstance().GetCouverts(), tmp + 5, "Couverts does not increment");
        }

        [TestMethod]
        public void TestCouvertsMoin()
        {
            var tmp = Armoire.GetInstance().GetCouverts();
            Armoire.GetInstance().SetCouverts(-5);
            Assert.AreEqual(Armoire.GetInstance().GetCouverts(), tmp - 5, "Couverts does not decrement");
        }

        // Test for the glasses
        [TestMethod]
        public void TestVerresPlus()
        {
            var tmp = Armoire.GetInstance().GetVerres();
            Armoire.GetInstance().SetVerres(5);
            Assert.AreEqual(Armoire.GetInstance().GetVerres(), tmp + 5, "Glasses does not increment");
        }

        [TestMethod]
        public void TestVerresMoin()
        {
            var tmp = Armoire.GetInstance().GetVerres();
            Armoire.GetInstance().SetVerres(-5);
            Assert.AreEqual(Armoire.GetInstance().GetVerres(), tmp - 5, "Glasses does not decrement");
        }

        // Test for the cofe sets
        [TestMethod]
        public void TestJeuCafePlus()
        {
            var tmp = Armoire.GetInstance().GetJeuCafe();
            Armoire.GetInstance().SetJeuCafe(5);
            Assert.AreEqual(Armoire.GetInstance().GetJeuCafe(), tmp + 5, "Cofe sets does not increment");
        }

        [TestMethod]
        public void TestJeuCafeMoin()
        {
            var tmp = Armoire.GetInstance().GetJeuCafe();
            Armoire.GetInstance().SetJeuCafe(-5);
            Assert.AreEqual(Armoire.GetInstance().GetJeuCafe(), tmp - 5, "Cofe sets does not decrement");
        }

        // Test for the towels
        [TestMethod]
        public void TestServiettesPlus()
        {
            var tmp = Armoire.GetInstance().GetServiettes();
            Armoire.GetInstance().SetServiettes(5);
            Assert.AreEqual(Armoire.GetInstance().GetServiettes(), tmp + 5, "Towels does not increment");
        }

        [TestMethod]
        public void TestServiettesMoin()
        {
            var tmp = Armoire.GetInstance().GetServiettes();
            Armoire.GetInstance().SetServiettes(-5);
            Assert.AreEqual(Armoire.GetInstance().GetServiettes(), tmp - 5, "Towels does not decrement");
        }

        // Test for the tablecloths
        [TestMethod]
        public void TestNapesPlus()
        {
            var tmp = Armoire.GetInstance().GetNapes();
            Armoire.GetInstance().SetNapes(5);
            Assert.AreEqual(Armoire.GetInstance().GetNapes(), tmp + 5, "Tablecloth does not increment");
        }

        [TestMethod]
        public void TestNapesMoin()
        {
            var tmp = Armoire.GetInstance().GetNapes();
            Armoire.GetInstance().SetNapes(-5);
            Assert.AreEqual(Armoire.GetInstance().GetNapes(), tmp - 5, "Tablecloth does not decrement");
        }
    }
}
